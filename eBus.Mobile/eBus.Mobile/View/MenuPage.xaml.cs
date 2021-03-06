﻿using eBus.Mobile.Model;
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
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
      
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;

      
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Novosti, Title="Novosti" },
                new HomeMenuItem {Id = MenuItemType.RedVoznje, Title="Red voznje" },
                new HomeMenuItem {Id = MenuItemType.Rezervacije, Title="Rezervacije" },
                 new HomeMenuItem {Id = MenuItemType.OcijeniRezervacija, Title="Ocijenite vožnju" },
                new HomeMenuItem {Id = MenuItemType.Karte, Title="Karte" }
                //new HomeMenuItem {Id = MenuItemType.Odjava, Title="Odjava" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];

            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                int id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };



        }
    }
}