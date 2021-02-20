using eBus.Model;
using eBus.Model.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBus.Mobile.ViewModel
{
    public class NovostiDetaljiViewModel:BaseViewModel
    {
        private APIService _notifikacijePutnikService = new APIService("PutnikNotifikacija");
        private APIService _notifikacijeService = new APIService("Notifikacije");
        private APIService _putnikService = new APIService("Putnik");

        public NovostiDetaljiViewModel()
        {
            Title = "Novost";
        }
        public Novosti Novost { get; set; }


        public async Task Pregled(int novostId)
        {

            var notif = await _notifikacijeService.Get<List<Notifikacije>>(new NotifikacijeSearchRequest()
            {
                NovostId = novostId
            });

            var listaPutnika = await _putnikService.Get<List<Putnici>>(new PutnikSearchRequest()
            {
                userName = APIService.Username
            });

            Putnici putnik = listaPutnika.FirstOrDefault(l => l.KorisnickoIme == APIService.Username);


            var search = new PutnikNotifikacijeSearchRequest()
            {
                PutnikId = putnik.PutnikId,
                NotifikacijaId = notif[0].NotifikacijeId
            };

            var lista = await _notifikacijePutnikService.Get<List<PutnikNotifikacije>>(search);

            var request = new PutnikNotifikacijeUpsertRequest();

            request.NotifikacijaId = notif[0].NotifikacijeId;
            request.Pregledana = true;
            request.PutnikId = putnik.PutnikId;

            // ukoliko je lista prazna tj nema trazenog elementa znaci da putnik nije notificiran
            // pa mu pregled dodajemo preko novosti
            if (lista.Count != 0)
            {
                if (lista[0].Pregledana == false)
                {
                    await _notifikacijePutnikService.Update<PutnikNotifikacije>(lista[0].NotifikacijeId, request);
                }
            }
            else
            {
                await _notifikacijePutnikService.Insert<PutnikNotifikacije>(request);
            }

        }
    }
}
