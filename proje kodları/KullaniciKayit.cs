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
    public partial class KullaniciKayit : DevExpress.XtraEditors.XtraForm
    {
        public KullaniciKayit()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            Mesaj mesaj = new Mesaj();
            bool durum = true;
            if (txtAdi.Text == "") durum = false;
            if (txtEposta.Text == "") durum = false;
            if (txtTelefon.Text == "") durum = false;
            if (txtSifreTekrar.Text == "") durum = false;
            if (txtSifre.Text == "") durum = false;
            if (durum == true)
            {
                string[] parametre = new string[5];
                parametre[0] = txtKullaniciadi.Text;
                parametre[1] = txtSifre.Text;
                parametre[2] = txtAdi.Text + " " + txtSoyadi.Text;
                parametre[3] = txtTelefon.Text;
                parametre[4] = txtEposta.Text;
                if (kullanici.KullaniciKaydet(parametre)) mesaj.KayitYapildi();
                else mesaj.KayitYapilmadi();
            }
            else mesaj.BosAlan();
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Text = "";
            txtEposta.Text = "";
            txtTelefon.Text = "";
            txtSifreTekrar.Text = "";
            txtSifre.Text = "";
            txtSoyadi.Text = "";
            txtKullaniciadi.Text = "";
        }
    }
}