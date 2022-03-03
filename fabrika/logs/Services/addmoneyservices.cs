using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace fabrika.logs.Services
{
    static class addmoneyservices
    {
        public static bool masradd(string name , int money , DateTime date)
        {
          return  DBHelper.excutedata("masradd", () => masrparameteradd(name, money, date ,  DBHelper.cmd));
        }
        //this method to add insert parameters into stored procedure
        private static void masrparameteradd(string name , double number, DateTime date ,SqlCommand cmd)
        {
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@money", SqlDbType.Real).Value = number;
            cmd.Parameters.Add("@date", SqlDbType.DateTime).Value = date;

        }

    }
}
