using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrika.logs.Presenter
{
     class preitemnumberpresenter
    {
        form.Interface.preitemnumberinterface ipre;
        public preitemnumberpresenter(form.Interface.preitemnumberinterface view) 
        {
            this.ipre = view;
        }

        public void autonumber()
        {
            ipre.name = Services.preitemnumberservices.getdata(ipre.id).Rows[0][0].ToString(); 
            ipre.number =Convert.ToInt32(Services.preitemnumberservices.getdata(ipre.id).Rows[0][1]);
            ipre.money1 =Convert.ToDecimal(Services.preitemnumberservices.getdata(ipre.id).Rows[0][2]);
            ipre.money2 = Convert.ToDecimal(Services.preitemnumberservices.getdata(ipre.id).Rows[0][3]);
            ipre.money3 = Convert.ToDecimal(Services.preitemnumberservices.getdata(ipre.id).Rows[0][4]);
        }
        public int check1()
        {
            return Services.preitemnumberservices.getdata(ipre.id).Rows.Count;
        }
        
        
        public bool addpreitems()
        {
            return Services.preitemnumberservices.preupdate(ipre.id , ipre.name, ipre.number, ipre.money1, ipre.money2, ipre.money3);
        }

    }
}
