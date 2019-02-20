using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteTakip
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Mesaj mesaj = new Mesaj();
            bool durum = true;
            if (txtAdi.Text == "") durum = false;
            if (txtSoyadi.Text == "") durum = false;
            if (txtTelefon.Text == "") durum = false;
            if (txtadres.Text == "") durum = false;
            if (txtTarih.Text == "") durum = false;
            if (durum == true)
            {
                if (mesaj.KayitEklemeOnay())
                {
                    musteri mst = new musteri();
                    mst.adisoyadi = txtAdi.Text.Trim() + " " + txtSoyadi.Text.Trim();
                    mst.tarih = Convert.ToDateTime(txtTarih.Text);
                    mst.adres = txtadres.Text;
                    mst.telefon = txtTelefon.Text;
                    mst.daireid = 0;
                    if (mst.Kaydet()) mesaj.KayitYapildi();
                    else mesaj.KayitYapilmadi();
                }
            }
            else mesaj.BosAlan();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtTelefon.Text = "";
            txtadres.Text = "";
            txtTarih.Text = "";
        }

        private void txtAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)) e.Handled = true;
        }

    }
}
