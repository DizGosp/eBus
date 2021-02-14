using System.ComponentModel;
using Xamarin.Forms;
using eBus.Mobile.ViewModel;

namespace eBus.Mobile.View
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}