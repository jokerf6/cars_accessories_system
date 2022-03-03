using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace fabrika.form.Interface
{
    public interface additeminfatorainterface
    {
        int id { get; set; }
        string name { get; set; }
        int number { get; set; }
        decimal price { get; set; }
        decimal dis { get; set; }
        object datagrid { get; set; }
        int fid { get; set; }
        DateTime date { get; set; }
        int number2 { get; set; }
        decimal diss { get; set; }
        decimal final { get; set; }
        decimal backup { get; set; }
        int fid2 { get; set; }
    }
}
