using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SiteTakip
{
    class dbConnection
    {
            private SqlDataAdapter komut;
        public SqlConnection Baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=KEMAL-PC;Initial Catalog=SiteTakip;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
            public dbConnection()
            {
                komut = new SqlDataAdapter();
                SqlConnection baglanti = new SqlConnection("Data Source=KEMAL-PC;Initial Catalog=SiteTakip;Integrated Security=True");
                baglanti.Open();
            }


            private SqlConnection openConnection()
            {
                SqlConnection baglanti = new SqlConnection("Data Source=KEMAL-PC;Initial Catalog=SiteTakip;Integrated Security=True");

                if (baglanti.State == ConnectionState.Closed || baglanti.State == ConnectionState.Broken)
                {
                    baglanti.Open();
                }
                return baglanti;
            }
            public DataTable executeSelectQuery(String _query, SqlParameter[] sqlParameter)
            {
                SqlCommand sorgu = new SqlCommand();
                DataTable dataTable = new DataTable();
                dataTable = null;
                DataSet ds = new DataSet();
                try
                {
                    sorgu.Connection = openConnection();
                    sorgu.CommandText = _query;
                    if (sqlParameter != null)
                        sorgu.Parameters.AddRange(sqlParameter);
                    sorgu.ExecuteNonQuery();
                    komut.SelectCommand = sorgu;
                    komut.Fill(ds);
                    dataTable = ds.Tables[0];
                }
                catch (SqlException e)
                {
                    Console.Write("Error - Connection.executeSelectQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                    return null;
                }
                finally
                {

                }
                return dataTable;
            }

            public bool executeInsertQuery(String _query, SqlParameter[] sqlParameter)
            {
                SqlCommand sorgu = new SqlCommand();
                try
                {
                    sorgu.Connection = openConnection();
                    sorgu.CommandText = _query;
                    if (sqlParameter != null)
                        sorgu.Parameters.AddRange(sqlParameter);
                    komut.InsertCommand = sorgu;
                    sorgu.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.Write("Error - Connection.executeInsertQuery - Query: " + _query + " \nException: \n" + e.StackTrace.ToString());
                    return false;
                }
                finally
                {
                }
                return true;
            }

            public bool executeUpdateQuery(String _query, SqlParameter[] sqlParameter)
            {
                SqlCommand sorgu = new SqlCommand();
                try
                {
                    sorgu.Connection = openConnection();
                    sorgu.CommandText = _query;
                    sorgu.Parameters.AddRange(sqlParameter);
                    komut.UpdateCommand = sorgu;
                    sorgu.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.Write("Error - Connection.executeUpdateQuery - Query: " + _query + " \nException: " + e.StackTrace.ToString());
                    return false;
                }
                finally
                {
                }
                return true;
            }
    }
}
