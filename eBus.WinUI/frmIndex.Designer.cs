namespace eBus.WinUI
{
    partial class frmIndex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndex));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redVožnjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosRedaVožnjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korisniciToolStripMenuItem,
            this.redVožnjeToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(843, 40);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosKorisnikaToolStripMenuItem,
            this.pretragaToolStripMenuItem});
            this.korisniciToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(127, 36);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // unosKorisnikaToolStripMenuItem
            // 
            this.unosKorisnikaToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.unosKorisnikaToolStripMenuItem.Name = "unosKorisnikaToolStripMenuItem";
            this.unosKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(259, 36);
            this.unosKorisnikaToolStripMenuItem.Text = "Unos korisnika";
            this.unosKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.unosKorisnikaToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(259, 36);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // redVožnjeToolStripMenuItem
            // 
            this.redVožnjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosRedaVožnjeToolStripMenuItem,
            this.pretragaToolStripMenuItem1});
            this.redVožnjeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redVožnjeToolStripMenuItem.Name = "redVožnjeToolStripMenuItem";
            this.redVožnjeToolStripMenuItem.Size = new System.Drawing.Size(152, 36);
            this.redVožnjeToolStripMenuItem.Text = "Red vožnje";
            // 
            // unosRedaVožnjeToolStripMenuItem
            // 
            this.unosRedaVožnjeToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.unosRedaVožnjeToolStripMenuItem.Name = "unosRedaVožnjeToolStripMenuItem";
            this.unosRedaVožnjeToolStripMenuItem.Size = new System.Drawing.Size(288, 36);
            this.unosRedaVožnjeToolStripMenuItem.Text = "Unos reda vožnje";
            this.unosRedaVožnjeToolStripMenuItem.Click += new System.EventHandler(this.unosRedaVožnjeToolStripMenuItem_Click);
            // 
            // pretragaToolStripMenuItem1
            // 
            this.pretragaToolStripMenuItem1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pretragaToolStripMenuItem1.Name = "pretragaToolStripMenuItem1";
            this.pretragaToolStripMenuItem1.Size = new System.Drawing.Size(288, 36);
            this.pretragaToolStripMenuItem1.Text = "Pretraga";
            this.pretragaToolStripMenuItem1.Click += new System.EventHandler(this.pretragaToolStripMenuItem1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 536);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmIndex";
            this.Text = "Index";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redVožnjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosRedaVožnjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem1;
    }
}



