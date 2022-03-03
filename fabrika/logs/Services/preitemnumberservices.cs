using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace fabrika.logs.Services
{
    static class preitemnumberservices
    {
        public static DataTable getdata(int id)
        {
            
            return DBHelper.displaydata("preitemnumberdisplay", () => preitemnumberparameter(id , DBHelper.cmd));
        }
        public static void preitemnumberparameter(int id,  SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        //*******************************************************//
        //*******************************************************//
        public static bool preupdate(int id , string name , int number , decimal money1 , decimal money2 , decimal money3)
        {
            return DBHelper.excutedata("preitemadd", () => preitemupdateparameter(id , name,number , money1 , money2 , money3 ,  DBHelper.cmd));
        }
        public static void preitemupdateparameter(int id , string name ,int number , decimal money1 ,decimal money2 , decimal money3, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@number", SqlDbType.Int).Value = number;
            cmd.Parameters.Add("@money1", SqlDbType.Real).Value = money1;
            cmd.Parameters.Add("@money2", SqlDbType.Real).Value = money2;
            cmd.Parameters.Add("@money3", SqlDbType.Real).Value = money3;

        }

    }
}
