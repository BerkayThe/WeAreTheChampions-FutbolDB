namespace FutbolDb
{
    partial class TakimlarForm
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
            this.dgvTakimlar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTakimAd = new System.Windows.Forms.TextBox();
            this.btnTakimEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnOyuncular = new System.Windows.Forms.Button();
            this.btnTakimSil = new System.Windows.Forms.Button();
            this.cboRenkEkle1 = new System.Windows.Forms.ComboBox();
            this.cboRenkEkle2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIptal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakimlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTakimlar
            // 
            this.dgvTakimlar.AllowUserToAddRows = false;
            this.dgvTakimlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTakimlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTakimlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTakimlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvTakimlar.Location = new System.Drawing.Point(12, 72);
            this.dgvTakimlar.MultiSelect = false;
            this.dgvTakimlar.Name = "dgvTakimlar";
            this.dgvTakimlar.ReadOnly = true;
            this.dgvTakimlar.RowHeadersVisible = false;
            this.dgvTakimlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTakimlar.Size = new System.Drawing.Size(517, 279);
            this.dgvTakimlar.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TakimAd";
            this.Column2.HeaderText = "TakimAd";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Takım Adı :";
            // 
            // txtTakimAd
            // 
            this.txtTakimAd.Location = new System.Drawing.Point(78, 6);
            this.txtTakimAd.Name = "txtTakimAd";
            this.txtTakimAd.Size = new System.Drawing.Size(176, 20);
            this.txtTakimAd.TabIndex = 5;
            // 
            // btnTakimEkle
            // 
            this.btnTakimEkle.Location = new System.Drawing.Point(15, 43);
            this.btnTakimEkle.Name = "btnTakimEkle";
            this.btnTakimEkle.Size = new System.Drawing.Size(111, 23);
            this.btnTakimEkle.TabIndex = 6;
            this.btnTakimEkle.Text = "Takım Ekle";
            this.btnTakimEkle.UseVisualStyleBackColor = true;
            this.btnTakimEkle.Click += new System.EventHandler(this.btnTakimEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(12, 357);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(114, 23);
            this.btnDuzenle.TabIndex = 7;
            this.btnDuzenle.Text = "Seçiliyi Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnOyuncular
            // 
            this.btnOyuncular.Location = new System.Drawing.Point(454, 357);
            this.btnOyuncular.Name = "btnOyuncular";
            this.btnOyuncular.Size = new System.Drawing.Size(75, 23);
            this.btnOyuncular.TabIndex = 8;
            this.btnOyuncular.Text = "Oyuncular";
            this.btnOyuncular.UseVisualStyleBackColor = true;
            this.btnOyuncular.Click += new System.EventHandler(this.btnOyuncular_Click);
            // 
            // btnTakimSil
            // 
            this.btnTakimSil.Location = new System.Drawing.Point(132, 357);
            this.btnTakimSil.Name = "btnTakimSil";
            this.btnTakimSil.Size = new System.Drawing.Size(123, 23);
            this.btnTakimSil.TabIndex = 9;
            this.btnTakimSil.Text = "Seçiliyi Sil";
            this.btnTakimSil.UseVisualStyleBackColor = true;
            this.btnTakimSil.Click += new System.EventHandler(this.btnTakimSil_Click);
            // 
            // cboRenkEkle1
            // 
            this.cboRenkEkle1.DisplayMember = "RenkAd";
            this.cboRenkEkle1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRenkEkle1.FormattingEnabled = true;
            this.cboRenkEkle1.Location = new System.Drawing.Point(260, 6);
            this.cboRenkEkle1.Name = "cboRenkEkle1";
            this.cboRenkEkle1.Size = new System.Drawing.Size(121, 21);
            this.cboRenkEkle1.TabIndex = 10;
            this.cboRenkEkle1.ValueMember = "Id";
            this.cboRenkEkle1.SelectedIndexChanged += new System.EventHandler(this.cboRenkEkle1_SelectedIndexChanged);
            // 
            // cboRenkEkle2
            // 
            this.cboRenkEkle2.DisplayMember = "RenkAd";
            this.cboRenkEkle2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRenkEkle2.FormattingEnabled = true;
            this.cboRenkEkle2.Location = new System.Drawing.Point(387, 6);
            this.cboRenkEkle2.Name = "cboRenkEkle2";
            this.cboRenkEkle2.Size = new System.Drawing.Size(121, 21);
            this.cboRenkEkle2.TabIndex = 11;
            this.cboRenkEkle2.ValueMember = "Id";
            this.cboRenkEkle2.SelectedIndexChanged += new System.EventHandler(this.cboRenkEkle2_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(260, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 33);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(387, 33);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(121, 33);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(132, 43);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 14;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // TakimlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 419);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboRenkEkle2);
            this.Controls.Add(this.cboRenkEkle1);
            this.Controls.Add(this.btnTakimSil);
            this.Controls.Add(this.btnOyuncular);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnTakimEkle);
            this.Controls.Add(this.txtTakimAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTakimlar);
            this.MaximumSize = new System.Drawing.Size(592, 458);
            this.MinimumSize = new System.Drawing.Size(592, 458);
            this.Name = "TakimlarForm";
            this.Text = "TakimlarForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTakimlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTakimlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTakimAd;
        private System.Windows.Forms.Button btnTakimEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnOyuncular;
        private System.Windows.Forms.Button btnTakimSil;
        private System.Windows.Forms.ComboBox cboRenkEkle1;
        private System.Windows.Forms.ComboBox cboRenkEkle2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}