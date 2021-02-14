
using eBus.Mobile.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBus.Mobile.ViewModel
{
    public class LoginViewModel :BaseViewModel
    {
        private readonly APIService _ser = new APIService("Putnik");
        
        public LoginViewModel() 
        {
            LoginCommand = new Command(async ()=>await Login());
            RegistracijaCommand = new Command(Registracija);
        }

        async void Registracija()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new RegistracijaPage());
        }

        string _username = string.Empty;
        public string Username 
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }
        string _pass = string.Empty;
        public string Password
        {
            get { return _pass; }
            set { SetProperty(ref _pass, value); }
        }
        public ICommand RegistracijaCommand { get; set; }
        public ICommand LoginCommand { get; set; }

        [Obsolete]
        async Task Login() 
        {
            IsBusy = true;
            APIService.Username = Username;
            APIService.Password = Password;

            try
            {
                await _ser.Get<dynamic>(null);
                Application.Current.MainPage = new eBus.Mobile.View.MainPage();
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Korisničko ime ili lozinka pogrešni", "OK");
                throw;
            }

        }

    }
}
