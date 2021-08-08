using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using PurpleYam_POS.helper;

namespace PurpleYam_POS.Model
{
    public class ProductModel : IProductModel
    {
        public string CreatedAt {get; set;}
        public string UpdatedAt { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage = "Product name field is required")]
        [Duplicate(column = "Product",table ="tbl_product")]
        public string Product { get; set; }
        [Required(ErrorMessage = "Quality field is required")]
        public string Quality { get; set; }
        public string  Particulars { get; set; }
        public bool Deleted { get; set; }
        public int Recipies { get; set; }
    }
}
