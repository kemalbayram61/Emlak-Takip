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
    public partial class KullaniciGirisi : DevExpress.XtraEditors.XtraForm
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            Mesaj mesaj = new Mesaj();

            if (kullanici.SistemdeVarmi(txtKullaniciadi.Text, txtSifre.Text))
            {
                acik.Visible = true;
                kilitli.Visible = false;
                timer1.Enabled = true;
                timer1.Start();
                
            }
            else
            {
                mesaj.KullaniciSistemdeYok();
            }
        }

        private void btnKayitol_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSifre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Kullanici kullanici = new Kullanici();
            if (e.KeyChar == 13 && kullanici.SistemdeVarmi(txtKullaniciadi.Text, txtSifre.Text))
            {
                acik.Visible = true;
                System.Threading.Thread.Sleep(1000);


            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AnaForm ana = new AnaForm();
            ana.Show();
            timer1.Enabled = false;
            timer1.Stop();
            this.Hide();
        }
    }
}