using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SiteTakip
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnSiteekle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["SiteEkle"] == null)
            {
                SiteEkle frm = new SiteEkle();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnApartmanekle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["ApartmanEkle"] == null)
            {
                ApartmanEkle frm = new ApartmanEkle();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnMusteriekle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["MusteriEkle"] == null)
            {
                MusteriEkle frm = new MusteriEkle();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnDairesat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["DaireSatKirala"] == null)
            {
                DaireSatKirala frm = new DaireSatKirala();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnCikis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Mesaj mesaj = new Mesaj();
            KullaniciGirisi giris = new KullaniciGirisi();
            if (mesaj.CikisYapiliyor())
            {
                this.Close();
                giris.Close();
            }
        }

        private void btnYeniKayit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["KullaniciKayit"] == null)
            {
                KullaniciKayit frm = new KullaniciKayit();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btnKasaislemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Kasa kasa = new Kasa();
            string metin = "Kasanızda " + kasa.GuncelPara().ToString() + " ₺ Para Bulunmaktadır.\n Ve son işlem tatihi " + kasa.SonIslemTarihi().ToString() + "";
            MessageBox.Show(metin,"Bildirim",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }

        private void btnParaislemleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["ParaIslemleri"] == null)
            {
                ParaIslemleri para = new ParaIslemleri();
                para.MdiParent = this;
                para.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["Listeler"] == null)
            {
                Listeler liste = new Listeler();
                liste.MdiParent = this;
                liste.Show();
            }
        }

        private void btnKasaBilgileri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["KasaBilgileri"] == null)
            {
                KasaBilgileri liste = new KasaBilgileri();
                liste.MdiParent = this;
                liste.Show();
            }
        }

        private void btnSatisBilgileri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Application.OpenForms["SatışBilgileri"] == null)
            {
                SatışBilgileri liste = new SatışBilgileri();
                liste.MdiParent = this;
                liste.Show();
            }
        }
    }
}
