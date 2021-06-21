using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Mobile.Model
{
    public enum MenuItemType
    {

        Notifikacija,
        About,
        RedVoznje,
        Rezervacije,
        Karte,
        Novosti
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
