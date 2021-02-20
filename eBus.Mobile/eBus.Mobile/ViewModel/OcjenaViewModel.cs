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
    public class OcjenaViewModel: BaseViewModel
    {
        private readonly APIService _putnik = new APIService("Putnik");
        private readonly APIService _bus = new APIService("Autobus");
        private readonly APIService _Ocjena = new APIService("Ocjena");
        public int id;
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
        public OcjenaViewModel()
        {
            InitCommand = new Command(async () => await Init());
            ButtonInitCommand = new Command(async () => await ButtonInit());
      
        }
        public OcjenaViewModel(int _id)
        {
            id = _id;
        }

        public ObservableCollection<OcjenaKomentar> ListaOcjena { get; set; } = new ObservableCollection<OcjenaKomentar>();

        string _komentar = string.Empty;
        public string Komentar
        {
            get { return _komentar; }
            set { SetProperty(ref _komentar, value); }
        }

        OcjenaKomentar _selectedOcjena = null;
        public OcjenaKomentar SelectedOcjena
        {
            get { return _selectedOcjena; }
            set
            {
                SetProperty(ref _selectedOcjena, value);
            }
        }


        public ICommand InitCommand { get; set; }
        public ICommand ButtonInitCommand { get; set; }


        public async Task Init()
        {

            if (ListaOcjena.Count == 0)
            {
                var listOcjena = new List<OcjenaKomentar>()
                {
                     new OcjenaKomentar { ocjenaNaziv="Jedan", ocjena=1 },
                    new OcjenaKomentar { ocjenaNaziv="Dva",ocjena=2},
                    new OcjenaKomentar { ocjenaNaziv="Tri", ocjena=3 },
                    new OcjenaKomentar { ocjenaNaziv="Četri", ocjena=4 },
                     new OcjenaKomentar { ocjenaNaziv="Pet", ocjena=5 }
                };

                foreach (var x in listOcjena)
                {
                    ListaOcjena.Add(x);
                }
            }
         

        }


        public async Task ButtonInit()
        {
  
            Putnici p = await GetPutnik();
            Autobus a = await GetAutobus(id);

            if (_selectedOcjena ==null || _komentar==null )
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Molimo unesite ocjenu i komentar!", "OK");
            }
            else
            {
                OcjenaInsertRequest o = new OcjenaInsertRequest()
                {
                    AutobusId = id,
                    PutnikId = p.PutnikId,
                    Ocjena1 = _selectedOcjena.ocjena,
                    Komentar = _komentar
                };

                await _Ocjena.Insert<Ocjena>(o);
                await Application.Current.MainPage.DisplayAlert(" ", "Uspješno ste unjeli komentar!", "OK");
                Application.Current.MainPage = new eBus.Mobile.View.MainPage();
            }


        }
    }
}
