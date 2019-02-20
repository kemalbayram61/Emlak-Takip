using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SiteTakip
{
    class Mesaj
    {
        public bool KayitEklemeOnay()
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Kayıt Yapılsın mı?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes) return true;
            else return false;
        }
        public void KayitYapilmadi()
        {
            MessageBox.Show("Kayıt Yapılamıyor.", "Bildirim", MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
        public void KayitYapildi()
        {
            MessageBox.Show("Kayıt Başarıyla Kaydedildi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        public void BosAlan()
        {
            MessageBox.Show("Kayıt Yapılırken Bos Giriş Olamaz.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public bool CikisYapiliyor()
        {
            DialogResult sonuc = MessageBox.Show("Çıkış Yapılsın mı?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.Yes) return true;
            else return false;
        }
        public void KullaniciSistemdeYok()
        {
          MessageBox.Show("Girilen Kişi Sistemde yok?", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
