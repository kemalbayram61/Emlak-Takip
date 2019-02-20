using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;

namespace SiteTakip
{
    public partial class DaireSatKirala : DevExpress.XtraEditors.XtraForm
    {
        dbConnection baglanti;
        Daire daire = new Daire();
        public DaireSatKirala()
        {
            InitializeComponent();
        }
        public int SiteId(string Isim)
        {
            int id = 0;

            baglanti = new dbConnection();
            string sorgu = "SELECT * FROM tblSite";
            DataTable dt = baglanti.executeSelectQuery(sorgu, null);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (item["ADI"].ToString() == Isim) id = Convert.ToInt32(item["ID"]);
                }
            }
            return id;
        }
        public int ApartmanId(int SiteId,string ApartmanAdi)
        {
            int id = 0;

            baglanti = new dbConnection();
            string sorgu = "SELECT * FROM tblApartman";
            DataTable dt = baglanti.executeSelectQuery(sorgu, null);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (item["ADI"].ToString().Trim() == ApartmanAdi && SiteId==Convert.ToInt32(item["SITEID"])) id = Convert.ToInt32(item["ID"]);
                }
            }
            return id;
        }
        public int Fiyati(int SatisFiyati,string Durum)
        {
            if (Durum.Trim() == "Satılık") return SatisFiyati;
            else if (Durum.Trim() == "Kiralık") return (int)SatisFiyati / 363;
            else if (Durum.Trim() == "Normal") return SatisFiyati;
            else return 0;
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            string numara = txtTelefon.Text;
            baglanti = new dbConnection();
            string[] isimsoyisim;
            string sorgu = "SELECT * FROM tblMusteri";
            DataTable dt = baglanti.executeSelectQuery(sorgu, null);
            
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (numara == item["TELEFON"].ToString())
                    {
                        isimsoyisim =item["ADISOYADI"].ToString().Split(' ');
                        txtAd.Text = isimsoyisim[0].ToString();
                        txtSoyad.Text = isimsoyisim[1].ToString();
                        txtAdres.Text = item["ADRES"].ToString();
                    }
                }
            }
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            MusteriEkle frm = new MusteriEkle();
            if (Application.OpenForms["MusteriEkle"] == null)
            {
                frm.MdiParent = AnaForm.ActiveForm;
                frm.Show();
            }
            else
            {
                this.ActivateMdiChild(Application.OpenForms["MusteriEkle"]);
            }
        }
        private void DaireSat_Load(object sender, EventArgs e)
        {
            site Site = new site();
            List<site> SiteListesi = Site.SiteleriGetir();
            foreach (var item in SiteListesi)
            {
                comboSiteler.Properties.Items.Add(item.siteAdi);
            }
        }

        private void comboSiteler_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboApartman.Properties.Items.Clear();
            apartman apart = new apartman();
            site st = new site();
            int siteid = st.SiteId(comboSiteler.Text);
            List<apartman> ApartmanListesi = apart.ApartmanlariGetir(siteid);
            foreach (var item in ApartmanListesi)
            {
                comboApartman.Properties.Items.Add(item.adi);
            }
        }

        private void comboApartman_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboKat.Properties.Items.Clear();
            apartman apart = new apartman();
            site Site = new site();
            Daire daire = new Daire();
            string[] durumvefiyat = daire.DaireDurumuVeFiyati(ApartmanId(Site.SiteId(comboSiteler.Text), comboApartman.Text));
            txtDurum.Text = durumvefiyat[0];
            txtFiyat.Text = durumvefiyat[1];
            int kat = apart.KatSayisi(apart.ApartmanId(Site.SiteId(comboSiteler.Text), comboApartman.Text));
            for (int i = 1; i <= kat; i++) comboKat.Properties.Items.Add(i);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtTelefon.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtAdres.Text = "";
            comboSiteler.Text = "";
            comboApartman.Text = "";
            comboKat.Text = "";
            txtFiyat.Text = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Mesaj mesaj = new Mesaj();
            musteri must = new musteri();
            Daire daire = new Daire();
            site site = new site();
            apartman apart = new apartman();
            Kasa kasa = new Kasa();
            Satis satis = new Satis();
            Kasaislem kasaislem = new Kasaislem();
            bool durum = true;
            if(txtTelefon.Text == "")durum=false;
            if(txtAd.Text == "")durum=false;
            if(txtSoyad.Text == "")durum=false;
            if(txtAdres.Text == "")durum=false;
            if(comboSiteler.Text == "")durum=false;
            if(comboApartman.Text == "")durum=false;
            if(comboKat.Text == "")durum=false;
            if(txtFiyat.Text == "")durum=false;
            int musteriid = must.MusteriId(txtTelefon.Text);
            int daireid = daire.DaireId(apart.ApartmanId(site.SiteId(comboSiteler.Text), comboApartman.Text), Convert.ToInt32(comboKat.Text), Convert.ToInt32(comboDaireNo.Text));
            if (durum == true)
            {
                decimal fiyat = Convert.ToDecimal(txtFiyat.Text);

                if (must.DaireIdGuncelle(musteriid, daireid) && daire.MusteriIdGuncelle(daireid, musteriid))
                {
                    if (kasa.ParaIslem(fiyat, DateTime.Now, true))
                    {
                        kasaislem.IslemAdi = txtDurum.Text;
                        kasaislem.ParaTutari = Convert.ToDecimal(txtFiyat.Text);
                        kasaislem.Kaydet();
                        satis.MusteriId = must.MusteriId(txtTelefon.Text);
                        satis.DaireId = daireid;
                        satis.Fiyat = Convert.ToDecimal(txtFiyat.Text);
                        satis.Tipi = txtDurum.Text;
                        satis.Tarih = DateTime.Now;
                        if(satis.Kaydet())
                        mesaj.KayitYapildi();
                    }
                }
                
            }
            else mesaj.BosAlan();
        }

        private void comboKat_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDaireNo.Properties.Items.Clear();
            apartman apart = new apartman();
            site Site = new site();
            int daireSayisi = apart.KatdakiDaire(apart.ApartmanId(Site.SiteId(comboSiteler.Text), comboApartman.Text));
            for(int i = 1; i <= daireSayisi; i++)
            {
                comboDaireNo.Properties.Items.Add(i);
            }
        }
    }
}