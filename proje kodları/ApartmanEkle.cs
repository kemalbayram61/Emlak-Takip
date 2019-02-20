using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SiteTakip
{
    public partial class ApartmanEkle : DevExpress.XtraEditors.XtraForm
    {
        site Site=new site();
        List<site> SiteListesi;
        public ApartmanEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Mesaj mesaj = new Mesaj();
            bool durum = true;
            if (txtApartmanadi.Text == "") durum = false;
            if (txtDaireSayisi.Text == "") durum = false;
            if (txtKatsayisi.Text == "") durum = false;
            if (txtApartmanaciklama.Text == "") durum = false;
            if (txtOzellikler.Text == "") durum = false;
            if (ComboSite.Text == "") durum = false;
            if (txtDurum.Text == "") durum = false;
            if (txtFiyat.Text == "") durum = false;
            if (txtAlan.Text == "") durum = false;
            if (durum == true)
            {
                if (mesaj.KayitEklemeOnay())
                {
                    apartman aprt = new apartman();
                    aprt.adi = txtApartmanadi.Text;
                    aprt.katdakidaire = Convert.ToInt32(txtDaireSayisi.Text);
                    aprt.katsayisi = Convert.ToInt32(txtKatsayisi.Text);
                    aprt.ozellikler = txtOzellikler.Text;
                    aprt.aciklama = txtApartmanaciklama.Text;
                    aprt.tipi = txtDurum.Text;
                    aprt.fiyat = Convert.ToDecimal(txtFiyat.Text);
                    aprt.alani = Convert.ToInt32(txtAlan.Text);
                    SiteListesi = Site.SiteleriGetir();
                    foreach (var item in SiteListesi)
                    {
                        if (ComboSite.Text == item.siteAdi) aprt.siteid = item.id;
                    }
                    if (aprt.Kaydet()) mesaj.KayitYapildi();
                    else mesaj.KayitYapilmadi();
                }
               
            }
            else mesaj.BosAlan();
        }

        private void ApartmanEkle_Load(object sender, EventArgs e)
        {
            SiteListesi = Site.SiteleriGetir();
            foreach (var item in SiteListesi)
            {
                ComboSite.Properties.Items.Add(item.siteAdi);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtApartmanadi.Text = "";
            txtDaireSayisi.Text = "";
            txtKatsayisi.Text = "";
            txtApartmanaciklama.Text = "";
            txtOzellikler.Text = "";
            ComboSite.Text = "";
            txtDurum.Text = "";
            txtFiyat.Text = "";
            txtAlan.Text = "";
        }

        private void txtDaireSayisi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) e.Handled = true;
        }

        private void txtOzellikler_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}