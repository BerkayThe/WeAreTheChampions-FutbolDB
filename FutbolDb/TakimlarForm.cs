using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutbolDb
{
    
    public partial class TakimlarForm : Form
    {
        BindingList<Takim> blTakimlar = new BindingList<Takim>();

        public event EventHandler DegisiklikYapildi;
        private readonly FutbolDbContext db;

        Takim duzenlenen = null;

        public TakimlarForm(FutbolDbContext context)
        {
            
            db = context;
            InitializeComponent();
            dgvTakimlar.AutoGenerateColumns = false;
            TakimlariListele();
            RenkleriGetir();
            
        }

        private void RenkleriGetir()
        {

            var filtreRenkler1 = db.Renkler.OrderBy(x => x.RenkAd).ToList();
            filtreRenkler1.Insert(0,new Renk {RenkAd = "Tüm Renkler" });
            cboRenkEkle1.DataSource = filtreRenkler1;

            var filtreRenkler2 = db.Renkler.OrderBy(x => x.RenkAd).ToList();
            filtreRenkler2.Insert(0, new Renk { RenkAd = "Tüm Renkler" });
            cboRenkEkle2.DataSource = filtreRenkler2;

        }

        private void TakimlariListele()
        {
            dgvTakimlar.DataSource = db.Takimlar
                .OrderBy(x => x.Id).ToList();
               
        }

     

        private void btnTakimEkle_Click(object sender, EventArgs e)
        {
            var renk1 = (Renk)cboRenkEkle1.SelectedItem;
            var renk2 = (Renk)cboRenkEkle2.SelectedItem;

            /*IQueryable<Takim> takimlar = db.Takimlar;


            if (renk1.Id != renk2.Id)
            {
                if (renk1.Id > 0)
                {
                    takimlar = takimlar.Where(x => x.Renkler.Any(t => t.Id == renk1.Id));
                }

                if (renk2.Id > 0)
                {
                    takimlar = takimlar.Where(x => x.Renkler.Any(t => t.Id == renk2.Id));
                }
            }
            else
            {
                MessageBox.Show("İki rengi aynı seçemezsiniz.");
            }*/
            

            string takimAd = txtTakimAd.Text.Trim();
            if (takimAd == "")
            {
                MessageBox.Show("Takım adı girmelisiniz.");
                return;
            }
            if (duzenlenen == null)
            {
                if (cboRenkEkle1.SelectedIndex == 0 || cboRenkEkle2.SelectedIndex == 0)
                {
                    MessageBox.Show("Takımınız için iki adet renk seçiniz.");
                    return;
                }
                db.Takimlar.Add(new Takim()
                {
                    TakimAd = takimAd,
                    Renkler = new List<Renk> { renk1,renk2}

                }) ;

                
            }
            else
            {
                if (cboRenkEkle1.SelectedIndex == 0 || cboRenkEkle2.SelectedIndex == 0)
                {
                    MessageBox.Show("Takımınız için iki adet renk seçiniz.");
                    return;
                }
                duzenlenen.TakimAd = takimAd;
                duzenlenen.Renkler = new List<Renk> { renk1, renk2 };
                FormuResetle();
            }
            db.SaveChanges();
            btnIptal.Hide();
            txtTakimAd.Clear();
            TakimlariListele();
            DegisiklikYapildiginda(EventArgs.Empty);
            FormuResetle();
        }

        private void DegisiklikYapildiginda(EventArgs empty)
        {
            DegisiklikYapildi?.Invoke(this, empty);
        }

        private void FormuResetle()
        {
            duzenlenen = null;
            txtTakimAd.Clear();
            btnIptal.Hide();
            cboRenkEkle1.SelectedIndex = 0;
            cboRenkEkle2.SelectedIndex = 0;
            pictureBox1.BackColor = default;
            pictureBox2.BackColor = default;
            btnTakimEkle.Text = "Takım Ekle";
            dgvTakimlar.Enabled = btnOyuncular.Enabled = btnTakimSil.Enabled =btnDuzenle.Enabled =true;
        }

        private void btnTakimSil_Click(object sender, EventArgs e)
        {
            if (dgvTakimlar.SelectedRows.Count == 0)
            {
                return;
            }
            int id = (int)dgvTakimlar.SelectedRows[0].Cells[0].Value;
            Takim seciliTakim = db.Takimlar.Find(id);
            db.Takimlar.Remove(seciliTakim);
            db.SaveChanges();
            TakimlariListele();
        }

        private void cboRenkEkle1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var secilenRenk = (Renk)cboRenkEkle1.SelectedItem;
            if (secilenRenk.RenkAd !="Tüm Renkler")
            {
                pictureBox1.BackColor = System.Drawing.Color
             .FromArgb(secilenRenk.Red, secilenRenk.Green, secilenRenk.Blue);
            }
            
        }

        private void cboRenkEkle2_SelectedIndexChanged(object sender, EventArgs e)
        {

            var secilenRenk = (Renk)cboRenkEkle2.SelectedItem;
            if (secilenRenk.RenkAd != "Tüm Renkler")
            {
                pictureBox2.BackColor = System.Drawing.Color
             .FromArgb(secilenRenk.Red, secilenRenk.Green, secilenRenk.Blue);
            }
           
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvTakimlar.SelectedRows.Count == 0)
            {
                return;
            }
            duzenlenen = (Takim)dgvTakimlar.SelectedRows[0].DataBoundItem;
            txtTakimAd.Text =duzenlenen.TakimAd;
            dgvTakimlar.Enabled = btnOyuncular.Enabled = btnTakimSil.Enabled =btnDuzenle.Enabled =false;
            btnTakimEkle.Text = "Takımı Düzenle";
            btnIptal.Show();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }

        private void btnOyuncular_Click(object sender, EventArgs e)
        {
            if (dgvTakimlar.SelectedRows.Count == 0)
                return;

            Takim seciliTakim = (Takim)dgvTakimlar.SelectedRows[0].DataBoundItem;
            TakimOyunculariForm frmTakimOyunculari = new TakimOyunculariForm(db,seciliTakim);
            frmTakimOyunculari.DegisiklikYapildi += FrmTakimOyunculari_DegisiklikYapildi;
            frmTakimOyunculari.ShowDialog();
        }

        private void FrmTakimOyunculari_DegisiklikYapildi(object sender, EventArgs e)
        {
            blTakimlar.ResetBindings();
        }
    }
}
