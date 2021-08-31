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
        private readonly APIService _uloge = new APIService("Uloge");
        private readonly APIService _serviceUlogeKorisnici = new APIService("KorisniciUloge");
        private int? _id = null;
        KorisniciInsertRequest request = new KorisniciInsertRequest();
        public frmKorisniciDetalji(int? korisnikID = null)
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

        public static byte[] GetByte(Image image)
        {
            MemoryStream ms = new MemoryStream();
            image.Save(ms, ImageFormat.Png);

            return ms.ToArray();
        }

        private async void txtSnimiKor_Click(object sender, EventArgs e)
        {

            try
            {
                if (ValidateChildren())
                {
                    var roleList = cbKorisniciUloge.CheckedItems.Cast<Model.Uloge>().Select(x => x.UlogaId).ToList();

                    request.Email = txtEmail.Text;
                    request.Ime = txtIme.Text;
                    request.Prezime = txtPrezime.Text;
                    request.KorisnickoIme = txtKorIme.Text;
                    request.pass = txtPass.Text;
                    request.confPass = txtConf.Text;
                    request.Status = cbAktivan.Checked;

                    if (_id.HasValue)
                    {
                        request.Slika = GetByte(pbKorisnik.Image);
                        await _service.Update<Model.Korisnici>(_id, request);
                    }
                    else
                    {
                        await _service.Insert<Model.Korisnici>(request);

                        //List<Model.Korisnici> listaKorisnika = await _service.Get<List<Model.Korisnici>>(null);

                        //for (int i = 0; i <listaKorisnika.Count; i++)
                        //{
                        //    if (listaKorisnika[i].KorisnickoIme == request.KorisnickoIme) 
                        //    {
                        //        for (int j= 0; j < roleList.Count; j++)
                        //        {
                        //            await _service.Insert<Model.KorisniciUloge>(new Model.KorisniciUloge()
                        //            {
                        //                UlogaId = roleList[j],
                        //                KorisnikId = listaKorisnika[i].KorisnikId
                        //            });
                        //        }
                        //    }
                        //}

                        

                    }
                    MessageBox.Show("Operacija uspješno izvršena!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void frmKorisniciDetalji_Load(object sender, EventArgs e)
        {
            var lista = await _uloge.Get<List<Model.Uloge>>(null);
            cbKorisniciUloge.DataSource = lista;
            cbKorisniciUloge.DisplayMember = "Naziv";

            if (_id.HasValue)
            {
                try
                {
                    var korisnik = await _service.GetById<Model.Korisnici>(_id);
                    txtEmail.Text = korisnik.Email;
                    txtIme.Text = korisnik.Ime;
                    txtPrezime.Text = korisnik.Prezime;
                    txtKorIme.Text = korisnik.KorisnickoIme;
                    txtImage.Text = "some data";
                    pbKorisnik.Image = GetImage(korisnik.Slika);
                    pbKorisnik.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
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
            var result = ofdKorisnikSlika.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = ofdKorisnikSlika.FileName;

                var file = File.ReadAllBytes(fileName);

                request.Slika = file;
                txtImage.Text = fileName;

                Image image = Image.FromFile(fileName);
                pbKorisnik.Image = image;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtKorIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorIme.Text))
            {
                errorProvider.SetError(txtKorIme, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtKorIme, null);
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                errorProvider.SetError(txtPass, "Obavezno polje!");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtPass, null);
            }
        }
    }
}
