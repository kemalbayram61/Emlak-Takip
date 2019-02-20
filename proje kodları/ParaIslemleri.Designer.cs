namespace SiteTakip
{
    partial class ParaIslemleri
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaIslemleri));
            this.Grafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.rdParaekle = new System.Windows.Forms.RadioButton();
            this.rdParacek = new System.Windows.Forms.RadioButton();
            this.grpParaekle = new System.Windows.Forms.GroupBox();
            this.txtEklenmisdurum = new DevExpress.XtraEditors.TextEdit();
            this.txtEklenecektutar = new DevExpress.XtraEditors.TextEdit();
            this.txtGuncelParaParaekle = new DevExpress.XtraEditors.TextEdit();
            this.btnOnaylaPraekle = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpParacek = new System.Windows.Forms.GroupBox();
            this.txtCekilmisdurum = new DevExpress.XtraEditors.TextEdit();
            this.txtCekilecektutar = new DevExpress.XtraEditors.TextEdit();
            this.txtGuncelParaParacek = new DevExpress.XtraEditors.TextEdit();
            this.btnOnaylaparacek = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPara = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSatilan = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKiralanan = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.Resim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grafik)).BeginInit();
            this.grpParaekle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEklenmisdurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEklenecektutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGuncelParaParaekle.Properties)).BeginInit();
            this.grpParacek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekilmisdurum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekilecektutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGuncelParaParacek.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPara.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatilan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKiralanan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).BeginInit();
            this.SuspendLayout();
            // 
            // Grafik
            // 
            chartArea4.Name = "ChartArea1";
            this.Grafik.ChartAreas.Add(chartArea4);
            this.Grafik.Location = new System.Drawing.Point(403, 12);
            this.Grafik.Name = "Grafik";
            this.Grafik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series10.ChartArea = "ChartArea1";
            series10.Label = "Para";
            series10.Name = "Para";
            series10.YValuesPerPoint = 4;
            series11.ChartArea = "ChartArea1";
            series11.Label = "Satılan";
            series11.Name = "Satilan";
            series12.ChartArea = "ChartArea1";
            series12.Label = "Kiralanan";
            series12.Name = "Kiralanan";
            this.Grafik.Series.Add(series10);
            this.Grafik.Series.Add(series11);
            this.Grafik.Series.Add(series12);
            this.Grafik.Size = new System.Drawing.Size(507, 342);
            this.Grafik.TabIndex = 0;
            this.Grafik.Text = "Grafik";
            // 
            // rdParaekle
            // 
            this.rdParaekle.AutoSize = true;
            this.rdParaekle.Location = new System.Drawing.Point(12, 239);
            this.rdParaekle.Name = "rdParaekle";
            this.rdParaekle.Size = new System.Drawing.Size(69, 17);
            this.rdParaekle.TabIndex = 1;
            this.rdParaekle.TabStop = true;
            this.rdParaekle.Text = "Para Ekle";
            this.rdParaekle.UseVisualStyleBackColor = true;
            this.rdParaekle.CheckedChanged += new System.EventHandler(this.rdParaekle_CheckedChanged);
            // 
            // rdParacek
            // 
            this.rdParacek.AutoSize = true;
            this.rdParacek.Location = new System.Drawing.Point(12, 216);
            this.rdParacek.Name = "rdParacek";
            this.rdParacek.Size = new System.Drawing.Size(68, 17);
            this.rdParacek.TabIndex = 1;
            this.rdParacek.TabStop = true;
            this.rdParacek.Text = "Para Çek";
            this.rdParacek.UseVisualStyleBackColor = true;
            this.rdParacek.CheckedChanged += new System.EventHandler(this.rdParacek_CheckedChanged);
            // 
            // grpParaekle
            // 
            this.grpParaekle.Controls.Add(this.txtEklenmisdurum);
            this.grpParaekle.Controls.Add(this.txtEklenecektutar);
            this.grpParaekle.Controls.Add(this.txtGuncelParaParaekle);
            this.grpParaekle.Controls.Add(this.btnOnaylaPraekle);
            this.grpParaekle.Controls.Add(this.label3);
            this.grpParaekle.Controls.Add(this.label2);
            this.grpParaekle.Controls.Add(this.label1);
            this.grpParaekle.Location = new System.Drawing.Point(87, 216);
            this.grpParaekle.Name = "grpParaekle";
            this.grpParaekle.Size = new System.Drawing.Size(310, 138);
            this.grpParaekle.TabIndex = 2;
            this.grpParaekle.TabStop = false;
            this.grpParaekle.Text = "Para Ekle";
            // 
            // txtEklenmisdurum
            // 
            this.txtEklenmisdurum.Enabled = false;
            this.txtEklenmisdurum.Location = new System.Drawing.Point(99, 80);
            this.txtEklenmisdurum.Name = "txtEklenmisdurum";
            this.txtEklenmisdurum.Size = new System.Drawing.Size(172, 20);
            this.txtEklenmisdurum.TabIndex = 4;
            // 
            // txtEklenecektutar
            // 
            this.txtEklenecektutar.EditValue = "0";
            this.txtEklenecektutar.Location = new System.Drawing.Point(99, 53);
            this.txtEklenecektutar.Name = "txtEklenecektutar";
            this.txtEklenecektutar.Properties.Mask.EditMask = "d";
            this.txtEklenecektutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtEklenecektutar.Size = new System.Drawing.Size(172, 20);
            this.txtEklenecektutar.TabIndex = 4;
            this.txtEklenecektutar.TextChanged += new System.EventHandler(this.txtEklenecektutar_TextChanged);
            // 
            // txtGuncelParaParaekle
            // 
            this.txtGuncelParaParaekle.Enabled = false;
            this.txtGuncelParaParaekle.Location = new System.Drawing.Point(99, 26);
            this.txtGuncelParaParaekle.Name = "txtGuncelParaParaekle";
            this.txtGuncelParaParaekle.Size = new System.Drawing.Size(172, 20);
            this.txtGuncelParaParaekle.TabIndex = 4;
            // 
            // btnOnaylaPraekle
            // 
            this.btnOnaylaPraekle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOnaylaPraekle.ImageOptions.Image")));
            this.btnOnaylaPraekle.Location = new System.Drawing.Point(99, 106);
            this.btnOnaylaPraekle.Name = "btnOnaylaPraekle";
            this.btnOnaylaPraekle.Size = new System.Drawing.Size(172, 23);
            this.btnOnaylaPraekle.TabIndex = 3;
            this.btnOnaylaPraekle.Text = "Onayla";
            this.btnOnaylaPraekle.Click += new System.EventHandler(this.btnOnaylaPraekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Eklenmiş Durum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Eklenecek Tutar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Güncel Para";
            // 
            // grpParacek
            // 
            this.grpParacek.Controls.Add(this.txtCekilmisdurum);
            this.grpParacek.Controls.Add(this.txtCekilecektutar);
            this.grpParacek.Controls.Add(this.txtGuncelParaParacek);
            this.grpParacek.Controls.Add(this.btnOnaylaparacek);
            this.grpParacek.Controls.Add(this.label4);
            this.grpParacek.Controls.Add(this.label5);
            this.grpParacek.Controls.Add(this.label6);
            this.grpParacek.Location = new System.Drawing.Point(87, 216);
            this.grpParacek.Name = "grpParacek";
            this.grpParacek.Size = new System.Drawing.Size(310, 138);
            this.grpParacek.TabIndex = 2;
            this.grpParacek.TabStop = false;
            this.grpParacek.Text = "Para Çek";
            // 
            // txtCekilmisdurum
            // 
            this.txtCekilmisdurum.Enabled = false;
            this.txtCekilmisdurum.Location = new System.Drawing.Point(99, 80);
            this.txtCekilmisdurum.Name = "txtCekilmisdurum";
            this.txtCekilmisdurum.Properties.Mask.EditMask = "c3";
            this.txtCekilmisdurum.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCekilmisdurum.Size = new System.Drawing.Size(172, 20);
            this.txtCekilmisdurum.TabIndex = 4;
            // 
            // txtCekilecektutar
            // 
            this.txtCekilecektutar.EditValue = "0";
            this.txtCekilecektutar.Location = new System.Drawing.Point(99, 53);
            this.txtCekilecektutar.Name = "txtCekilecektutar";
            this.txtCekilecektutar.Properties.Mask.EditMask = "d";
            this.txtCekilecektutar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCekilecektutar.Size = new System.Drawing.Size(172, 20);
            this.txtCekilecektutar.TabIndex = 4;
            this.txtCekilecektutar.TextChanged += new System.EventHandler(this.txtCekilecektutar_TextChanged);
            // 
            // txtGuncelParaParacek
            // 
            this.txtGuncelParaParacek.Enabled = false;
            this.txtGuncelParaParacek.Location = new System.Drawing.Point(99, 26);
            this.txtGuncelParaParacek.Name = "txtGuncelParaParacek";
            this.txtGuncelParaParacek.Properties.Mask.EditMask = "c3";
            this.txtGuncelParaParacek.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGuncelParaParacek.Size = new System.Drawing.Size(172, 20);
            this.txtGuncelParaParacek.TabIndex = 4;
            // 
            // btnOnaylaparacek
            // 
            this.btnOnaylaparacek.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOnaylaparacek.ImageOptions.Image")));
            this.btnOnaylaparacek.Location = new System.Drawing.Point(99, 106);
            this.btnOnaylaparacek.Name = "btnOnaylaparacek";
            this.btnOnaylaparacek.Size = new System.Drawing.Size(172, 23);
            this.btnOnaylaparacek.TabIndex = 3;
            this.btnOnaylaparacek.Text = "Onayla";
            this.btnOnaylaparacek.Click += new System.EventHandler(this.btnOnaylaparacek_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Çekilmiş Durum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Çekilecek Tutar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Güncel Para";
            // 
            // txtPara
            // 
            this.txtPara.Enabled = false;
            this.txtPara.Location = new System.Drawing.Point(186, 67);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(172, 20);
            this.txtPara.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(61, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Güncel Kasada ki Para ";
            // 
            // txtSatilan
            // 
            this.txtSatilan.Enabled = false;
            this.txtSatilan.Location = new System.Drawing.Point(186, 93);
            this.txtSatilan.Name = "txtSatilan";
            this.txtSatilan.Size = new System.Drawing.Size(172, 20);
            this.txtSatilan.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Satılan Daire Sayısı";
            // 
            // txtKiralanan
            // 
            this.txtKiralanan.Enabled = false;
            this.txtKiralanan.Location = new System.Drawing.Point(186, 119);
            this.txtKiralanan.Name = "txtKiralanan";
            this.txtKiralanan.Size = new System.Drawing.Size(172, 20);
            this.txtKiralanan.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(61, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Kiralanan Daire Sayısı";
            // 
            // Resim
            // 
            this.Resim.Image = ((System.Drawing.Image)(resources.GetObject("Resim.Image")));
            this.Resim.Location = new System.Drawing.Point(86, 216);
            this.Resim.Name = "Resim";
            this.Resim.Size = new System.Drawing.Size(310, 138);
            this.Resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Resim.TabIndex = 5;
            this.Resim.TabStop = false;
            // 
            // ParaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 366);
            this.Controls.Add(this.Resim);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKiralanan);
            this.Controls.Add(this.txtSatilan);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.grpParaekle);
            this.Controls.Add(this.grpParacek);
            this.Controls.Add(this.rdParacek);
            this.Controls.Add(this.rdParaekle);
            this.Controls.Add(this.Grafik);
            this.Name = "ParaIslemleri";
            this.Text = "ParaIslemleri";
            this.Load += new System.EventHandler(this.ParaIslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grafik)).EndInit();
            this.grpParaekle.ResumeLayout(false);
            this.grpParaekle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtEklenmisdurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEklenecektutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGuncelParaParaekle.Properties)).EndInit();
            this.grpParacek.ResumeLayout(false);
            this.grpParacek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekilmisdurum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekilecektutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGuncelParaParacek.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPara.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatilan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKiralanan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Grafik;
        private System.Windows.Forms.RadioButton rdParaekle;
        private System.Windows.Forms.RadioButton rdParacek;
        private System.Windows.Forms.GroupBox grpParaekle;
        private DevExpress.XtraEditors.SimpleButton btnOnaylaPraekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpParacek;
        private DevExpress.XtraEditors.SimpleButton btnOnaylaparacek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtEklenmisdurum;
        private DevExpress.XtraEditors.TextEdit txtEklenecektutar;
        private DevExpress.XtraEditors.TextEdit txtGuncelParaParaekle;
        private DevExpress.XtraEditors.TextEdit txtCekilmisdurum;
        private DevExpress.XtraEditors.TextEdit txtCekilecektutar;
        private DevExpress.XtraEditors.TextEdit txtGuncelParaParacek;
        private DevExpress.XtraEditors.TextEdit txtPara;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtSatilan;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit txtKiralanan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox Resim;
    }
}