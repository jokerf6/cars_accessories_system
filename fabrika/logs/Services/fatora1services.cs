using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace fabrika.logs.Services
{
    static class fatora1services
    {
        //*******************************************************
        //****************************************************fawater size
        public static DataTable fawatersize(DateTime date)
        {
            return DBHelper.displaydata("sizefawater", () => sizefawaterparameter(date, DBHelper.cmd));
        }
        public static void sizefawaterparameter(DateTime date, SqlCommand cmd)
        {
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
        }
        //*****************************************************
        //*************************************************display datagrid
        public static DataTable fawaterdisplay(int id)
        {
            return DBHelper.displaydata("fawaterdisplay", () => fawaterdisplayparameter(id, DBHelper.cmd));

        }
        public static void fawaterdisplayparameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        //*************************************************first id in this history
        public static DataTable firstid(DateTime date)
        {
            return DBHelper.displaydata("firstid", () => firstidparameter(date, DBHelper.cmd));

        }
        public static void firstidparameter(DateTime date, SqlCommand cmd)
        {
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
        }
        //*************************************************sumdis
        public static DataTable sumdis(DateTime date)
        {
            return DBHelper.displaydata("sumdis", () => sumdisparameter(date, DBHelper.cmd));

        }
        public static void sumdisparameter(DateTime date, SqlCommand cmd)
        {
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
        }
        //*************************************************sumfinal
        public static DataTable sumfinal(DateTime date)
        {
            return DBHelper.displaydata("sumfinal", () => sumfinalparameter(date, DBHelper.cmd));

        }
        public static void sumfinalparameter(DateTime date, SqlCommand cmd)
        {
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
        }
        //************************************************************
        //******************************************************fawater display final
        public static DataTable fawaterdisplayfinal(int fid)
        {

            return DBHelper.displaydata("fawaterdisplayfinal", () => fawaterdisplayfinalparameter(fid, DBHelper.cmd));
        }
        public static void fawaterdisplayfinalparameter(int fid, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = fid;

        }
        //************************************************************
        //******************************************************fawater display dis
        public static DataTable fawaterdisplaydis(int fid)
        {

            return DBHelper.displaydata("fawaterdisplaydis", () => fawaterdisplaydisparameter(fid, DBHelper.cmd));
        }
        public static void fawaterdisplaydisparameter(int fid, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = fid;

        }
        //*************************************************summasr
        public static DataTable summasr(DateTime date)
        {
            return DBHelper.displaydata("summasr", () => summasrparameter(date, DBHelper.cmd));

        }
       
        public static void summasrparameter(DateTime date, SqlCommand cmd)
        {
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
        }
        //****************************************************masrsize
        public static DataTable masrsize(DateTime date)
        {
            return DBHelper.displaydata("masrsize", () => masrsizeparameter(date, DBHelper.cmd));

        }
        public static void masrsizeparameter(DateTime date, SqlCommand cmd)
        {
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
        }
        
    }
}
