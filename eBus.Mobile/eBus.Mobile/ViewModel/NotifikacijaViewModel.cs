using eBus.Model;
using eBus.Model.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eBus.Mobile.ViewModel
{
    public class NotifikacijaViewModel:BaseViewModel
    {
        private readonly APIService _notifikacijeService = new APIService("Notifikacije");
        private readonly APIService _putnikNotifikacijeService = new APIService("PutnikNotifikacija");
        private readonly APIService _putnikService = new APIService("Putnik");

        public async Task<Putnici> GetPutnik()
        {
            PutnikSearchRequest searchP = new PutnikSearchRequest()
            {
                userName = APIService.Username
            };
            List<Putnici> p = await _putnikService.Get<List<eBus.Model.Putnici>>(searchP);
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
        public NotifikacijaViewModel()
        {
            Title = "Notifikacija";
        }
        public ObservableCollection<Notifikacije> NotifikacijeList { get; set; } = new ObservableCollection<Notifikacije>();

        public async Task Init()
        {
            var lista = await _notifikacijeService.Get<List<Notifikacije>>(null);

            Putnici putnik = await GetPutnik();

            var searchPN = new PutnikNotifikacijeSearchRequest()
            {
                PutnikId = putnik.PutnikId
            };

            var listaPN = await _putnikNotifikacijeService.Get<List<PutnikNotifikacije>>(searchPN);

            NotifikacijeList.Clear();

            foreach (var item in lista)
            {

                foreach (var item2 in listaPN)
                {
                    if (item.NotifikacijeId == item2.NotifikacijeId && !item2.Pregledana)
                    {
                        NotifikacijeList.Add(item);
                    }
                }




            }
        }

        public async Task OznaciProcitano(Notifikacije n)
        {
            try
            {
                var searchPutnik = new PutnikSearchRequest()
                {
                    userName = APIService.Username
                };

                var listaPutnika = await _putnikService.Get<List<Putnici>>(searchPutnik);

                Putnici putnik = null;
                foreach (var item in listaPutnika)
                {
                    if (item.KorisnickoIme == APIService.Username)
                    {
                        putnik = item;
                        break;
                    }
                }

                var searchPN = new PutnikNotifikacijeSearchRequest()
                {
                    PutnikId = putnik.PutnikId
                };

                var listaPN = await _putnikNotifikacijeService.Get<List<PutnikNotifikacije>>(searchPN);

                PutnikNotifikacije pn = null;
                foreach (var item in listaPN)
                {
                    if (item.NotifikacijeId == n.NotifikacijeId && item.PutnikId == putnik.PutnikId)
                    {
                        pn = item;
                        break;
                    }
                }

                if (pn != null)
                {
                    var request = new PutnikNotifikacijeUpsertRequest()
                    {
                        NotifikacijaId = n.NotifikacijeId,
                        PutnikId = putnik.PutnikId,
                        Pregledana = true
                    };

                    await _putnikNotifikacijeService.Update<PutnikNotifikacije>(pn.NotifikacijeId, request);

                    if (n != null)
                    {
                        NotifikacijeList.Remove(n);

                        await Application.Current.MainPage.DisplayAlert(" ", "Označili ste notifikaciju pročitanom", "OK");
                    }
                }







                //var updateN = new NotifikacijaUpsertRequest()
                //{
                //    DatumSlanja = n.DatumSlanja,
                //    Naslov = n.Naslov,
                //    NovostId = n.NovostId,
                //    Procitano = true
                //};

                //await _notifikacijeService.Update<Notifikacija>(n.Id, updateN);


            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
