namespace SiteTakip
{
    partial class SiteEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiteEkle));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtYoneticiadi = new DevExpress.XtraEditors.TextEdit();
            this.txtYoneticisoyadi = new DevExpress.XtraEditors.TextEdit();
            this.txtYoneticitelefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtSiteaciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtSiteadres = new DevExpress.XtraEditors.TextEdit();
            this.txtSiteadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtOzellikler = new DevExpress.XtraEditors.TextEdit();
            this.txtSitetelefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYoneticiadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYoneticisoyadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYoneticitelefon.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiteaciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiteadres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiteadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOzellikler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSitetelefon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txtYoneticiadi
            // 
            this.txtYoneticiadi.Location = new System.Drawing.Point(63, 14);
            this.txtYoneticiadi.Name = "txtYoneticiadi";
            this.txtYoneticiadi.Size = new System.Drawing.Size(223, 20);
            this.txtYoneticiadi.TabIndex = 5;
            // 
            // txtYoneticisoyadi
            // 
            this.txtYoneticisoyadi.Location = new System.Drawing.Point(63, 58);
            this.txtYoneticisoyadi.Name = "txtYoneticisoyadi";
            this.txtYoneticisoyadi.Size = new System.Drawing.Size(223, 20);
            this.txtYoneticisoyadi.TabIndex = 6;
            // 
            // txtYoneticitelefon
            // 
            this.txtYoneticitelefon.Location = new System.Drawing.Point(63, 108);
            this.txtYoneticitelefon.Name = "txtYoneticitelefon";
            this.txtYoneticitelefon.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtYoneticitelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtYoneticitelefon.Size = new System.Drawing.Size(223, 20);
            this.txtYoneticitelefon.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(17, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(15, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Adı";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 61);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Soyadı";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Telefon";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtYoneticisoyadi);
            this.groupBox1.Controls.Add(this.txtYoneticiadi);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.txtYoneticitelefon);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Location = new System.Drawing.Point(610, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yönetici";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Controls.Add(this.txtSiteaciklama);
            this.groupBox2.Controls.Add(this.txtSiteadres);
            this.groupBox2.Controls.Add(this.txtSiteadi);
            this.groupBox2.Controls.Add(this.labelControl8);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.txtOzellikler);
            this.groupBox2.Controls.Add(this.txtSitetelefon);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Location = new System.Drawing.Point(284, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 342);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Site";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(17, 186);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Açıklama";
            // 
            // txtSiteaciklama
            // 
            this.txtSiteaciklama.Location = new System.Drawing.Point(63, 184);
            this.txtSiteaciklama.Name = "txtSiteaciklama";
            this.txtSiteaciklama.Size = new System.Drawing.Size(223, 119);
            this.txtSiteaciklama.TabIndex = 4;
            // 
            // txtSiteadres
            // 
            this.txtSiteadres.Location = new System.Drawing.Point(63, 58);
            this.txtSiteadres.Name = "txtSiteadres";
            this.txtSiteadres.Size = new System.Drawing.Size(223, 20);
            this.txtSiteadres.TabIndex = 1;
            // 
            // txtSiteadi
            // 
            this.txtSiteadi.Location = new System.Drawing.Point(63, 14);
            this.txtSiteadi.Name = "txtSiteadi";
            this.txtSiteadi.Size = new System.Drawing.Size(223, 20);
            this.txtSiteadi.TabIndex = 0;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(17, 144);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(42, 13);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "Özellikler";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(17, 102);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Telefon";
            // 
            // txtOzellikler
            // 
            this.txtOzellikler.Location = new System.Drawing.Point(63, 141);
            this.txtOzellikler.Name = "txtOzellikler";
            this.txtOzellikler.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtOzellikler.Size = new System.Drawing.Size(223, 20);
            this.txtOzellikler.TabIndex = 3;
            // 
            // txtSitetelefon
            // 
            this.txtSitetelefon.Location = new System.Drawing.Point(63, 99);
            this.txtSitetelefon.Name = "txtSitetelefon";
            this.txtSitetelefon.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtSitetelefon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txtSitetelefon.Size = new System.Drawing.Size(223, 20);
            this.txtSitetelefon.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(17, 21);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(15, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Adı";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(17, 61);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Adres";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.Location = new System.Drawing.Point(610, 249);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(117, 105);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Black;
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(793, 249);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(117, 105);
            this.btnTemizle.TabIndex = 6;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // SiteEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 366);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SiteEkle";
            this.Text = "SiteEkle";
            this.Load += new System.EventHandler(this.SiteEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYoneticiadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYoneticisoyadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYoneticitelefon.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiteaciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiteadres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiteadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOzellikler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSitetelefon.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit txtYoneticiadi;
        private DevExpress.XtraEditors.TextEdit txtYoneticisoyadi;
        private DevExpress.XtraEditors.TextEdit txtYoneticitelefon;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.MemoEdit txtSiteaciklama;
        private DevExpress.XtraEditors.TextEdit txtSiteadres;
        private DevExpress.XtraEditors.TextEdit txtSiteadi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtSitetelefon;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTemizle;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtOzellikler;
    }
}