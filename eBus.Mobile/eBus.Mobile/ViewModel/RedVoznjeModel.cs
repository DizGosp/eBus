using eBus.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBus.Mobile.ViewModel
{
    public class RedVoznjeModel
    {

        private readonly APIService _RedVoznje = new APIService("RedVoznje");
        public RedVoznjeModel() 
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<RedVoznje> RedVoznjeList { get; set; } = new ObservableCollection<RedVoznje>();

        public ICommand InitCommand { get; set; }

        public async Task Init() 
        {
            var list =await _RedVoznje.Get<IEnumerable<RedVoznje>>(null);
            RedVoznjeList.Clear();

            foreach (var item in list)
            {
                RedVoznjeList.Add(item);
            }
        }

    }
}
