﻿namespace eBus.WinUI.Vozilo_i_vozac
{
    partial class frmAutobus
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVozilo = new System.Windows.Forms.TextBox();
            this.txtKlasa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVoz = new System.Windows.Forms.ComboBox();
            this.btnVoz = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dodaj vozilo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(25, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv vozila:";
            // 
            // txtVozilo
            // 
            this.txtVozilo.Location = new System.Drawing.Point(110, 70);
            this.txtVozilo.Margin = new System.Windows.Forms.Padding(2);
            this.txtVozilo.Name = "txtVozilo";
            this.txtVozilo.Size = new System.Drawing.Size(156, 20);
            this.txtVozilo.TabIndex = 2;
            // 
            // txtKlasa
            // 
            this.txtKlasa.Location = new System.Drawing.Point(110, 101);
            this.txtKlasa.Margin = new System.Windows.Forms.Padding(2);
            this.txtKlasa.Name = "txtKlasa";
            this.txtKlasa.Size = new System.Drawing.Size(156, 20);
            this.txtKlasa.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(25, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Klasa vozila:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(25, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Vozač:";
            // 
            // cmbVoz
            // 
            this.cmbVoz.FormattingEnabled = true;
            this.cmbVoz.Location = new System.Drawing.Point(110, 133);
            this.cmbVoz.Name = "cmbVoz";
            this.cmbVoz.Size = new System.Drawing.Size(156, 21);
            this.cmbVoz.TabIndex = 22;
            // 
            // btnVoz
            // 
            this.btnVoz.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnVoz.Location = new System.Drawing.Point(269, 133);
            this.btnVoz.Margin = new System.Windows.Forms.Padding(2);
            this.btnVoz.Name = "btnVoz";
            this.btnVoz.Size = new System.Drawing.Size(22, 19);
            this.btnVoz.TabIndex = 23;
            this.btnVoz.Text = "...";
            this.btnVoz.UseVisualStyleBackColor = false;
            this.btnVoz.Click += new System.EventHandler(this.btnVoz_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.ForeColor = System.Drawing.Color.RoyalBlue;
            this.cbStatus.Location = new System.Drawing.Point(110, 176);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(59, 17);
            this.cbStatus.TabIndex = 24;
            this.cbStatus.Text = "Zauzet";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSave.Location = new System.Drawing.Point(198, 170);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 27);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Snimi";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(281, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 28);
            this.button1.TabIndex = 44;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAutobus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(304, 230);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btnVoz);
            this.Controls.Add(this.cmbVoz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKlasa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtVozilo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAutobus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAutobus";
            this.Load += new System.EventHandler(this.frmAutobus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVozilo;
        private System.Windows.Forms.TextBox txtKlasa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVoz;
        private System.Windows.Forms.Button btnVoz;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
    }
}