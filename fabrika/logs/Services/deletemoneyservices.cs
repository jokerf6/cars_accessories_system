using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace fabrika.logs.Services
{
    static class deletemoneyservices
    {
        public static bool masrdelete(string name, int number)
        {
            return DBHelper.excutedata("masrdelete", () => masrparameterdelete(name, number, DBHelper.cmd));
        }
        //this method to add delet parameters into stored procedure
        private static void masrparameterdelete(string name, double number,  SqlCommand cmd)
        {
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@number", SqlDbType.Real).Value = number;

        }
    }
}
