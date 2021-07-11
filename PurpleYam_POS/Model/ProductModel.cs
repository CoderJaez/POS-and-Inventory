using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PurpleYam_POS.Model
{
    class ProductModel : IProductModel
    {
        public string CreatedAt {get; set;}

        public bool Deleted
        {
            get;
            set;
        }

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

        public string UnitCode
        {
            get;
            set;
        }
    }
}
