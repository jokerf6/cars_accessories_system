using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace fabrika.logs.Services
{
    static class fawaterservices
    {
        //*************************************************first id in this history
        public static DataTable firstid(DateTime date)
        {
            return DBHelper.displaydata("firstid", () => firstidparameter(date , DBHelper.cmd));
  
        }
        public static void firstidparameter(DateTime date, SqlCommand cmd)
        {
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
        }
        //*******************************************************
        //*************************************************display fatora history
        public static DataTable fawaterdisplay(int id)
        {
            return DBHelper.displaydata("fawaterdisplay", () => fawaterdisplayparameter(id, DBHelper.cmd));

        }
        public static void fawaterdisplayparameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        //*******************************************************
        //****************************************************fawater size
        public static DataTable fawatersize(DateTime date)
        {
            return DBHelper.displaydata("sizefawater", () => sizefawaterparameter(date, DBHelper.cmd));
        }
        public static void sizefawaterparameter(DateTime date , SqlCommand cmd)
        {
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
        }
        //************************************************************
        //******************************************************add items
        public static DataTable itemsdisplay(int id , int fid)
        {

            return DBHelper.displaydata("fawateritemdisplay", () => itemsdisplayparameter(id,fid, DBHelper.cmd));
        }
        public static void itemsdisplayparameter(int id,int fid ,  SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = fid;

        }
        //*****************************************************************
        //******************************************************update helper fawater
        public static bool updatehelperfawater(int number , decimal dis , decimal final,int id, int fid)
        {

            return DBHelper.excutedata("updatehelperfawater", () => updatehelperfawaterparameter(number , dis , final , id, fid, DBHelper.cmd));
        }
        public static void updatehelperfawaterparameter(int number, decimal dis, decimal final, int id, int fid, SqlCommand cmd)
        {
            cmd.Parameters.Add("@number", SqlDbType.Int).Value = number;
            cmd.Parameters.Add("@dis", SqlDbType.Real).Value = dis;
            cmd.Parameters.Add("@final", SqlDbType.Real).Value = final;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = fid;

        }
        //*****************************************************************
        //******************************************************delete item fawater
        public static bool deleteitemfawater(int id, int fid)
        {

            return DBHelper.excutedata("deleteitemfawater", () => deleteitemfawaterparameter( id, fid, DBHelper.cmd));
        }
        public static void deleteitemfawaterparameter( int id, int fid, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = fid;

        }
        //*****************************************************************
        //******************************************************update fawater
        public static bool updatefawater( int fid , decimal x)
        {

            return DBHelper.excutedata("updatefawater", () => updatefawaterparameter(fid, x, DBHelper.cmd));
        }
        public static void updatefawaterparameter(int fid ,decimal x , SqlCommand cmd)
        {
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = fid;
            cmd.Parameters.Add("@x", SqlDbType.Real).Value = x;

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
        //************************************************************
        //******************************************************edit item fawater 
        public static DataTable edititemfawater(int id)
        {

            return DBHelper.displaydata("edit_item_fatora", () => edititemfawaterparameter(id, DBHelper.cmd));
        }
        public static void edititemfawaterparameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

        }
        //*****************************************************************
        //******************************************************delete fawater
        public static bool deletefawater(int fid)
        {

            return DBHelper.excutedata("deletefawater", () => deletefawaterparameter(fid,  DBHelper.cmd));
        }
        public static void deletefawaterparameter(int fid, SqlCommand cmd)
        {
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = fid;

        }
        //*****************************************************************
        //******************************************************fatora size
        public static DataTable fatorasize(int fid)
        {

            return DBHelper.displaydata("fatoras", () => fatorasizeparameter(fid, DBHelper.cmd));
        }
        public static void fatorasizeparameter(int fid, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = fid;

        }
        //***************************************************
        //***********************************************helperitemsize
        public static DataTable helperitemsize(int fid, int id)
        {

            return DBHelper.displaydata("helperitemsize", () => helperitemsizeparameter(fid, id, DBHelper.cmd));
        }
        public static void helperitemsizeparameter(int fid, int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = fid;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

        }
        //******************************************************//
        //*******************************************************//
        public static bool incitems(int x, int id)
        {
            return DBHelper.excutedata("incitems", () => incitemsparameter(x, id, DBHelper.cmd));
        }
        public static void incitemsparameter(int x, int id, SqlCommand cmd)//37500
        {
            cmd.Parameters.Add("x", SqlDbType.Int).Value = x;
            cmd.Parameters.Add("id", SqlDbType.Int).Value = id;

        }
        //**************************************************
        //************************************************item size
        public static DataTable itemssize(int id)
        {
            return DBHelper.displaydata("itemssize", () => itemssizeparameter(id, DBHelper.cmd));
        }
        public static void itemssizeparameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("id", SqlDbType.Int).Value = id;

        }
        
    }
}
