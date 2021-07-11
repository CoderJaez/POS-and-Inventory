using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleYam_POS.Model
{
    interface IProductUnit
    {
        string BaseUnit { get; set; }
        string DisplayUnit { get; set; }
        decimal Qty { get; set; }
    }
}
