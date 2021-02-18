using eBus.Mobile.ViewModel;
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
    public partial class KartePage : ContentPage
    {
        private KarteViewModel model = null;
        public KartePage()
        {
            InitializeComponent();
            BindingContext = model = new KarteViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void  Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int id = int.Parse(button.CommandParameter.ToString());
            await  model.ButtonInit(id);

            //ADD()-> Ovdje bi trebali poslati id autobusa kojeg želimo ocjeniti. Pošto sam ja greškom u bazi stavio RedVoznje umjesto Vozilo,
            //poslat cu ovako (da se na RedVoznje 2 dodaje ocjena)
        }
    }
}