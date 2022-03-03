using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace fabrika.logs.Services
{
    static class displaymasr
    {
        public static DataTable getalldata()
        {
            return DBHelper.displaydata("masrdisplay", () => { });
        }
    }
}
