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
    public partial class frmKartaPregled : Form
    {
        APIService _karta = new APIService("Karta");
        private int? _korId = null;
        public frmKartaPregled(int kor)
        {
            InitializeComponent();
            _korId = kor;
            dgrKaraPregled.AutoGenerateColumns = false;
        }

        private async void frmKartaPregled_Load(object sender, EventArgs e)
        {
            var result = await _karta.Get<List<Model.Karta>>(null);
            dgrKaraPregled.DataSource = result;
            dgrKaraPregled.MaximumSize = MaximumSize;
        }

        private async void btnKartaFilter_Click(object sender, EventArgs e)
        {
            var x = new Model.Karta()
            {
                DatumIzdavanja = dtpKarta.Value
            };

            var result = await _karta.Get<Model.Karta>(x);
            dgrKaraPregled.DataSource = result; 
            dgrKaraPregled.MaximumSize = MaximumSize;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
