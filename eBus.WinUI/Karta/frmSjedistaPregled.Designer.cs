namespace eBus.WinUI.Karta
{
    partial class frmSjedistaPregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSjedistaPregled));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgrSjediste = new System.Windows.Forms.DataGridView();
            this.btnKartaFilter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBus = new System.Windows.Forms.ComboBox();
            this.RezervacijaSjedistaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Red = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autobus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSjediste)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(287, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 162);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // dgrSjediste
            // 
            this.dgrSjediste.AllowUserToAddRows = false;
            this.dgrSjediste.AllowUserToDeleteRows = false;
            this.dgrSjediste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrSjediste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RezervacijaSjedistaId,
            this.Red,
            this.Kolona,
            this.Autobus});
            this.dgrSjediste.Location = new System.Drawing.Point(11, 180);
            this.dgrSjediste.Name = "dgrSjediste";
            this.dgrSjediste.ReadOnly = true;
            this.dgrSjediste.RowTemplate.Height = 24;
            this.dgrSjediste.Size = new System.Drawing.Size(470, 325);
            this.dgrSjediste.TabIndex = 11;
            // 
            // btnKartaFilter
            // 
            this.btnKartaFilter.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnKartaFilter.Location = new System.Drawing.Point(185, 131);
            this.btnKartaFilter.Name = "btnKartaFilter";
            this.btnKartaFilter.Size = new System.Drawing.Size(86, 31);
            this.btnKartaFilter.TabIndex = 10;
            this.btnKartaFilter.Text = "Filtriraj";
            this.btnKartaFilter.UseVisualStyleBackColor = false;
            this.btnKartaFilter.Click += new System.EventHandler(this.btnKartaFilter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vozilo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sjedišta:";
            // 
            // cmbBus
            // 
            this.cmbBus.FormattingEnabled = true;
            this.cmbBus.Location = new System.Drawing.Point(77, 96);
            this.cmbBus.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBus.Name = "cmbBus";
            this.cmbBus.Size = new System.Drawing.Size(194, 24);
            this.cmbBus.TabIndex = 32;
            // 
            // RezervacijaSjedistaId
            // 
            this.RezervacijaSjedistaId.HeaderText = "RezervacijaSjedistaId";
            this.RezervacijaSjedistaId.Name = "RezervacijaSjedistaId";
            this.RezervacijaSjedistaId.ReadOnly = true;
            this.RezervacijaSjedistaId.Visible = false;
            // 
            // Red
            // 
            this.Red.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Red.HeaderText = "Red";
            this.Red.Name = "Red";
            this.Red.ReadOnly = true;
            // 
            // Kolona
            // 
            this.Kolona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kolona.HeaderText = "Kolona";
            this.Kolona.Name = "Kolona";
            this.Kolona.ReadOnly = true;
            // 
            // Autobus
            // 
            this.Autobus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Autobus.DataPropertyName = "Autobus";
            this.Autobus.HeaderText = "Vozilo ";
            this.Autobus.Name = "Autobus";
            this.Autobus.ReadOnly = true;
            // 
            // frmSjedistaPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 546);
            this.Controls.Add(this.cmbBus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgrSjediste);
            this.Controls.Add(this.btnKartaFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSjedistaPregled";
            this.Text = "frmSjedistaPregled";
            this.Load += new System.EventHandler(this.frmSjedistaPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrSjediste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgrSjediste;
        private System.Windows.Forms.Button btnKartaFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBus;
        private System.Windows.Forms.DataGridViewTextBoxColumn RezervacijaSjedistaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Red;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autobus;
    }
}