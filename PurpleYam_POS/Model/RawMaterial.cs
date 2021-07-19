using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PurpleYam_POS.helper;

namespace PurpleYam_POS.Model
{
   public  class RawMaterial:IProductUnit
    {
        public string CreatedAt { get; set; }

        public int Id
        {
            get;
            set;
        }
        [Required()]
        [Duplicate(column = "Product",table ="rawmaterial")]
        public string Product
        {
            get;
            set;
        }

      public string BaseUnit
        {
            get;set;
        }
       public string DisplayUnit
        {
            get;set;
        }

        public decimal Qty
        {
            get;set;
        }
        public bool Deleted { get; set; }

    }
}
