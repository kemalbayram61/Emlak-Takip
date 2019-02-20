namespace SiteTakip
{
    partial class ApartmanEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApartmanEkle));
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ComboSite = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtApartmanaciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtDaireSayisi = new DevExpress.XtraEditors.TextEdit();
            this.txtApartmanadi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtOzellikler = new DevExpress.XtraEditors.TextEdit();
            this.txtKatsayisi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAlan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtFiyat = new DevExpress.XtraEditors.TextEdit();
            this.txtDurum = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboSite.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApartmanaciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaireSayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApartmanadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOzellikler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKatsayisi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDurum.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.Black;
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.Location = new System.Drawing.Point(793, 249);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(117, 105);
            this.btnTemizle.TabIndex = 7;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = ((System.Drawing.Image)(resources.GetObject("btnEkle.Image")));
            this.btnEkle.Location = new System.Drawing.Point(642, 249);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(117, 105);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ComboSite);
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Controls.Add(this.txtApartmanaciklama);
            this.groupBox2.Controls.Add(this.txtDaireSayisi);
            this.groupBox2.Controls.Add(this.txtApartmanadi);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.txtOzellikler);
            this.groupBox2.Controls.Add(this.txtKatsayisi);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Location = new System.Drawing.Point(295, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 342);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Apartman";
            // 
            // ComboSite
            // 
            this.ComboSite.Location = new System.Drawing.Point(76, 181);
            this.ComboSite.Name = "ComboSite";
            this.ComboSite.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboSite.Properties.Appearance.Options.UseFont = true;
            this.ComboSite.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ComboSite.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ComboSite.Size = new System.Drawing.Size(223, 28);
            this.ComboSite.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(9, 230);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Açıklama";
            // 
            // txtApartmanaciklama
            // 
            this.txtApartmanaciklama.Location = new System.Drawing.Point(76, 230);
            this.txtApartmanaciklama.Name = "txtApartmanaciklama";
            this.txtApartmanaciklama.Size = new System.Drawing.Size(223, 88);
            this.txtApartmanaciklama.TabIndex = 5;
            // 
            // txtDaireSayisi
            // 
            this.txtDaireSayisi.Location = new System.Drawing.Point(77, 55);
            this.txtDaireSayisi.Name = "txtDaireSayisi";
            this.txtDaireSayisi.Size = new System.Drawing.Size(223, 20);
            this.txtDaireSayisi.TabIndex = 1;
            this.txtDaireSayisi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDaireSayisi_KeyPress);
            // 
            // txtApartmanadi
            // 
            this.txtApartmanadi.Location = new System.Drawing.Point(76, 14);
            this.txtApartmanadi.Name = "txtApartmanadi";
            this.txtApartmanadi.Size = new System.Drawing.Size(223, 20);
            this.txtApartmanadi.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(9, 184);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Sitesi";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 142);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Özellikler";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 98);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Kat Sayısı";
            // 
            // txtOzellikler
            // 
            this.txtOzellikler.Location = new System.Drawing.Point(76, 139);
            this.txtOzellikler.Name = "txtOzellikler";
            this.txtOzellikler.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtOzellikler.Size = new System.Drawing.Size(223, 20);
            this.txtOzellikler.TabIndex = 3;
            this.txtOzellikler.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOzellikler_KeyPress);
            // 
            // txtKatsayisi
            // 
            this.txtKatsayisi.Location = new System.Drawing.Point(76, 95);
            this.txtKatsayisi.Name = "txtKatsayisi";
            this.txtKatsayisi.Properties.Mask.EditMask = "(999) 000-0000";
            this.txtKatsayisi.Size = new System.Drawing.Size(223, 20);
            this.txtKatsayisi.TabIndex = 2;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 21);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(15, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Adı";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(10, 58);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 13);
            this.labelControl6.TabIndex = 3;
            this.labelControl6.Text = "Katdaki Daire";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 342);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAlan);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.txtDurum);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Location = new System.Drawing.Point(610, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 159);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Daire Özellikleri";
            // 
            // txtAlan
            // 
            this.txtAlan.Location = new System.Drawing.Point(62, 119);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(223, 20);
            this.txtAlan.TabIndex = 11;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(16, 122);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(22, 13);
            this.labelControl9.TabIndex = 10;
            this.labelControl9.Text = "m^2";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(63, 76);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Properties.Mask.EditMask = "c2";
            this.txtFiyat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtFiyat.Size = new System.Drawing.Size(223, 20);
            this.txtFiyat.TabIndex = 9;
            // 
            // txtDurum
            // 
            this.txtDurum.Location = new System.Drawing.Point(63, 30);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDurum.Properties.Items.AddRange(new object[] {
            "Satılık",
            "Kiralık",
            "Normal"});
            this.txtDurum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtDurum.Size = new System.Drawing.Size(223, 20);
            this.txtDurum.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(17, 79);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 13);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Fiyatları";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(17, 33);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(31, 13);
            this.labelControl8.TabIndex = 3;
            this.labelControl8.Text = "Durum";
            // 
            // ApartmanEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ApartmanEkle";
            this.Text = "ApartmanEkle";
            this.Load += new System.EventHandler(this.ApartmanEkle_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboSite.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApartmanaciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDaireSayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApartmanadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOzellikler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKatsayisi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAlan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDurum.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.MemoEdit txtApartmanaciklama;
        private DevExpress.XtraEditors.TextEdit txtDaireSayisi;
        private DevExpress.XtraEditors.TextEdit txtApartmanadi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKatsayisi;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtOzellikler;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit ComboSite;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtFiyat;
        private DevExpress.XtraEditors.ComboBoxEdit txtDurum;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtAlan;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}