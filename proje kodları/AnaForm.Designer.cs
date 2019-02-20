namespace SiteTakip
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSiteekle = new DevExpress.XtraBars.BarButtonItem();
            this.btnApartmanekle = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteriekle = new DevExpress.XtraBars.BarButtonItem();
            this.btnDairesat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDairekirala = new DevExpress.XtraBars.BarButtonItem();
            this.btnParaislemleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnKasaislemleri = new DevExpress.XtraBars.BarButtonItem();
            this.btnHareketler = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnCikis = new DevExpress.XtraBars.BarButtonItem();
            this.btnYeniKayit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSatisBilgileri = new DevExpress.XtraBars.BarButtonItem();
            this.btnKasaBilgileri = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.cikis = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnSiteekle,
            this.btnApartmanekle,
            this.btnMusteriekle,
            this.btnDairesat,
            this.btnDairekirala,
            this.btnParaislemleri,
            this.btnKasaislemleri,
            this.btnHareketler,
            this.skinRibbonGalleryBarItem1,
            this.btnCikis,
            this.btnYeniKayit,
            this.barButtonItem1,
            this.btnSatisBilgileri,
            this.btnKasaBilgileri});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 15;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(940, 130);
            // 
            // btnSiteekle
            // 
            this.btnSiteekle.Caption = "Site Ekle";
            this.btnSiteekle.Id = 1;
            this.btnSiteekle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSiteekle.ImageOptions.LargeImage")));
            this.btnSiteekle.Name = "btnSiteekle";
            this.btnSiteekle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSiteekle_ItemClick);
            // 
            // btnApartmanekle
            // 
            this.btnApartmanekle.Caption = "Apartman Ekle";
            this.btnApartmanekle.Id = 2;
            this.btnApartmanekle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnApartmanekle.ImageOptions.LargeImage")));
            this.btnApartmanekle.Name = "btnApartmanekle";
            this.btnApartmanekle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnApartmanekle_ItemClick);
            // 
            // btnMusteriekle
            // 
            this.btnMusteriekle.Caption = "Müşteri Ekle";
            this.btnMusteriekle.Id = 3;
            this.btnMusteriekle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriekle.ImageOptions.LargeImage")));
            this.btnMusteriekle.Name = "btnMusteriekle";
            this.btnMusteriekle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriekle_ItemClick);
            // 
            // btnDairesat
            // 
            this.btnDairesat.Caption = "Daire Sat/Kirala";
            this.btnDairesat.Id = 4;
            this.btnDairesat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDairesat.ImageOptions.LargeImage")));
            this.btnDairesat.Name = "btnDairesat";
            this.btnDairesat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDairesat_ItemClick);
            // 
            // btnDairekirala
            // 
            this.btnDairekirala.Caption = "Daire Kirala";
            this.btnDairekirala.Id = 5;
            this.btnDairekirala.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDairekirala.ImageOptions.LargeImage")));
            this.btnDairekirala.Name = "btnDairekirala";
            // 
            // btnParaislemleri
            // 
            this.btnParaislemleri.Caption = "Para İşlemi";
            this.btnParaislemleri.Id = 6;
            this.btnParaislemleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnParaislemleri.ImageOptions.LargeImage")));
            this.btnParaislemleri.Name = "btnParaislemleri";
            this.btnParaislemleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnParaislemleri_ItemClick);
            // 
            // btnKasaislemleri
            // 
            this.btnKasaislemleri.Caption = "Kasa Bilgileri";
            this.btnKasaislemleri.Id = 7;
            this.btnKasaislemleri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKasaislemleri.ImageOptions.LargeImage")));
            this.btnKasaislemleri.Name = "btnKasaislemleri";
            this.btnKasaislemleri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKasaislemleri_ItemClick);
            // 
            // btnHareketler
            // 
            this.btnHareketler.Caption = "Hareketler";
            this.btnHareketler.Id = 8;
            this.btnHareketler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHareketler.ImageOptions.LargeImage")));
            this.btnHareketler.Name = "btnHareketler";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 9;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnCikis
            // 
            this.btnCikis.Caption = "Çıkış";
            this.btnCikis.Id = 10;
            this.btnCikis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCikis.ImageOptions.LargeImage")));
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCikis_ItemClick);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Caption = "Kayıt Ol";
            this.btnYeniKayit.Id = 11;
            this.btnYeniKayit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniKayit.ImageOptions.LargeImage")));
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYeniKayit_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Listeler";
            this.barButtonItem1.Id = 12;
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnSatisBilgileri
            // 
            this.btnSatisBilgileri.Caption = "Satış Bilgileri";
            this.btnSatisBilgileri.Id = 13;
            this.btnSatisBilgileri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSatisBilgileri.ImageOptions.LargeImage")));
            this.btnSatisBilgileri.Name = "btnSatisBilgileri";
            this.btnSatisBilgileri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSatisBilgileri_ItemClick);
            // 
            // btnKasaBilgileri
            // 
            this.btnKasaBilgileri.Caption = "Kasa Bilgileri";
            this.btnKasaBilgileri.Id = 14;
            this.btnKasaBilgileri.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKasaBilgileri.ImageOptions.LargeImage")));
            this.btnKasaBilgileri.Name = "btnKasaBilgileri";
            this.btnKasaBilgileri.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKasaBilgileri_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.cikis});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Ana Menü";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSiteekle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnApartmanekle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteriekle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDairesat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Genel İşlemler";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnParaislemleri);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKasaislemleri);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Kasa İşlemleri";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnSatisBilgileri);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnKasaBilgileri);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Döküman";
            // 
            // cikis
            // 
            this.cikis.ItemLinks.Add(this.btnYeniKayit);
            this.cikis.ItemLinks.Add(this.btnCikis);
            this.cikis.Name = "cikis";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // AnaForm
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 545);
            this.ControlBox = false;
            this.Controls.Add(this.ribbonControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Site Takibi";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnSiteekle;
        private DevExpress.XtraBars.BarButtonItem btnApartmanekle;
        private DevExpress.XtraBars.BarButtonItem btnMusteriekle;
        private DevExpress.XtraBars.BarButtonItem btnDairesat;
        private DevExpress.XtraBars.BarButtonItem btnDairekirala;
        private DevExpress.XtraBars.BarButtonItem btnParaislemleri;
        private DevExpress.XtraBars.BarButtonItem btnKasaislemleri;
        private DevExpress.XtraBars.BarButtonItem btnHareketler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem btnCikis;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup cikis;
        private DevExpress.XtraBars.BarButtonItem btnYeniKayit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnSatisBilgileri;
        private DevExpress.XtraBars.BarButtonItem btnKasaBilgileri;
    }
}

