using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PurpleYam_POS.helper;
using Repository;

namespace PurpleYam_POS.Model
{
   public  class RawMaterial:IProductUnit
    {
        public string CreatedAt { get; set; }
        public int Id { get; set; }
        [Required()]
        [Duplicate(column = "Product",table ="rawmaterial")]
        public string Product { get; set; }
        public string BaseUnit { get; set; }
        public string DisplayUnit { get; set; }
        public int UnitId { get; set; }
        public decimal Qty { get; set; }
        public bool HasExpiry { get; set; }
        [Required]
        [Range(1,int.MaxValue,ErrorMessage = "ReOrder field is required")]
        public int ReOrder { get; set; }
        public DateTime DateExpiry { get; set; }
        public DateTime DateArrival { get; set; }
        public DateTime DateStockin { get; set; }
        [IfHasExpiry]
        public int DaysBeforeExpiry { get; set; }
        public bool Deleted { get; set; }

      

    }
}
