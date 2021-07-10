
namespace eBus.WinUI.Izvještaji
{
    partial class frmRedVoznjeKorisnik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRedVoznjeKorisnik));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbPutnik = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKorisnikRedVoznje = new System.Windows.Forms.DataGridView();
            this.Qrcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumKreiranja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIsteka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Otkazana = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placeno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnikRedVoznje)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(517, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 166);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(364, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 40;
            this.button1.Text = "Prikaži";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbPutnik
            // 
            this.cmbPutnik.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPutnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPutnik.ForeColor = System.Drawing.Color.Black;
            this.cmbPutnik.FormattingEnabled = true;
            this.cmbPutnik.Location = new System.Drawing.Point(250, 74);
            this.cmbPutnik.Name = "cmbPutnik";
            this.cmbPutnik.Size = new System.Drawing.Size(203, 33);
            this.cmbPutnik.TabIndex = 39;
            this.cmbPutnik.Text = "Odaberite korisnika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(42, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Izaberite korisnika:";
            // 
            // dgvKorisnikRedVoznje
            // 
            this.dgvKorisnikRedVoznje.AllowUserToAddRows = false;
            this.dgvKorisnikRedVoznje.AllowUserToDeleteRows = false;
            this.dgvKorisnikRedVoznje.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.dgvKorisnikRedVoznje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKorisnikRedVoznje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Qrcode,
            this.DatumKreiranja,
            this.DatumIsteka,
            this.Otkazana,
            this.Placeno});
            this.dgvKorisnikRedVoznje.Location = new System.Drawing.Point(3, 218);
            this.dgvKorisnikRedVoznje.Name = "dgvKorisnikRedVoznje";
            this.dgvKorisnikRedVoznje.ReadOnly = true;
            this.dgvKorisnikRedVoznje.Size = new System.Drawing.Size(726, 257);
            this.dgvKorisnikRedVoznje.TabIndex = 42;
            // 
            // Qrcode
            // 
            this.Qrcode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qrcode.DataPropertyName = "Qrcode";
            this.Qrcode.HeaderText = "Code";
            this.Qrcode.Name = "Qrcode";
            this.Qrcode.ReadOnly = true;
            // 
            // DatumKreiranja
            // 
            this.DatumKreiranja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumKreiranja.DataPropertyName = "DatumKreiranja";
            this.DatumKreiranja.HeaderText = "Datum kreiranja";
            this.DatumKreiranja.Name = "DatumKreiranja";
            this.DatumKreiranja.ReadOnly = true;
            // 
            // DatumIsteka
            // 
            this.DatumIsteka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumIsteka.DataPropertyName = "DatumIsteka";
            this.DatumIsteka.HeaderText = "Datum isteka";
            this.DatumIsteka.Name = "DatumIsteka";
            this.DatumIsteka.ReadOnly = true;
            // 
            // Otkazana
            // 
            this.Otkazana.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Otkazana.DataPropertyName = "Otkazana";
            this.Otkazana.HeaderText = "Otkazana";
            this.Otkazana.Name = "Otkazana";
            this.Otkazana.ReadOnly = true;
            // 
            // Placeno
            // 
            this.Placeno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Placeno.DataPropertyName = "Placeno";
            this.Placeno.HeaderText = "Placena";
            this.Placeno.Name = "Placeno";
            this.Placeno.ReadOnly = true;
            // 
            // frmRedVoznjeKorisnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(733, 477);
            this.Controls.Add(this.dgvKorisnikRedVoznje);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbPutnik);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRedVoznjeKorisnik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmRedVoznjeKorisnik";
            this.Load += new System.EventHandler(this.frmRedVoznjeKorisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKorisnikRedVoznje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbPutnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKorisnikRedVoznje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qrcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumKreiranja;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIsteka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Otkazana;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placeno;
    }
}