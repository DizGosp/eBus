using eBus.WinUI.Karta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBus.WinUI
{
    public partial class Form1 : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(46, 51, 73);


            lblNaziv.Text = "Početna";
            this.PnlFormLoader.Controls.Clear();
            frmIndexPoziva frm = new frmIndexPoziva() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm);
            frm.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHome.Height;
            pnlNav.Top = btnHome.Top;
            pnlNav.Left = btnHome.Left;
            btnHome.BackColor = Color.FromArgb(46, 51, 73);

            lblNaziv.Text = "Početna";
            this.PnlFormLoader.Controls.Clear();
            frmIndexPoziva frm = new frmIndexPoziva() { Dock=DockStyle.Fill, TopLevel=false, TopMost=true};
            frm.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(frm);
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnKorisnici.Height;
            pnlNav.Top = btnKorisnici.Top;
            pnlNav.Left = btnKorisnici.Left;
            btnKorisnici.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnRedVoznje.Height;
            pnlNav.Top = btnRedVoznje.Top;
            pnlNav.Left = btnRedVoznje.Left;
            btnRedVoznje.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnKarta_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnKarta.Height;
            pnlNav.Top = btnKarta.Top;
            pnlNav.Left = btnKarta.Left;
            btnKarta.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnHome_Leave(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnKorisnici_Leave(object sender, EventArgs e)
        {
            btnKorisnici.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnRedVoznje_Leave(object sender, EventArgs e)
        {
            btnRedVoznje.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnKarta_Leave(object sender, EventArgs e)
        {
            btnKarta.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
