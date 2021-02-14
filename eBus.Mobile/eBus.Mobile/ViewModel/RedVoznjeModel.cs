using eBus.Model;
using eBus.Model.Request;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBus.Mobile.ViewModel
{
    public class RedVoznjeModel : BaseViewModel
    {

        private readonly APIService _RedVoznje = new APIService("RedVoznje");
        private readonly APIService _Grad = new APIService("Grad");
        public RedVoznjeModel() 
        {
            InitCommand = new Command(async () => await Init());
        }

        public ObservableCollection<RedVoznje> RedVoznjeList { get; set; } = new ObservableCollection<RedVoznje>();
        public ObservableCollection<Grad> GradoviList { get; set; } = new ObservableCollection<Grad>();

        Grad _selectedGradPolaska = null;
        public Grad SelectedGradPolaska 
        {
            get { return _selectedGradPolaska; }
            set 
            { 
                SetProperty(ref _selectedGradPolaska, value);
                if (value != null){InitCommand.Execute(null); }
            } 
        }
        Grad _selectedGradDolaska = null;
        public Grad SelectedGradDolaska
        {
            get { return _selectedGradDolaska; }
            set
            {
                SetProperty(ref _selectedGradDolaska, value);
                if (value != null) { InitCommand.Execute(null); }
            }
        }

        public ICommand InitCommand { get; set; }

        public async Task Init() 
        {

            if (GradoviList.Count == 0) 
            {
                var listGrad = await _Grad.Get<List<Grad>>(null);
               
                foreach (var x in listGrad)
                {
                    GradoviList.Add(x);
                }
            }

            if (SelectedGradPolaska != null && SelectedGradDolaska!=null) 
            {
                RedVoznjeSearchRequest search = new RedVoznjeSearchRequest()
                {
                    GradPolaskaId = SelectedGradPolaska.GradId,
                    GradDolaskaId =SelectedGradDolaska.GradId
                };

                var list = await _RedVoznje.Get<IEnumerable<RedVoznje>>(search);
                RedVoznjeList.Clear();
                foreach (var item in list)
                {
                    RedVoznjeList.Add(item);
                }
            }
            else if(SelectedGradPolaska!=null && SelectedGradDolaska == null) 
            {
                RedVoznjeSearchRequest search = new RedVoznjeSearchRequest()
                {
                    GradPolaskaId = SelectedGradPolaska.GradId
                };

                var list = await _RedVoznje.Get<IEnumerable<RedVoznje>>(search);
                RedVoznjeList.Clear();
                foreach (var item in list)
                {
                    RedVoznjeList.Add(item);
                }
            }
            else if (SelectedGradPolaska == null && SelectedGradDolaska != null)
            {
                RedVoznjeSearchRequest search = new RedVoznjeSearchRequest()
                {
                    GradDolaskaId = SelectedGradDolaska.GradId
                };

                var list = await _RedVoznje.Get<IEnumerable<RedVoznje>>(search);
                RedVoznjeList.Clear();
                foreach (var item in list)
                {
                    RedVoznjeList.Add(item);
                }
            }
            else if (SelectedGradPolaska == null && SelectedGradDolaska == null)
            {
                var list = await _RedVoznje.Get<IEnumerable<RedVoznje>>(null);
                RedVoznjeList.Clear();
                foreach (var item in list)
                {
                    RedVoznjeList.Add(item);
                }
            }
        }

    }
}
