using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBus.WinUI.Vozilo_i_vozac
{
    public partial class frmVozac : Form
    {
        private APIService _vozac =new APIService("Vozac");
        private int? k = null;
        public frmVozac(int? kor)
        {
            InitializeComponent();
            k = kor;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            Model.Vozaci voz = new Model.Vozaci()
            {
                Ime=txtIme.Text,
                Prezime=txtPrezime.Text,
                Vozacka=txtVozKlasa.Text,
                Status=cbStatus.Checked
            };

            await _vozac.Insert<Model.Vozaci>(voz);
            MessageBox.Show("Operacija uspješno izvršena!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmAutobus frm = new frmAutobus(k);
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
