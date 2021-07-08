using Flurl.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eBus.Model;
using eBus.Model.Request;
//https://localhost:44329/
namespace eBus.WinUI.Korisnici
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _api = new APIService("Korisnici");

        public frmKorisnici()
        {
            InitializeComponent();
        }

        private async void btnPrikazi_Click(object sender, EventArgs e)
        {

            var search = new KorisniciSearchRequest()
            {
                ime = txtPretraga.Text,
                prezime=txtPrezime.Text
            };

            var result = await _api.Get<List<Model.Korisnici>>(search);
            dgvKorisnici.DataSource = result;
        }

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvKorisnici.SelectedRows[0].Cells[0].Value;
            frmKorisniciDetalji frm = new frmKorisniciDetalji(int.Parse(id.ToString()));
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpKorisnici_Enter(object sender, EventArgs e)
        {

        }
    }
}
