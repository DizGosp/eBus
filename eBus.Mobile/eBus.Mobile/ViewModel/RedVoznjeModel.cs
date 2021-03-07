using eBus.Model;
using eBus.Model.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBus.Mobile.ViewModel
{
    public class RedVoznjeModel : BaseViewModel
    {

        private readonly APIService _RedVoznje = new APIService("RedVoznje");
        private readonly APIService _Grad = new APIService("Grad");
        private readonly APIService _putnik = new APIService("Putnik");
        private readonly APIService _vKarte = new APIService("VrstaKarte");
        private readonly APIService _Karta = new APIService("Karta");
        private readonly APIService _Rezervacija = new APIService("RezervacijaKarte");
        private readonly APIService _preporuka = new APIService("SistemPreporuke");

        private decimal? popust = 0;
        public RedVoznjeModel() 
        {
            InitCommand = new Command(async () => await Init());
            InitPreporukaCommand = new Command(async () => await InitPreporuka());
            ButtonCommand = new Command(async () => await ButtonInit(0));
        }

        public string getBrojKarte() 
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 10)
              .Select(s => s[random.Next(s.Length)]).ToArray());
         }

        public ObservableCollection<RedVoznje> RedVoznjeList { get; set; } = new ObservableCollection<RedVoznje>();
        public ObservableCollection<Grad> GradoviList { get; set; } = new ObservableCollection<Grad>();
        public ObservableCollection<VrstaKarte> VrstaKarteList { get; set; } = new ObservableCollection<VrstaKarte>();


        Grad _selectedGradPolaska = null;
        public Grad SelectedGradPolaska 
        {
            get { return _selectedGradPolaska; }
            set 
            { 
                SetProperty(ref _selectedGradPolaska, value);
                if (value != null){InitCommand.Execute(null); }
            } 
        }
        Grad _selectedGradDolaska = null;
        public Grad SelectedGradDolaska
        {
            get { return _selectedGradDolaska; }
            set
            {
                SetProperty(ref _selectedGradDolaska, value);
                if (value != null) { InitCommand.Execute(null); }
            }
        }

       
        private DateTime _datum = DateTime.Now;

        public DateTime Datum
        {
            get { return _datum; }
            set
            {
                SetProperty(ref _datum, value);
                if (value != null)
                {
                    InitCommand.Execute(null);
                }
            }
        }


        VrstaKarte _selectedVrstaKarte = null;
        public VrstaKarte SelectedVrstaKarte
        {
            get { return _selectedVrstaKarte; }
            set
            {
                SetProperty(ref _selectedVrstaKarte, value);
                if (value != null) { InitCommand.Execute(null); }
            }
        }

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

        public async Task<Karta> GetKarta(KartaSearchRequest search)
        {
           
            List<Karta> p = await _Karta.Get<List<eBus.Model.Karta>>(null);
            Karta karta = new Karta();
            foreach (var item in p)
            {
                if (item.BrojKarte == search.BrojKarte)
                {
                    karta = item;
                }
            }
            return karta;
        }


        public ICommand InitCommand { get; set; }
        public ICommand InitPreporukaCommand { get; set; }
        public ICommand ButtonCommand { get; set; }

        public async Task Init() 
        {

            RedVoznjeSearchRequest search = new RedVoznjeSearchRequest();

            if (VrstaKarteList.Count == 0) 
            {
                var listVrsteKarti = await _vKarte.Get<List<VrstaKarte>>(null);

                foreach (var x in listVrsteKarti)
                {
                    VrstaKarteList.Add(x);
                }

            }
            if (GradoviList.Count == 0) 
            {
                var listGrad = await _Grad.Get<List<Grad>>(null);
               
                foreach (var x in listGrad)
                {
                    GradoviList.Add(x);
                }
            }

            if (SelectedGradPolaska != null ) 
            {
                search.GradPolaskaId = SelectedGradPolaska.GradId; 
            }
            if(SelectedGradDolaska != null) 
            {
                search.GradDolaskaId = SelectedGradDolaska.GradId;
            }
            if(Datum != null)
            {
                search.DatumVrijemePolaska = Datum;
            }



            if (search == null)
            {
                if (SelectedVrstaKarte == null || SelectedVrstaKarte.VrstaKarteId == 1)
                {
                    var list = await _RedVoznje.Get<IEnumerable<RedVoznje>>(null);
                    RedVoznjeList.Clear();
                    foreach (var item in list)
                    {
                        if (item.DatumVrijemePolaska > DateTime.Now)
                        {
                            RedVoznjeList.Add(item);
                        }
                    }
                }
                else if (SelectedVrstaKarte.VrstaKarteId == 2) 
                {
                    popust = (decimal?)0.15;
                    var list = await _RedVoznje.Get<IEnumerable<RedVoznje>>(null);
                    RedVoznjeList.Clear();
                    foreach (var item in list)
                    {
                        item.Cijena = item.Cijena-(item.Cijena*popust);
                        if (item.DatumVrijemePolaska > DateTime.Now)
                        {
                            RedVoznjeList.Add(item);
                        }
                    }
                }
                else if (SelectedVrstaKarte.VrstaKarteId == 3)
                {
                    popust = (decimal?)0.10;
                    var list = await _RedVoznje.Get<IEnumerable<RedVoznje>>(null);
                    RedVoznjeList.Clear();
                    foreach (var item in list)
                    {
                        item.Cijena = item.Cijena - (item.Cijena * popust);
                        if (item.DatumVrijemePolaska > DateTime.Now)
                        {
                            RedVoznjeList.Add(item);
                        }
                    }
                }

            }
            else 
            {
                if (SelectedVrstaKarte == null || SelectedVrstaKarte.VrstaKarteId == 1)
                {
                   
                    var list = await _RedVoznje.Get<IEnumerable<RedVoznje>>(search);
                    RedVoznjeList.Clear();
                    foreach (var item in list)
                    {
                        if (item.DatumVrijemePolaska > DateTime.Now) 
                        {
                            RedVoznjeList.Add(item);
                        }
                     
                    }
                }
                else if (SelectedVrstaKarte.VrstaKarteId == 2)
                {
                    popust = (decimal?)0.15;
                    var list = await _RedVoznje.Get<IEnumerable<RedVoznje>>(search);
                    RedVoznjeList.Clear();
                    foreach (var item in list)
                    {
                        item.Cijena = item.Cijena - (item.Cijena * popust);
                        if (item.DatumVrijemePolaska > DateTime.Now)
                        {
                            RedVoznjeList.Add(item);
                        }
                    }
                }
                else if (SelectedVrstaKarte.VrstaKarteId == 3)
                {
                    popust = (decimal?)0.10;
                    var list = await _RedVoznje.Get<IEnumerable<RedVoznje>>(search);
                    RedVoznjeList.Clear();
                    foreach (var item in list)
                    {
                        item.Cijena = item.Cijena - (item.Cijena * popust);
                        if (item.DatumVrijemePolaska > DateTime.Now)
                        {
                            RedVoznjeList.Add(item);
                        }
                    }
                }
            }


        }

        public async Task InitPreporuka()
        {
            Putnici p = await GetPutnik();

            SistemPreporukeRequest searchS = new SistemPreporukeRequest()
            {
                PutnikId = p.PutnikId
            };
            var preporuka =await _preporuka.Get<SistemPreporuke>(searchS);

            if (VrstaKarteList.Count == 0)
            {
                var listVrsteKarti = await _vKarte.Get<List<VrstaKarte>>(null);
                foreach (var x in listVrsteKarti)
                {
                    VrstaKarteList.Add(x);
                }
            }

                if (SelectedVrstaKarte == null || SelectedVrstaKarte.VrstaKarteId == 1)
                {

                   RedVoznjeList.Clear();
                foreach (var item in preporuka.listaPreporuka)
                {
                    if (item.DatumVrijemePolaska > DateTime.Now)
                    {
                        RedVoznjeList.Add(item);
                    }
                }
                }
                else if (SelectedVrstaKarte.VrstaKarteId == 2)
                {
                    popust = (decimal?)0.15;

                RedVoznjeList.Clear();
                foreach (var item in preporuka.listaPreporuka)
                {
                    item.Cijena = item.Cijena - (item.Cijena * popust);
                    if (item.DatumVrijemePolaska > DateTime.Now)
                    {
                        RedVoznjeList.Add(item);
                    }
                }
            }
                else if (SelectedVrstaKarte.VrstaKarteId == 3)
                {
                    popust = (decimal?)0.10;
                RedVoznjeList.Clear();
                foreach (var item in preporuka.listaPreporuka)
                {
                    item.Cijena = item.Cijena - (item.Cijena * popust);
                    if (item.DatumVrijemePolaska > DateTime.Now)
                    {
                        RedVoznjeList.Add(item);
                    }
                }
            }
            


        }
        public async Task ButtonInit(int id)
        {

            Putnici p = await GetPutnik();

           
            KartaInsertRequest kInsert = new KartaInsertRequest()
            {
                DatumIzdavanja = DateTime.Now,
                RezervacijaSjedistaId = 1,
                BrojKarte = getBrojKarte()
            };

            if (SelectedVrstaKarte == null)
            {
                kInsert.VrstaKarteId = 1;
            }
            else 
            {
                kInsert.VrstaKarteId = SelectedVrstaKarte.VrstaKarteId;
            }

            await _Karta.Insert<Karta>(kInsert);

            KartaSearchRequest searchKarta = new KartaSearchRequest() { BrojKarte = kInsert.BrojKarte };

            Karta kGet = await GetKarta(searchKarta);

            RezervacijaInsertRequest rezInsert = new RezervacijaInsertRequest()
            {
                DatumKreiranja=DateTime.Now,
                DatumIsteka=DateTime.Now.AddDays(7),
                Otkazana=false,
                Qrcode=getBrojKarte(),
                PutnikId=p.PutnikId,
                KartaId=kGet.KartaId,
                RedVoznjeId=id            
            };

            await _Rezervacija.Insert<RezervacijaKarte>(rezInsert);

            await Application.Current.MainPage.DisplayAlert(" ", "Uspješno ste rezervisali vašu kartu!", "OK");

        }
    }
}
