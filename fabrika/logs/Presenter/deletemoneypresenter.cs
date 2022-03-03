using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrika.logs.Presenter
{
     class deletemoneypresenter
    {
        form.Interface.ideletemoney idelete;
        model.mdeletemoney mdelete = new model.mdeletemoney();
        //connect between view and interface
        public deletemoneypresenter(form.Interface.ideletemoney view)
        {
            this.idelete = view;
        }
        //connect between class and interface
         private void connectbetweenmodelandinterface()
        {
            mdelete.Name = idelete.name;
            mdelete.number = idelete.number;
        }
        public bool deletemoney()
        {
            connectbetweenmodelandinterface();
            return Services.deletemoneyservices.masrdelete(mdelete.Name, mdelete.number);
        }

    }
}
