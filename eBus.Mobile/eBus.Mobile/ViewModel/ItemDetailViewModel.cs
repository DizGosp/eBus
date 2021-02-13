using eBus.Mobile.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace eBus.Mobile.ViewModel
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
