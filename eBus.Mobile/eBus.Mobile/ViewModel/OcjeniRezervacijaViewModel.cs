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
    public class OcjeniRezervacijaViewModel : BaseViewModel
    {

        private readonly APIService _rezervacija = new APIService("RezervacijaKarte");
        private readonly APIService _putnik = new APIService("Putnik");
        public OcjeniRezervacijaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }


        public ObservableCollection<RezervacijaKarte> Rezervacije { get; set; } = new ObservableCollection<RezervacijaKarte>();
        public ICommand InitCommand { get; set; }


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


        public async Task Init()
        {

            Putnici p = await GetPutnik();

            RezervacijaSearchRequest searchRez = new RezervacijaSearchRequest()
            {
                PutnikId = p.PutnikId
            };
            var list = await _rezervacija.Get<List<RezervacijaKarte>>(searchRez);

            Rezervacije.Clear();
            foreach (var item in list)
            {
                if (item.RedVoznje.DatumVrijemeDolaska < DateTime.Now && item.Placeno == true && item.Otkazana == false)
                {
                    Rezervacije.Add(item);
                }
            }

        }

    }

}

