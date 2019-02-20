using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SiteTakip
{
    class site
    {
        dbConnection baglanti;
        public string siteAdi { get; set; }
        public string ozellikler { get; set; }
        public string siteTelefon { get; set; }
        public string yoneticiAdiSoyadi { get; set; }
        public string yoneticiTelefon { get; set; }
        public string adres { get; set; }
        public string acıklama { get; set; }
        public int id { get; set; }
        public List<site> SiteleriGetir()
        {
            baglanti = new dbConnection();
            site Site = new site();
            List<site> SiteListesi = new List<site>();
            string sorgu = "SELECT * FROM tblSite";
            DataTable dt = baglanti.executeSelectQuery(sorgu, null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    Site = new site();
                    Site.id = Convert.ToInt32(item["ID"]);
                    Site.siteAdi = item["ADI"].ToString();
                    SiteListesi.Add(Site);
                }
            }
            return SiteListesi;

        }
        public bool Kaydet()
        {

            baglanti = new dbConnection();
            string sorgu = "INSERT INTO tblSite (ADI,OZELLIKLER,YONETICIADSOYAD,YONETICITELEFON,SITETELEFON,SITEADRES,ACIKLAMA) VALUES (@ADI,@OZELLIKLER,@YONETICIADSOYAD,@YONETICITELEFON,@SITETELEFON,@SITEADRES,@ACIKLAMA)";
            SqlParameter[] parameter = new SqlParameter[7];
            parameter[0] = new SqlParameter("@ADI", SqlDbType.NVarChar);
            parameter[0].Value = siteAdi;
            parameter[1] = new SqlParameter("@OZELLIKLER", SqlDbType.NVarChar);
            parameter[1].Value = ozellikler;
            parameter[2] = new SqlParameter("@YONETICIADSOYAD", SqlDbType.NVarChar);
            parameter[2].Value = yoneticiAdiSoyadi;
            parameter[3] = new SqlParameter("@YONETICITELEFON", SqlDbType.NVarChar);
            parameter[3].Value = yoneticiTelefon;
            parameter[4] = new SqlParameter("@SITETELEFON", SqlDbType.NVarChar);
            parameter[4].Value = siteTelefon;
            parameter[5] = new SqlParameter("@SITEADRES", SqlDbType.NVarChar);
            parameter[5].Value = adres;
            parameter[6] = new SqlParameter("@ACIKLAMA", SqlDbType.Text);
            parameter[6].Value = acıklama;
            if (baglanti.executeInsertQuery(sorgu, parameter))
                return true;
            else
                return false;
        }
        public int SiteId(string isim)
        {
            baglanti = new dbConnection();
            string sorgu = "SELECT * FROM tblSite";
            DataTable dt = baglanti.executeSelectQuery(sorgu, null);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (item["ADI"].ToString().Trim() == isim.Trim()) return Convert.ToInt32(item["ID"]);
                }
            }
            return 0;
        }
        public DataTable SiteTablosu(string Adi = "")
        {
            dbConnection baglanti = new dbConnection();
            string sorgu;
            if (Adi != "") sorgu = "select * from tblSite where ADI='" + Adi + "'";
            else sorgu = "select * from tblSite";
            SqlDataAdapter da = new SqlDataAdapter(sorgu,baglanti.Baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Guncelle(int ID,string[] Yeniler)
        {
            baglanti = new dbConnection();
            string sorgu = "update tblSite set ADI=@ADI,OZELLIKLER=@OZELLIKLER,YONETICIADSOYAD=@YONETICIADSOYAD,YONETICITELEFON=@YONETICITELEFON,SITETELEFON=@SITETELEFON,SITEADRES=@SITEADRES,ACIKLAMA=@ACIKLAMA where ID=@ID";
            SqlParameter[] parameter = new SqlParameter[8];
            parameter[0] = new SqlParameter("@ADI", SqlDbType.NChar);
            parameter[0].Value = Yeniler[0];
            parameter[1] = new SqlParameter("@OZELLIKLER", SqlDbType.Text);
            parameter[1].Value = Yeniler[1];
            parameter[2] = new SqlParameter("@YONETICIADSOYAD", SqlDbType.NChar);
            parameter[2].Value = Yeniler[2];
            parameter[3] = new SqlParameter("@YONETICITELEFON", SqlDbType.NChar);
            parameter[3].Value = Yeniler[3];
            parameter[4] = new SqlParameter("@SITETELEFON", SqlDbType.NChar);
            parameter[4].Value = Yeniler[4];
            parameter[5] = new SqlParameter("@SITEADRES", SqlDbType.NChar);
            parameter[5].Value = Yeniler[5];
            parameter[6] = new SqlParameter("@ACIKLAMA", SqlDbType.Text);
            parameter[6].Value = Yeniler[6];
            parameter[7] = new SqlParameter("@ID", SqlDbType.Int);
            parameter[7].Value = ID;
            return baglanti.executeUpdateQuery(sorgu, parameter);
        }
    }
}
