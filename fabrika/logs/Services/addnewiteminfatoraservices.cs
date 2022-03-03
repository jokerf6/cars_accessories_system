using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace fabrika.logs.Services
{
    static class addnewiteminfatoraservices
    {
        //***************************************************************************
        //*****************************************************get all data from temp
        public static DataTable getalldata()
        {
            return DBHelper.displaydata("fatoradisplay", () => { });
        }
        //*****************************************************************************
        //*****************************************************id fatora
        public static DataTable getdatafatora()
        {

            return DBHelper.displaydata("addfatoradisplay", () => { });
        }
        //******************************************************************************
        //****************************************************size el fawaterr
        public static DataTable addfatoradisplaycount()
        {

            return DBHelper.displaydata("addfatoradisplaycount", () => { });
        }
        //****************************************************************************
        //***********************************************add items
        public static bool additems(int id, string name, int number, decimal money1, decimal money2)
        {
            return DBHelper.excutedata("fatoraadd", () => additemsparameter(id, name, number, money1, money2, DBHelper.cmd));
        }
        public static void additemsparameter(int id, string name, int number, decimal money1, decimal money2,  SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@number", SqlDbType.Int).Value = number;
            cmd.Parameters.Add("@money1", SqlDbType.Real).Value = money1;
            cmd.Parameters.Add("@money2", SqlDbType.Real).Value = money2;
           
        }
        //*******************************************************//
        //***************************************************add fatora
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
        //*********************************************************//
        //******************************************* add items in fatora
        public static bool addinfatora()
        {

            return DBHelper.excutedata("addinfatora", () => { });
        }
        //***********************************************************
        //****************************************** update temp
        public static bool updatetemp(int fid)
        {
            return DBHelper.excutedata("updatetemp", () => updatetempparameter(fid, DBHelper.cmd));
        }
        public static void updatetempparameter(int fid , SqlCommand cmd)
        {
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = fid;
        }
        //********************************************************/
        //**********************************************delete temp
        public static bool deletetemp()
        {
            return DBHelper.excutedata("deletetemp", () => { });
        }
        //*********************************************************
        //****************************************sum of items
        public static DataTable count()
        {

            return DBHelper.displaydata("count", () => { });
        }
        //******************************************************
        //*****************************************edit temp
        public static bool tempupdate(int id, int number, decimal dis, decimal final)
        {
            return DBHelper.excutedata("tempupdate", () => tempupdateparameter(id, number, dis, final, DBHelper.cmd));
        }
        public static void tempupdateparameter(int id, int number, decimal dis, decimal final, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@number", SqlDbType.Int).Value = number;
            cmd.Parameters.Add("@dis", SqlDbType.Real).Value = dis;
            cmd.Parameters.Add("@final", SqlDbType.Real).Value = final;


        }
        //************************************************************
        //*********************************************get data from items
        public static DataTable getdata(int id)
        {

            return DBHelper.displaydata("additeminfatora", () => displaydataparameter(id, DBHelper.cmd));
        }
        public static void displaydataparameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        //*****************************************************************
        //*************************************************delete items from fatora

        public static bool deletefromfatora(int id)
        {
            return DBHelper.excutedata("deletefromfatora", () => deletefromfatoraparameter(id, DBHelper.cmd));
        }
        public static void deletefromfatoraparameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

        }
        //*****************************************************************
        //*************************************************search in temp

        public static DataTable searchintemp(int id)
        {
            return DBHelper.displaydata("searchintemp", () => searchintempparameter(id, DBHelper.cmd));
        }
        public static void searchintempparameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

        }
        //*******************************************************//
        //**************************************************add fatora commit
        public static bool fatorafinish1(DateTime date, int number, decimal dis, decimal final)
        {
            return DBHelper.excutedata("fatorafinish1", () => fatorafinish1parameter(date, number, dis, final, DBHelper.cmd));
        }
        public static void fatorafinish1parameter(DateTime date, int number, decimal dis, decimal final, SqlCommand cmd)
        {
            cmd.Parameters.Add("@date", SqlDbType.Date).Value = date;
            cmd.Parameters.Add("@number", SqlDbType.Int).Value = number;
            cmd.Parameters.Add("@dis", SqlDbType.Real).Value = dis;
            cmd.Parameters.Add("@final", SqlDbType.Real).Value = final;
        }
        //*****************************************************
        //*******************************************add items in fatora commit
        public static bool addinfatora1()
        {
            return DBHelper.excutedata("addinfatora1", () => { });
        }
        //**************************************************
        //**************************************update helper1
        public static bool updatetemp2(int fid)
        {
            return DBHelper.excutedata("updatetemp2", () => updatetemp2parameter(fid, DBHelper.cmd));
        }
        public static void updatetemp2parameter(int fid, SqlCommand cmd)
        {
            cmd.Parameters.Add("@fid", SqlDbType.Int).Value = fid;
        }
        //*****************************************************
        //*****************************************to add last id
        public static DataTable getdatafatora1()
        {

            return DBHelper.displaydata("addfatoradisplay1", () => { });
        }









        //******************************************************//
        //******************************************************//
        public static bool check(int id)
        {
            return DBHelper.excutedata("fatoraitemnumberdisplay", () => fatoraitemcheckparameter(id, DBHelper.cmd));
        }
        public static void fatoraitemcheckparameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
        }
        //******************************************************//
        //*******************************************************//
        public static DataTable lastrowinfatora()
        {

            return DBHelper.displaydata("lastrowinfatora", () => { });
        }
        //******************************************************//
        //*******************************************************//
        public static DataTable lastrowinfatora1()
        {

            return DBHelper.displaydata("lastrowinfatora1", () => { });
        }



        //******************************************************//
 
        //*******************************************************//

        //********************************************************//
        //*******************************************************//
        public static DataTable deletefromfatoracheck(int id,int id2)
        {
            return DBHelper.displaydata("deletefromfatoracheck", () => deletefromfatoracheckparameter(id,id2, DBHelper.cmd));
        }
        public static void deletefromfatoracheckparameter(int id,int id2, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id2;

        }

        //*******************************************************//

        //*******************************************************//
        //*******************************************************//
        public static bool deletefinish(int id)
        {
            return DBHelper.excutedata("deletefinish", () => deletefinishparameter(id , DBHelper.cmd));
        }
        public static void deletefinishparameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

        }
        //*******************************************************//
        //*******************************************************//
        public static DataTable editfatora(int id)
        {
            return DBHelper.displaydata("editfatora", () => editfatoraparameter(id , DBHelper.cmd));
        }
        public static void editfatoraparameter(int id, SqlCommand cmd)
        {
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

        }
        public static DataTable displayfatora1()
        {
            return DBHelper.displaydata("displayfatoraadd1", () => { });

        }


        //******************************************************//
        //*******************************************************//
        public static bool incitems(int x , int id)
        {
            return DBHelper.excutedata("incitems" , () => incitemsparameter(x ,id ,  DBHelper.cmd));
        }
        public static void incitemsparameter(int x ,int id ,  SqlCommand cmd)//37500
        {
            cmd.Parameters.Add("x" , SqlDbType.Int).Value = x;
            cmd.Parameters.Add("id", SqlDbType.Int).Value = id;

        }
        //************************************************//
        //*****************************************************
        public static DataTable itemssize(int id)
        {
            return DBHelper.displaydata("itemssize", () => itemssizeparameter(id, DBHelper.cmd));
        }
        public static void itemssizeparameter(int id , SqlCommand cmd)
        {
            cmd.Parameters.Add("id", SqlDbType.Int).Value = id;

        }
        //*****************************************************
        //*******************************************************compare
         public static DataTable compare(int id)
        {
            return DBHelper.displaydata("compare", () => compareparameter(id, DBHelper.cmd));
        }
        public static void compareparameter(int id , SqlCommand cmd)
        {
            cmd.Parameters.Add("id", SqlDbType.Int).Value = id;
        }
        //**************************************
        //********************************************
    }
}
