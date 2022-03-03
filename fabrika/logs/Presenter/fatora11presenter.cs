using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrika.logs.Presenter
{
     class fatora11presenter
    {
        form.Interface.fatora11interface ipre;
        public fatora11presenter(form.Interface.fatora11interface view)
        {
            ipre = view;
        }
        //*******************************************data grid
        public void data()
        {
          ipre.datagrid =  Services.fatora11services.getalldata(ipre.row);
        }
        //*****************************************number of fawater
        public int number()
        {
            int x = Convert.ToInt32(Services.fatora11services.number().Rows[0][0]);
            ipre.number = x;
            return x;
        }
        //****************************************date , dis , final
        public void details()
        {
            ipre.date = Convert.ToDateTime(Services.fatora11services.display(ipre.row).Rows[0][0]);
            ipre.dis = Convert.ToDecimal(Services.fatora11services.display(ipre.row).Rows[0][1]);
            ipre.final = Convert.ToDecimal(Services.fatora11services.display(ipre.row).Rows[0][2]);

        }
        //*************************************first row
        public int firtrow()
        {
            return Convert.ToInt32(Services.fatora11services.firstrow().Rows[0][0]);

        }
        //***************************************row size
        public int fatorasize()
        {
            return Services.fatora11services.getalldata(ipre.row).Rows.Count;
        }
        //**********************************last row
        public int lastrow()
        {
            int x = Convert.ToInt32(Services.fatora11services.lastrowinfatora().Rows[0][0]) - 1;
            return Convert.ToInt32(Services.fatora11services.firstrow().Rows[x][0]);
        }
    }
}
