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
    public class NovostiViewModel : BaseViewModel
    {
        private readonly APIService _novostiService = new APIService("Novosti");
        private readonly APIService _putnikNotifikacijeService = new APIService("PutnikNotifikacija");
        private readonly APIService _notifikacijeService = new APIService("Notifikacije");

        public NovostiViewModel()
        {  
           InitCommand = new Command(async () => await Init());     
        }


        public ObservableCollection<Novosti> NovostiList { get; set; } = new ObservableCollection<Novosti>();

        public ICommand InitCommand { get; set; }


        Dictionary<int, int> BrojPregleda = new Dictionary<int, int>();

        public async Task Init()
        {
            try
            {
                var lista = await _novostiService.Get<List<Novosti>>(null);

                var listaNotif = await _putnikNotifikacijeService.Get<List<PutnikNotifikacije>>(null);

                NovostiList.Clear();
                foreach (var item in lista)
                {
                    item.BrojPregleda = 0;
                    foreach (var item2 in listaNotif)
                    {
                        var nov = await _notifikacijeService.GetById<Notifikacije>(item2.NotifikacijeId);
                        if (item.NovostiId == nov.NovostId && item2.Pregledana)
                        {
                            item.BrojPregleda += 1;
                        }
                    }
                }
                foreach (var item in lista)
                {

                    NovostiList.Add(item);

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
