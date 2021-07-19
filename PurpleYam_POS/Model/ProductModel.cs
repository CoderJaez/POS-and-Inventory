using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PurpleYam_POS.helper;

namespace PurpleYam_POS.Model
{
    class ProductModel : IProductModel
    {
        public string CreatedAt {get; set;}

        public int Id
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Product name field is required")]
        [Duplicate(column = "Product",table ="tbl_rawmat")]
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

        public bool Deleted { get; set; }

    }
}
