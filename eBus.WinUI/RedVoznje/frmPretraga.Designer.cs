namespace eBus.WinUI.RedVoznje
{
    partial class frmPretraga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPretraga));
            this.cmbDo = new System.Windows.Forms.ComboBox();
            this.cmbOD = new System.Windows.Forms.ComboBox();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.dtpOD = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgrRedPretraga = new System.Windows.Forms.DataGridView();
            this.RedVoznjeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijemePolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumVrijemeDolaska = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradPolaskaNavigation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradDolaskaNavigation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Korisnik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autobus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrRedPretraga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDo
            // 
            this.cmbDo.FormattingEnabled = true;
            this.cmbDo.Location = new System.Drawing.Point(206, 133);
            this.cmbDo.Name = "cmbDo";
            this.cmbDo.Size = new System.Drawing.Size(167, 21);
            this.cmbDo.TabIndex = 32;
            // 
            // cmbOD
            // 
            this.cmbOD.FormattingEnabled = true;
            this.cmbOD.Location = new System.Drawing.Point(206, 107);
            this.cmbOD.Name = "cmbOD";
            this.cmbOD.Size = new System.Drawing.Size(167, 21);
            this.cmbOD.TabIndex = 31;
            // 
            // cmbBus
            // 
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(206, 159);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(167, 21);
            this.cmbBus.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "Vozilo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Odredište (naziv):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Polazak (naziv) :";
            // 
            // dtpDO
            // 
            this.dtpDO.Location = new System.Drawing.Point(206, 83);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(167, 20);
            this.dtpDO.TabIndex = 26;
            this.dtpDO.TabStop = false;
            // 
            // dtpOD
            // 
            this.dtpOD.CustomFormat = "";
            this.dtpOD.Location = new System.Drawing.Point(206, 58);
            this.dtpOD.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.Size = new System.Drawing.Size(167, 20);
            this.dtpOD.TabIndex = 25;
            this.dtpOD.Value = new System.DateTime(2021, 1, 31, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Datum dolaska: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Datum polaska:";
            // 
            // dgrRedPretraga
            // 
            this.dgrRedPretraga.AllowUserToDeleteRows = false;
            this.dgrRedPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrRedPretraga.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RedVoznjeId,
            this.Naziv,
            this.DatumVrijemePolaska,
            this.DatumVrijemeDolaska,
            this.Cijena,
            this.GradPolaskaNavigation,
            this.GradDolaskaNavigation,
            this.Korisnik,
            this.Autobus});
            this.dgrRedPretraga.Location = new System.Drawing.Point(37, 189);
            this.dgrRedPretraga.Name = "dgrRedPretraga";
            this.dgrRedPretraga.ReadOnly = true;
            this.dgrRedPretraga.Size = new System.Drawing.Size(753, 218);
            this.dgrRedPretraga.TabIndex = 33;
            // 
            // RedVoznjeId
            // 
            this.RedVoznjeId.DataPropertyName = "RedVoznjeId";
            this.RedVoznjeId.HeaderText = "RedVoznjeId";
            this.RedVoznjeId.Name = "RedVoznjeId";
            this.RedVoznjeId.ReadOnly = true;
            this.RedVoznjeId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 7;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // DatumVrijemePolaska
            // 
            this.DatumVrijemePolaska.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumVrijemePolaska.DataPropertyName = "DatumVrijemePolaska";
            this.DatumVrijemePolaska.HeaderText = "Datum polaska";
            this.DatumVrijemePolaska.Name = "DatumVrijemePolaska";
            this.DatumVrijemePolaska.ReadOnly = true;
            // 
            // DatumVrijemeDolaska
            // 
            this.DatumVrijemeDolaska.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumVrijemeDolaska.DataPropertyName = "DatumVrijemeDolaska";
            this.DatumVrijemeDolaska.HeaderText = "Datum  dolaska";
            this.DatumVrijemeDolaska.Name = "DatumVrijemeDolaska";
            this.DatumVrijemeDolaska.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // GradPolaskaNavigation
            // 
            this.GradPolaskaNavigation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GradPolaskaNavigation.DataPropertyName = "GradPolaskaNavigation";
            this.GradPolaskaNavigation.HeaderText = "Grad polaska";
            this.GradPolaskaNavigation.Name = "GradPolaskaNavigation";
            this.GradPolaskaNavigation.ReadOnly = true;
            // 
            // GradDolaskaNavigation
            // 
            this.GradDolaskaNavigation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GradDolaskaNavigation.DataPropertyName = "GradDolaskaNavigation";
            this.GradDolaskaNavigation.HeaderText = "Grad dolaska";
            this.GradDolaskaNavigation.Name = "GradDolaskaNavigation";
            this.GradDolaskaNavigation.ReadOnly = true;
            // 
            // Korisnik
            // 
            this.Korisnik.DataPropertyName = "Korisnik";
            this.Korisnik.HeaderText = "Korisnik";
            this.Korisnik.Name = "Korisnik";
            this.Korisnik.ReadOnly = true;
            // 
            // Autobus
            // 
            this.Autobus.DataPropertyName = "Autobus";
            this.Autobus.HeaderText = "Autobus";
            this.Autobus.Name = "Autobus";
            this.Autobus.ReadOnly = true;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFiltriraj.Location = new System.Drawing.Point(398, 161);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(75, 23);
            this.btnFiltriraj.TabIndex = 34;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = false;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(512, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 158);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(106, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "Detalji reda vožnje:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(37, 413);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 37;
            this.button1.Text = "Nazad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(714, 413);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 28);
            this.button2.TabIndex = 38;
            this.button2.Text = "Dodaj ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.dgrRedPretraga);
            this.Controls.Add(this.cmbDo);
            this.Controls.Add(this.cmbOD);
            this.Controls.Add(this.cmbBus);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDO);
            this.Controls.Add(this.dtpOD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "frmPretraga";
            this.Text = "frmPretraga";
            this.Load += new System.EventHandler(this.frmPretraga_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrRedPretraga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDo;
        private System.Windows.Forms.ComboBox cmbOD;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.DateTimePicker dtpOD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgrRedPretraga;
        public System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedVoznjeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijemePolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumVrijemeDolaska;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradPolaskaNavigation;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradDolaskaNavigation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Korisnik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autobus;
    }
}