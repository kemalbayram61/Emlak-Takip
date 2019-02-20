namespace SiteTakip
{
    partial class Listeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listeler));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFiltre = new System.Windows.Forms.ComboBox();
            this.grpDaire = new DevExpress.XtraEditors.GroupControl();
            this.rdSatilmis = new System.Windows.Forms.RadioButton();
            this.rdKiralanmis = new System.Windows.Forms.RadioButton();
            this.rdSatilik = new System.Windows.Forms.RadioButton();
            this.rdKiralik = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFiltrele = new DevExpress.XtraEditors.SimpleButton();
            this.grpSite = new DevExpress.XtraEditors.GroupControl();
            this.comboSiteler = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpApartman = new DevExpress.XtraEditors.GroupControl();
            this.comboApartmanadi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Resim = new System.Windows.Forms.PictureBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.güncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDaire)).BeginInit();
            this.grpDaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSite)).BeginInit();
            this.grpSite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpApartman)).BeginInit();
            this.grpApartman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.comboFiltre);
            this.groupControl1.Location = new System.Drawing.Point(13, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(190, 97);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Filtreler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Neye Göre Filtrelensin ?";
            // 
            // comboFiltre
            // 
            this.comboFiltre.FormattingEnabled = true;
            this.comboFiltre.Items.AddRange(new object[] {
            "Daire",
            "Site",
            "Apartman"});
            this.comboFiltre.Location = new System.Drawing.Point(5, 56);
            this.comboFiltre.Name = "comboFiltre";
            this.comboFiltre.Size = new System.Drawing.Size(180, 21);
            this.comboFiltre.TabIndex = 0;
            this.comboFiltre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grpDaire
            // 
            this.grpDaire.Controls.Add(this.rdSatilmis);
            this.grpDaire.Controls.Add(this.rdKiralanmis);
            this.grpDaire.Controls.Add(this.rdSatilik);
            this.grpDaire.Controls.Add(this.rdKiralik);
            this.grpDaire.Controls.Add(this.label5);
            this.grpDaire.Location = new System.Drawing.Point(13, 127);
            this.grpDaire.Name = "grpDaire";
            this.grpDaire.Size = new System.Drawing.Size(190, 162);
            this.grpDaire.TabIndex = 2;
            this.grpDaire.Text = "Daire";
            // 
            // rdSatilmis
            // 
            this.rdSatilmis.AutoSize = true;
            this.rdSatilmis.Location = new System.Drawing.Point(9, 133);
            this.rdSatilmis.Name = "rdSatilmis";
            this.rdSatilmis.Size = new System.Drawing.Size(60, 17);
            this.rdSatilmis.TabIndex = 3;
            this.rdSatilmis.TabStop = true;
            this.rdSatilmis.Text = "Satılmış";
            this.rdSatilmis.UseVisualStyleBackColor = true;
            // 
            // rdKiralanmis
            // 
            this.rdKiralanmis.AutoSize = true;
            this.rdKiralanmis.Location = new System.Drawing.Point(9, 106);
            this.rdKiralanmis.Name = "rdKiralanmis";
            this.rdKiralanmis.Size = new System.Drawing.Size(72, 17);
            this.rdKiralanmis.TabIndex = 3;
            this.rdKiralanmis.TabStop = true;
            this.rdKiralanmis.Text = "Kiralanmış";
            this.rdKiralanmis.UseVisualStyleBackColor = true;
            // 
            // rdSatilik
            // 
            this.rdSatilik.AutoSize = true;
            this.rdSatilik.Location = new System.Drawing.Point(9, 79);
            this.rdSatilik.Name = "rdSatilik";
            this.rdSatilik.Size = new System.Drawing.Size(52, 17);
            this.rdSatilik.TabIndex = 3;
            this.rdSatilik.TabStop = true;
            this.rdSatilik.Text = "Satılık";
            this.rdSatilik.UseVisualStyleBackColor = true;
            // 
            // rdKiralik
            // 
            this.rdKiralik.AutoSize = true;
            this.rdKiralik.Location = new System.Drawing.Point(9, 51);
            this.rdKiralik.Name = "rdKiralik";
            this.rdKiralik.Size = new System.Drawing.Size(52, 17);
            this.rdKiralik.TabIndex = 3;
            this.rdKiralik.TabStop = true;
            this.rdKiralik.Text = "Kiralık";
            this.rdKiralik.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Neye Göre Filtrelensin ?";
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrele.ImageOptions.Image")));
            this.btnFiltrele.Location = new System.Drawing.Point(18, 299);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(180, 47);
            this.btnFiltrele.TabIndex = 3;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // grpSite
            // 
            this.grpSite.Controls.Add(this.comboSiteler);
            this.grpSite.Controls.Add(this.label6);
            this.grpSite.Controls.Add(this.label4);
            this.grpSite.Location = new System.Drawing.Point(13, 127);
            this.grpSite.Name = "grpSite";
            this.grpSite.Size = new System.Drawing.Size(190, 162);
            this.grpSite.TabIndex = 2;
            this.grpSite.Text = "Site";
            // 
            // comboSiteler
            // 
            this.comboSiteler.FormattingEnabled = true;
            this.comboSiteler.Location = new System.Drawing.Point(9, 90);
            this.comboSiteler.Name = "comboSiteler";
            this.comboSiteler.Size = new System.Drawing.Size(176, 21);
            this.comboSiteler.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Neye Göre Filtrelensin ?";
            // 
            // grpApartman
            // 
            this.grpApartman.Controls.Add(this.comboApartmanadi);
            this.grpApartman.Controls.Add(this.label7);
            this.grpApartman.Controls.Add(this.label8);
            this.grpApartman.Location = new System.Drawing.Point(13, 127);
            this.grpApartman.Name = "grpApartman";
            this.grpApartman.Size = new System.Drawing.Size(190, 162);
            this.grpApartman.TabIndex = 2;
            this.grpApartman.Text = "Apartman";
            // 
            // comboApartmanadi
            // 
            this.comboApartmanadi.FormattingEnabled = true;
            this.comboApartmanadi.Location = new System.Drawing.Point(9, 70);
            this.comboApartmanadi.Name = "comboApartmanadi";
            this.comboApartmanadi.Size = new System.Drawing.Size(176, 21);
            this.comboApartmanadi.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Adı";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Neye Göre Filtrelensin ?";
            // 
            // Resim
            // 
            this.Resim.Image = ((System.Drawing.Image)(resources.GetObject("Resim.Image")));
            this.Resim.Location = new System.Drawing.Point(13, 127);
            this.Resim.Name = "Resim";
            this.Resim.Size = new System.Drawing.Size(190, 162);
            this.Resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Resim.TabIndex = 4;
            this.Resim.TabStop = false;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Location = new System.Drawing.Point(209, 13);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(692, 341);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.güncelleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            // 
            // güncelleToolStripMenuItem
            // 
            this.güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            this.güncelleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.güncelleToolStripMenuItem.Text = "Güncelle";
            this.güncelleToolStripMenuItem.Click += new System.EventHandler(this.güncelleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // Listeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 366);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.Resim);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.grpApartman);
            this.Controls.Add(this.grpSite);
            this.Controls.Add(this.grpDaire);
            this.Controls.Add(this.groupControl1);
            this.Name = "Listeler";
            this.Text = "Listeler";
            this.Load += new System.EventHandler(this.Listeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpDaire)).EndInit();
            this.grpDaire.ResumeLayout(false);
            this.grpDaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpSite)).EndInit();
            this.grpSite.ResumeLayout(false);
            this.grpSite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grpApartman)).EndInit();
            this.grpApartman.ResumeLayout(false);
            this.grpApartman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Resim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboFiltre;
        private DevExpress.XtraEditors.GroupControl grpDaire;
        private System.Windows.Forms.RadioButton rdSatilmis;
        private System.Windows.Forms.RadioButton rdKiralanmis;
        private System.Windows.Forms.RadioButton rdSatilik;
        private System.Windows.Forms.RadioButton rdKiralik;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnFiltrele;
        private DevExpress.XtraEditors.GroupControl grpSite;
        private System.Windows.Forms.ComboBox comboSiteler;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl grpApartman;
        private System.Windows.Forms.ComboBox comboApartmanadi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox Resim;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem güncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}