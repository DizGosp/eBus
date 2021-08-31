using eBus.Model;
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
        private int? _id = null;
        public frmGradovi(int? id)
        {
            InitializeComponent();
            _id = id;
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
            if (this.ValidateChildren()) 
            {
                Model.Grad req = new Model.Grad
                {
                    NazivGrada = txtNaziv.Text
                };

                var idDr = cmbDrzava.SelectedValue;
                if (int.TryParse(idDr.ToString(), out int id))
                {
                    req.DrzavaId = id;
                }
                await _grad.Insert<Model.Grad>(req);

                MessageBox.Show("Operacija uspješno izvršena!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmRedVoznje frm = new frmRedVoznje(null);
                frm.Show();
                this.Close();
            }
            
        }

       

        private async void frmGradovi_Load(object sender, EventArgs e)
        {
            await LoadDrzava();
            if (_id.HasValue) 
            {
                var grad =await _grad.GetById<Grad>(_id);

                txtNaziv.Text = grad.NazivGrada;
                cmbDrzava.Hide();
            }

        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            frmDrzava frm = new frmDrzava(null);
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text) || cmbDrzava.SelectedValue==null)
            {
                errorProvider1.SetError(txtNaziv, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtNaziv, null);
            }

        }
    }
}
