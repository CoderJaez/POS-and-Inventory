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
    public class Recipe
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int RawmatId { get; set; }
        public int GrpUnitId { get; set; }
        public string Product { get; set; }
        public decimal Qty { get; set; }
        public string UnitCode { get; set; }
        public bool HasExpiry { get; set; }
    }

    public class ProductModel
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string Quality { get; set; }
        public string Particulars { get; set; }
        public DateTime DateTimeStamp { get; set; }
        public bool Deleted { get; set; }
        public int Recipies { get; set; }
        public int Qty { get; set; }
        public Decimal Price { get; set; }
        public DateTime DateDiscountEnd { get; set; }
        public string Status { get; set; }
    }
}
