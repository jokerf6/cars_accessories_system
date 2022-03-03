using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrika.logs.Presenter
{
     class fatora2presenter
    {
        form.Interface.fatora2interface ipre;
        public fatora2presenter(form.Interface.fatora2interface view)
        {
            ipre = view;
        }
        //******************************************sum
        public void sum()
        {
            decimal x = Convert.ToDecimal(Services.mainpage11services.sum(DateTime.Now, DateTime.Now).Rows[0][0]);
            ipre.b1 = x;
        }
        //******************************************masr
        public void masr()
        {
            decimal x = Convert.ToDecimal(Services.mainpage11services.masr(DateTime.Now, DateTime.Now).Rows[0][0]);
            ipre.b2 = x;

        }
        //*************************************sum size
        public int sumsize()
        {
            return Convert.ToInt32(Services.mainpage11services.sumsize(DateTime.Now, DateTime.Now).Rows[0][0]);
        }
        //*************************************masr size
        public int masrsize()
        {
            return Convert.ToInt32(Services.mainpage11services.masrsize(DateTime.Now, DateTime.Now).Rows[0][0]);
        }
    }
}
