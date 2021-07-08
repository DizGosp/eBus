using eBus.Model;
using eBus.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBus.WinUI.Izvještaji
{
    public partial class frmZaradaKorisnik : Form
    {

        APIService _putnik = new APIService("Putnik");
        APIService _rezKarte = new APIService("RezervacijaKarte");

        public  frmZaradaKorisnik()
        {
            InitializeComponent();
           
        }


        private async Task LoadKorisnici()
        {
            var result = await _putnik.Get<List<Model.Putnici>>(null);
            result.Insert(0, new Model.Putnici());
            cmbPutnik.DataSource = result;
            cmbPutnik.DisplayMember = "KorisnickoIme";
            cmbPutnik.ValueMember = "PutnikID";

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            RezervacijaSearchRequest searc = new RezervacijaSearchRequest()
            {
                Platio=true,
                PutnikId=(int)cmbPutnik.SelectedValue
            };

            var ListaRezervacija = await _rezKarte.Get<List<RezervacijaKarte>>(searc);

            decimal result = 0;

            foreach (var item in ListaRezervacija)
            {
                result += item.RedVoznje.Cijena.Value;
            }

            txtKorisnikZarada.Text = result.ToString();
        }

        private async void frmZaradaKorisnik_Load(object sender, EventArgs e)
        {
            await LoadKorisnici();
        }
    }
}
