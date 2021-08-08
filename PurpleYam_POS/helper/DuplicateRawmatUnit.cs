using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MySql.Data.MySqlClient;
using PurpleYam_POS.Model;
using System.Windows.Forms;

namespace PurpleYam_POS.helper
{
   public class DuplicateRawmatUnit:ValidationAttribute
    {

        public string query { get; set; }
        private MySqlConnection conn;
        private readonly string connString = "host=localhost;user=root;pass=;database=purpleyam_db;port=3306;";
        private string sql;
        private int Id;
        private int ProductId;
        public DuplicateRawmatUnit(): base("{0} is already inserted.") {}
      
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
                if(Id == 0)
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
                            if(rd.HasRows)
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
