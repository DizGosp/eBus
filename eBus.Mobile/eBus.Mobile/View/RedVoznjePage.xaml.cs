using eBus.Mobile.ViewModel;
using eBus.Mobile.ViewModel.Placanje;
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
    public partial class RedVoznjePage : ContentPage
    {

        private RedVoznjeModel model = null;

        public RedVoznjePage()
        {
            InitializeComponent();
            BindingContext = model = new RedVoznjeModel();
     
        }

        protected async override void OnAppearing() 
        {
            base.OnAppearing();
            await model.Init();
        }

        private  async void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int id = int.Parse(button.CommandParameter.ToString());
            await model.ButtonInit(id);

        }

    

        private async void Ingredients_Clicked(object sender, EventArgs e)
        {
            await model.InitPreporuka();
            directionsButton.IsEnabled = true;
            ingredientsButton.IsEnabled = false;
        }

        private async void Directions_Clicked(object sender, EventArgs e)
        {
            await model.Init();
            directionsButton.IsEnabled = false;
            ingredientsButton.IsEnabled = true;
        }
    }
}