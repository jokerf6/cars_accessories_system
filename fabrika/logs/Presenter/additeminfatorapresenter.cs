using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrika.logs.Presenter
{
    class additeminfatorapresenter
    {
        form.Interface.additeminfatorainterface ipre;
        model.additems mpre = new model.additems();
        public additeminfatorapresenter(form.Interface.additeminfatorainterface view)
        {
            this.ipre = view;
        }
        //*************************************************************************************************************************************
        //*************************************************الاتصال بين الموديل والانترفيس*****************************************************************************
        //*************************************************************************************************************************************
        private void connectbetweenmodelandinterface()
        {
            mpre.id = ipre.id;
            mpre.name = ipre.name;
            mpre.number = ipre.number;
            mpre.price = ipre.price;
            mpre.dis = ipre.dis;
            mpre.fid = ipre.fid;
            mpre.date = ipre.date;
            mpre.number2 = ipre.number2;
            mpre.diss = ipre.diss;
            mpre.final = ipre.final;
            mpre.fid2 = ipre.fid2;
        }
        //*****************************************************************
        //*****************************************get all data from temp
        public bool getalldata()
        {
            if (Services.addnewiteminfatoraservices.getalldata().Rows.Count == 0)
            {
                ipre.datagrid = Services.addnewiteminfatoraservices.getalldata();
                ipre.number2 = Convert.ToInt32(Services.addnewiteminfatoraservices.getalldata().Rows.Count);
                return false;
            }
            else
            {
                ipre.datagrid = Services.addnewiteminfatoraservices.getalldata();
                ipre.number2 = Convert.ToInt32(Services.addnewiteminfatoraservices.getalldata().Rows.Count);
                return true;
            }
        }
        //***********************************************************
        //****************************************** عرض بيانات المنتج
        public bool autonumber()
        {
           if(Services.addnewiteminfatoraservices.getdata(ipre.id).Rows.Count == 0)
            {
                return false;
            }
            else{
                ipre.name = Services.addnewiteminfatoraservices.getdata(ipre.id).Rows[0][0].ToString();
                ipre.price = Convert.ToDecimal(Services.addnewiteminfatoraservices.getdata(ipre.id).Rows[0][1]);
              return true;
            }
            }
        //************************************************************
        //*******************************************نقل من ال تيمب للفواتير
        public bool addinfatora()
        {
            return Services.addnewiteminfatoraservices.addinfatora();
        }
        //**********************************************************
        //***************************************fawater size
        public int addfatoradisplaycount()
        {
            return Convert.ToInt32(Services.addnewiteminfatoraservices.addfatoradisplaycount().Rows[0][0]);
        }
        //***********************************************************
        //*********************************************************رقم الفاتورة
        public int autonumber2()
        {
            int x = Convert.ToInt32(Services.addnewiteminfatoraservices.getdatafatora().Rows[addfatoradisplaycount()-1][0]);
            ipre.fid = x;
            return x;
        }
        //*************************************************************
        //*************************************************************add items
        public bool addnewitems()
        {
            return Services.addnewiteminfatoraservices.additems(ipre.id, ipre.name, ipre.number, ipre.dis, ipre.price);
        }
        //*************************************************************
        //***********************************************add fatora
        public bool fatorafinish()
        {
            return Services.addnewiteminfatoraservices.fatorafinish(ipre.date, ipre.number2, ipre.diss, ipre.final);
        }
        //***************************************************************
        //**********************************************updatetemp
        public void updatetemp()
        {
             Services.addnewiteminfatoraservices.updatetemp(autonumber2());
        }
         //***************************************************************
         //*********************************************delete temp
        public bool deletetemp()
        {
            ipre.diss = 0;
            ipre.final = 0;
            return Services.addnewiteminfatoraservices.deletetemp();

        }
        //******************************************************************
        //***********************************************sum of items final

        public decimal count()
        {
            
                ipre.final =Convert.ToDecimal(Services.addnewiteminfatoraservices.count().Rows[0][0]);
                return Convert.ToDecimal(Services.addnewiteminfatoraservices.count().Rows[0][0]);
            
        }
        //********************************************************************
        //***********************************************calculation
        public decimal bas()
        {
            decimal x = Convert.ToDecimal(Services.addnewiteminfatoraservices.getdata(ipre.id).Rows[0][1]);
            return x;
        }
        public decimal calculate1()
        {
            ipre.price = (ipre.number * bas()) - ipre.dis;
            return ipre.price;
        }

        public void calculate3()
        {
            ipre.final = count() - ipre.diss;
        }
        //*****************************************************************************
        //************************************************temp update
        public void tempupdate()
        {
            Services.addnewiteminfatoraservices.tempupdate(ipre.id, ipre.number, ipre.dis, ipre.price);
            
        }
        //******************************************************************************
        //**************************************delete from fatora
        public void deletefromfatora()
        {
            ipre.datagrid = Services.addnewiteminfatoraservices.deletefromfatora(ipre.id);
        }
        //******************************************************************************
        //****************************************search in temp
        public bool searchintemp()
        {
            if(Services.addnewiteminfatoraservices.searchintemp(ipre.id).Rows.Count == 0)
            {
                return false;

            }
            else
            {
                return true;
            }
        }
        //*************************************************************************
        //************************************show temp after edit
        public void show()
        {
            ipre.number = Convert.ToInt32(Services.addnewiteminfatoraservices.searchintemp(ipre.id).Rows[0][2]);
            ipre.dis = Convert.ToDecimal(Services.addnewiteminfatoraservices.searchintemp(ipre.id).Rows[0][3]);
            ipre.price = Convert.ToDecimal(Services.addnewiteminfatoraservices.searchintemp(ipre.id).Rows[0][4]);
        }
        //************************************************************
        //***********************************************add fatora commit
        public bool fatorafinish1()
        {
            return Services.addnewiteminfatoraservices.fatorafinish1(ipre.date, ipre.number2, ipre.diss, ipre.final);
        }
        //************************************************************
        //********************************************add in helper
        public bool addinfatora1()
        {
            return Services.addnewiteminfatoraservices.addinfatora1();
        }
        //*******************************************************
        //*********************************************update helper1
        //***************************************************************
        //**********************************************updatetemp
        public void updatetemp2()
        {
            Services.addnewiteminfatoraservices.updatetemp2(autonumber3());
        }
        //************************************************************
        //**********************************************last row in fatora1
        public int autonumber3()
        {
            int x = Services.addnewiteminfatoraservices.getdatafatora1().Rows.Count -1;
            return Convert.ToInt32(Services.addnewiteminfatoraservices.getdatafatora1().Rows[x][0]);
        }
        //***************************************************************
        //*********************************************inc items
        public void incitems()
        {
            Services.addnewiteminfatoraservices.incitems(itemssize()- ipre.number , ipre.id);
        }
        //************************************************************
        //*****************************************itemssize
        public int itemssize()
        {
          return Convert.ToInt32(Services.addnewiteminfatoraservices.itemssize(ipre.id).Rows[0][0]);
        }
        //****************************************************************
        //******************************************dec items
        public void decitems()
        {
            int x = Convert.ToInt32(Services.addnewiteminfatoraservices.compare(ipre.id).Rows[0][0]);
            Services.addnewiteminfatoraservices.incitems(itemssize() + x , ipre.id);
        }
        //********************************************************
        //***********************************compare
        public void decallitems()
        {
            for (int i = 0; i < ipre.number2; i++)
            {
                int x = Convert.ToInt32(Services.addnewiteminfatoraservices.getalldata().Rows[i][2]);
                int y = Convert.ToInt32(Services.addnewiteminfatoraservices.getalldata().Rows[i][0]);
                int z = Convert.ToInt32(Services.addnewiteminfatoraservices.itemssize(y).Rows[0][0]);
                Services.addnewiteminfatoraservices.incitems(z + x, y);
            }
        }
        //*******************************************************
        //************************************************
        public  void compare()
        {
            int x =Convert.ToInt32(Services.addnewiteminfatoraservices.compare(ipre.id).Rows[0][0]);//  1  // 5
                Services.addnewiteminfatoraservices.incitems(itemssize() + x, ipre.id);
                Services.addnewiteminfatoraservices.incitems(itemssize() - ipre.number, ipre.id);
        }



        //*****************************************************************اخر صف في الفواتير
        public int lastrowinfatora()
        {
            return Convert.ToInt32(Services.addnewiteminfatoraservices.lastrowinfatora().Rows[0][0]) - 1;
        }
        //*****************************************************************اخر صف في الفواتير
        public int lastrowinfatora1()
        {
            return Convert.ToInt32(Services.addnewiteminfatoraservices.lastrowinfatora1().Rows[0][0]) - 1;
        }

        public int displayfatora1()
        {
            return Services.addnewiteminfatoraservices.displayfatora1().Rows.Count;
        }

        //*************************************************************************************************************************************
        //************************************************اضافة راس الفاتورة *****************************************************************************
        //*************************************************************************************************************************************

        //*************************************************************************************************************************************
        //***************************************************عرض المنتجات***************************************************************************
        //*************************************************************************************************************************************

        //*************************************************************************************************************************************
        //*************************************************مسح منتجات *****************************************************************************
        //*************************************************************************************************************************************

        public int deletefromfatoracheck()
        {
            return Services.addnewiteminfatoraservices.deletefromfatoracheck(ipre.id, ipre.fid).Rows.Count;

        }
        //*************************************************************************************************************************************
        //************************************************عدد الاصناف في الفاتورة *****************************************************************************
        //*************************************************************************************************************************************


        //*************************************************************************************************************************************
        public void deletefinish()
        {
            ipre.datagrid = Services.addnewiteminfatoraservices.deletefinish(ipre.fid);
           // ipre.final = 0;

        }

        //*********************************************************رقم الفاتورة


    }
    }

