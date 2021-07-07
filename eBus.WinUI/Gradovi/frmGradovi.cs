using eBus.WinUI.RedVoznje;
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
    public partial class frmGradovi : Form
    {
        private readonly APIService _grad = new APIService("Grad");
        private readonly APIService _drzava = new APIService("Drzava");
        private int? _korId = null;
        public frmGradovi(int? korId)
        {
            InitializeComponent();
            _korId = korId;
        }
        private async Task LoadDrzava()
        {
            var result = await _drzava.Get<List<Model.Drzava>>(null);
            result.Insert(0, new Model.Drzava());
            cmbDrzava.DataSource = result;
            cmbDrzava.DisplayMember = "NazivDrzave";
            cmbDrzava.ValueMember = "DrzavaID";

        }
        private async void button1_Click(object sender, EventArgs e)
        {

            Model.Grad req = new Model.Grad
            {
                NazivGrada=txtNaziv.Text
            };

            var idDr = cmbDrzava.SelectedValue;
            if (int.TryParse(idDr.ToString(), out int id))
            {
                req.DrzavaId = id;
            }
            await _grad.Insert<Model.Grad>(req);

            MessageBox.Show("Operacija uspješno izvršena!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmRedVoznje frm = new frmRedVoznje(_korId);
            frm.Show();
            this.Close();
        }

       

        private async void frmGradovi_Load(object sender, EventArgs e)
        {
            await LoadDrzava();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            frmDrzava frm = new frmDrzava(_korId);
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
