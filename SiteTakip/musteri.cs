using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SiteTakip
{
    class musteri
    {
        dbConnection baglanti;
        public int id { get; set; }
        public string adisoyadi { get; set; }
        public string telefon { get; set; }
        public string adres { get; set; }
        public DateTime tarih { get; set; }
        public int daireid { get; set; }
        public bool Kaydet()
        {
            baglanti = new dbConnection();
            string sorgu = "INSERT INTO tblMusteri (ADISOYADI,TELEFON,ADRES,TARIH,DAIREID) VALUES (@ADISOYADI,@TELEFON,@ADRES,@TARIH,@DAIREID)";
            SqlParameter[] parameter = new SqlParameter[5];
            parameter[0] = new SqlParameter("@ADISOYADI", SqlDbType.NVarChar);
            parameter[0].Value = adisoyadi;
            parameter[1] = new SqlParameter("@TELEFON", SqlDbType.NVarChar);
            parameter[1].Value = telefon;
            parameter[2] = new SqlParameter("@ADRES", SqlDbType.NVarChar);
            parameter[2].Value = adres;
            parameter[3] = new SqlParameter("@TARIH", SqlDbType.DateTime);
            parameter[3].Value = tarih;
            parameter[4] = new SqlParameter("@DAIREID", SqlDbType.Int);
            parameter[4].Value = daireid;
            if (baglanti.executeInsertQuery(sorgu, parameter))
                return true;
            else
                return false;
        }
        public bool DaireIdGuncelle(int MusteriID, int DaireId)
        {
            baglanti = new dbConnection();
            string sorgu = "UPDATE tblMusteri SET DAIREID='"+DaireId+"' WHERE ID='"+MusteriID+"'";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.Baglanti());
            komut.ExecuteNonQuery();

            return true;
        }
        public int MusteriId(string Telefon)
        {
            baglanti = new dbConnection();
            string sorgu = "SELECT * FROM tblMusteri";

            DataTable dt = baglanti.executeSelectQuery(sorgu, null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (Convert.ToString(item["TELEFON"]) == Telefon) { return Convert.ToInt32(item["ID"]); }
                }

            }
            return 0;
        }
        public List<musteri> Musterilistesi()
        {
            musteri must = new musteri();
            List<musteri> Musteri = new List<musteri>();
            baglanti = new dbConnection();
            string sorgu = "select * from tblMusteri";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.Baglanti());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                must.adisoyadi = okuyucu["ADISOYADI"].ToString();
                must.telefon = okuyucu["TELEFON"].ToString();
                must.id = Convert.ToInt32(okuyucu["ID"]);
                must.adres = okuyucu["ADRES"].ToString();
                must.tarih =Convert.ToDateTime(okuyucu["TARIH"]);
                must.daireid = Convert.ToInt32(okuyucu["DAIREID"]);
                Musteri.Add(must);
            }
            return Musteri;
        }
    }
}
