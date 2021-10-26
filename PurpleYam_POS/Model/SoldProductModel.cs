using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleYam_POS.Model
{
    public class SoldProductModel
    {
        public string TransactionNo { get; set; }
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string Product { get; set; }
        public byte[] Image { get; set; }
        public decimal Price { get; set; }
        public decimal Qty { get; set; }
        public decimal SubTotal { get; set; }
        public bool WithAddon { get; set; }
        public string  Type { get; set; }
        public string UnitCode { get; set; }
        public DateTime TransactionDate { get; set; }

    }
}
