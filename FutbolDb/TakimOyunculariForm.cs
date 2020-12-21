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
    public partial class TakimOyunculariForm : Form
    {
        public event EventHandler DegisiklikYapildi;
        private readonly FutbolDbContext db;

        private Takim seciliTakim;

        public TakimOyunculariForm(FutbolDbContext context,Takim seciliTakim)
        {
            db = context;
            this.seciliTakim = seciliTakim;
            InitializeComponent();
            OyuncuListele();

        }

        private void OyuncuListele()
        {


            var tumOyunculariGoster = db.Oyuncular.OrderBy(x => x.OyuncuAd).ToList();
            tumOyunculariGoster.Insert(0, new Oyuncu { OyuncuAd = "Tüm Oyuncular" });
            cboOyuncu.DataSource = tumOyunculariGoster.Where(x => x.TakimId == null).ToList();

            dgvOyuncular.DataSource = seciliTakim.Oyuncular.Select(x => new 
            { 
                x.Id,
                x.OyuncuAd,
                x.Takimi.TakimAd
            }).ToList();

                
                
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var oyuncu = (Oyuncu)cboOyuncu.SelectedItem;
            

            if (oyuncu.TakimId != null && oyuncu.TakimId != seciliTakim.Id)
            {
                MessageBox.Show("Bu oyuncu başka bir takımda oynuyor.");
            }

            if (cboOyuncu.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen eklemek istediğiniz oyuncuyu seçiniz.");
                return;
            }
            
            if (oyuncu.TakimId == seciliTakim.Id)
            {
                MessageBox.Show("Bu oyuncu takımda mevcut olduğu için ekleyemezsiniz.");
                return;
            }
            if (oyuncu.TakimId == null)
            {
                seciliTakim.Oyuncular.Add(oyuncu);
                oyuncu.TakimId = seciliTakim.Id;
                oyuncu.Takimi = seciliTakim;
            }
            db.SaveChanges();
            OyuncuListele();

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (dgvOyuncular.SelectedRows.Count == 0)
            {
                return;
            }
            int id = (int)dgvOyuncular.SelectedRows[0].Cells[0].Value;
            Oyuncu seciliOyuncu = db.Oyuncular.Find(id);
            seciliTakim.Oyuncular.Remove(seciliOyuncu);
            //Oyuncu oyuncu = (Oyuncu)dgvOyuncular.SelectedRows[0].DataBoundItem;
            //seciliTakim.Oyuncular.Remove(oyuncu);
            seciliOyuncu.Takimi = null;
            seciliOyuncu.TakimId = null;
            db.SaveChanges();
            OyuncuListele();
            
        }

        private void cboOyuncu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
