using eBus.Model;
using eBus.Model.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBus.Mobile.ViewModel
{
    public class KarteViewModel : BaseViewModel
    {
        private readonly APIService _putnik = new APIService("Putnik");
        private readonly APIService _bus = new APIService("Autobus");
        private readonly APIService _Ocjena = new APIService("Ocjena");
        private readonly APIService _Rezervacija = new APIService("RezervacijaKarte");


        public async Task<Putnici> GetPutnik()
        {
            PutnikSearchRequest searchP = new PutnikSearchRequest()
            {
                userName = APIService.Username
            };
            List<Putnici> p = await _putnik.Get<List<eBus.Model.Putnici>>(searchP);
            Putnici putn = new Putnici();
            foreach (var item in p)
            {
                if (item.KorisnickoIme == APIService.Username)
                {
                    putn = item;
                }
            }
            return putn;
        }
        public async Task<Autobus> GetAutobus(int id)
        {
            Autobus busSearch = new Autobus()
            {
                AutobusId = id
            };
            List<Autobus> bus = await _bus.Get<List<eBus.Model.Autobus>>(busSearch);

            return bus[0];
        }

        public KarteViewModel()
        {
            InitCommand = new Command(async () => await Init());
            ButtonInitCommand = new Command(async () => await ButtonInit(0));
        }
        public ICommand InitCommand { get; set; }
        public ICommand ButtonInitCommand { get; set; }
        public ObservableCollection<RezervacijaKarte> Rezervacije { get; set; } = new ObservableCollection<RezervacijaKarte>();

        string _komentar = string.Empty;
        public string Komentar
        {
            get { return _komentar; }
            set { SetProperty(ref _komentar, value); }
        }

        int? _ocjena;
        public int? Ocjena
        {
            get
            {
                return _ocjena;
            }
            set
            {
                SetProperty(ref _ocjena, value);
            }
        }

        public async Task Init()
        {
            Putnici p = await GetPutnik();

            RezervacijaSearchRequest searchRez = new RezervacijaSearchRequest()
            {
                PutnikId = p.PutnikId
            };
            var list = await _Rezervacija.Get<List<RezervacijaKarte>>(searchRez);
            Rezervacije.Clear();
            foreach (var item in list)
            {
                Rezervacije.Add(item);
            }

        }
        public async Task ButtonInit(int id)
        {
            Putnici p = await GetPutnik();
            Autobus a = await GetAutobus(id); //Ovdje sam trebao dobaviti autobus za koji se daje ocjena
            if (_ocjena < 1 || _ocjena > 10)
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Molimo unesite ocjenu od 1 - 10!", "OK");
            }
            else
            {
                OcjenaInsertRequest o = new OcjenaInsertRequest()
                {
                    RedVoznjeId = id,
                    PutnikId = p.PutnikId,
                    Ocjena1 = _ocjena,
                    Komentar = _komentar
                };

                await _Ocjena.Insert<Ocjena>(o);
                await Application.Current.MainPage.DisplayAlert(" ", "Uspješno ste unjeli komentar!", "OK");
            }
            

        }
    }
}
