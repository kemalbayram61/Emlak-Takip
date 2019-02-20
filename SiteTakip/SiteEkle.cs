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
    public partial class SiteEkle : DevExpress.XtraEditors.XtraForm
    {
        public SiteEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Mesaj mesaj = new Mesaj();
            bool durum = true;
            if (txtSiteadi.Text == "") durum = false;
            if (txtOzellikler.Text == "") durum = false;
            if (txtYoneticiadi.Text == "") durum = false;
            if (txtYoneticisoyadi.Text == "") durum = false;
            if (txtYoneticitelefon.Text == "") durum = false;
            if (txtSitetelefon.Text == "") durum = false;
            if (txtSiteadres.Text == "") durum = false;
            if (txtSiteaciklama.Text == "") durum = false;
            if (durum == true)
            {
                if (mesaj.KayitEklemeOnay())
                {
                    site st = new site();
                    st.siteAdi = txtSiteadi.Text;
                    st.adres = txtSiteadres.Text;
                    st.siteTelefon = txtSitetelefon.Text;
                    st.ozellikler = txtOzellikler.Text;
                    st.acıklama = txtSiteaciklama.Text;
                    st.yoneticiAdiSoyadi = string.Concat(txtYoneticiadi.Text, txtYoneticisoyadi.Text);
                    st.yoneticiTelefon = txtYoneticitelefon.Text;
                    if (st.Kaydet())
                    {
                        mesaj.KayitYapildi();
                    }
                    else mesaj.KayitYapilmadi();
                }
            }
            else mesaj.BosAlan();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtSiteadi.Text = "";
            txtOzellikler.Text = "";
            txtYoneticiadi.Text = "";
            txtYoneticisoyadi.Text = "";
            txtYoneticitelefon.Text = "";
            txtSitetelefon.Text = "";
            txtSiteadres.Text = "";
            txtSiteaciklama.Text = "";
        }

        private void SiteEkle_Load(object sender, EventArgs e)
        {

        }
    }
}