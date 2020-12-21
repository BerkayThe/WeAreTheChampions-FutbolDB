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
    public partial class YeniKarsilasmaForm : Form
    {
        public event EventHandler MacEklendi;
        private readonly FutbolDbContext db;
        public YeniKarsilasmaForm(FutbolDbContext context)
        {
            db = context;
            InitializeComponent();
            TarihDuzelt();
            TakimlariGetir();
            
        }

        private void TarihDuzelt()
        {
            dtpMacTarih.Format = DateTimePickerFormat.Custom;
            dtpMacTarih.CustomFormat = "hh:mm:ss tt dd/MM/yyyy";
            dtpMacTarih.ShowUpDown = true;
        }

        private void TakimlariGetir()
        {
            
            var takimGetir1 = db.Takimlar.OrderBy(x => x.TakimAd).ToList();
            takimGetir1.Insert(0, new Takim { TakimAd = "Tüm Takımlar" });
            cboTakim1Sec.DataSource = takimGetir1;

            var takimGetir2 = db.Takimlar.OrderBy(x => x.TakimAd).ToList();
            takimGetir2.Insert(0, new Takim { TakimAd = "Tüm Takımlar" });
            cboTakim2Sec.DataSource = takimGetir2;
        }

        

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string dt = dtpMacTarih.Value.ToString("hh:mm:ss tt dd/MM/yyyy");
            var secilenTakim1 = (Takim)cboTakim1Sec.SelectedItem;
            var secilenTakim2 = (Takim)cboTakim2Sec.SelectedItem;
            var macTarihi = dt;
            var skor1 = nudTakim1Skor.Value;
            var skor2 = nudTakim2Skor.Value;
            var sonuc = txtSonuc.Text.Trim();

            if (secilenTakim1.TakimAd == secilenTakim2.TakimAd)
            {
                MessageBox.Show("Takımlar kendisiyle maç yapamaz.");
            }

            if (secilenTakim1.TakimAd == "Tüm Takımlar" || secilenTakim2.TakimAd == "Tüm Takımlar")
            {
                MessageBox.Show("Lütfen karşılaşacak takımları seçiniz.");
                return;
            }

            if (Convert.ToDateTime(macTarihi) < DateTime.Now)
            {
                if (sonuc == "")
                {
                    MessageBox.Show("Sonuc değerini  giriniz.");
                    return;
                }

                db.Maclar.Add(new Mac()
                {
                    Takim1 = secilenTakim1,
                    Takim2 = secilenTakim2,
                    Skor1 = Convert.ToInt32(skor1),
                    Skor2 = Convert.ToInt32(skor2),
                    MacTarih = Convert.ToDateTime(macTarihi),
                    Sonuc = (Sonuc?)Convert.ToInt32(sonuc)

                });
            }
            else if (Convert.ToDateTime(macTarihi) > DateTime.Now)
            {
                db.Maclar.Add(new Mac()
                {
                    Takim1 = secilenTakim1,
                    Takim2 = secilenTakim2,
                    MacTarih = Convert.ToDateTime(macTarihi)
                });
            }
           

            db.SaveChanges();
            YeniKarsilasmaEklendiginde(EventArgs.Empty);
            FormuResetle();
            Close();
        }

        private void FormuResetle()
        {
            cboTakim1Sec.SelectedIndex = 0;
            cboTakim2Sec.SelectedIndex = 0;
            nudTakim1Skor.Value = 0;
            nudTakim2Skor.Value = 0;
            txtSonuc.Clear();
        }

        private void YeniKarsilasmaEklendiginde(EventArgs empty)
        {
            MacEklendi?.Invoke(this, empty);
        }

       

        private void dtpMacTarih_ValueChanged(object sender, EventArgs e)
        {
            string dt = dtpMacTarih.Value.ToString("hh:mm:ss tt dd/MM/yyyy");
            var macTarihi = dt;

            if (Convert.ToDateTime(macTarihi) < DateTime.Now)
            {
                txtSonuc.Text = "0";
                nudTakim1Skor.Enabled = nudTakim2Skor.Enabled = true;
            }
            else
            {
                txtSonuc.Text = "";
                nudTakim1Skor.Value = 0;
                nudTakim2Skor.Value = 0;
                txtSonuc.Clear();
                nudTakim1Skor.Enabled = nudTakim2Skor.Enabled = false;
            }
        }


        private void nudTakim1Skor_ValueChanged(object sender, EventArgs e)
        {
            if (nudTakim1Skor.Enabled == true && nudTakim2Skor.Enabled ==true)
            {
                if (nudTakim1Skor.Value == nudTakim2Skor.Value)
                {
                    txtSonuc.Text = "0";
                }
            }

            if (nudTakim1Skor.Value < nudTakim2Skor.Value)
            {
                txtSonuc.Text = "2";
            }
            else if (nudTakim1Skor.Value > nudTakim2Skor.Value)
            {
                txtSonuc.Text = "1";
            }
           
        }

        private void nudTakim2Skor_ValueChanged(object sender, EventArgs e)
        {
            if (nudTakim1Skor.Enabled == true && nudTakim2Skor.Enabled == true)
            {
                if (nudTakim1Skor.Value == nudTakim2Skor.Value)
                {
                    txtSonuc.Text = "0";
                }
            }

            if (nudTakim1Skor.Value < nudTakim2Skor.Value)
            {
                txtSonuc.Text = "2";
            }
            else if (nudTakim1Skor.Value > nudTakim2Skor.Value)
            {
                txtSonuc.Text = "1";
            }
        }
    }
}
