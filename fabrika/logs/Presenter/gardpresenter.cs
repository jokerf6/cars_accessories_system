using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrika.logs.Presenter
{
     class gardpresenter
    {
        form.Interface.gardinterface igd;
        public gardpresenter(form.Interface.gardinterface view)
        {
           this.igd = view;
        }
        public void display()
        {
          igd.datagrid =  Services.gardservices.display();
        }
        public void display2()
        {
            igd.datagrid = Services.gardservices.display2();
        }

    }
}
