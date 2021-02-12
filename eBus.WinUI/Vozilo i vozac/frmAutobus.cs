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

namespace eBus.WinUI.Vozilo_i_vozac
{
    public partial class frmAutobus : Form
    {
        private readonly APIService _vozac = new APIService("Vozac");
        private readonly APIService _autobus = new APIService("Autobus");
        private int? _id = null;
        public frmAutobus(int? _korId)
        {
            InitializeComponent();
            _id = _korId;

        }

        private async Task LoadVozaci()
        {
            var result = await _vozac.Get<List<Model.Vozaci>>(null);
            result.Insert(0, new Model.Vozaci());
            cmbVoz.DataSource = result;
            cmbVoz.DisplayMember = "Ime";
            cmbVoz.ValueMember = "VozacId";

        }
        private async void frmAutobus_Load(object sender, EventArgs e)
        {
            await LoadVozaci();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            Model.Autobus a = new Model.Autobus()
            {
                NazivAutobusa=txtVozilo.Text,
                Klasa=txtKlasa.Text,
                Status=cbStatus.Checked,
                BrojSjedista=int.Parse(txtBr.Text)
            };
            var idOD = cmbVoz.SelectedValue;
            if (int.TryParse(idOD.ToString(), out int id))
            {
                a.VozacId = id;
            }

            Model.Vozaci v = await _vozac.GetById<Model.Vozaci>(a.VozacId);
            v.Status = true;
            await _vozac.Update<Model.Vozaci>(a.VozacId,v);



            await _autobus.Insert<Model.Autobus>(a);
            MessageBox.Show("Operacija uspješno izvršena!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmRedVoznje frm = new frmRedVoznje(_id);
            frm.Show();
            this.Close();
        }

        private void btnVoz_Click(object sender, EventArgs e)
        {
            frmVozac frm = new frmVozac(_id);
            frm.Show();
            this.Close();
        }
    }
}
