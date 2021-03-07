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
    public partial class NovostiPage : ContentPage
    {
        NovostiViewModel model = null;
        public NovostiPage()
        {
            InitializeComponent();

            BindingContext = model = new NovostiViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        //private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    try
        //    {
        //        var novost = e.SelectedItem as Novosti;

        //        Navigation.PushAsync(new NovostiDetaljiPage(novost));
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //}
    }
}