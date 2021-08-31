﻿using eBus.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eBus.WinUI.Gradovi
{
    public partial class frmDrzava : Form
    {
        private readonly APIService _drzava = new APIService("Drzava");
        private int? _korId = null;
        public frmDrzava(int? kor)
        {
            InitializeComponent();
            _korId = kor;
        }

        private async void button1_Click(object sender, EventArgs e)
        {

            if (this.ValidateChildren()) 
            {
                DrzInsRequst d = new DrzInsRequst()
                {
                    NazivDrzave = txtNaziv.Text
                };

                await _drzava.Insert<DrzInsRequst>(d);


                MessageBox.Show("Operacija uspješno izvršena!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmGradovi frm = new frmGradovi(_korId);
                frm.Show();
                this.Close();

            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNaziv_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNaziv.Text)) 
            {
                erroDrzava.SetError(txtNaziv, "Obavezno polje!");
                e.Cancel = true;
            }
            else 
            {
                erroDrzava.SetError(txtNaziv, null);
            }
        }
    }
}
