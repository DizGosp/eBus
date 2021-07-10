using eBus.Mobile.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBus.Mobile.View
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    [Obsolete]
    public partial class MainPage : MasterDetailPage
    {

        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

          
            MenuPages.Add((int)MenuItemType.Novosti, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Novosti:
                        MenuPages.Add(id, new NavigationPage(new NovostiPage()));
                        break;
                    case (int)MenuItemType.RedVoznje:
                        MenuPages.Add(id, new NavigationPage(new RedVoznjePage()));
                        break;
                    case (int)MenuItemType.Rezervacije:
                        MenuPages.Add(id, new NavigationPage(new RezervacijePage()));
                        break;
                    case (int)MenuItemType.OcijeniRezervacija:
                        MenuPages.Add(id, new NavigationPage(new OcijeniteRezervacijaPage()));
                        break;
                    case (int)MenuItemType.Karte:
                        MenuPages.Add(id, new NavigationPage(new KartePage()));
                        break;
                    

                }

                var newPage = MenuPages[id];

                if (newPage != null && Detail != newPage)
                {
                    Detail = newPage;

                    if (Device.RuntimePlatform == Device.Android)
                        await Task.Delay(100);

                    IsPresented = false;
                }
            }
            
        }
    }
}