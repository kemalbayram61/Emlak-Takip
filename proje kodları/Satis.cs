using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SiteTakip
{
    class Satis
    {
        dbConnection Baglanti;
        public int MusteriId { get; set; }
        public int DaireId { get; set; }
        public decimal Fiyat { get; set; }
        public string Tipi { get; set; }
        public DateTime Tarih { get; set; }
        public bool Kaydet()
        {
            Baglanti = new dbConnection();
            string sorgu = "insert into tblSatis(MUSTERIID,DAIREID,FIYAT,TIPI,TARIH)values(@MUSTERIID,@DAIREID,@FIYAT,@TIPI,@TARIH)";
            SqlParameter[] parameter = new SqlParameter[5];
            parameter[0] = new SqlParameter("@MUSTERIID", SqlDbType.Int);
            parameter[0].Value = MusteriId;
            parameter[1] = new SqlParameter("@DAIREID", SqlDbType.Int);
            parameter[1].Value = DaireId;
            parameter[2] = new SqlParameter("@FIYAT", SqlDbType.Decimal);
            parameter[2].Value = Fiyat;
            parameter[3] = new SqlParameter("@TIPI", SqlDbType.NVarChar);
            parameter[3].Value = Tipi;
            parameter[4] = new SqlParameter("@TARIH", SqlDbType.DateTime);
            parameter[4].Value = Tarih;
            Baglanti.executeInsertQuery(sorgu, parameter);
            return true;
        }
        public DataTable SatisIslemlerTablosu()
        {
            Baglanti = new dbConnection();
            string sorgu = "select * from tblSatis";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, Baglanti.Baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
