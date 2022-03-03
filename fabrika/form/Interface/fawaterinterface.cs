using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace fabrika.form.Interface
{
    public interface fawaterinterface
    {
        int row { get; set; }
        DateTime date { get; set; }
        object datagrid { get; set; }
        int id { get; set; }
        string name { get; set; }
        int number { get; set; }
        decimal dis  { get; set; } 
        decimal price { get; set; }
        decimal disfinal { get; set; }
        decimal final { get; set; }
    }
}
