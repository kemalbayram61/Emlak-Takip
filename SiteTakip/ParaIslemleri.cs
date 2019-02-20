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
    public partial class ParaIslemleri : DevExpress.XtraEditors.XtraForm
    {
        public ParaIslemleri()
        {
            InitializeComponent();
        }

        private void ParaIslemleri_Load(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            foreach (var series in Grafik.Series)
            {
                series.Points.Clear();
            }
            Grafik.Series["Kiralanan"].Points.Add(kasa.KiralananDaire());
            Grafik.Series["Satilan"].Points.Add(kasa.SatilanDaire());
            Grafik.Series["Para"].Points.Add(kasa.GuncelPara()/10000);
            grpParacek.Visible = false;
            grpParaekle.Visible = false;
            txtGuncelParaParacek.Text = kasa.GuncelPara().ToString();
            txtGuncelParaParaekle.Text = kasa.GuncelPara().ToString();
            txtPara.Text = kasa.GuncelPara().ToString();
            txtSatilan.Text = kasa.SatilanDaire().ToString();
            txtKiralanan.Text = kasa.KiralananDaire().ToString();
        }

        private void rdParacek_CheckedChanged(object sender, EventArgs e)
        {
            grpParacek.Visible = true;
            grpParaekle.Visible = false;
            Resim.Hide();
        }

        private void rdParaekle_CheckedChanged(object sender, EventArgs e)
        {
            grpParaekle.Visible = true;
            grpParacek.Visible = false;
            Resim.Hide();
        }

        private void txtEklenecektutar_TextChanged(object sender, EventArgs e)
        {
            txtEklenmisdurum.Text = (Convert.ToInt32(txtEklenecektutar.Text) + Convert.ToInt32(txtGuncelParaParaekle.Text)).ToString();
        }

        private void txtCekilecektutar_TextChanged(object sender, EventArgs e)
        {
            txtCekilmisdurum.Text = (Convert.ToInt32(txtGuncelParaParacek.Text) - Convert.ToInt32(txtCekilecektutar.Text)).ToString();
        }

        private void btnOnaylaparacek_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            Kasaislem kasaislem = new Kasaislem();
            kasaislem.IslemAdi = "Para Cekme";
            kasaislem.ParaTutari = Convert.ToDecimal(txtCekilecektutar.Text);
            kasaislem.Kaydet();
            kasa.ParaIslem(Convert.ToInt32(txtCekilecektutar.Text), DateTime.Now, false);
            MessageBox.Show("Para Başarıyla Çekildi .", "Bildirim.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOnaylaPraekle_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();
            Kasaislem kasaislem = new Kasaislem();
            kasaislem.IslemAdi = "Para Yatırma";
            kasaislem.ParaTutari = Convert.ToDecimal(txtEklenecektutar.Text);
            kasaislem.Kaydet();
            kasa.ParaIslem(Convert.ToInt32(txtEklenecektutar.Text),DateTime.Now,true);
            MessageBox.Show("Para Başarıyla Eklendi .", "Bildirim.", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
    }
}