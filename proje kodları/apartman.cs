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
    class apartman
    {
        dbConnection baglanti;
        public int id;
        public int siteid { get; set; }
        public string adi { get; set; }
        public int katdakidaire { get; set; }
        public string aciklama { get; set; }
        public int katsayisi { get; set; }
        public string ozellikler { get; set; }
        public string tipi { get; set; }
        public decimal fiyat { get; set; }
        public int alani { get; set; }
        public bool Kaydet()
        {
            bool durum;
            baglanti = new dbConnection();
            string sorgu = "INSERT INTO tblApartman (SITEID,ADI,KATDAIRE,ACIKLAMA,OZELLIKLER,KATSAYISI) VALUES(@SITEID,@ADI,@KATDAIRE,@ACIKLAMA,@OZELLIKLER,@KATSAYISI)";//apartman tablosu ekleme
            SqlParameter[] parameter = new SqlParameter[6];
            parameter[0] = new SqlParameter("@SITEID", SqlDbType.Int);
            parameter[0].Value = siteid;
            parameter[1] = new SqlParameter("@ADI", SqlDbType.Text);
            parameter[1].Value = adi;
            parameter[2] = new SqlParameter("@KATDAIRE", SqlDbType.Int);
            parameter[2].Value = katdakidaire;
            parameter[3] = new SqlParameter("@ACIKLAMA", SqlDbType.Text);
            parameter[3].Value = aciklama;
            parameter[4] = new SqlParameter("@OZELLIKLER", SqlDbType.Text);
            parameter[4].Value = ozellikler;
            parameter[5] = new SqlParameter("@KATSAYISI", SqlDbType.Int);
            parameter[5].Value = katsayisi;
            durum=baglanti.executeInsertQuery(sorgu, parameter);
            sorgu = "INSERT INTO tblDaire (APARTMANID,ALAN,KATNUMARASI,TIPI,FIYAT,MUSTERINO,DAIRENO) VALUES(@APARTMANID,@ALAN,@KATNUMARASI,@TIPI,@FIYAT,@MUSTERINO,@DAIRENO)";
            parameter = new SqlParameter[7];
            for (int i = 0; i < katsayisi; i++)
            {
                for (int j = 0; j < katdakidaire; j++)
                {
                    parameter[0] = new SqlParameter("@APARTMANID", SqlDbType.Int);
                    parameter[0].Value = ApartmanId(siteid, adi);
                    parameter[1] = new SqlParameter("@ALAN", SqlDbType.Int);
                    parameter[1].Value = alani;
                    parameter[2] = new SqlParameter("@KATNUMARASI", SqlDbType.Int);
                    parameter[2].Value = i+1;
                    parameter[3] = new SqlParameter("@TIPI", SqlDbType.Text);
                    parameter[3].Value = tipi;
                    parameter[4] = new SqlParameter("@FIYAT", SqlDbType.Decimal);
                    parameter[4].Value = fiyat;
                    parameter[5] = new SqlParameter("@MUSTERINO", SqlDbType.Int);
                    parameter[5].Value = 0;
                    parameter[6] = new SqlParameter("@DAIRENO", SqlDbType.Int);
                    parameter[6].Value = j+1;
                    durum = baglanti.executeInsertQuery(sorgu, parameter);
                }
            }

            return durum;
        }
        public int ApartmanId(int SiteId,string ApartmanAdi)
        {

            int aprtid=0,geciciid;

            string geciciisim;

            baglanti = new dbConnection();

            string sorgu = "SELECT * FROM tblApartman";

            DataTable dt = baglanti.executeSelectQuery(sorgu, null);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    geciciid = Convert.ToInt32(item["SITEID"]);
                    geciciisim = item["ADI"].ToString().Trim();
                    if (geciciid == SiteId && geciciisim == ApartmanAdi) aprtid =Convert.ToInt32(item["ID"]);
                }
            }
            return aprtid;
        }
        public List<apartman> ApartmanlariGetir(int siteid=0)
        {
            baglanti = new dbConnection();
            apartman apart = new apartman();
            List<apartman> ApartmanListesi = new List<apartman>();
            string sorgu = "SELECT * FROM tblApartman";
            DataTable dt = baglanti.executeSelectQuery(sorgu, null);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows) 
                {
                    if (siteid == Convert.ToInt32(item["SITEID"]) && siteid!=0)
                    {
                        apart = new apartman();
                        apart.id = Convert.ToInt32(item["ID"]);
                        apart.siteid = Convert.ToInt32(item["SITEID"]);
                        apart.katdakidaire = Convert.ToInt32(item["KATDAIRE"]);
                        apart.aciklama = item["ACIKLAMA"].ToString();
                        apart.ozellikler = item["OZELLIKLER"].ToString();
                        apart.adi = item["ADI"].ToString().Trim();
                        apart.katsayisi = Convert.ToInt32(item["KATSAYISI"]);
                        ApartmanListesi.Add(apart);
                    }
                    else if (siteid == 0)
                    {
                        apart = new apartman();
                        apart.id = Convert.ToInt32(item["ID"]);
                        apart.siteid = Convert.ToInt32(item["SITEID"]);
                        apart.katdakidaire = Convert.ToInt32(item["KATDAIRE"]);
                        apart.aciklama = item["ACIKLAMA"].ToString();
                        apart.ozellikler = item["OZELLIKLER"].ToString();
                        apart.adi = item["ADI"].ToString().Trim();
                        apart.katsayisi = Convert.ToInt32(item["KATSAYISI"]);
                        ApartmanListesi.Add(apart);
                    }
                }
            }
            return ApartmanListesi;
        }
        public int KatSayisi(int ApartmanId)
        {
            string sorgu = "SELECT * FROM tblApartman";
            DataTable dt = baglanti.executeSelectQuery(sorgu, null);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (Convert.ToInt32(item["ID"]) == ApartmanId) return Convert.ToInt32(item["KATSAYISI"]);
                }
            }
            return 0;
        }
        public int KatdakiDaire(int ApartmanId)
        {
            string sorgu = "SELECT * FROM tblApartman";
            DataTable dt = baglanti.executeSelectQuery(sorgu, null);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (Convert.ToInt32(item["ID"]) == ApartmanId) return Convert.ToInt32(item["KATDAIRE"]);
                }
            }
            return 0;
        }
        public DataTable ApartmanTablosu(string Adi="")
        {
            apartman apart = new apartman();
            dbConnection Baglanti = new dbConnection();
            SqlConnection baglanti = Baglanti.Baglanti();
            string sorgu;
            if (Adi != "") sorgu = "select * from tblApartman where ADI='" + Adi.ToString() + "'";
            else sorgu = "select * from tblApartman";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Guncelle(int ID,string[] Yeniler)
        {
            baglanti = new dbConnection();
            string sorgu = "update tblApartman set ADI=@ADI,ACIKLAMA=@ACIKLAMA,OZELLIKLER=@OZELLIKLER where ID=@ID";
            SqlParameter[] parameter = new SqlParameter[4];
            parameter[0] = new SqlParameter("@ADI", SqlDbType.NVarChar);
            parameter[0].Value = Yeniler[0];
            parameter[1] = new SqlParameter("@ACIKLAMA", SqlDbType.Text);
            parameter[1].Value = Yeniler[1];
            parameter[2] = new SqlParameter("@OZELLIKLER", SqlDbType.Text);
            parameter[2].Value = Yeniler[2];
            parameter[3] = new SqlParameter("@ID", SqlDbType.Int);
            parameter[3].Value = ID;
           return baglanti.executeUpdateQuery(sorgu, parameter);
       
        }
        public int[] ApartmanIdleri(int SiteId)
        {
            baglanti = new dbConnection();
            int sayac = 0;
            string sorgu = "select * from tblApartman";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.Baglanti());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                if (Convert.ToInt32(okuyucu["SITEID"]) == SiteId) sayac++;
                
            }
            int[] idler = new int[sayac];
            sayac = 0;
            sorgu = "select * from tblApartman";
             komut = new SqlCommand(sorgu, baglanti.Baglanti());
             okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                if (Convert.ToInt32(okuyucu["SITEID"]) == SiteId) { idler[sayac] = Convert.ToInt32(okuyucu["ID"]); sayac++; }
            }
            baglanti.Baglanti().Close();
            return idler;
        }
    }
}
