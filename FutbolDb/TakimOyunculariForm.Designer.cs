namespace FutbolDb
{
    partial class TakimOyunculariForm
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
            this.dgvOyuncular = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cboOyuncu = new System.Windows.Forms.ComboBox();
            this.btnCikar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncular)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOyuncular
            // 
            this.dgvOyuncular.AllowUserToAddRows = false;
            this.dgvOyuncular.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOyuncular.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOyuncular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOyuncular.Location = new System.Drawing.Point(12, 70);
            this.dgvOyuncular.Name = "dgvOyuncular";
            this.dgvOyuncular.ReadOnly = true;
            this.dgvOyuncular.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOyuncular.Size = new System.Drawing.Size(448, 212);
            this.dgvOyuncular.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Oyuncu Ekle : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Takım Oyuncuları";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(230, 8);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(128, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Oyuncu Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cboOyuncu
            // 
            this.cboOyuncu.DisplayMember = "OyuncuAd";
            this.cboOyuncu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOyuncu.FormattingEnabled = true;
            this.cboOyuncu.Location = new System.Drawing.Point(87, 10);
            this.cboOyuncu.Name = "cboOyuncu";
            this.cboOyuncu.Size = new System.Drawing.Size(121, 21);
            this.cboOyuncu.TabIndex = 5;
            this.cboOyuncu.ValueMember = "Id";
            this.cboOyuncu.SelectedIndexChanged += new System.EventHandler(this.cboOyuncu_SelectedIndexChanged);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(338, 288);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(122, 23);
            this.btnCikar.TabIndex = 6;
            this.btnCikar.Text = "Oyuncu Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // TakimOyunculariForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 345);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.cboOyuncu);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvOyuncular);
            this.MaximumSize = new System.Drawing.Size(548, 384);
            this.MinimumSize = new System.Drawing.Size(548, 384);
            this.Name = "TakimOyunculariForm";
            this.Text = "TakimOyunculariForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOyuncular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cboOyuncu;
        private System.Windows.Forms.Button btnCikar;
    }
}