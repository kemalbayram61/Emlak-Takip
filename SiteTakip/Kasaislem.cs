using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace SiteTakip
{
    class Kasaislem
    {
        dbConnection Baglanti;
        public string IslemAdi { get; set; }
        public decimal ParaTutari { get; set; }
        public bool Kaydet()
        {
            Baglanti = new dbConnection();
            string sorgu = "insert into tblKasaislem(ISLEMADI,PARATUTARI)values(@ISLEMADI,@PARATUTARI)";
            SqlParameter[] parameter = new SqlParameter[2];
            parameter[0] = new SqlParameter("@ISLEMADI", SqlDbType.NChar);
            parameter[0].Value = IslemAdi;
            parameter[1] = new SqlParameter("@PARATUTARI", SqlDbType.Decimal);
            parameter[1].Value = ParaTutari;
            Baglanti.executeInsertQuery(sorgu, parameter);
            return true;
        }
        public DataTable KasaIslemTablosu()
        {
            Baglanti = new dbConnection();
            string sorgu = "select * from tblKasaislem";
            SqlDataAdapter da = new SqlDataAdapter(sorgu,Baglanti.Baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
