using eBus.Model.Request;
using eBus.WinUI.Gradovi;
using eBus.WinUI.Korisnici;
using eBus.WinUI.Ocjene;
using eBus.WinUI.RedVoznje;
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

namespace eBus.WinUI.Karta
{
    public partial class frmIndexPoziva : Form
    {
        APIService _service = new APIService("Korisnici");
        APIService _serviceUloge = new APIService("KorisniciUloge");
        private string _korIme = "";
        public frmIndexPoziva()
        {
            InitializeComponent();
            Provjeri();
        }

        private async void Provjeri() 
        {
            var x = await _service.Get<List<Model.Korisnici>>(null);
            List<Model.KorisniciUloge> ulogeKorisnici = await _serviceUloge.Get<List<Model.KorisniciUloge>>(null);
            for (int i = 0; i < x.Count; i++)
            {
                if (x[i].KorisnickoIme == APIService.Username)
                {
                    for (int j = 0; j < ulogeKorisnici.Count; j++)
                    {

                        if (ulogeKorisnici[j].UlogaId != 1 && x[i].KorisnikId==ulogeKorisnici[j].KorisnikId)
                        {
                            this.button1.Hide();
                            this.button2.Hide();
                        }
                    }
                    return;
                }
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


        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button8_MouseHover(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button9_MouseHover(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24,30, 54);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button9_MouseLeave(object sender, EventArgs e)
        {
            button9.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(24, 30, 54);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            frmKorisniciDetalji frm = new frmKorisniciDetalji();
            frm.Show();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            int id = await getId(_korIme);
            frmRedVoznje frm = new frmRedVoznje(id);
            frm.Show();
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            int id = await getId(_korIme);
            frmGradovi frm  = new frmGradovi(id);
            frm.Show();
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            int id = await getId(_korIme);
            frmDrzava frm = new frmDrzava(id);
            frm.Show();
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            int id = await getId(_korIme);
            frmVozac frm = new frmVozac(id);
            frm.Show();
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            int id = await getId(_korIme);
            frmAutobus frm = new frmAutobus(id);
            frm.Show();
        }

        private async void button5_Click(object sender, EventArgs e)
        {
            int id = await getId(_korIme);
            frmKartaPregled frm = new frmKartaPregled(id);
            frm.Show();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            int id = await getId(_korIme);
            frmPretraga frm = new frmPretraga(id);
            frm.Show();
        }

        private  void button10_Click(object sender, EventArgs e)
        {
           
            PregledOcjena frm = new PregledOcjena();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            frmKorisnici frm = new frmKorisnici();
            frm.Show();
        }
    }
}
