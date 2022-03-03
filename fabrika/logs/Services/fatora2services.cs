using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace fabrika.logs.Services
{
    static class fatora2services
    {
        public static DataTable sum(DateTime date1, DateTime date2)
        {
            return DBHelper.displaydata("fatora3final", () => fatora3sumparameter(date1, date2, DBHelper.cmd));
        }
        public static void fatora3sumparameter(DateTime date1, DateTime date2, SqlCommand cmd)
        {
            cmd.Parameters.Add("date1", SqlDbType.Date).Value = date1;
            cmd.Parameters.Add("date2", SqlDbType.Date).Value = date2;

        }
        //**********************************************masr
        public static DataTable masr(DateTime date1, DateTime date2)
        {
            return DBHelper.displaydata("fatora3masr", () => fatora3masrparameter(date1, date2, DBHelper.cmd));
        }
        public static void fatora3masrparameter(DateTime date1, DateTime date2, SqlCommand cmd)
        {
            cmd.Parameters.Add("date1", SqlDbType.Date).Value = date1;
            cmd.Parameters.Add("date2", SqlDbType.Date).Value = date2;

        }
        //**************************************masrsize
        public static DataTable masrsize(DateTime date1, DateTime date2)
        {
            return DBHelper.displaydata("fatora3masrsize", () => fatora3masrsizeparameter(date1, date2, DBHelper.cmd));
        }
        public static void fatora3masrsizeparameter(DateTime date1, DateTime date2, SqlCommand cmd)
        {
            cmd.Parameters.Add("date1", SqlDbType.Date).Value = date1;
            cmd.Parameters.Add("date2", SqlDbType.Date).Value = date2;

        }
        //*********************************************finalsize
        public static DataTable sumsize(DateTime date1, DateTime date2)
        {
            return DBHelper.displaydata("fatora3sumsize", () => fatora3sumsizeparameter(date1, date2, DBHelper.cmd));
        }
        public static void fatora3sumsizeparameter(DateTime date1, DateTime date2, SqlCommand cmd)
        {
            cmd.Parameters.Add("date1", SqlDbType.Date).Value = date1;
            cmd.Parameters.Add("date2", SqlDbType.Date).Value = date2;

        }
    }
}
