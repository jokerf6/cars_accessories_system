using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace fabrika.logs.Services
{
    public static class DBHelper
    {
        public static SqlCommand cmd;

        //this method to get connection
        private static SqlConnection getConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = Properties.Settings.Default.servername;
            builder.InitialCatalog = Properties.Settings.Default.DBname;
            builder.IntegratedSecurity = true;
            return new SqlConnection(builder.ConnectionString);
        }
        public static bool excutedata(string spName , Action method)
        {
            SqlConnection conn = getConnectionString();
            try
            {
                cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                method.Invoke();
                
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception )
            {
                conn.Close();

                return false;
            }
            finally
            {
                conn.Close();
            }

        }
        public static DataTable displaydata(string spName, Action method)
        {
            DataTable t1 = new DataTable();
            SqlConnection conn = getConnectionString();
            try
            {
                cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;

                method.Invoke();

                conn.Open();
                t1.Load(cmd.ExecuteReader());
                conn.Close();
         
            }
            catch (Exception)
            {
                conn.Close();

            }
            finally
            {
                conn.Close();
            }
            return t1;
        }
    }
}
