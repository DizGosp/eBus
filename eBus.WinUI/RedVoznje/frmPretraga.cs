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

namespace eBus.WinUI.RedVoznje
{
    public partial class frmPretraga : Form
    {
        APIService _autobus = new APIService("Autobus");
        APIService _gradovOD = new APIService("Grad");
        APIService _gradovDO = new APIService("Grad");
        APIService _redVoznje = new APIService("RedVoznje");
        private int? _id = null;
        KorisniciInsertRequest request = new KorisniciInsertRequest();
        public frmPretraga(int? korisnikID = null)
        {
            InitializeComponent();
            _id = korisnikID;
    }

        private async void frmPretraga_Load(object sender, EventArgs e)
        {
           
            var result = await _redVoznje.Get<List<Model.RedVoznje>>(null);
            dgrRedPretraga.DataSource = result;
            dgrRedPretraga.MaximumSize = MaximumSize;

            await LoadAutobusi();
            await LoadGradOd();
            await LoadGradDo();

        }
        private async Task LoadAutobusi()
        {
            var result = await _autobus.Get<List<Model.Autobus>>(null);
            result.Insert(0, new Model.Autobus());
            cmbBus.DataSource = result;
            cmbBus.DisplayMember = "NazivAutobusa";
            cmbBus.ValueMember = "AutobusID";

        }
        private async Task LoadGradOd()
        {
            var result = await _gradovOD.Get<List<Model.Grad>>(null);
            result.Insert(0, new Model.Grad());
            cmbOD.DataSource = result;
            cmbOD.DisplayMember = "NazivGrada";
            cmbOD.ValueMember = "GradId";
        }
        private async Task LoadGradDo()
        {
            var result = await _gradovDO.Get<List<Model.Grad>>(null);
            result.Insert(0, new Model.Grad());
            cmbDo.DataSource = result;
            cmbDo.DisplayMember = "NazivGrada";
            cmbDo.ValueMember = "GradId";
        }


        private async Task LoadRedVoznje(RedVoznjeSearchRequest x)
        {
            var result = await _redVoznje.Get<List<Model.RedVoznje>>(x);
            dgrRedPretraga.DataSource = result;   
        }

        private async void btnFiltriraj_Click(object sender, EventArgs e)
        {
            var x =new RedVoznjeSearchRequest() 
            {
                GradPolaskaId= (int?)cmbOD.SelectedValue,
                GradDolaskaId= (int?)cmbDo.SelectedValue,
                AutobusId= (int?)cmbBus.SelectedValue,
                DatumVrijemeDolaska=dtpDO.Value.Date,
                DatumVrijemePolaska=dtpOD.Value.Date
            };

            await LoadRedVoznje(x);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRedVoznje frm = new frmRedVoznje(_id);
            frm.Show();
            this.Close();
        }
    }
}
