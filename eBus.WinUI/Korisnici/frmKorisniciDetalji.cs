using eBus.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBus.WinUI.Korisnici
{
    public partial class frmKorisniciDetalji : Form
    {
        private readonly APIService _service = new APIService("Korisnici");
        private int? _id = null;
        private  byte[] CopyImageToByteArray = null;
        KorisniciInsertRequest request = new KorisniciInsertRequest();
        public frmKorisniciDetalji(int? korisnikID=null)
        {
            InitializeComponent();
            _id = korisnikID;

        }

        private static Image GetImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return (Image.FromStream(ms));
            }
        }
       
        
        private async void txtSnimiKor_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                request.Email = txtEmail.Text;
                request.Ime = txtIme.Text;
                request.Prezime = txtPrezime.Text;
                request.KorisnickoIme = txtKorIme.Text;
                request.pass = txtPass.Text;
                request.confPass = txtConf.Text;
                request.Status = cbAktivan.Checked;
                if (CopyImageToByteArray != null)
                {
                    request.Slika = CopyImageToByteArray;
                }
                if (_id.HasValue)
                {
                    await _service.Update<Model.Korisnici>(_id, request);
                }
                else
                {
                    await _service.Insert<Model.Korisnici>(request);
                }
                MessageBox.Show("Operacija uspješno izvršena!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            if (_id.HasValue) 
            {
                var korisnik = await _service.GetById<Model.Korisnici>(_id);

                txtEmail.Text = korisnik.Email;
                txtIme.Text = korisnik.Ime;
                txtPrezime.Text = korisnik.Prezime;
                txtKorIme.Text = korisnik.KorisnickoIme;
                CopyImageToByteArray = korisnik.Slika;
                pbKorisnik.Image = GetImage(korisnik.Slika);
                pbKorisnik.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text)) 
            {
                errorProvider.SetError(txtIme, Properties.Resources.Validation_RequiredField);
                e.Cancel = true;
            }
            else 
            {
                errorProvider.SetError(txtIme, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Obavezno polje!");
                e.Cancel = true;
            }
            
            else
            {
                errorProvider.SetError(txtEmail, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider.SetError(txtPrezime, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPrezime, null);
            }
        }

      
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Slika = file;
                txtImage.Text = fileName;

                Image img = Image.FromFile(fileName);
                pbKorisnik.Image = img;
                pbKorisnik.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
