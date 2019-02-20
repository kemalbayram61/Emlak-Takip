using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace SiteTakip
{
    public partial class Listeler : Form
    {
        public string Tabloadi;
        public int id;
        public Listeler()
        {
            InitializeComponent();
        }
        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) e.Handled = true;
        }

        private void Listeler_Load(object sender, EventArgs e)
        {
            grpDaire.Visible = false;
            grpSite.Visible = false;
            grpApartman.Visible = false;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboFiltre.Text)
            {
                case "Daire":grpDaire.Visible = true;grpSite.Visible = false;grpApartman.Visible = false;Resim.Hide(); break;
                case "Site":
                    {
                        grpSite.Visible = true; grpDaire.Visible = false; grpApartman.Visible = false; Resim.Hide();
                        comboSiteler.Items.Clear();
                        site Site = new site();
                        List<site> Sitelistesi = Site.SiteleriGetir();
                        foreach (var item in Sitelistesi)
                        {
                            comboSiteler.Items.Add(item.siteAdi);
                        }
                        break;
                    }
                case "Apartman":
                    {
                        comboApartmanadi.Items.Clear();
                        apartman apart = new apartman();
                        grpApartman.Visible = true; grpDaire.Visible = false; grpSite.Visible = false; Resim.Hide(); 
                        List<apartman> ApartmalListesi =apart.ApartmanlariGetir(0);
                        foreach (var item in ApartmalListesi)
                        {
                            comboApartmanadi.Items.Add(item.adi);
                        }
                        break;
                    }
                default:grpApartman.Visible = false;grpDaire.Visible = false;grpSite.Visible = false;Resim.Show(); break;
            }
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            Tabloadi = comboFiltre.Text;
            gridControl1.DataSource = null;
            Daire daire = new Daire();
            apartman apart = new apartman();
            site Site = new site();
            int secenek=0;//1 kiralık 2 satılık 3 kiralanmış 4 satılmış
            switch (comboFiltre.Text)
            {
                case "Daire":
                    {
                        if (rdKiralik.Checked == true) secenek = 1;
                        if (rdSatilik.Checked == true) secenek=2;
                        if (rdKiralanmis.Checked == true) secenek=3;
                        if (rdSatilmis.Checked == true) secenek=4;
                        gridView1.Columns.Clear();
                        gridControl1.DataSource = daire.DaireTablosu(secenek);
                        break;
                    }
                case "Apartman":
                    {
                        string adi = comboApartmanadi.Text;
                        gridView1.Columns.Clear();
                        gridControl1.DataSource = apart.ApartmanTablosu(comboApartmanadi.Text);
                        break;
                    }
                case "Site":
                    {
                        string adi = comboSiteler.Text;
                        gridView1.Columns.Clear();
                        gridControl1.DataSource = Site.SiteTablosu(comboSiteler.Text);
                        break;
                    }
            }
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] Ozellikler;
            if (Tabloadi == "Apartman")
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                Ozellikler = new string[6];
                Ozellikler[0] = gridView1.GetFocusedRowCellValue("SITEID").ToString();
                Ozellikler[1] = gridView1.GetFocusedRowCellValue("ADI").ToString();
                Ozellikler[2] = gridView1.GetFocusedRowCellValue("KATDAIRE").ToString();
                Ozellikler[3] = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
                Ozellikler[4] = gridView1.GetFocusedRowCellValue("OZELLIKLER").ToString();
                Ozellikler[5] = gridView1.GetFocusedRowCellValue("KATSAYISI").ToString();
            }
            else if (Tabloadi == "Daire")
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                Ozellikler = new string[7];
                Ozellikler[0] = gridView1.GetFocusedRowCellValue("APARTMANID").ToString();
                Ozellikler[1] = gridView1.GetFocusedRowCellValue("ALAN").ToString();
                Ozellikler[2] = gridView1.GetFocusedRowCellValue("KATNUMARASI").ToString();
                Ozellikler[3] = gridView1.GetFocusedRowCellValue("TIPI").ToString();
                Ozellikler[4] = gridView1.GetFocusedRowCellValue("FIYAT").ToString();
                Ozellikler[5] = gridView1.GetFocusedRowCellValue("MUSTERINO").ToString();
                Ozellikler[6] = gridView1.GetFocusedRowCellValue("DAIRENO").ToString();

            }
            else if (Tabloadi == "Site")
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                Ozellikler = new string[7];
                Ozellikler[0] = gridView1.GetFocusedRowCellValue("ADI").ToString();
                Ozellikler[1] = gridView1.GetFocusedRowCellValue("OZELLIKLER").ToString();
                Ozellikler[2] = gridView1.GetFocusedRowCellValue("YONETICIADSOYAD").ToString();
                Ozellikler[3] = gridView1.GetFocusedRowCellValue("YONETICITELEFON").ToString();
                Ozellikler[4] = gridView1.GetFocusedRowCellValue("SITETELEFON").ToString();
                Ozellikler[5] = gridView1.GetFocusedRowCellValue("SITEADRES").ToString();
                Ozellikler[6] = gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
            }
            else Ozellikler = new string[3];
            GuncellemeEkranı guncel = new GuncellemeEkranı(id, Tabloadi, Ozellikler);
            guncel.Show();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbConnection baglanti = new dbConnection();
            if (Tabloadi == "Daire")
            {
                string sorgu = "delete from tblDaire where ID='"+Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"))+"'";
                SqlCommand komut = new SqlCommand(sorgu, baglanti.Baglanti());
                komut.ExecuteNonQuery();
                baglanti.Baglanti().Close();
                MessageBox.Show("Silindi");
                
            }
            else if (Tabloadi == "Site")
            {
                Daire daire = new Daire();
                apartman apart = new apartman();
                int siteid = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));

                string sorgu;
                SqlCommand komut;

                int[] apartmanlar = apart.ApartmanIdleri(siteid);
                for(int i = 0; i < apartmanlar.Length; i++)
                {
                    sorgu = "delete from tblDaire where APARTMANID='" + apartmanlar[i] + "'";//dairedende apartman ıdyi silme
                    komut = new SqlCommand(sorgu, baglanti.Baglanti());
                    komut.ExecuteNonQuery();
                }

                sorgu = "delete from tblApartman where SITEID='" + siteid + "'";//o site id deki apartmanları silme
                komut = new SqlCommand(sorgu, baglanti.Baglanti());
                komut.ExecuteNonQuery();

                sorgu = "delete from tblSite where ID='" + siteid + "'";
                komut = new SqlCommand(sorgu, baglanti.Baglanti());
                komut.ExecuteNonQuery();

                MessageBox.Show("Silindi");
                baglanti.Baglanti().Close();
            }
            else if (Tabloadi == "Apartman")
            {

                int apartmanid = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));

                string sorgu;
                SqlCommand komut;

                sorgu = "delete from tblDaire where APARTMANID='" + apartmanid + "'";
                komut = new SqlCommand(sorgu, baglanti.Baglanti());
                komut.ExecuteNonQuery();

                sorgu = "delete from tblApartman where ID='" + apartmanid + "'";
                komut = new SqlCommand(sorgu, baglanti.Baglanti());
                komut.ExecuteNonQuery();

                MessageBox.Show("Silindi..");
                baglanti.Baglanti().Close();
            }
        }
    }
}
