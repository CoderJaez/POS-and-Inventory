using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Model
{
    public class RawMaterialModel
    {

        public string CreatedAt { get; set; }
        public int Id { get; set; }
        public string Product { get; set; }
        public string BaseUnit { get; set; }
        public string DisplayUnit { get; set; }
        public decimal Qty { get; set; }
        public bool HasExpiry { get; set; }
        public int ReOrder { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool Deleted { get; set; }

    }
}
