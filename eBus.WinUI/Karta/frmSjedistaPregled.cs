using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBus.WinUI.Karta
{
    public partial class frmSjedistaPregled : Form
    {
        APIService _autobus = new APIService("Autobus");
        APIService _sjediste = new APIService("RezervacijaSjedista");

        public frmSjedistaPregled()
        {
            InitializeComponent();
            dgrSjediste.AutoGenerateColumns = false;
        }
        private async Task LoadAutobusi()
        {
            var result = await _autobus.Get<List<Model.Autobus>>(null);
            result.Insert(0, new Model.Autobus());
            cmbBus.DataSource = result;
            cmbBus.DisplayMember = "NazivAutobusa";
            cmbBus.ValueMember = "AutobusID";

        }
        private async void frmSjedistaPregled_Load(object sender, EventArgs e)
        {
            var result = await _sjediste.Get<List<Model.RezervacijaSjedista>>(null);
            dgrSjediste.DataSource = result;
            dgrSjediste.MaximumSize = MaximumSize;

            await LoadAutobusi();
        }

        private async void btnKartaFilter_Click(object sender, EventArgs e)
        {
            var x = new Model.RezervacijaSjedista()
            {
                AutobusId = (int)cmbBus.SelectedValue
            };

            var result = await _sjediste.Get<Model.RezervacijaSjedista>(x);
            dgrSjediste.DataSource = result;
            dgrSjediste.MaximumSize = MaximumSize;
        }
    }
}
