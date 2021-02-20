using eBus.Model.Request;
using eBus.WinUI.Karta;
using eBus.WinUI.Korisnici;
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

namespace eBus.WinUI
{
    public partial class frmIndex : Form
    {
        APIService _service = new APIService("Korisnici");
        private int childFormNumber = 0;
        private string _korIme = "";

        

        public frmIndex(string user)
        {
            InitializeComponent();
            _korIme = user;
        }
       
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private async Task<int> getId(string user) 
        {
            KorisniciSearchRequest search = new KorisniciSearchRequest()
            {
                userName = _korIme
            };
            var kor = await _service.Get<List<Model.Korisnici>>(search);
            int id = 0;
            foreach (var item in kor)
            {
                id = item.KorisnikId;
            }

            return id;
        }
        private void pretragaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnici frm = new frmKorisnici();
            frm.MdiParent = this;       
            frm.Show();
        }

        private void unosKorisnikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisniciDetalji frm = new frmKorisniciDetalji();
            frm.MdiParent = this;   
            frm.Show();
        }

        private async void unosRedaVožnjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = await getId(_korIme);

            frmRedVoznje frm = new frmRedVoznje(id);
            frm.MdiParent = this;     
            frm.Show();
        }

        private async void pretragaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id = await getId(_korIme);

            frmPretraga frm = new frmPretraga(id);
            frm.MdiParent = this;       
            frm.Show();
        }

        private async void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = await getId(_korIme);
            frmKartaPregled frm = new frmKartaPregled(id);
            frm.MdiParent = this;
            frm.Show();

        }

        private async void pregledSjedištaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSjedistaPregled frm = new frmSjedistaPregled();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
