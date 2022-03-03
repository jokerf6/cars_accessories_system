using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrika.logs.Presenter
{
     class fatora3presenter
    {
        form.Interface.fatora3interface ipre;
        public fatora3presenter(form.Interface.fatora3interface view)
        {
            ipre = view;
        }
        //******************************************sum
        public void sum()
        {
            decimal x =Convert.ToDecimal(Services.fatora3services.sum(ipre.fomedate , ipre.todate).Rows[0][0]);
            ipre.b1 = x;
        }
        //******************************************masr
        public void masr()
        {
            decimal x = Convert.ToDecimal(Services.fatora3services.masr(ipre.fomedate, ipre.todate).Rows[0][0]);
            ipre.b2 = x;
          
        }
        //*************************************sum size
        public int sumsize()
        {
            return Convert.ToInt32( Services.fatora3services.sumsize(ipre.fomedate, ipre.todate).Rows[0][0]);
        }
        //*************************************masr size
        public int masrsize()
        {
            return Convert.ToInt32(Services.fatora3services.masrsize(ipre.fomedate, ipre.todate).Rows[0][0]);
        }
    }
}
