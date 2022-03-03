using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace fabrika.logs.Services
{
    static class fatoracommitservices
    {
        /// ********************************* عرض المنتجات
        public static DataTable getalldata(int id)
        {
            return DBHelper.displaydata("fatoracommitdisplay", () => fatoracommitdisplayparameter(id , DBHelper.cmd) );
        }
        public static void fatoracommitdisplayparameter(int id,  SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        //****************************************************************************************************************
        public static DataTable getalldata2()
        {
            return DBHelper.displaydata("fatoracommitdisplay1", () => { });
        }
        public static DataTable getdate(int id)
        {
            return DBHelper.displaydata("fatoracommitdate", () => fatoracommitdateparameter(id, DBHelper.cmd));
        }
        public static void fatoracommitdateparameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }

        //**************************************************اضافة عناصر ************************************//
        public static DataTable getdata(int id)
        {

            return DBHelper.displaydata("additeminfatora", () => displaydataparameter(id, DBHelper.cmd));
        }
        public static void displaydataparameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        ///////////////////////////////////////*************************************************************//
        public static bool additems1( int id, string name, int number, decimal money1, decimal money2, int fid)
        {
            return DBHelper.excutedata("fatoraadd1", () => additems1parameter(id, name, number, money1, money2, fid, DBHelper.cmd));
        }
        public static void additems1parameter(int id, string name, int number, decimal money1, decimal money2, int fid, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@number", SqlDbType.Int).Value = number;
            cmd.Parameters.Add("@money1", SqlDbType.Real).Value = money1;
            cmd.Parameters.Add("@money2", SqlDbType.Real).Value = money2;
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = fid;
        }
        //*******************************************************//
        //*******************************************************//

        public static bool deletefromfatora(int id, int id2)
        {
            return DBHelper.excutedata("deletefromfatora1", () => deletefromfatoraparameter(id, id2, DBHelper.cmd));
        }
        public static void deletefromfatoraparameter(int id, int id2, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@id2", SqlDbType.Int).Value = id2;

        }
        //********************************************************//
        //*******************************************************//
        public static bool fatorafinish(DateTime date, int number, decimal dis, decimal final)
        {
            return DBHelper.excutedata("fatorafinish", () => fatorafinishparameter(date, number, dis, final, DBHelper.cmd));
        }
        public static void fatorafinishparameter(DateTime date, int number, decimal dis, decimal final, SqlCommand cmd)
        {
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@number", SqlDbType.Int).Value = number;
            cmd.Parameters.Add("@dis", SqlDbType.Real).Value = dis;
            cmd.Parameters.Add("@final", SqlDbType.Real).Value = final;
        }
        //********************************************************//
        //*******************************************************//
        public static DataTable fatorasize(int id)
        {

            return DBHelper.displaydata("fatorasize", () => fatorasizeparameter(id, DBHelper.cmd));
        }
        public static void fatorasizeparameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        public static bool fatoraupdate( int id, decimal dis, decimal final)
        {
            return DBHelper.excutedata("fatoraupdate", () => fatoraupdateparameter( id , dis, final, DBHelper.cmd));
        }
        public static void fatoraupdateparameter(int id, decimal dis, decimal final, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@dis", SqlDbType.Real).Value = dis;
            cmd.Parameters.Add("@final", SqlDbType.Real).Value = final;
        }
        public static DataTable fatora1sum(int id)
        {

            return DBHelper.displaydata("fatora1sum", () => fatora1sumparameter(id, DBHelper.cmd));
        }
        public static void fatora1sumparameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        public static DataTable firstrow()
        {
            return DBHelper.displaydata("firstrow", () => { });
        }
        //**************************************************اضافة عناصر ************************************//
        public static bool fh1totemp(int id)
        {
            return DBHelper.excutedata("fh1totemp", () => fh1totemp1parameter(id,  DBHelper.cmd));
        }
        public static void fh1totemp1parameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
   
        }
        public static DataTable lastrowinfatora()
        {

            return DBHelper.displaydata("lastrowinfatora", () => { });
        }
        public static DataTable getdatafatora()
        {

            return DBHelper.displaydata("addfatoradisplay", () => { });
        }
        public static bool temptofh1(int id)
        {
            return DBHelper.excutedata("temptofh1", () => temptofh1parameter(id, DBHelper.cmd));
        }
        public static void temptofh1parameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

        }
        public static DataTable fatorafinish1(int id)
        {

            return DBHelper.displaydata("deletefinish1", () => fatorafinish1parameter(id, DBHelper.cmd));
        }
        public static void fatorafinish1parameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        //*********************************************************************
        //*********************************update helper1
        public static bool updatehelper1(int fid ,  int id,int number ,  decimal dis, decimal final)
        {
            return DBHelper.excutedata("updatehelper1", () => updatehelper1parameter(fid , id,number , dis, final, DBHelper.cmd));
        }
        public static void updatehelper1parameter(int fid ,  int id,int number , decimal dis, decimal final, SqlCommand cmd)
        {
            cmd.Parameters.Add("fid" , SqlDbType.Int).Value = fid;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@number", SqlDbType.Int).Value = number;
            cmd.Parameters.Add("@dis", SqlDbType.Real).Value = dis;
            cmd.Parameters.Add("@final", SqlDbType.Real).Value = final;
        }
        //**********************************************************************
        //****************************search helper1
        public static DataTable searchhelper1(int id , int fid)
        {
            return DBHelper.displaydata("searchinhelper1",() => searchinhelper1parameters( id ,  fid , DBHelper.cmd) );
        }
        public static void searchinhelper1parameters(int id , int fid , SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = fid;
        }
        //********************************************************************
        //***************************************************
        //***********************************************helperitemsize
        public static DataTable helper1itemsize(int fid, int id)
        {

            return DBHelper.displaydata("helper1itemsize", () => helper1itemsizeparameter(fid, id, DBHelper.cmd));
        }
        public static void helper1itemsizeparameter(int fid, int id, SqlCommand cmd)
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
