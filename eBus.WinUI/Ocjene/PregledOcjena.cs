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

namespace eBus.WinUI.Ocjene
{
    public partial class PregledOcjena : Form
    {

        private readonly APIService _ocjene = new APIService("Ocjena"); 

        public PregledOcjena()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void PregledOcjena_Load(object sender, EventArgs e)
        {
            var result = await _ocjene.Get<List<Ocjena>>(null);
            dtgOcjene.AutoGenerateColumns = false;
            dtgOcjene.DataSource = result;
        }
    }
}
