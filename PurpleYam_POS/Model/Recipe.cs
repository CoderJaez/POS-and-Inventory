using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleYam_POS.Model
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public decimal Qty { get; set; }
        public string  UnitCode { get; set; }
    }
}
