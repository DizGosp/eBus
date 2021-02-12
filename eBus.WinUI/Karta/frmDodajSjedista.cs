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
    public partial class frmDodajSjedista : Form
    {
        APIService _autobus = new APIService("Autobus");
        APIService _sjedista = new APIService("RezervacijaSjedista");

        public frmDodajSjedista()
        {
            InitializeComponent();
        }
        private async Task LoadAutobusi()
        {
            var result = await _autobus.Get<List<Model.Autobus>>(null);
            result.Insert(0, new Model.Autobus());
            cmbBus.DataSource = result;
            cmbBus.DisplayMember = "NazivAutobusa";
            cmbBus.ValueMember = "AutobusID";

        }
        private async void frmDodajSjedista_Load(object sender, EventArgs e)
        {
            await LoadAutobusi();
        }

        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            var rSjed = new Model.RezervacijaSjedista()
            {
                Kolona = int.Parse(txtKolona.Text),
                Red = int.Parse(txtRed.Text),
                AutobusId = int.Parse(cmbBus.SelectedValue.ToString())
            };


            var searchSjedista = new Model.RezervacijaSjedista()
            {
                AutobusId = rSjed.AutobusId.Value
            };
            var listaSjedista = await _sjedista.Get<List<Model.RezervacijaSjedista>>(searchSjedista);
            var vozilo = await _autobus.GetById<Model.Autobus>(rSjed.AutobusId.Value);

            if (listaSjedista.Count != 0 && vozilo.BrojSjedista == listaSjedista.Count)
            {
                MessageBox.Show("Dodali ste sva sjedista za vozilo");
            }
            else
            {
                if (!await ProvjeriSjediste(rSjed))
                {
                    await _sjedista.Insert<Model.RezervacijaSjedista>(rSjed);


                    MessageBox.Show("Dodali ste sjedište");
                }
                else
                {
                    MessageBox.Show("Sjediste je vec dodano za to vozilo");
                }

            }
        }

        private async Task<bool> ProvjeriSjediste(Model.RezervacijaSjedista request)
        {

            var search = new Model.RezervacijaSjedista()
            {
                AutobusId = request.AutobusId.Value
            };
            var lista = await _sjedista.Get<List<Model.RezervacijaSjedista>>(search);

            foreach (var item in lista)
            {
                if (request.Red == item.Red && request.Kolona == item.Kolona)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
