using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.ComponentModel;

namespace Repository
{


    public class IfHasExpiry:ValidationAttribute
    {
        public IfHasExpiry() : base("{0}  field is required.") { }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(validationContext.ObjectInstance);
                bool HasExpiry = (bool)properties.Find("HasExpiry", true).GetValue(validationContext.ObjectInstance);
                int DaysBeforeExpiry = (int)properties.Find("DaysBeforeExpiry", true).GetValue(validationContext.ObjectInstance);
               
                if(HasExpiry && DaysBeforeExpiry <= 0)
                {
                    var errorMessage = FormatErrorMessage($"{validationContext.DisplayName} ");
                    return new ValidationResult(errorMessage);
                }
            
            return ValidationResult.Success;

        }
    }
    public class DuplicateRecipe : ValidationAttribute
    {
        private int id;
        private int ProductId;
        private int RawmatId;
        private string sql;
        public DuplicateRecipe() : base("{0} is already exist") { }
        private static string connString = DatabaseConnection.ConnectionString;

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string strValue = value as string;
            if (!string.IsNullOrEmpty(strValue))
            {
                PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(validationContext.ObjectInstance);
                id =  (int)properties.Find("Id", true).GetValue(validationContext.ObjectInstance);
                ProductId = (int)properties.Find("ProductId", true).GetValue(validationContext.ObjectInstance);
                RawmatId = (int)properties.Find("RawmatId", true).GetValue(validationContext.ObjectInstance);

                using (IDbConnection conn = new MySqlConnection(connString))
                {
                    //sql = "SELECT COUNT(r.Product) AS total FROM rawmaterial r LEFT JOIN tbl_recipe rc ON rc.RawmatId = r.Id WHERE rc.Deleted = FALSE and rc.ProductId = @ProductId and r.Product = @Product and rc.Id != @Id";

                    sql = "select count(*) from tbl_recipe where Deleted = false and ProductId = @ProductId and RawmatId = @RawmatId and Id != @Id";
                    var result = conn.Query<int>(sql, new { Id = id, ProductId = ProductId, RawmatId = RawmatId }).Single();
                    if ( result > 0 )
                    {
                        var errorMessage = FormatErrorMessage($"{validationContext.DisplayName} {strValue}");
                        return new ValidationResult(errorMessage);
                    }
                }
                   


            }
            return ValidationResult.Success;
        }
    }


    public class ProductDuplicate : ValidationAttribute
    {

        public string table { get; set; }
        public string column { get; set; }
        public string query { get; set; }
        public string Id { get; set; }
        private MySqlConnection conn;
        private static string connString = DatabaseConnection.ConnectionString;
        private string sql;
        private int id;
        public ProductDuplicate() : base("{0} is already exist.") { }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string strValue = value as string;
            if (!string.IsNullOrEmpty(strValue))
            {
                var container = validationContext.ObjectInstance.GetType();
                var field = container.GetProperty("Id");
                string type = (string)container.GetProperty("Type").GetValue(validationContext.ObjectInstance, null);
                if (field != null)
                {
                    id = (int)field.GetValue(validationContext.ObjectInstance, null);
                }
                if (id != 0)
                    if (query == null)
                        sql = $"SELECT * FROM {table} where Deleted = false and Type = '{type}' and Id != {id} and {column} = @{column}";
                    else
                        sql = $"{query} {id}";
                else
                    if (query == null)
                    sql = $"SELECT * FROM {table} where Deleted = false and {column} = @{column}";
                else
                    sql = $"{query}";
                using (conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue($"@{column}", strValue);
                        conn.Open();
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.HasRows)
                            {
                                var errorMessage = FormatErrorMessage($"{validationContext.DisplayName} {strValue}");
                                return new ValidationResult(errorMessage);
                            }
                        }
                    }
                }

            }
            return ValidationResult.Success;
        }
    }

    public class Duplicate : ValidationAttribute
    {

        public string table { get; set; }
        public string column { get; set; }
        public string query { get; set; }
        public string Id { get; set; }
        private MySqlConnection conn;
        private static string connString = DatabaseConnection.ConnectionString;
        private string sql;
        private int id;
        public Duplicate() : base("{0} is already exist.") { }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string strValue = value as string;
            if (!string.IsNullOrEmpty(strValue))
            {
                var container = validationContext.ObjectInstance.GetType();
                var field = container.GetProperty("Id");
                if (field != null)
                {
                    id = (int)field.GetValue(validationContext.ObjectInstance, null);
                }
                if (id != 0)
                    if (query == null)
                        sql = $"SELECT * FROM {table} where Deleted = false and Id != {id} and {column} = @{column}";
                    else
                        sql = $"{query} {id}";
                else
                    if (query == null)
                    sql = $"SELECT * FROM {table} where Deleted = false and {column} = @{column}";
                else
                    sql = $"{query}";
                using (conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue($"@{column}", strValue);
                        conn.Open();
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.HasRows)
                            {
                                var errorMessage = FormatErrorMessage($"{validationContext.DisplayName} {strValue}");
                                return new ValidationResult(errorMessage);
                            }
                        }
                    }
                }

            }
            return ValidationResult.Success;
        }
    }

    public class CashTendered:ValidationAttribute
    {
        public CashTendered() : base("{0} Must not below to down payment.") { }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(validationContext.ObjectInstance);
            decimal cashTendered = (decimal)properties.Find("CashTendered", true).GetValue(validationContext.ObjectInstance);
            decimal downPayment = (decimal)properties.Find("DownPayment", true).GetValue(validationContext.ObjectInstance);

            if (cashTendered < downPayment)
            {
                var errorMessage = FormatErrorMessage($"{validationContext.DisplayName}");
                return new ValidationResult(errorMessage);
            }

            return ValidationResult.Success;
        }
    }

    public class DuplicateRawmatUnit : ValidationAttribute
    {

        public string query { get; set; }
        private MySqlConnection conn;
        private static string connString = DatabaseConnection.ConnectionString;
        private string sql;
        private int Id;
        private int ProductId;
        public DuplicateRawmatUnit() : base("{0} is already inserted.") { }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string strValue = value as string;
            if (!string.IsNullOrEmpty(strValue))
            {
                var container = validationContext.ObjectInstance.GetType();
                var field = container.GetProperty("Id");
                var field2 = container.GetProperty("ProductId");
                Id = (int)field.GetValue(validationContext.ObjectInstance, null);
                ProductId = (int)field2.GetValue(validationContext.ObjectInstance, null);
                if (Id == 0)
                    sql = $"SELECT UnitCode FROM units where ProductId = {ProductId} and UnitCode = @UnitCode";
                else
                    sql = $"SELECT UnitCode FROM units where ProductId = {ProductId} and Id != {Id} and UnitCode = @UnitCode";
                using (conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue($"@UnitCode", strValue);
                        conn.Open();
                        using (MySqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.HasRows)
                            {
                                var errorMessage = FormatErrorMessage($"{validationContext.DisplayName} {strValue}");
                                return new ValidationResult(errorMessage);
                            }
                        }
                    }
                }

            }
            return ValidationResult.Success;
        }


    }
}
