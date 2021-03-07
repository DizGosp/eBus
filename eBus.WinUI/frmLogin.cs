using eBus.Model.Request;
using eBus.WinUI.Korisnici;
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
    public partial class frmLogin : Form
    {
        APIService _serviceR = new APIService("RedVoznje");
        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
         
            APIService.Username = txtUser.Text;
            APIService.Password = txtPass.Text;
            try
            {          
                await _serviceR.Get<dynamic>(null);
                frmIndex frm = new frmIndex(APIService.Username);
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Korisničko ime ili šifra nisu ispravni!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
    }
}
