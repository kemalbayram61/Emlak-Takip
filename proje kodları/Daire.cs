using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SiteTakip
{
    class Daire
    {
        dbConnection baglanti = new dbConnection();
        public int id { get; set; }
        public int apartmanid { get; set; }
        public int alan { get; set; }
        public int katNumarasi { get; set; }
        public string tipi { get; set; }
        public decimal fiyat { get; set; }
        public int musteriNo { get; set; }
        public int daireNo { get; set; }
        public int DaireId(int ApartmanId, int Kat, int DaireNo)
        {
            int gid, gkat, gdaireno;
            string sorgu = "SELECT * FROM tblDaire";
            DataTable dt = baglanti.executeSelectQuery(sorgu, null);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    gid = Convert.ToInt32(item["APARTMANID"]);
                    gkat = Convert.ToInt32(item["KATNUMARASI"]);
                    gdaireno = Convert.ToInt32(item["DAIRENO"]);
                    if (gid == ApartmanId && gkat == Kat && gdaireno == DaireNo) return Convert.ToInt32(item["ID"]);
                }
            }
            return 0;
        }
        public string[] DaireDurumuVeFiyati(int ApartmanId)
        {
            string[] donus = new string[2];
            string sorgu = "SELECT * FROM tblDaire";
            DataTable dt = baglanti.executeSelectQuery(sorgu, null);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    if (Convert.ToInt32(item["APARTMANID"]) == ApartmanId) { donus[0] = item["TIPI"].ToString(); donus[1] = item["FIYAT"].ToString(); }
                }
            }
            return donus;
        }
        public bool MusteriIdGuncelle(int DaireId,int MusteriId)
        {
            baglanti = new dbConnection();
            string sorgu = "UPDATE tblDaire SET MUSTERINO='"+MusteriId+"' WHERE ID='"+DaireId+"'";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.Baglanti());
            komut.ExecuteNonQuery();
            
            return true;
           
        }
        public List<Daire> DaireListesi(int DaireID=0)
        {
            Daire daire;
            List<Daire> DaireListesi=new List<Daire>();
            baglanti = new dbConnection();
            string sorgu = "select * from tblDaire";
            SqlCommand komut = new SqlCommand(sorgu, baglanti.Baglanti());
            SqlDataReader okuyucu = komut.ExecuteReader();
            while (okuyucu.Read())
            {
                if (DaireID== 0)
                {
                    daire = new Daire();
                    daire.id = Convert.ToInt32(okuyucu["ID"]);
                    daire.apartmanid = Convert.ToInt32(okuyucu["APARTMANID"]);
                    daire.alan = Convert.ToInt32(okuyucu["ALAN"]);
                    daire.katNumarasi = Convert.ToInt32(okuyucu["KATNUMARASI"]);
                    daire.tipi = okuyucu["TIPI"].ToString();
                    daire.musteriNo = Convert.ToInt32(okuyucu["MUSTERINO"]);
                    daire.daireNo = Convert.ToInt32(okuyucu["DAIRENO"]);
                    DaireListesi.Add(daire);
                }
                else if(Convert.ToInt32(okuyucu["ID"])==DaireID)
                {
                    daire = new Daire();
                    daire.id = Convert.ToInt32(okuyucu["ID"]);
                    daire.apartmanid = Convert.ToInt32(okuyucu["APARTMANID"]);
                    daire.alan = Convert.ToInt32(okuyucu["ALAN"]);
                    daire.katNumarasi = Convert.ToInt32(okuyucu["KATNUMARASI"]);
                    daire.tipi = okuyucu["TIPI"].ToString();
                    daire.musteriNo = Convert.ToInt32(okuyucu["MUSTERINO"]);
                    daire.daireNo = Convert.ToInt32(okuyucu["DAIRENO"]);
                    DaireListesi.Add(daire);
                }
            }
            return DaireListesi;
        }
        public DataTable DaireTablosu(int Secenek=0)
        {
            dbConnection Baglanti = new dbConnection();
            string sorgu;
            if (Secenek == 1) sorgu = "select * from tblDaire where TIPI='" + "Kiralık" + "'";
            else if (Secenek == 2) sorgu = "select * from tblDaire where TIPI='" + "Satılık" + "'";
            else if (Secenek == 3) sorgu = "select * from tblDaire where TIPI='" + "Kiralık" + "' and MUSTERINO >'" + 0 + "'";
            else if (Secenek == 4) sorgu = "select * from tblDaire where TIPI='" + "Satılık" + "' and MUSTERINO >'" + 0 + "'";
            else sorgu = "select * from tblDaire";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, Baglanti.Baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool Guncelle(int ID, string[] Yeniler)
        {
            baglanti = new dbConnection();
            string sorgu = "update tblDaire set ALAN=@ALAN,TIPI=@TIPI,FIYAT=@FIYAT,MUSTERINO=@MUSTERINO where ID=@ID";
            SqlParameter[] parameter = new SqlParameter[5];
            parameter[0] = new SqlParameter("@ALAN", SqlDbType.Int);
            parameter[0].Value =Convert.ToInt32(Yeniler[0]);
            parameter[1] = new SqlParameter("@TIPI", SqlDbType.NChar);
            parameter[1].Value = Yeniler[1];
            parameter[2] = new SqlParameter("@FIYAT", SqlDbType.Decimal);
            parameter[2].Value =Convert.ToDecimal(Yeniler[2]);
            parameter[3] = new SqlParameter("@MUSTERINO", SqlDbType.Int);
            parameter[3].Value =Convert.ToInt32(Yeniler[3]);
            parameter[4] = new SqlParameter("@ID", SqlDbType.Int);
            parameter[4].Value = ID;
            return baglanti.executeUpdateQuery(sorgu, parameter);

        }
    }
}

