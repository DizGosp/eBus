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
            this.cmbDo.Location = new System.Drawing.Point(274, 164);
            this.cmbDo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDo.Name = "cmbDo";
            this.cmbDo.Size = new System.Drawing.Size(221, 24);
            this.cmbDo.TabIndex = 32;
            // 
            // cmbOD
            // 
            this.cmbOD.FormattingEnabled = true;
            this.cmbOD.Location = new System.Drawing.Point(274, 132);
            this.cmbOD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOD.Name = "cmbOD";
            this.cmbOD.Size = new System.Drawing.Size(221, 24);
            this.cmbOD.TabIndex = 31;
            // 
            // cmbBus
            // 
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(274, 196);
            this.cmbBus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(221, 24);
            this.cmbBus.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 204);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Vozilo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 172);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Odredište (naziv):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 140);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Polazak (naziv) :";
            // 
            // dtpDO
            // 
            this.dtpDO.Location = new System.Drawing.Point(274, 102);
            this.dtpDO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(221, 22);
            this.dtpDO.TabIndex = 26;
            this.dtpDO.TabStop = false;
            // 
            // dtpOD
            // 
            this.dtpOD.CustomFormat = "";
            this.dtpOD.Location = new System.Drawing.Point(274, 72);
            this.dtpOD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpOD.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.Size = new System.Drawing.Size(221, 22);
            this.dtpOD.TabIndex = 25;
            this.dtpOD.Value = new System.DateTime(2021, 1, 31, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Vrijeme i datum dolaska: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Vrijeme i datum polaska:";
            // 
            // dgrRedPretraga
            // 
            this.dgrRedPretraga.AllowUserToAddRows = false;
            this.dgrRedPretraga.AllowUserToDeleteRows = false;
            this.dgrRedPretraga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrRedPretraga.Location = new System.Drawing.Point(49, 233);
            this.dgrRedPretraga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgrRedPretraga.Name = "dgrRedPretraga";
            this.dgrRedPretraga.ReadOnly = true;
            this.dgrRedPretraga.Size = new System.Drawing.Size(1005, 268);
            this.dgrRedPretraga.TabIndex = 33;
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFiltriraj.Location = new System.Drawing.Point(531, 198);
            this.btnFiltriraj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(100, 28);
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
            this.pictureBox1.Location = new System.Drawing.Point(683, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 194);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(141, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 31);
            this.label1.TabIndex = 36;
            this.label1.Text = "Detalji reda vožnje:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Location = new System.Drawing.Point(49, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 34);
            this.button1.TabIndex = 37;
            this.button1.Text = "Nazad";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Location = new System.Drawing.Point(952, 508);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 34);
            this.button2.TabIndex = 38;
            this.button2.Text = "Dodaj ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPretraga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}