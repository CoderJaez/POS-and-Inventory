using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleYam_POS.Model
{
    public class ProductionStock
    {
        public string Product { get; set; }
        public string Particulars { get; set; }
        public string Quality { get; set; }
        public int  Beginning { get; set; }
        public int Production { get; set; }
        public int Ending { get; set; }
        public int TotalQty { get { return Beginning + Production; } }
        public int Spoilage { get; set; }
        public int Sold { get; set; }
        public decimal Price { get; set; }
        public decimal TotalAmount { get { return Price * Sold; } }
    }
}
