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
    public partial class RezervacijePage : ContentPage
    {

        private RezervacijeViewModel model = null;
        public RezervacijePage()
        {
            InitializeComponent();
            BindingContext = model = new RezervacijeViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int id = int.Parse(button.CommandParameter.ToString());

            await Navigation.PushAsync(new StripePaymentGatwayPage(id));
        }


    }
}