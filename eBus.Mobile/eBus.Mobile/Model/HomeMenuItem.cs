using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Mobile.Model
{
    public enum MenuItemType
    {

        Novosti,
        About,
        RedVoznje,
        Rezervacije,
        OcijeniRezervacija,
        Karte
        
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
