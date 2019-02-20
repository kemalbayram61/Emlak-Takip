using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SiteTakip
{
    class Kullanici
    {
        public string adisoyadi { get; set; }
        public string telefon { get; set; }
        public string eposta { get; set; }
        public string kullaniciadi { get; set; }
        public string sifre { get; set; }
        dbConnection baglanti;
      public bool SistemdeVarmi(string KullaniciAdi,string Sifre)
        {
            baglanti = new dbConnection();
            string GKadi,GSifre;
            string sorgu = "SELECT * FROM tblKullanici";
            DataTable dt = baglanti.executeSelectQuery(sorgu, null);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    GKadi = item["KULLANICIADI"].ToString().Trim();
                    GSifre =item["SIFRE"].ToString().Trim();
                    if (GKadi == KullaniciAdi && GSifre == Sifre) return true;
                }
            }
            return false;
        }
        public bool KullaniciKaydet(string[] Parametre)
        {
            baglanti = new dbConnection();
            string sorgu = "INSERT INTO tblKullanici (KULLANICIADI,SIFRE,ADISOYADI,TELEFON,EPOSTA) VALUES (@KULLANICIADI,@SIFRE,@ADISOYADI,@TELEFON,@EPOSTA)";
            SqlParameter[] parameter = new SqlParameter[5];
            parameter[0] = new SqlParameter("@KULLANICIADI", SqlDbType.NVarChar);
            parameter[0].Value = Parametre[0];
            parameter[1] = new SqlParameter("@SIFRE", SqlDbType.NVarChar);
            parameter[1].Value = Parametre[1];
            parameter[2] = new SqlParameter("@ADISOYADI", SqlDbType.NVarChar);
            parameter[2].Value = Parametre[2];
            parameter[3] = new SqlParameter("@TELEFON", SqlDbType.NVarChar);
            parameter[3].Value = Parametre[3];
            parameter[4] = new SqlParameter("@EPOSTA", SqlDbType.NVarChar);
            parameter[4].Value = Parametre[4];
            if (baglanti.executeInsertQuery(sorgu, parameter))
                return true;
            else
                return false;
        }
    }
}
