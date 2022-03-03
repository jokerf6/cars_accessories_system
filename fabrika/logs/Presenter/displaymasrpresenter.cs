using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrika.logs.Presenter
{
     class displaymasrpresenter
    {
        form.Interface.masrdisplay imasr;
        public displaymasrpresenter(form.Interface.masrdisplay view)
        {
            this.imasr = view;
        }

      public  void getalldata()
        {
            imasr.datagrid = Services.displaymasr.getalldata();
                 
        }
    }
}
