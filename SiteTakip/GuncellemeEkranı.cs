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
    public partial class GuncellemeEkranı : DevExpress.XtraEditors.XtraForm
    {
        public string[] gelenler,guncellenecek;
        public string tabloadi;
        public int id,musteriid;
        public string MusteriId(string Adi)
        {
            string sonuc="";
            musteri must = new musteri();
            List<musteri> MusteriListesi = must.Musterilistesi();
                foreach (var item in MusteriListesi)
                {
                    if (item.adisoyadi.Trim() == Adi.Trim()) sonuc = item.id.ToString();
                }
            return sonuc;
        }
        public GuncellemeEkranı(int ID,string GuncellemeTablosuAdi,params string[] Gelenler)
        {
            tabloadi = GuncellemeTablosuAdi;
            gelenler = Gelenler;
            id = ID;
            InitializeComponent();
        }

        private void GuncellemeEkranı_Load(object sender, EventArgs e)
        {
            comboMusterisi.Text = "Bos Olamaz...!";
            if (tabloadi == "Apartman")
            {
                grpApartman.Visible = true;
                grpSite.Visible = false;
                grpDaire.Visible = false;
                txtSıteId.Text = gelenler[0];
                txtApartmanAdi.Text = gelenler[1];
                txtKatdakiDaire.Text = gelenler[2];
                txtApartmanAcıklama.Text = gelenler[3];
                txtApartmanOzellikler.Text = gelenler[4];
                txtKatSayisi.Text = gelenler[5];
            }else if (tabloadi == "Daire")
            {
                grpDaire.Visible = true;
                grpApartman.Visible = false;
                grpSite.Visible = false;
                comboMusterisi.Items.Clear();
                musteri must = new musteri();
                List<musteri> MusteriListesi = must.Musterilistesi();
                foreach (var item in MusteriListesi)
                {
                    comboMusterisi.Items.Add(item.adisoyadi.Trim());
                }
                txtDaireıd.Text = id.ToString() ;
                txtApartmanıdDaire.Text = gelenler[0];
                txtAlan.Text = gelenler[1];
                txtKatNumarasi.Text = gelenler[2];
                comboTipi.Text = gelenler[3];
                txtFiyat.Text = gelenler[4];
                txtDaireNo.Text = gelenler[6];
            }
            else if (tabloadi == "Site")
            {
                grpSite.Visible = true;
                grpDaire.Visible = false;
                grpApartman.Visible = false;
                txtSiteId.Text = id.ToString();
                txtSiteadi.Text = gelenler[0];
                txtSiteOzellikler.Text = gelenler[1];
                txtYoneticiadi.Text = gelenler[2];
                txtYoneticitelefon.Text = gelenler[3];
                txtSitetelefon.Text = gelenler[4];
                txtSiteadres.Text = gelenler[5];
                txtAciklama.Text = gelenler[6];

            }

            

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (tabloadi == "Apartman")
            {
                guncellenecek = new string[3];
                apartman apart = new apartman();
                guncellenecek[0] = txtApartmanAdi.Text;
                guncellenecek[1] = txtApartmanAcıklama.Text;
                guncellenecek[2] = txtApartmanOzellikler.Text;
                if (apart.Guncelle(id, guncellenecek)) MessageBox.Show("Güncellendi");
            }else if (tabloadi == "Daire")
            {
                Daire daire = new Daire();
                guncellenecek = new string[4];
                guncellenecek[0] = txtAlan.Text;
                guncellenecek[1] = comboTipi.Text;
                guncellenecek[2] = txtFiyat.Text;
                guncellenecek[3] = MusteriId(comboMusterisi.Text).ToString();
                if (daire.Guncelle(id, guncellenecek)) MessageBox.Show("GÜncellendi");
            }
            else if (tabloadi == "Site")
            {
                site Site = new site();
                guncellenecek = new string[7];
                guncellenecek[0] = txtSiteadi.Text;
                guncellenecek[1] = txtSiteOzellikler.Text;
                guncellenecek[2] = txtYoneticiadi.Text;
                guncellenecek[3] = txtYoneticitelefon.Text;
                guncellenecek[4] = txtSitetelefon.Text;
                guncellenecek[5] = txtSiteadres.Text;
                guncellenecek[6] = txtAciklama.Text;
                if (Site.Guncelle(id, guncellenecek)) MessageBox.Show("Güncellendi");
            }
            this.Close();
        }
    }
}