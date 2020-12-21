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
    public partial class OyuncularForm : Form
    {
        public event EventHandler OyuncuEklendi;
        private readonly FutbolDbContext db;

        Oyuncu duzenlenen = null;
        public OyuncularForm(FutbolDbContext context)
        {
            db = context;
            InitializeComponent();
            dgvOyuncular.AutoGenerateColumns = false;
            OyunculariListele();
            TakimlariGetir();
        }

        private void TakimlariGetir()
        {
            var takimFiltrele = db.Takimlar.OrderBy(x => x.TakimAd).ToList();
            takimFiltrele.Insert(0, new Takim { TakimAd = "Tüm Takımlar" });
            cboTakimFiltre.DataSource = takimFiltrele;

            var takimGetir = db.Takimlar.OrderBy(x => x.TakimAd).ToList();
            takimGetir.Insert(0, new Takim { TakimAd = "Tüm Takımlar" });
            cboTakimSec.DataSource = takimGetir;
        }

        private void OyunculariListele()
        {
            dgvOyuncular.DataSource = db.Oyuncular.ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var takim = (Takim)cboTakimSec.SelectedItem;

            string oyuncuAd = txtOyuncu.Text.Trim();
            if (oyuncuAd == "")
            {
                MessageBox.Show("Oyuncu adı girmelisiniz.");
                return;
            }

            if (duzenlenen == null)
            {
                if (cboTakimSec.SelectedIndex == 0)
                {
                    db.Oyuncular.Add(new Oyuncu()
                    {
                        OyuncuAd = oyuncuAd
                    });
                }

                

                else if (cboTakimSec.SelectedIndex != 0)
                {
                    db.Oyuncular.Add(new Oyuncu()
                    {
                        OyuncuAd = oyuncuAd,
                        TakimId = takim.Id,
                        Takimi = takim
                    });
                }

            }
            else
            {
                if (cboTakimSec.SelectedIndex == 0)
                {
                    duzenlenen.OyuncuAd = oyuncuAd;
                }
                else
                {
                    duzenlenen.OyuncuAd = oyuncuAd;
                    duzenlenen.TakimId = takim.Id;
                    FormuResetle();
                }
            }

            db.SaveChanges();
            btnIptal.Hide();
            txtOyuncu.Clear();
            OyunculariListele();
            OyuncuEklendiginde(EventArgs.Empty);
            FormuResetle();
        }

        private void OyuncuEklendiginde(EventArgs empty)
        {
            OyuncuEklendi?.Invoke(this, empty);
        }

        private void FormuResetle()
        {
            duzenlenen = null;
            btnIptal.Hide();
            txtOyuncu.Clear();
            cboTakimSec.SelectedIndex = 0;
            btnEkle.Text = "Oyuncu Ekle";
            dgvOyuncular.Enabled = btnDuzenle.Enabled = btnSil.Enabled = true;
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvOyuncular.SelectedRows.Count == 0)
            {
                return;
            }

            duzenlenen = (Oyuncu)dgvOyuncular.SelectedRows[0].DataBoundItem;
            txtOyuncu.Text = duzenlenen.OyuncuAd;
            cboTakimSec.SelectedItem = duzenlenen.Takimi;
            dgvOyuncular.Enabled = btnDuzenle.Enabled = btnSil.Enabled = false;
            btnEkle.Text = "Oyuncuyu Düzenle";
            btnIptal.Show();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }

        private void cboTakimFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {

            OyunculariListele();

            if (cboTakimFiltre.SelectedIndex > 0)
            {
                Takim seciliTakim = (Takim)cboTakimFiltre.SelectedItem;
                dgvOyuncular.DataSource = seciliTakim.Oyuncular.ToList();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvOyuncular.SelectedRows.Count == 0)
            {
                return;
            }
            Oyuncu seciliOyuncu = (Oyuncu)dgvOyuncular.SelectedRows[0].DataBoundItem;
            db.Oyuncular.Remove(seciliOyuncu);
            db.SaveChanges();
            OyunculariListele();
        }
    }
}
