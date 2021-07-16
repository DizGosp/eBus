using Acr.UserDialogs;
using eBus.Model;
using eBus.Model.Placanje;
using eBus.Model.Request;
//using Microsoft.VisualStudio.PlatformUI;
using Prism.Commands;
using Prism.Mvvm;
using Stripe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBus.Mobile.ViewModel.Placanje
{
    public class PaymentGatwayPageViewModel:BaseViewModel
    {
        private readonly APIService _putnikService = new APIService("Putnik");
        private readonly APIService _redVoznjeService = new APIService("RedVoznje");
        private readonly APIService _rezervacija = new APIService("RezervacijaKarte");


        private CreditCardModel _creditCardModel;
        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;

        //Putnik
        public int redVoznjeID;
        private int PutnikId;
        private string Ime;
        private string Prezime;
        private string Email;
        private string KorisnickoIme; 
        private double UkupnaCijena;
       
        private string StripeTestApiKey = "pk_test_51JBK7OK1zFg7YeWyuHoZs0G0WnAdBL5gDtLLq4oJFD3puc8bJr6o0w2HBkrdOuR3E5yPSpkjYo2O28R7Sq1uM3lR00uZ5TFmU1";
        private string StripeSecreatApiKey = "sk_test_51JBK7OK1zFg7YeWy4kZGfTCHR5cHtFfsUqSYwC4leGjGNO9xwseekKQFS1PsPg8Z91nhtg9ENjJ9ijBjFJMsyL9e00EZlrj1br";
        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }

        public CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }

        public  PaymentGatwayPageViewModel(int id)
        {
            CreditCardModel = new CreditCardModel();
            Title = "Card Details";
            redVoznjeID = id;
            SubmitCommand = new Command(async () => await DelegateCommand());
            GetPutnik();
        }

        public ICommand SubmitCommand { get; set; }
        public async Task DelegateCommand()
        {
            CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {

                var rezervacija = await _rezervacija.GetById<RezervacijaKarte>(redVoznjeID);
                if (rezervacija.Placeno == true) 
                {
                    throw new Exception("Vec ste uplatili iznos!");
                }

                UserDialogs.Instance.ShowLoading("Payment processing..");
                await Task.Run(async () =>
                {

                    var Token = CreateToken();
                    Console.Write("Payment Gateway" + "Token :" + Token);
                    if (Token != null)
                    {
                        IsTransectionSuccess = MakePayment(Token);
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Bad card credentials", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");
                Console.Write("Payment Gatway" + ex.Message);
            }
            finally
            {
                if (IsTransectionSuccess)
                {
                    //Izmujena placenog

                    RezervacijaKarteUpdateRequest update = new RezervacijaKarteUpdateRequest() { placeno = true };
                    await _rezervacija.Update<RezervacijaKarteUpdateRequest>(redVoznjeID,update);

                   
                    Console.Write("Payment Gateway" + "Payment Successful ");
                    UserDialogs.Instance.HideLoading();
                    UserDialogs.Instance.Alert("Uplata je uspješno izvršena!", "Notifikacija", "OK");
                }
                else
                {

                    UserDialogs.Instance.HideLoading();
                    UserDialogs.Instance.Alert("Oops, something went wrong", "Payment failed", "OK");
                    Console.Write("Payment Gateway" + "Payment Failure ");
                }
            }

        }


        public async Task GetPutnik()
        {
            var rezervacija = await _rezervacija.GetById<RezervacijaKarte>(redVoznjeID);
            var _redVoznje = await _redVoznjeService.GetById<RedVoznje>(rezervacija.RedVoznjeId);

            Ime = APIService.Username;
            Prezime = APIService.Username;
            Email = APIService.Username+"@gmail.com";
            KorisnickoIme = APIService.Username;
            UkupnaCijena = (double)_redVoznje.Cijena;
        }


        private  string CreateToken()
        {
            try
            {
                StripeConfiguration.SetApiKey(StripeTestApiKey);
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {
                    
                    Card = new TokenCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = Ime+" "+Prezime,
                        AddressLine1 = Email,
                        AddressLine2 = KorisnickoIme,
                        AddressCity = "Maglaj",
                        AddressZip = "74250",
                        AddressState = "BiH",
                        AddressCountry = "Bosna i Hercegovina",
                        Currency = "inr",
                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return  stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool MakePayment(string token)
        {
            try
            {
                StripeConfiguration.SetApiKey(StripeSecreatApiKey);
                var options = new ChargeCreateOptions
                {
                    Amount = (int)(UkupnaCijena*100),
                    Currency = "bam",
                    Description = "Charge for "+Ime+" "+Prezime,
                    Source = stripeToken.Id,
                    StatementDescriptor = "Custom descriptor",
                    Capture = true,
                    ReceiptEmail = "sonu.sharma@gmail.com",
                };
                //Make Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("Payment Gatway (CreateCharge)" + ex.Message);
                throw ex;
            }
        }

        private bool ValidateCard()
        {
            if (CreditCardModel.Number.Length == 16 && ExpMonth.Length == 2 && ExpYear.Length == 2 && CreditCardModel.Cvc.Length == 3)
            {
                return true;
            }
            return false;
        }


    }
}
