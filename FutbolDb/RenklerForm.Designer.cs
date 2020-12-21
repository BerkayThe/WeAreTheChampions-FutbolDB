namespace FutbolDb
{
    partial class RenklerForm
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
            this.hsbRed = new System.Windows.Forms.HScrollBar();
            this.hsbGreen = new System.Windows.Forms.HScrollBar();
            this.hsbBlue = new System.Windows.Forms.HScrollBar();
            this.lblRenk = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lstRenk = new System.Windows.Forms.ListBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRedDeger = new System.Windows.Forms.Label();
            this.lblGreenDeger = new System.Windows.Forms.Label();
            this.lblBlueDeger = new System.Windows.Forms.Label();
            this.txtRenkAd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSecilenRenk = new System.Windows.Forms.Label();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hsbRed
            // 
            this.hsbRed.LargeChange = 1;
            this.hsbRed.Location = new System.Drawing.Point(95, 62);
            this.hsbRed.Maximum = 255;
            this.hsbRed.Name = "hsbRed";
            this.hsbRed.Size = new System.Drawing.Size(243, 17);
            this.hsbRed.TabIndex = 0;
            this.hsbRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbRed_Scroll);
            // 
            // hsbGreen
            // 
            this.hsbGreen.LargeChange = 1;
            this.hsbGreen.Location = new System.Drawing.Point(95, 99);
            this.hsbGreen.Maximum = 255;
            this.hsbGreen.Name = "hsbGreen";
            this.hsbGreen.Size = new System.Drawing.Size(243, 17);
            this.hsbGreen.TabIndex = 1;
            this.hsbGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbGreen_Scroll);
            // 
            // hsbBlue
            // 
            this.hsbBlue.LargeChange = 1;
            this.hsbBlue.Location = new System.Drawing.Point(95, 137);
            this.hsbBlue.Maximum = 255;
            this.hsbBlue.Name = "hsbBlue";
            this.hsbBlue.Size = new System.Drawing.Size(243, 17);
            this.hsbBlue.TabIndex = 2;
            this.hsbBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hsbBlue_Scroll);
            // 
            // lblRenk
            // 
            this.lblRenk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRenk.Location = new System.Drawing.Point(95, 30);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(243, 19);
            this.lblRenk.TabIndex = 3;
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(13, 62);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(30, 13);
            this.lblRed.TabIndex = 4;
            this.lblRed.Text = "RED";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(13, 99);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(45, 13);
            this.lblGreen.TabIndex = 5;
            this.lblGreen.Text = "GREEN";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(13, 137);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(35, 13);
            this.lblBlue.TabIndex = 6;
            this.lblBlue.Text = "BLUE";
            // 
            // lstRenk
            // 
            this.lstRenk.FormattingEnabled = true;
            this.lstRenk.Location = new System.Drawing.Point(398, 28);
            this.lstRenk.Name = "lstRenk";
            this.lstRenk.Size = new System.Drawing.Size(172, 160);
            this.lstRenk.TabIndex = 7;
            this.lstRenk.SelectedIndexChanged += new System.EventHandler(this.lstRenk_SelectedIndexChanged);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(437, 194);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(106, 23);
            this.btnDuzenle.TabIndex = 8;
            this.btnDuzenle.Text = "Renk Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click_1);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(263, 208);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Renk Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(453, 223);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Renk Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "GREEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "BLUE";
            // 
            // lblRedDeger
            // 
            this.lblRedDeger.AutoSize = true;
            this.lblRedDeger.Location = new System.Drawing.Point(353, 62);
            this.lblRedDeger.Name = "lblRedDeger";
            this.lblRedDeger.Size = new System.Drawing.Size(0, 13);
            this.lblRedDeger.TabIndex = 11;
            // 
            // lblGreenDeger
            // 
            this.lblGreenDeger.AutoSize = true;
            this.lblGreenDeger.Location = new System.Drawing.Point(353, 99);
            this.lblGreenDeger.Name = "lblGreenDeger";
            this.lblGreenDeger.Size = new System.Drawing.Size(0, 13);
            this.lblGreenDeger.TabIndex = 12;
            // 
            // lblBlueDeger
            // 
            this.lblBlueDeger.AutoSize = true;
            this.lblBlueDeger.Location = new System.Drawing.Point(353, 137);
            this.lblBlueDeger.Name = "lblBlueDeger";
            this.lblBlueDeger.Size = new System.Drawing.Size(0, 13);
            this.lblBlueDeger.TabIndex = 13;
            // 
            // txtRenkAd
            // 
            this.txtRenkAd.Location = new System.Drawing.Point(98, 168);
            this.txtRenkAd.Name = "txtRenkAd";
            this.txtRenkAd.Size = new System.Drawing.Size(129, 20);
            this.txtRenkAd.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Renk Adı Seç : ";
            // 
            // lblSecilenRenk
            // 
            this.lblSecilenRenk.Location = new System.Drawing.Point(592, 28);
            this.lblSecilenRenk.Name = "lblSecilenRenk";
            this.lblSecilenRenk.Size = new System.Drawing.Size(28, 163);
            this.lblSecilenRenk.TabIndex = 16;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(13, 207);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 17;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // RenklerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 303);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lblSecilenRenk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRenkAd);
            this.Controls.Add(this.lblBlueDeger);
            this.Controls.Add(this.lblGreenDeger);
            this.Controls.Add(this.lblRedDeger);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.lstRenk);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblRenk);
            this.Controls.Add(this.hsbBlue);
            this.Controls.Add(this.hsbGreen);
            this.Controls.Add(this.hsbRed);
            this.MaximumSize = new System.Drawing.Size(659, 342);
            this.MinimumSize = new System.Drawing.Size(659, 342);
            this.Name = "RenklerForm";
            this.Text = "RenklerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar hsbRed;
        private System.Windows.Forms.HScrollBar hsbGreen;
        private System.Windows.Forms.HScrollBar hsbBlue;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstRenk;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblRedDeger;
        private System.Windows.Forms.Label lblGreenDeger;
        private System.Windows.Forms.Label lblBlueDeger;
        private System.Windows.Forms.TextBox txtRenkAd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSecilenRenk;
        private System.Windows.Forms.Button btnIptal;
    }
}