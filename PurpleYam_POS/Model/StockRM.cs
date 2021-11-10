using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleYam_POS.Model
{
   public class StockRM
    {
        public string RawMaterial { get; set; }
        public decimal Beginning { get; set; }
        public decimal D1 { get; set; }
        public decimal D2 { get; set; }
        public decimal D3 { get; set; }
        public decimal Spoilage { get; set; }
        public decimal TA { get; set; }
        public decimal Ending { get; set; }
        public decimal Consumption { get { return (Beginning + D1 + D2 + D3) - Ending; } }
    }
}
