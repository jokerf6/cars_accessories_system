using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrika.logs.Presenter
{
     class fawaterpresenter
    {
        form.Interface.fawaterinterface fipre;
        //******************************************connect between presenter and interface
      public fawaterpresenter(form.Interface.fawaterinterface view)
        {
            fipre = view;
        }
        //*****************************************first id in this date
        public int firstid()
        {
           return Convert.ToInt32( Services.fawaterservices.firstid(fipre.date).Rows[0][0]);
        }
        //******************************************get all data in grid
        public void fawaterdisplay()
        {
            fipre.datagrid = Services.fawaterservices.fawaterdisplay(fipre.row);
        }
        //*********************************************fawater size
        public int fawatersize()
        {
            return Convert.ToInt32(Services.fawaterservices.fawatersize(fipre.date).Rows[0][0]);
        }
        //*************************************************last row in fatora
        public int lastrow()
        {
            return Convert.ToInt32(Services.fawaterservices.firstid(fipre.date).Rows[fawatersize()-1][0]);
        }
        //****************************************************************
        //**************************************************add items
        public bool itemsdisplay()
        {
            if (Services.fawaterservices.itemsdisplay(fipre.id , fipre.row).Rows.Count == 0)
            {
                return false;
            }
            else
            {
                fipre.name = Convert.ToString(Services.fawaterservices.itemsdisplay(fipre.id,fipre.row).Rows[0][0]);
                fipre.number =Convert.ToInt32( Services.fawaterservices.itemsdisplay(fipre.id, fipre.row).Rows[0][1]);
                fipre.dis = Convert.ToDecimal(Services.fawaterservices.itemsdisplay(fipre.id, fipre.row).Rows[0][2]);
                fipre.price = Convert.ToDecimal(Services.fawaterservices.itemsdisplay(fipre.id,fipre.row).Rows[0][3]);
            return true;
            }
        }
        //*********************************************************************
        //****************************************************حساب الاسعار 
        public decimal edititemfawater()
        {
            return Convert.ToDecimal(Services.fawaterservices.edititemfawater(fipre.id).Rows[0][0]);

        }
        public decimal calculate1()
        {
            return (fipre.number * edititemfawater()) - fipre.dis;
        }
        public void calculate2()
        {
            fipre.price = calculate1();
        }
        //*****************************************************************
        ///********************************************************edit fawater
        public bool updateitemfawater()
        {
            return Services.fawaterservices.updatehelperfawater(fipre.number , fipre.dis , fipre.price , fipre.id , fipre.row);
        }
        //*****************************************************************
        ///********************************************************delete item fawater
        public bool deleteitemfawater()
        {
            return Services.fawaterservices.deleteitemfawater( fipre.id, fipre.row);
        }
        //*****************************************************************
        ///********************************************************update fawater
        public bool updatefawater()
        {

            return Services.fawaterservices.updatefawater(fipre.row , fipre.price);
        }
        //*****************************************************************
        ///********************************************************display fawater final
        public void fawaterdisplayfinal()
        {
            fipre.final = Convert.ToDecimal(Services.fawaterservices.fawaterdisplayfinal(fipre.row).Rows[0][0]);

        }
        //*****************************************************************
        ///********************************************************display fawater dis
        public decimal fawaterdisplaydis()
        {
            decimal x = Convert.ToDecimal(Services.fawaterservices.fawaterdisplaydis(fipre.row).Rows[0][0]);
            fipre.disfinal = x;
            return x;
        }
        //*****************************************************************
        ///********************************************************delete fawater 
        public void deletefawater()
        {
            Services.fawaterservices.deletefawater(fipre.row);
        }
        //*******************************************************************
        //************************************************fatora size
        public int fatorasize()
        {
            return Convert.ToInt32(Services.fawaterservices.fatorasize(fipre.row).Rows[0][0]);
        }
        //**************************************************************
        //**********************************************helperitemsize
        public int helperitemsize()
        {
            return Convert.ToInt32(Services.fawaterservices.helperitemsize(fipre.row, fipre.id).Rows[0][0]);
        }
        //***************************************************************
        //*********************************************itemsize
        public int itemssize()
        {
            return Convert.ToInt32(Services.addnewiteminfatoraservices.itemssize(fipre.id).Rows[0][0]);
        }
        //**************************************************************
        //**********************************************incitems
        public void incitems()
        {
            Services.fawaterservices.incitems(itemssize() + helperitemsize() , fipre.id);
            Services.fawaterservices.incitems(itemssize() - fipre.number, fipre.id);

        }
        //************************************************************
        //***********************************************decitems
        public void decitems()
        {
            Services.fawaterservices.incitems(itemssize() + helperitemsize(), fipre.id);
        }
        //*********************************************************
        //**********************************************decallitems
        public void decallitems()
        {
            int n = Services.fawaterservices.fawaterdisplay(fipre.row).Rows.Count;
            for (int i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(Services.fawaterservices.fawaterdisplay(fipre.row).Rows[i][2]);
                int y = Convert.ToInt32(Services.fawaterservices.fawaterdisplay(fipre.row).Rows[i][0]);
                int z = Convert.ToInt32(Services.addnewiteminfatoraservices.itemssize(y).Rows[0][0]);
                Services.addnewiteminfatoraservices.incitems(z + x, y);
            }
        }
    }
}
