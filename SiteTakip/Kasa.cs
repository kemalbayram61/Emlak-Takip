using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SiteTakip
{
    class Kasa
    { 
        dbConnection Baglanti;
        public bool ParaIslem(decimal Para,DateTime Tarih,bool Durum)//durum true ise ekler false isa çıkarır
        {
            Kasa kasa = new Kasa();
            Baglanti = new dbConnection();
            int guncel = Durum == true ? kasa.GuncelPara() + Convert.ToInt32(Para) : kasa.GuncelPara() - Convert.ToInt32(Para);

                string Sorgu = "update tblKasa set PARA='" +guncel + "',ISLEMTARIHI=@ISLEMTARIHI where ID='"+2+"'";
            SqlCommand komut = new SqlCommand(Sorgu, Baglanti.Baglanti());
            komut.Parameters.AddWithValue("@ISLEMTARIHI", Tarih);
            komut.ExecuteNonQuery();

            return true;
        }
        public int GuncelPara()
        {
            dbConnection Baglanti= new dbConnection();
            int para=0;
            string Sorgu = "select PARA from tblKasa";
            SqlCommand komut = new SqlCommand(Sorgu, Baglanti.Baglanti());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read()) para = Convert.ToInt32(okuyucu["PARA"]);
            return para;
        }
        public DateTime SonIslemTarihi()
        {
            dbConnection baglanti = new dbConnection();
            DateTime tarih=DateTime.Now;
            string sorgu = "select ISLEMTARIHI from tblKasa ";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.Baglanti());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                tarih = Convert.ToDateTime(okuyucu["ISLEMTARIHI"]);
            }
            return tarih;
        }
        public int SatilanDaire()
        {
            int satilan = 0;
            dbConnection baglanti = new dbConnection();
            string sorgu = "select * from tblDaire";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.Baglanti());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                if (okuyucu["TIPI"].ToString().Trim() == "Satılık" && okuyucu["MUSTERINO"].ToString().Trim() != "0") satilan++;
            }
            return satilan;
        }
        public int KiralananDaire()
        {
            int kiralanan = 0;
            dbConnection baglanti = new dbConnection();
            string sorgu = "select * from tblDaire ";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.Baglanti());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                if (okuyucu["TIPI"].ToString().Trim() == "Kiralık" && okuyucu["MUSTERINO"].ToString().Trim() != "0") kiralanan++;
            }
            return kiralanan;
        }
    }
}
