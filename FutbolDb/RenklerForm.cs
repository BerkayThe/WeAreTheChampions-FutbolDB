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
    public partial class RenklerForm : Form
    {
        public event EventHandler RenkEklendi;
        private readonly FutbolDbContext db;
        Renk duzenlenen = null;
        
        public RenklerForm(FutbolDbContext context)
        {
            db = context;
            InitializeComponent();
            RenkleriListele();
            
        }

       

        private void RenkleriListele()
        {
            lstRenk.DataSource = db.Renkler.OrderBy(x => x.RenkAd).ToList();
            lstRenk.DisplayMember = "RenkAd";
        }


        private void hsbRed_Scroll(object sender, ScrollEventArgs e)
        {
            lblRenk.BackColor = System.Drawing.Color.FromArgb(hsbRed.Value,hsbGreen.Value,hsbBlue.Value);
            lblRedDeger.Text ="(" + hsbRed.Value + ")";
        }

        private void hsbGreen_Scroll(object sender, ScrollEventArgs e)
        {
            lblRenk.BackColor = System.Drawing.Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
            lblGreenDeger.Text = "(" + hsbGreen.Value + ")";
        }

        private void hsbBlue_Scroll(object sender, ScrollEventArgs e)
        {
            lblRenk.BackColor = System.Drawing.Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
            lblBlueDeger.Text = "(" + hsbBlue.Value + ")";
        }

      

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string renkAd = txtRenkAd.Text.Trim();
            if (renkAd == "")
            {
                MessageBox.Show("Renk adı girmelisiniz.");
                return;
            }
            if (duzenlenen == null)
            {
                db.Renkler.Add(new Renk()
                {
                    RenkAd = renkAd,
                    Red =Convert.ToByte(hsbRed.Value),
                    Blue = Convert.ToByte(hsbBlue.Value),
                    Green = Convert.ToByte(hsbGreen.Value)
                });
            }
            else
            {
                duzenlenen.RenkAd = renkAd;
                duzenlenen.Red = Convert.ToByte(hsbRed.Value);
                duzenlenen.Green = Convert.ToByte(hsbGreen.Value);
                duzenlenen.Blue = Convert.ToByte(hsbBlue.Value);
                FormuResetle();
            }
            db.SaveChanges();
            txtRenkAd.Clear();
            RenkleriListele();
            DegisiklikYapildiginda(EventArgs.Empty);
            FormuResetle();
        }

        private void DegisiklikYapildiginda(EventArgs empty)
        {
            RenkEklendi?.Invoke(this, empty);
        }

        private void FormuResetle()
        {
            duzenlenen = null;
            txtRenkAd.Clear();
            btnEkle.Text = "Ekle";
            btnIptal.Hide();
            lblRedDeger.Text = "";
            lblGreenDeger.Text = "";
            lblBlueDeger.Text = "";
            hsbRed.Value = 0;
            hsbGreen.Value = 0;
            hsbBlue.Value = 0;
            lblRenk.BackColor= System.Drawing.Color.FromArgb(hsbRed.Value, hsbGreen.Value, hsbBlue.Value);
            lstRenk.Enabled = btnDuzenle.Enabled = btnSil.Enabled = true;
        }

        private void lstRenk_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var secilenRenk = (Renk)lstRenk.SelectedItem;
            lblSecilenRenk.BackColor = System.Drawing.Color
                .FromArgb(secilenRenk.Red, secilenRenk.Green, secilenRenk.Blue);
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int sid = lstRenk.SelectedIndex;

            if (sid < 0)
            {
                MessageBox.Show("Silmek için bir öğe seçiniz.");
                return;
            }

            Renk renk = (Renk)lstRenk.SelectedItem;
            db.Renkler.Remove(renk);
            db.SaveChanges();
            RenkleriListele();
            lstRenk.SelectedIndex = sid < lstRenk.Items.Count
                ? sid : lstRenk.Items.Count - 1;

        }

      
        private void btnDuzenle_Click_1(object sender, EventArgs e)
        {
            int sid = lstRenk.SelectedIndex;
            if (sid < 0)
            {
                MessageBox.Show("Düzenlemek için bir öğe seçiniz.");
                return;
            }
         
            lblRenk.BackColor = lblSecilenRenk.BackColor;
            duzenlenen = (Renk)lstRenk.SelectedItem;
            txtRenkAd.Text = duzenlenen.RenkAd;
            hsbRed.Value = duzenlenen.Red;
            hsbGreen.Value = duzenlenen.Green;
            hsbBlue.Value = duzenlenen.Blue;
            lblRedDeger.Text = "(" + hsbRed.Value + ")";
            lblGreenDeger.Text = "(" + hsbGreen.Value + ")";
            lblBlueDeger.Text = "(" + hsbBlue.Value + ")";
            btnEkle.Text = "Kaydet";
            btnIptal.Show();
            lstRenk.Enabled = btnDuzenle.Enabled = btnSil.Enabled = false;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }
    }
}
