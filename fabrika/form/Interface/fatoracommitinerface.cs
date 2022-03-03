using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fabrika.form.Interface
{
    public interface fatoracommitinerface
    {
        object datagrid { get; set; }
        int row { get; set; }
        DateTime date { get; set; }
        decimal dis { get; set; }
        decimal final { get; set; }
        int itemid { get; set; }
        string itemname { get; set; }
        decimal itemsell { get; set; }
        int itemnumber { get; set; }
        decimal itemdis { get; set; }
         DateTime fatoradate { get; set; }
         int fatoranumber2 { get; set; }
         decimal fatoradis { get; set; }
         decimal fatorafinal { get; set; }


    }
}
