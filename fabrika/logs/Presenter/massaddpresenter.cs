using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrika.logs.Presenter
{
     class massaddpresenter
    {
        form.Interface.iaddmoney iadd;
        model.maddmoney madd = new model.maddmoney();
        public massaddpresenter(form.Interface.iaddmoney view)
        {
            this.iadd = view;
        }
        //connect between model and interface
        private void connectbetweenmodelandinterface()
        {
            madd.name = iadd.Name;
            madd.number = iadd.number;
            madd.date = iadd.date;
           
        } 
        public bool addmoneyinset()
        {
            connectbetweenmodelandinterface();
            return Services.addmoneyservices.masradd(madd.name , madd.number , madd.date);
        }
    }
}
