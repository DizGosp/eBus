using eBus.Model;
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
    public partial class frmUkupnaZarada : Form
    {
        APIService _rezKarte = new APIService("RezervacijaKarte");
        public frmUkupnaZarada()
        {
            InitializeComponent();
        }

        private async void frmUkupnaZarada_Load(object sender, EventArgs e)
        {
            var ListaRezervacija = await _rezKarte.Get<List<RezervacijaKarte>>(null);

            decimal result = 0;

            foreach (var item in ListaRezervacija)
            {
                result += item.RedVoznje.Cijena.Value;
            }

            txtZarada.Text = result.ToString();
        }
    }
}
