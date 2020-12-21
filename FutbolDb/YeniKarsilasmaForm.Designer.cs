namespace FutbolDb
{
    partial class YeniKarsilasmaForm
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
            this.cboTakim1Sec = new System.Windows.Forms.ComboBox();
            this.cboTakim2Sec = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpMacTarih = new System.Windows.Forms.DateTimePicker();
            this.nudTakim1Skor = new System.Windows.Forms.NumericUpDown();
            this.nudTakim2Skor = new System.Windows.Forms.NumericUpDown();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTakim1Skor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTakim2Skor)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTakim1Sec
            // 
            this.cboTakim1Sec.DisplayMember = "TakimAd";
            this.cboTakim1Sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTakim1Sec.FormattingEnabled = true;
            this.cboTakim1Sec.Location = new System.Drawing.Point(15, 25);
            this.cboTakim1Sec.Name = "cboTakim1Sec";
            this.cboTakim1Sec.Size = new System.Drawing.Size(121, 21);
            this.cboTakim1Sec.TabIndex = 0;
            this.cboTakim1Sec.ValueMember = "Id";
            // 
            // cboTakim2Sec
            // 
            this.cboTakim2Sec.DisplayMember = "TakimAd";
            this.cboTakim2Sec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTakim2Sec.FormattingEnabled = true;
            this.cboTakim2Sec.Location = new System.Drawing.Point(142, 25);
            this.cboTakim2Sec.Name = "cboTakim2Sec";
            this.cboTakim2Sec.Size = new System.Drawing.Size(121, 21);
            this.cboTakim2Sec.TabIndex = 1;
            this.cboTakim2Sec.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. Takımı Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "2. Takımı Seç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarih Seç";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(176, 132);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Maç Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "1. Takım Skoru";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(139, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "2. Takım Skoru";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(308, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Sonuc";
            // 
            // dtpMacTarih
            // 
            this.dtpMacTarih.Location = new System.Drawing.Point(270, 25);
            this.dtpMacTarih.Name = "dtpMacTarih";
            this.dtpMacTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpMacTarih.TabIndex = 19;
            this.dtpMacTarih.ValueChanged += new System.EventHandler(this.dtpMacTarih_ValueChanged);
            // 
            // nudTakim1Skor
            // 
            this.nudTakim1Skor.Location = new System.Drawing.Point(15, 85);
            this.nudTakim1Skor.Name = "nudTakim1Skor";
            this.nudTakim1Skor.Size = new System.Drawing.Size(99, 20);
            this.nudTakim1Skor.TabIndex = 20;
            this.nudTakim1Skor.ValueChanged += new System.EventHandler(this.nudTakim1Skor_ValueChanged);
            // 
            // nudTakim2Skor
            // 
            this.nudTakim2Skor.Location = new System.Drawing.Point(142, 85);
            this.nudTakim2Skor.Name = "nudTakim2Skor";
            this.nudTakim2Skor.Size = new System.Drawing.Size(100, 20);
            this.nudTakim2Skor.TabIndex = 21;
            this.nudTakim2Skor.ValueChanged += new System.EventHandler(this.nudTakim2Skor_ValueChanged);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Enabled = false;
            this.txtSonuc.Location = new System.Drawing.Point(311, 86);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(100, 20);
            this.txtSonuc.TabIndex = 22;
            // 
            // YeniKarsilasmaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 205);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.nudTakim2Skor);
            this.Controls.Add(this.nudTakim1Skor);
            this.Controls.Add(this.dtpMacTarih);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTakim2Sec);
            this.Controls.Add(this.cboTakim1Sec);
            this.MaximumSize = new System.Drawing.Size(520, 244);
            this.MinimumSize = new System.Drawing.Size(520, 244);
            this.Name = "YeniKarsilasmaForm";
            this.Text = "YeniKarsilasmaForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudTakim1Skor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTakim2Skor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTakim1Sec;
        private System.Windows.Forms.ComboBox cboTakim2Sec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpMacTarih;
        private System.Windows.Forms.NumericUpDown nudTakim1Skor;
        private System.Windows.Forms.NumericUpDown nudTakim2Skor;
        private System.Windows.Forms.TextBox txtSonuc;
    }
}