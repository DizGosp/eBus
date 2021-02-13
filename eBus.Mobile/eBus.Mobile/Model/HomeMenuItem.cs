using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Mobile.Model
{
    public enum MenuItemType
    {

        Browse,
        About,
        Profil,
        Novosti,
        Ocjena,
        Notifikacija,
        Linija,
        Rezervacija,
        Preporuke,
        Odjava
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
