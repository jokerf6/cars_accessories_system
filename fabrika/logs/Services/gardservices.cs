using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace fabrika.logs.Services
{
    static class gardservices
    {
        public static DataTable display()
        {
            return DBHelper.displaydata("gard1", () => { }); 
        }
        public static DataTable display2()
        {
            return DBHelper.displaydata("gard2", () => { });
        }
    }
}
