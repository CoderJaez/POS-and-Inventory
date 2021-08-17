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
    public class Recipe
    {
        [Range(1,int.MaxValue,ErrorMessage = "No product is created.")]
        public int ProductId { get; set; }
        public int GrpUnitId { get; set; }
        public int Id { get; set; }
        public int RawmatId { get; set; }
        [Required]
        [DuplicateRecipe]
        public string Product { get; set; }
        [Range(1,int.MaxValue,ErrorMessage = "Quantity field is required")]
        public decimal Qty { get; set; }
        [Required]
        public string  UnitCode { get; set; }
    }
}
