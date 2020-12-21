namespace FutbolDb
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
            this.dgvKarsilasmalar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiTakimlar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRenkler = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOyuncular = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSeciliyiDuzenle = new System.Windows.Forms.Button();
            this.btnSeciliyiSil = new System.Windows.Forms.Button();
            this.btnYeniKarsilasma = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarsilasmalar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKarsilasmalar
            // 
            this.dgvKarsilasmalar.AllowUserToAddRows = false;
            this.dgvKarsilasmalar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKarsilasmalar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKarsilasmalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKarsilasmalar.Location = new System.Drawing.Point(12, 105);
            this.dgvKarsilasmalar.MultiSelect = false;
            this.dgvKarsilasmalar.Name = "dgvKarsilasmalar";
            this.dgvKarsilasmalar.ReadOnly = true;
            this.dgvKarsilasmalar.RowHeadersVisible = false;
            this.dgvKarsilasmalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKarsilasmalar.Size = new System.Drawing.Size(709, 225);
            this.dgvKarsilasmalar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Karşılaşmalar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTakimlar,
            this.tsmiRenkler,
            this.tsmiOyuncular});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(754, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiTakimlar
            // 
            this.tsmiTakimlar.Name = "tsmiTakimlar";
            this.tsmiTakimlar.Size = new System.Drawing.Size(63, 20);
            this.tsmiTakimlar.Text = "Takımlar";
            this.tsmiTakimlar.Click += new System.EventHandler(this.tsmiTakimlar_Click);
            // 
            // tsmiRenkler
            // 
            this.tsmiRenkler.Name = "tsmiRenkler";
            this.tsmiRenkler.Size = new System.Drawing.Size(58, 20);
            this.tsmiRenkler.Text = "Renkler";
            this.tsmiRenkler.Click += new System.EventHandler(this.tsmiRenkler_Click);
            // 
            // tsmiOyuncular
            // 
            this.tsmiOyuncular.Name = "tsmiOyuncular";
            this.tsmiOyuncular.Size = new System.Drawing.Size(74, 20);
            this.tsmiOyuncular.Text = "Oyuncular";
            this.tsmiOyuncular.Click += new System.EventHandler(this.tsmiOyuncular_Click);
            // 
            // btnSeciliyiDuzenle
            // 
            this.btnSeciliyiDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeciliyiDuzenle.Location = new System.Drawing.Point(12, 336);
            this.btnSeciliyiDuzenle.Name = "btnSeciliyiDuzenle";
            this.btnSeciliyiDuzenle.Size = new System.Drawing.Size(143, 23);
            this.btnSeciliyiDuzenle.TabIndex = 5;
            this.btnSeciliyiDuzenle.Text = "Seçiliyi Düzenle";
            this.btnSeciliyiDuzenle.UseVisualStyleBackColor = true;
            this.btnSeciliyiDuzenle.Click += new System.EventHandler(this.btnSeciliyiDuzenle_Click);
            // 
            // btnSeciliyiSil
            // 
            this.btnSeciliyiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeciliyiSil.Location = new System.Drawing.Point(217, 336);
            this.btnSeciliyiSil.Name = "btnSeciliyiSil";
            this.btnSeciliyiSil.Size = new System.Drawing.Size(143, 23);
            this.btnSeciliyiSil.TabIndex = 6;
            this.btnSeciliyiSil.Text = "Seçiliyi Sil";
            this.btnSeciliyiSil.UseVisualStyleBackColor = true;
            this.btnSeciliyiSil.Click += new System.EventHandler(this.btnSeciliyiSil_Click);
            // 
            // btnYeniKarsilasma
            // 
            this.btnYeniKarsilasma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKarsilasma.Location = new System.Drawing.Point(578, 79);
            this.btnYeniKarsilasma.Name = "btnYeniKarsilasma";
            this.btnYeniKarsilasma.Size = new System.Drawing.Size(143, 23);
            this.btnYeniKarsilasma.TabIndex = 7;
            this.btnYeniKarsilasma.Text = "+ Yeni Karşılaşma";
            this.btnYeniKarsilasma.UseVisualStyleBackColor = true;
            this.btnYeniKarsilasma.Click += new System.EventHandler(this.btnYeniKarsilasma_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 412);
            this.Controls.Add(this.btnYeniKarsilasma);
            this.Controls.Add(this.btnSeciliyiSil);
            this.Controls.Add(this.btnSeciliyiDuzenle);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvKarsilasmalar);
            this.MaximumSize = new System.Drawing.Size(770, 451);
            this.MinimumSize = new System.Drawing.Size(770, 451);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarsilasmalar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKarsilasmalar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiTakimlar;
        private System.Windows.Forms.ToolStripMenuItem tsmiRenkler;
        private System.Windows.Forms.ToolStripMenuItem tsmiOyuncular;
        private System.Windows.Forms.Button btnSeciliyiDuzenle;
        private System.Windows.Forms.Button btnSeciliyiSil;
        private System.Windows.Forms.Button btnYeniKarsilasma;
    }
}

