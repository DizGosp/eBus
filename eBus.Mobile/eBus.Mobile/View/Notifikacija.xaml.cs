using eBus.Mobile.ViewModel;
using eBus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBus.Mobile.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Notifikacija : ContentPage
    {
        private readonly APIService _novostiService = new APIService("Novosti");
        NotifikacijaViewModel model = null;
        public Notifikacija()
        {
            InitializeComponent();
            BindingContext = model = new NotifikacijaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                var notif = e.SelectedItem as Notifikacije;

                await model.OznaciProcitano(notif);

                var novost = await _novostiService.GetById<Novosti>(notif.NovostId.Value);

                await Navigation.PushAsync(new NovostiDetaljiPage(novost));


            }
        }
    }
}