using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrika.logs.Presenter
{
     class addnewitempresenter
    {
        form.Interface.iaddnewitems iadnewitems;
        //connect between interface and view
        public addnewitempresenter(form.Interface.iaddnewitems view)
        {
            this.iadnewitems = view;
        }
        public bool addnewitems()
        {
            return Services.addnewitemsservices.addnewitems(iadnewitems.name, iadnewitems.number, iadnewitems.money1, iadnewitems.money2, iadnewitems.money3);
        }
        public void autonumber()
        {
            int x = Services.addnewitemsservices.getalldata().Rows.Count -1;
            iadnewitems.id =Convert.ToInt32(Services.addnewitemsservices.getalldata().Rows[x][0]);
        }
        public int search()
        {

            return Convert.ToInt32(Services.addnewitemsservices.search(iadnewitems.name).Rows[0][0]);
        }
        
    }
}
