using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrika.logs.Presenter
{
     class fatoracommitpresenter
    {
        int x = -1;
        form.Interface.fatoracommitinerface ipre;
        model.fatoracommit mpre = new model.fatoracommit();
     public  fatoracommitpresenter(form.Interface.fatoracommitinerface view)
     {
            ipre = view;
     }
        public void getalldata()
        {
            ipre.datagrid = Services.fatoracommitservices.getalldata(ipre.row);
        }
        public int getalldata2()
        {
            return Convert.ToInt32( Services.fatoracommitservices.getalldata2().Rows[0][0]);
        }
        public void display()
        {
            ipre.datagrid = Services.fatoracommitservices.getalldata(getalldata2());
        }
        public void getadate()
        {
            
           
           ipre.date =Convert.ToDateTime (Services.fatoracommitservices.getdate(ipre.row).Rows[0][0]);
        }
        public void getdis()
        {
            ipre.dis = Convert.ToDecimal(Services.fatoracommitservices.getdate(ipre.row).Rows[0][1]);
        }
        public void getfinal()
        {
            ipre.final = Convert.ToDecimal(Services.fatoracommitservices.getdate(ipre.row).Rows[0][2]);
        }
        //*************************************************************************************************************************************
        //*************************************************اعرض العنصر س*****************************************************************************
        //*************************************************************************************************************************************
        public void autonumber()
        {
            ipre.itemname = Services.fatoracommitservices.getdata(ipre.itemid).Rows[0][0].ToString();
            ipre.itemsell = Convert.ToDecimal(Services.fatoracommitservices.getdata(ipre.itemid).Rows[0][1]);
        }
        public int size()
        {
            return Services.fatoracommitservices.getdata(ipre.itemid).Rows.Count;

        }
        public decimal bas()
        {
            decimal x = Convert.ToDecimal(Services.fatoracommitservices.getdata(ipre.itemid).Rows[0][1]);
            return x;
        }
        public decimal calculate1()
        {

            ipre.itemsell = (ipre.itemnumber * bas());
            return ipre.itemsell;
        }
        public void calculate2()
        {
            ipre.itemsell = calculate1() - ipre.itemdis;
        }
        public bool addnewitems()
        {
            return Services.fatoracommitservices.additems1(ipre.itemid, ipre.itemname, ipre.itemnumber, ipre.itemdis, ipre.itemsell, ipre.row) ;

        }
        public void deletefromfatora()
        {
            ipre.datagrid = Services.fatoracommitservices.deletefromfatora(ipre.itemid, ipre.row);
        }
        public bool fatorafinish()
        {
            return Services.fatoracommitservices.fatorafinish(ipre.fatoradate, ipre.fatoranumber2, ipre.fatoradis, ipre.fatorafinal);
        }
        public int fatorasize()
        {
            ipre.fatoranumber2 = Services.fatoracommitservices.fatorasize(ipre.row).Rows.Count ;
            return ipre.fatoranumber2;
        }
        //***********************************************************
        //***************************************تعديل الفاتورة 
        public bool updatefatora()
        {
            return Services.fatoracommitservices.fatoraupdate(ipre.row , ipre.fatoradis , ipre.fatorafinal);
        }
        //**********************************************************
        public void fatora1sum()
        {
            if (fatorasize() != 0)
            {
                ipre.fatorafinal = Convert.ToDecimal(Services.fatoracommitservices.fatora1sum(ipre.row).Rows[0][0]) - ipre.fatoradis;
            }
        }
        public int firtrow()
        {
            return  Convert.ToInt32( Services.fatoracommitservices.firstrow().Rows[0][0]);
            
        }
        public int lastrow()
        {
             return Convert.ToInt32(Services.fatoracommitservices.firstrow().Rows[getalldata2()-1][0]);
            
        }
        public bool fh1totemp()
        {
            return Services.fatoracommitservices.fh1totemp(ipre.row);
        }
        public int lastrowinfatora()
        {
            return Convert.ToInt32(Services.addnewiteminfatoraservices.lastrowinfatora().Rows[0][0]) - 1;
        }
        public int autonumber2()
        {
            int x = Convert.ToInt32(Services.addnewiteminfatoraservices.getdatafatora().Rows[lastrowinfatora()][0]) ;
            return x;
        }
        public bool temptofh1()
        {
            return Services.fatoracommitservices.temptofh1(autonumber2());
        }
        public void fatorafinish1()
        {
            Services.fatoracommitservices.fatorafinish1(ipre.row);
        }
        public bool updatehelper1()
        {
            return Services.fatoracommitservices.updatehelper1(ipre.row, ipre.itemid, ipre.itemnumber, ipre.itemdis, ipre.itemsell);
        }
        public int inorout()
        {
            return Services.fatoracommitservices.searchhelper1(ipre.itemid, ipre.row).Rows.Count;
        }
        public void predisplay()
        {
            ipre.itemname =Convert.ToString( Services.fatoracommitservices.searchhelper1(ipre.itemid, ipre.row).Rows[0][1]);
            ipre.itemnumber = Convert.ToInt32(Services.fatoracommitservices.searchhelper1(ipre.itemid, ipre.row).Rows[0][2]);
            ipre.itemdis = Convert.ToDecimal(Services.fatoracommitservices.searchhelper1(ipre.itemid, ipre.row).Rows[0][3]);
            ipre.itemsell = Convert.ToDecimal(Services.fatoracommitservices.searchhelper1(ipre.itemid, ipre.row).Rows[0][4]);

        }
        //**************************************************************
        //**********************************************helperitemsize
        public int helper1itemsize()
        {
            return Convert.ToInt32(Services.fatoracommitservices.helper1itemsize(ipre.row, ipre.itemid).Rows[0][0]);
        }
        //***************************************************************
        //*********************************************itemsize
        public int itemssize()
        {
            return Convert.ToInt32(Services.fatoracommitservices.itemssize(ipre.itemid).Rows[0][0]);
        }
        //**************************************************************
        //**********************************************incitems
        public void incitems()
        {
            Services.fatoracommitservices.incitems(itemssize() - ipre.itemnumber, ipre.itemid);

        }
        //**************************************************************
        //**********************************************incitems
        public void incitems2()
        {
            Services.fatoracommitservices.incitems(itemssize() + helper1itemsize(), ipre.itemid);
            Services.fatoracommitservices.incitems(itemssize() - ipre.itemnumber, ipre.itemid);

        }
        //************************************************************
        //***********************************************decitems
        public void decitems()
        {
            Services.fatoracommitservices.incitems(itemssize() + helper1itemsize(), ipre.itemid);
        }
        //*********************************************************
        //**********************************************decallitems
        public void decallitems()
        {
            int n = Services.fatoracommitservices.getalldata(ipre.row).Rows.Count;
            for (int i = 0; i < n; i++)
            {
                int x = Convert.ToInt32(Services.fatoracommitservices.getalldata(ipre.row).Rows[i][2]);
                int y = Convert.ToInt32(Services.fatoracommitservices.getalldata(ipre.row).Rows[i][0]);
                int z = Convert.ToInt32(Services.fatoracommitservices.itemssize(y).Rows[0][0]);
                Services.fatoracommitservices.incitems(z + x, y);
            }
        }
    }
}
