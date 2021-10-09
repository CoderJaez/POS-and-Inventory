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
    public class ProductModel 
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Product name field is required")]
        [Duplicate(column = "Product",table ="tbl_product")]
        public string Product { get; set; }
        [Required]
        public string Quality { get; set; }
        [Required]
        public string  Particulars { get; set; }
        public byte[] Image { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public DateTime DateStockin { get; set; }
        public bool Deleted { get; set; }
        public int Recipies { get; set; }
        public int Qty { get; set; }
        public Decimal Price { get; set; }
        public DateTime DateDiscountEnd { get; set; }
        public string Status { get; set; }
    }
}
