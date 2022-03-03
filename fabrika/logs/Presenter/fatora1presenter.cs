using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace fabrika.logs.Presenter
{
     
     class fatora1presenter
    {
        form.Interface.fatora1interface ipre;
        public fatora1presenter(form.Interface.fatora1interface view)
        {
            ipre = view;
        }
        //*********************************************fawater size
        public int fawatersize()
        {
            int x =  Convert.ToInt32(Services.fatora1services.fawatersize(ipre.date).Rows[0][0]);
            ipre.number = x;
            return x;
        }
        //*********************************************fawater display
        public void fawaterdisplay()
        {
            ipre.datagrid = Services.fatora1services.fawaterdisplay(ipre.row);
        }
        //*****************************************first id in this date
        public int firstid()
        {
            return Convert.ToInt32(Services.fatora1services.firstid(ipre.date).Rows[0][0]);
        }
        //*********************************************sum dis
        public void sumdis()
        {
            ipre.disfinal =  Convert.ToInt32(Services.fatora1services.sumdis(ipre.date).Rows[0][0]);
        }
        //*********************************************sum final
        public void sumfinal()
        {
           ipre.final2 =  Convert.ToInt32(Services.fatora1services.sumfinal(ipre.date).Rows[0][0]);
        }
        //*****************************************************************
        ///********************************************************display fawater final
        public void fawaterdisplayfinal()
        {
            ipre.final = Convert.ToDecimal(Services.fatora1services.fawaterdisplayfinal(ipre.row).Rows[0][0]);
        }
        //*****************************************************************
        ///********************************************************display fawater dis
        public void fawaterdisplaydis()
        {
            ipre.disfinal = Convert.ToDecimal(Services.fatora1services.fawaterdisplaydis(ipre.row).Rows[0][0]);
          
        }
        //*************************************************last row in fatora
        public int lastrow()
        {
            return Convert.ToInt32(Services.fatora1services.firstid(ipre.date).Rows[fawatersize() - 1][0]);
        }
        //****************************************************masr display
        public void summasr()
        {
            ipre.masr = Convert.ToDecimal(Services.fatora1services.summasr(ipre.date).Rows[0][0]);
        }
        //***********************************************masr size
        public int masrsize()
        {
            return Convert.ToInt32(Services.fatora1services.masrsize(ipre.date).Rows[0][0]);
        }
        //**********************************************fatora size
        public int fatorasize()
        {
            return Convert.ToInt32(Services.fatora1services.fawaterdisplay(ipre.row).Rows.Count);
        }
    }
}
