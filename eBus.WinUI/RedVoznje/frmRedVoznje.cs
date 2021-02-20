using eBus.Model.Request;
using eBus.WinUI.Gradovi;
using eBus.WinUI.Vozilo_i_vozac;
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
    public partial class frmRedVoznje : Form
    {
        private readonly APIService _autobus = new APIService("Autobus");
        private readonly APIService _gradOD = new APIService("Grad");
        private readonly APIService _gradDO = new APIService("Grad");
        private readonly APIService _red = new APIService("RedVoznje");
        private int? _korId { get; set; }
        public frmRedVoznje(int? kor)
        {
            InitializeComponent();
            _korId = kor;
        }

        private async void frmRedVoznje_Load(object sender, EventArgs e)
        {
            await LoadAutobusi();
            await LoadGradOD();
            await LoadGradDO();
        }

        private async Task LoadAutobusi() 
        {
            var searc = new Model.Autobus()
            {
                Status = false
            };
            var result = await _autobus.Get<List<Model.Autobus>>(null);
            result.Insert(0, new Model.Autobus());
            cmbBus.DataSource = result;
            cmbBus.DisplayMember = "NazivAutobusa";
            cmbBus.ValueMember = "AutobusID";

        }
        private async Task LoadGradOD()
        {
            var result = await _gradOD.Get<List<Model.Grad>>(null);
            result.Insert(0, new Model.Grad());
            cmbOD.DataSource = result; 
            cmbOD.DisplayMember = "NazivGrada";
            cmbOD.ValueMember = "GradId";
        }
        private async Task LoadGradDO()
        {
            var result = await _gradDO.Get<List<Model.Grad>>(null);
            result.Insert(0, new Model.Grad());
            cmbDo.DataSource = result;
            cmbDo.DisplayMember = "NazivGrada";
            cmbDo.ValueMember = "GradId";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
   
            RedVoznjeUpsertRequest req = new RedVoznjeUpsertRequest
            {
                Cijena = numCijena.Value,
                Naziv = txtKomp.Text,
                DatumVrijemePolaska = dtpOD.Value,
                DatumVrijemeDolaska = dtpDO.Value,
                KorisnikId =  _korId      
            };

            var idOD = cmbOD.SelectedValue;
            if(int.TryParse(idOD.ToString(), out int id)) 
            {
                req.GradPolaskaId = id;
            }
            var idDO = cmbDo.SelectedValue;
            if (int.TryParse(idDO.ToString(), out int idD))
            {
                req.GradDolaskaId = idD;
            }
            var idBs = cmbBus.SelectedValue;
            if (int.TryParse(idBs.ToString(), out int idB))
            {
                req.AutobusId = idB;
            }
         
            Model.Autobus v = await _autobus.GetById<Model.Autobus>(req.AutobusId);
            v.Status = true;
            await _autobus.Update<Model.Autobus>(req.AutobusId, v);
        

            await _red.Insert<Model.RedVoznje>(req);
            MessageBox.Show("Operacija uspješno izvršena!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmGradovi frm = new frmGradovi(_korId);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmGradovi frm = new frmGradovi(_korId);
            frm.Show();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAutobus frm = new frmAutobus(_korId);
            frm.Show();
        }
    }
}
