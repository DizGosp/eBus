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

namespace eBus.WinUI.Gradovi
{
    public partial class frmGradoviPretraga : Form
    {
        private readonly APIService _grad = new APIService("Grad");
        public frmGradoviPretraga()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private  async void frmGradoviPretraga_Load(object sender, EventArgs e)
        {
            var result = await _grad.Get<List<Grad>>(null);
            dgvGradovi.DataSource = result;
        }

        private void dgvGradovi_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var id = dgvGradovi.SelectedRows[0].Cells[0].Value;

            frmGradovi frm = new frmGradovi(int.Parse(id.ToString()));
            frm.Show();


        }
    }
}
