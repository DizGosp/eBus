using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Mobile.Model
{
    public enum MenuItemType
    {

        Browse,
        About,
        RedVoznje
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
