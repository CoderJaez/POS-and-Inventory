using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Model
{
    public class CustomerModel
    {
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public string Firstname { get; set; }
        public string ContactNo { get; set; }
        public DateTime DateTimeStamp { get; set; }

        public string Fullname
        {
            get { return $"{Lastname.ToUpper()}, {Firstname.ToUpper()} {Middlename.ToUpper()} "; }
        }

    }

    public class SaleTransactionModel
    {
        public string TransactionNo { get; set; }
        public decimal DownPayment { get; set; }
        public decimal Balance { get; set; }
        public decimal Vat { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal CashTendered { get; set; }
        public decimal Change { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime ReservationDate { get; set; }
        public string ClaimStatus { get; set; }
        public string TransactionType { get; set; }
        public CustomerModel Customer { get; set; }


    }
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
