using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace fabrika.logs.Services
{
   static  class addnewitemsservices
    {
        public static bool addnewitems(string name , int number , double money1 , double money2 , double money3)
        {
            return DBHelper.excutedata("itemadd", () => itemsaddparameter( name, number, money1, money2, money3, DBHelper.cmd)); 
        }
        public static void itemsaddparameter( string name , int number , double money1 , double money2 , double money3 ,SqlCommand cmd)
        {
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@number", SqlDbType.Int).Value = number;
            cmd.Parameters.Add("@money1", SqlDbType.Real).Value = money1;
            cmd.Parameters.Add("@money2", SqlDbType.Real).Value = money2;
            cmd.Parameters.Add("@money3", SqlDbType.Real).Value = money3;
        }
        public static DataTable getalldata()
        {
            return DBHelper.displaydata("itemdisplay", () => { });
        }
        public static DataTable search(string name )
        {
            return DBHelper.displaydata("search", () => searchparameter(name,  DBHelper.cmd));
        }
        public static void searchparameter(string name, SqlCommand cmd)
        {
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
        }
    }
}
