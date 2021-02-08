using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBus.WinUI.Gradovi
{
    public partial class frmDrzava : Form
    {
        private readonly APIService _drzava = new APIService("Drzava");
        private int? _korId = null;
        public frmDrzava(int? kor)
        {
            InitializeComponent();
            _korId = kor;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Model.Drzava d = new Model.Drzava()
            {
                NazivDrzave = txtNaziv.Text
            };

            await _drzava.Insert<Model.Drzava>(d);
            MessageBox.Show("Operacija uspješno izvršena!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmGradovi frm = new frmGradovi(_korId);
            frm.Show();
            this.Close();
        }
    }
}
