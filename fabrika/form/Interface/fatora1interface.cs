using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace fabrika.form.Interface
{
    public interface fatora1interface
    {
        DateTime date { get; set; }
        int row { get; set; }
        object datagrid { get; set; }
        decimal final { get; set; }
        decimal disfinal { get; set; }
        int number { get; set; }
        decimal masr { get; set; }
        decimal dis { get; set; }
        decimal final2 { get; set; }
     }
}
