using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace fabrika.logs.Services
{
    public class fatora11services
    {
        public static DataTable getalldata(int id)
        {
            return DBHelper.displaydata("fatoracommitdisplay", () => fatoracommitdisplayparameter(id, DBHelper.cmd));
        }
        public static void fatoracommitdisplayparameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        
        //********************************************************final , dis , date
        public static DataTable display(int id)
        {

            return DBHelper.displaydata("fatoracommitdate", () => displayparameter(id, DBHelper.cmd));
        }
        public static void displayparameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        //*********************************************************number
        public static DataTable number()
        {
            return DBHelper.displaydata("fatoracommitdisplay1", () => { });
        }
        //*******************************************************first row
        public static DataTable firstrow()
        {
            return DBHelper.displaydata("firstrow", () => { });
        }
        //***************************************************last row
        public static DataTable lastrowinfatora()
        {
            
            return DBHelper.displaydata("lastrowinfatora1", () => { });
        }

    }
}
