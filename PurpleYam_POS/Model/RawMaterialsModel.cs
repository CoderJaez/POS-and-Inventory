using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleYam_POS.Model
{
   public  class RawMaterialsModel:IProductUnit
    {
        public string CreatedAt { get; set; }

        public bool Deleted
        {
            get;
            set;
        } = false;

        public int Id
        {
            get;
            set;
        }

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

    }
}
