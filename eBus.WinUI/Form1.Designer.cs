namespace eBus.WinUI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btnKarta = new System.Windows.Forms.Button();
            this.btnRedVoznje = new System.Windows.Forms.Button();
            this.btnKorisnici = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btnKarta);
            this.panel1.Controls.Add(this.btnRedVoznje);
            this.panel1.Controls.Add(this.btnKorisnici);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 577);
            this.panel1.TabIndex = 0;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(12, 163);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(3, 150);
            this.pnlNav.TabIndex = 2;
            // 
            // btnKarta
            // 
            this.btnKarta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKarta.FlatAppearance.BorderSize = 0;
            this.btnKarta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnKarta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKarta.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKarta.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnKarta.Image = ((System.Drawing.Image)(resources.GetObject("btnKarta.Image")));
            this.btnKarta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKarta.Location = new System.Drawing.Point(0, 282);
            this.btnKarta.Name = "btnKarta";
            this.btnKarta.Size = new System.Drawing.Size(186, 48);
            this.btnKarta.TabIndex = 4;
            this.btnKarta.Text = "Karta";
            this.btnKarta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKarta.UseVisualStyleBackColor = true;
            this.btnKarta.Click += new System.EventHandler(this.btnKarta_Click);
            this.btnKarta.Leave += new System.EventHandler(this.btnKarta_Leave);
            // 
            // btnRedVoznje
            // 
            this.btnRedVoznje.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRedVoznje.FlatAppearance.BorderSize = 0;
            this.btnRedVoznje.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRedVoznje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedVoznje.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedVoznje.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnRedVoznje.Image = ((System.Drawing.Image)(resources.GetObject("btnRedVoznje.Image")));
            this.btnRedVoznje.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRedVoznje.Location = new System.Drawing.Point(0, 234);
            this.btnRedVoznje.Name = "btnRedVoznje";
            this.btnRedVoznje.Size = new System.Drawing.Size(186, 48);
            this.btnRedVoznje.TabIndex = 3;
            this.btnRedVoznje.Text = "Red vožnje";
            this.btnRedVoznje.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRedVoznje.UseVisualStyleBackColor = true;
            this.btnRedVoznje.Click += new System.EventHandler(this.button2_Click);
            this.btnRedVoznje.Leave += new System.EventHandler(this.btnRedVoznje_Leave);
            // 
            // btnKorisnici
            // 
            this.btnKorisnici.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKorisnici.FlatAppearance.BorderSize = 0;
            this.btnKorisnici.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnKorisnici.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKorisnici.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKorisnici.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnKorisnici.Image = ((System.Drawing.Image)(resources.GetObject("btnKorisnici.Image")));
            this.btnKorisnici.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKorisnici.Location = new System.Drawing.Point(0, 190);
            this.btnKorisnici.Name = "btnKorisnici";
            this.btnKorisnici.Size = new System.Drawing.Size(186, 44);
            this.btnKorisnici.TabIndex = 2;
            this.btnKorisnici.Text = "Korisnici";
            this.btnKorisnici.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnKorisnici.UseVisualStyleBackColor = true;
            this.btnKorisnici.Click += new System.EventHandler(this.button1_Click);
            this.btnKorisnici.Leave += new System.EventHandler(this.btnKorisnici_Leave);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.Location = new System.Drawing.Point(0, 144);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(186, 46);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Početna";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            this.btnHome.Leave += new System.EventHandler(this.btnHome_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 144);
            this.panel2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(12, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(42, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlFormLoader.Location = new System.Drawing.Point(186, 104);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(765, 473);
            this.PnlFormLoader.TabIndex = 1;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.BackColor = System.Drawing.Color.Transparent;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNaziv.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNaziv.Location = new System.Drawing.Point(224, 37);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(114, 31);
            this.lblNaziv.TabIndex = 2;
            this.lblNaziv.Text = "Početna";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKorisnici;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKarta;
        private System.Windows.Forms.Button btnRedVoznje;
        private System.Windows.Forms.Panel pnlNav;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Label lblNaziv;
    }
}

