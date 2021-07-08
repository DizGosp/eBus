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
            this.KartaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojKarte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumIzdavanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RezervacijaSjedista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrKaraPregled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(162, 106);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Karta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(9, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum izdavanja:";
            // 
            // dtpKarta
            // 
            this.dtpKarta.Location = new System.Drawing.Point(105, 154);
            this.dtpKarta.Margin = new System.Windows.Forms.Padding(2);
            this.dtpKarta.Name = "dtpKarta";
            this.dtpKarta.Size = new System.Drawing.Size(151, 20);
            this.dtpKarta.TabIndex = 3;
            // 
            // btnKartaFilter
            // 
            this.btnKartaFilter.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKartaFilter.Location = new System.Drawing.Point(333, 154);
            this.btnKartaFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnKartaFilter.Name = "btnKartaFilter";
            this.btnKartaFilter.Size = new System.Drawing.Size(64, 25);
            this.btnKartaFilter.TabIndex = 4;
            this.btnKartaFilter.Text = "Filtriraj";
            this.btnKartaFilter.UseVisualStyleBackColor = false;
            this.btnKartaFilter.Click += new System.EventHandler(this.btnKartaFilter_Click);
            // 
            // dgrKaraPregled
            // 
            this.dgrKaraPregled.AllowUserToAddRows = false;
            this.dgrKaraPregled.AllowUserToDeleteRows = false;
            this.dgrKaraPregled.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.dgrKaraPregled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrKaraPregled.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KartaId,
            this.BrojKarte,
            this.DatumIzdavanja,
            this.RezervacijaSjedista});
            this.dgrKaraPregled.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.dgrKaraPregled.Location = new System.Drawing.Point(1, 186);
            this.dgrKaraPregled.Margin = new System.Windows.Forms.Padding(2);
            this.dgrKaraPregled.Name = "dgrKaraPregled";
            this.dgrKaraPregled.ReadOnly = true;
            this.dgrKaraPregled.RowTemplate.Height = 24;
            this.dgrKaraPregled.Size = new System.Drawing.Size(408, 264);
            this.dgrKaraPregled.TabIndex = 5;
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
            this.BrojKarte.DataPropertyName = "BrojKarte";
            this.BrojKarte.HeaderText = "Broj karte";
            this.BrojKarte.Name = "BrojKarte";
            this.BrojKarte.ReadOnly = true;
            // 
            // DatumIzdavanja
            // 
            this.DatumIzdavanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumIzdavanja.DataPropertyName = "DatumIzdavanja";
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
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 132);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(376, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmKartaPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(408, 457);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgrKaraPregled);
            this.Controls.Add(this.btnKartaFilter);
            this.Controls.Add(this.dtpKarta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKartaPregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKartaPregled";
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
        private System.Windows.Forms.Button button1;
    }
}