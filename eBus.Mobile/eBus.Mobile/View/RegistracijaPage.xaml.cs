using eBus.Mobile.ViewModel;
using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eBus.Mobile.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegistracijaPage : ContentPage
    {
        RegistracijaViewModel model = null;
        public RegistracijaPage()
        {
            InitializeComponent();
            BindingContext = model = new RegistracijaViewModel();
        }

        private async void Button_Registrujse(object sender, EventArgs e)
        {



            if (!Regex.IsMatch(this.Ime.Text, @"^[a-zA-Z]+$"))
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Ime se sastoji od samo slova", "OK");
            }
            else if (!Regex.IsMatch(this.Prezime.Text, @"^[a-zA-Z]+$"))
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Prezime se sastoji od samo slova", "OK");

            }
            else if (!Regex.IsMatch(this.Email.Text, @"^[a-zA-Z.]+@[a-z]+(?:.[a-z]+).[a-z]+$"))
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Email nije ispravnog formata", "OK");

            }
            else if (model.Slika.SequenceEqual(new byte[0]))
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Morate unjeti sliku", "OK");

            }
            else if (!Regex.IsMatch(this.KorinsickoIme.Text, @"^[a-z]+$"))
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Korisnicko ime se sastoji samo od malih slova", "OK");

            }
            else if (string.IsNullOrWhiteSpace(this.Lozinka.Text))
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Morate unjeti lozinku", "OK");

            }
            else if (this.Lozinka.Text != this.PotvrdiLozinku.Text)
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Lozinke se moraju podudarati", "OK");

            }
            else if (this.Lozinka.Text.Length < 4)
            {
                await Application.Current.MainPage.DisplayAlert(" ", "Lozinke ne smije biti manja od 4 karaktera", "OK");

            }
            //else if (await model.ProvjeriKorisnickoIme(this.KorinsickoIme.Text))
            //{
            //    await Application.Current.MainPage.DisplayAlert(" ", "Korisničko ime nije dozvoljeno", "OK");
            //}
            else
            {

                await model.Init();

            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            
                if (!CrossMedia.Current.IsPickPhotoSupported)
                {
                    await Application.Current.MainPage.DisplayAlert(" ", "Format slike nije podržan", "OK");
                    return;
                }

                var file = await CrossMedia.Current.PickPhotoAsync();
                if (file == null)
                    return;

                Stream stream = file.GetStream();

                using (MemoryStream ms = new MemoryStream())
                {
                    stream.CopyTo(ms);

                    model.Slika = ms.ToArray();
                }
            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
        }
    }
}