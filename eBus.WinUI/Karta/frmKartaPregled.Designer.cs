namespace eBus.WinUI.Karta
{
    partial class frmKartaPregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKartaPregled));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpKarta = new System.Windows.Forms.DateTimePicker();
            this.btnKartaFilter = new System.Windows.Forms.Button();
            this.dgrKaraPregled = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.KartaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RezervacijaSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgrKaraPregled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Karta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum izdavanja:";
            // 
            // dtpKarta
            // 
            this.dtpKarta.Location = new System.Drawing.Point(140, 190);
            this.dtpKarta.Name = "dtpKarta";
            this.dtpKarta.Size = new System.Drawing.Size(200, 22);
            this.dtpKarta.TabIndex = 3;
            // 
            // btnKartaFilter
            // 
            this.btnKartaFilter.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKartaFilter.Location = new System.Drawing.Point(385, 188);
            this.btnKartaFilter.Name = "btnKartaFilter";
            this.btnKartaFilter.Size = new System.Drawing.Size(86, 31);
            this.btnKartaFilter.TabIndex = 4;
            this.btnKartaFilter.Text = "Filtriraj";
            this.btnKartaFilter.UseVisualStyleBackColor = false;
            this.btnKartaFilter.Click += new System.EventHandler(this.btnKartaFilter_Click);
            // 
            // dgrKaraPregled
            // 
            this.dgrKaraPregled.AllowUserToAddRows = false;
            this.dgrKaraPregled.AllowUserToDeleteRows = false;
            this.dgrKaraPregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrKaraPregled.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KartaId,
            this.BrojKarte,
            this.DatumIzdavanja,
            this.RezervacijaSjedista});
            this.dgrKaraPregled.Location = new System.Drawing.Point(1, 229);
            this.dgrKaraPregled.Name = "dgrKaraPregled";
            this.dgrKaraPregled.ReadOnly = true;
            this.dgrKaraPregled.RowTemplate.Height = 24;
            this.dgrKaraPregled.Size = new System.Drawing.Size(470, 325);
            this.dgrKaraPregled.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(277, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 162);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // KartaId
            // 
            this.KartaId.HeaderText = "KartaId";
            this.KartaId.Name = "KartaId";
            this.KartaId.ReadOnly = true;
            this.KartaId.Visible = false;
            // 
            // BrojKarte
            // 
            this.BrojKarte.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojKarte.HeaderText = "Broj karte";
            this.BrojKarte.Name = "BrojKarte";
            this.BrojKarte.ReadOnly = true;
            // 
            // DatumIzdavanja
            // 
            this.DatumIzdavanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumIzdavanja.HeaderText = "Datum izdavanja";
            this.DatumIzdavanja.Name = "DatumIzdavanja";
            this.DatumIzdavanja.ReadOnly = true;
            // 
            // RezervacijaSjedista
            // 
            this.RezervacijaSjedista.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RezervacijaSjedista.DataPropertyName = "RezervacijaSjedista";
            this.RezervacijaSjedista.HeaderText = "Vozilo - Sjedište";
            this.RezervacijaSjedista.Name = "RezervacijaSjedista";
            this.RezervacijaSjedista.ReadOnly = true;
            // 
            // frmKartaPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 563);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgrKaraPregled);
            this.Controls.Add(this.btnKartaFilter);
            this.Controls.Add(this.dtpKarta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKartaPregled";
            this.Text = "frmKartaPregled";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKartaPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrKaraPregled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpKarta;
        private System.Windows.Forms.Button btnKartaFilter;
        private System.Windows.Forms.DataGridView dgrKaraPregled;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn KartaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojKarte;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumIzdavanja;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaSjedista;
    }
}