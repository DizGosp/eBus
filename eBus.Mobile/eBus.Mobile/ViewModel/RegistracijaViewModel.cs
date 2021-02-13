using eBus.Mobile.View;
using eBus.Model;
using eBus.Model.Request;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eBus.Mobile.ViewModel
{
    class RegistracijaViewModel : BaseViewModel
    {
        private readonly APIService _putnikService = new APIService("Putnik");
        public Putnici Putnik { get; set; }

        private string _ime = string.Empty;
        public string Ime
        {
            get { return _ime; }
            set { SetProperty(ref _ime, value); }
        }
        private string _prezime = string.Empty;
        public string Prezime
        {
            get { return _prezime; }
            set { SetProperty(ref _prezime, value); }
        }

        private string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { SetProperty(ref _email, value); }
        }


        private byte[] _slika = new byte[0];

        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }

        private string _korisnickoIme = string.Empty;
        public string KorisnickoIme
        {
            get { return _korisnickoIme; }
            set { SetProperty(ref _korisnickoIme, value); }
        }

        private string _lozinka = string.Empty;
        public string Lozinka
        {
            get { return _lozinka; }
            set { SetProperty(ref _lozinka, value); }
        }

        private string _potvrdiLozinku = string.Empty;
        public string PotvrdiLozinku
        {
            get { return _potvrdiLozinku; }
            set { SetProperty(ref _potvrdiLozinku, value); }
        }

        private DateTime _datumRodjenja = DateTime.Now;
        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set { SetProperty(ref _datumRodjenja, value); }
        }

        public async Task<bool> ProvjeriKorisnickoIme(string NovoKorisnickoIme)
        {
            var lista = await _putnikService.Get<List<Putnici>>(null);

            foreach (var item in lista)
            {
                if (item.KorisnickoIme == NovoKorisnickoIme)
                    return true;
            }

            return false;
        }

        public async Task Init()
        {

            try
            {
                var putnik = new PutnikInsertRequest ();

                putnik.Ime = Ime;
                putnik.Prezime = Prezime;
                putnik.Email = Email;
                putnik.KorisnickoIme = KorisnickoIme;
                putnik.DatumRegistracije = DateTime.Now;
                putnik.Lozinka = Lozinka;
                putnik.PotvrdiLozinku = PotvrdiLozinku;
                putnik.Slika = Slika;
                putnik.DatumRodjenja = DatumRodjenja;

                APIService.Username = KorisnickoIme;
                APIService.Password = Lozinka;


                await _putnikService.Registracija<Putnici>(putnik);

                await Application.Current.MainPage.DisplayAlert("Registracija", "Uspješno podaci pohranjeni", "OK");

              
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }
    }
}
