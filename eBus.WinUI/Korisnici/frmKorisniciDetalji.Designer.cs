namespace eBus.WinUI.Korisnici
{
    partial class frmKorisniciDetalji
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSnimiKor = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbAktivan = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ofdKorisnikSlika = new System.Windows.Forms.OpenFileDialog();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.btnAddImage = new System.Windows.Forms.Button();
            this.pbKorisnik = new System.Windows.Forms.PictureBox();
            this.cbKorisniciUloge = new System.Windows.Forms.CheckedListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKorisnik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(209, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalji korisnika";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblIme.Location = new System.Drawing.Point(84, 135);
            this.lblIme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(30, 17);
            this.lblIme.TabIndex = 1;
            this.lblIme.Text = "Ime";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(217, 127);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(345, 22);
            this.txtIme.TabIndex = 2;
            this.txtIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtIme_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(217, 176);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(345, 22);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.errorProvider.SetIconAlignment(this.label2, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.label2.Location = new System.Drawing.Point(84, 230);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(217, 226);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(345, 22);
            this.txtPrezime.TabIndex = 6;
            this.txtPrezime.Validating += new System.ComponentModel.CancelEventHandler(this.txtPrezime_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.errorProvider.SetIconAlignment(this.label3, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.label3.Location = new System.Drawing.Point(84, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // txtKorIme
            // 
            this.txtKorIme.Location = new System.Drawing.Point(217, 279);
            this.txtKorIme.Margin = new System.Windows.Forms.Padding(4);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(345, 22);
            this.txtKorIme.TabIndex = 8;
            this.txtKorIme.Validating += new System.ComponentModel.CancelEventHandler(this.txtKorIme_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.errorProvider.SetIconAlignment(this.label4, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.label4.Location = new System.Drawing.Point(84, 283);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Korisničko ime";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(131, 338);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(165, 22);
            this.txtPass.TabIndex = 10;
            this.txtPass.Validating += new System.ComponentModel.CancelEventHandler(this.txtPass_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.errorProvider.SetIconAlignment(this.label5, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.label5.Location = new System.Drawing.Point(89, 342);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Šifra";
            // 
            // txtConf
            // 
            this.txtConf.Location = new System.Drawing.Point(393, 338);
            this.txtConf.Margin = new System.Windows.Forms.Padding(4);
            this.txtConf.Name = "txtConf";
            this.txtConf.Size = new System.Drawing.Size(169, 22);
            this.txtConf.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.errorProvider.SetIconAlignment(this.label6, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.label6.Location = new System.Drawing.Point(327, 342);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Potvrda";
            // 
            // txtSnimiKor
            // 
            this.txtSnimiKor.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtSnimiKor.Location = new System.Drawing.Point(449, 425);
            this.txtSnimiKor.Margin = new System.Windows.Forms.Padding(4);
            this.txtSnimiKor.Name = "txtSnimiKor";
            this.txtSnimiKor.Size = new System.Drawing.Size(115, 38);
            this.txtSnimiKor.TabIndex = 13;
            this.txtSnimiKor.Text = "Snimi";
            this.txtSnimiKor.UseVisualStyleBackColor = false;
            this.txtSnimiKor.Click += new System.EventHandler(this.txtSnimiKor_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbAktivan
            // 
            this.cbAktivan.AutoSize = true;
            this.cbAktivan.ForeColor = System.Drawing.Color.RoyalBlue;
            this.errorProvider.SetIconAlignment(this.cbAktivan, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.cbAktivan.Location = new System.Drawing.Point(393, 370);
            this.cbAktivan.Margin = new System.Windows.Forms.Padding(4);
            this.cbAktivan.Name = "cbAktivan";
            this.cbAktivan.Size = new System.Drawing.Size(76, 21);
            this.cbAktivan.TabIndex = 14;
            this.cbAktivan.Text = "Aktivan";
            this.cbAktivan.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.errorProvider.SetIconAlignment(this.button1, System.Windows.Forms.ErrorIconAlignment.TopRight);
            this.button1.Location = new System.Drawing.Point(923, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 33);
            this.button1.TabIndex = 42;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ofdKorisnikSlika
            // 
            this.ofdKorisnikSlika.FileName = "openFileDialog1";
            // 
            // txtImage
            // 
            this.txtImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtImage.Location = new System.Drawing.Point(645, 367);
            this.txtImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(261, 26);
            this.txtImage.TabIndex = 39;
            // 
            // btnAddImage
            // 
            this.btnAddImage.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddImage.Location = new System.Drawing.Point(699, 422);
            this.btnAddImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(160, 37);
            this.btnAddImage.TabIndex = 38;
            this.btnAddImage.Text = "Add photo";
            this.btnAddImage.UseVisualStyleBackColor = false;
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // pbKorisnik
            // 
            this.pbKorisnik.Location = new System.Drawing.Point(645, 127);
            this.pbKorisnik.Margin = new System.Windows.Forms.Padding(4);
            this.pbKorisnik.Name = "pbKorisnik";
            this.pbKorisnik.Size = new System.Drawing.Size(263, 220);
            this.pbKorisnik.TabIndex = 40;
            this.pbKorisnik.TabStop = false;
            // 
            // cbKorisniciUloge
            // 
            this.cbKorisniciUloge.FormattingEnabled = true;
            this.cbKorisniciUloge.Location = new System.Drawing.Point(131, 384);
            this.cbKorisniciUloge.Margin = new System.Windows.Forms.Padding(4);
            this.cbKorisniciUloge.Name = "cbKorisniciUloge";
            this.cbKorisniciUloge.Size = new System.Drawing.Size(165, 72);
            this.cbKorisniciUloge.TabIndex = 41;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmKorisniciDetalji
            // 
            this.AcceptButton = this.txtSnimiKor;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(956, 539);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbKorisniciUloge);
            this.Controls.Add(this.pbKorisnik);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.btnAddImage);
            this.Controls.Add(this.cbAktivan);
            this.Controls.Add(this.txtSnimiKor);
            this.Controls.Add(this.txtConf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKorisniciDetalji";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKorisniciDetalji";
            this.Load += new System.EventHandler(this.frmKorisniciDetalji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKorisnik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button txtSnimiKor;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox cbAktivan;
        private System.Windows.Forms.OpenFileDialog ofdKorisnikSlika;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Button btnAddImage;
        private System.Windows.Forms.PictureBox pbKorisnik;
        private System.Windows.Forms.CheckedListBox cbKorisniciUloge;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}