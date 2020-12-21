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
    public partial class Form1 : Form
    {
        BindingList<Mac> blMaclar = new BindingList<Mac>();

        FutbolDbContext db = new FutbolDbContext();
        public Form1()
        {
            InitializeComponent();
            MaclariListele();
        }

        private void MaclariListele()
        {
            dgvKarsilasmalar.DataSource = db.Maclar
                .OrderBy(x => x.MacTarih).ToList()
                .Select(x => new
                {
                 x.Id,
                 EvSahibi = x.Takim1.TakimAd,
                 Deplasman = x.Takim2.TakimAd,
                 Skor = x.Skor1 + " - " + x.Skor2,
                 MacTarihi = x.MacTarih?.ToShortDateString(),
                 MacSaati = x.MacTarih?.ToShortTimeString(),
                 Sonuc = x.Sonuc
                }).ToList();
        }

        private void tsmiTakimlar_Click(object sender, EventArgs e)
        {
            TakimlarForm frmTakimlar = new TakimlarForm(db);
            frmTakimlar.DegisiklikYapildi += FrmTakimlar_DegisiklikYapildi;
            frmTakimlar.ShowDialog();
        }

        private void FrmTakimlar_DegisiklikYapildi(object sender, EventArgs e)
        {
            MaclariListele();
        }

        private void tsmiRenkler_Click(object sender, EventArgs e)
        {
            RenklerForm frmRenkler = new RenklerForm(db);
            frmRenkler.RenkEklendi += FrmRenkler_RenkEklendi;
            frmRenkler.ShowDialog();
        }

        private void FrmRenkler_RenkEklendi(object sender, EventArgs e)
        {
            MaclariListele();
        }

        private void tsmiOyuncular_Click(object sender, EventArgs e)
        {
            OyuncularForm frmOyuncular = new OyuncularForm(db);
            frmOyuncular.OyuncuEklendi += FrmOyuncular_OyuncuEklendi;
            frmOyuncular.ShowDialog();
        }

        private void FrmOyuncular_OyuncuEklendi(object sender, EventArgs e)
        {
            MaclariListele();
        }

        private void btnYeniKarsilasma_Click(object sender, EventArgs e)
        {
            YeniKarsilasmaForm frmYeniKarsilasma = new YeniKarsilasmaForm(db);
            frmYeniKarsilasma.MacEklendi += FrmMac_Eklendi;
            frmYeniKarsilasma.ShowDialog();
        }

        private void FrmMac_Eklendi(object sender, EventArgs e)
        {
            MaclariListele();
        }

        private void btnSeciliyiSil_Click(object sender, EventArgs e)
        {
            if (dgvKarsilasmalar.SelectedRows.Count == 0)
            {
                return;
            }

            int id = (int)dgvKarsilasmalar.SelectedRows[0].Cells[0].Value;
            Mac seciliMac = db.Maclar.Find(id);
            db.Maclar.Remove(seciliMac);
            db.SaveChanges();
            MaclariListele();
        }

        private void btnSeciliyiDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvKarsilasmalar.SelectedRows.Count == 0)
            {
                return;
            }

            int id = (int)dgvKarsilasmalar.SelectedRows[0].Cells[0].Value;
            Mac seciliMac = db.Maclar.Find(id);
            MacDuzenleFrom frmMacDuzenle = new MacDuzenleFrom(db, seciliMac);
            frmMacDuzenle.DegisiklikYapildi += FrmMacDuzenle_DegisiklikYapildi;
            frmMacDuzenle.ShowDialog();
            MaclariListele();
        }

        private void FrmMacDuzenle_DegisiklikYapildi(object sender, EventArgs e)
        {
            blMaclar.ResetBindings();
        }
    }
}
