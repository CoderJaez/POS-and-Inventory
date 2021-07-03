using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MySql.Data.MySqlClient;
using PurpleYam_POS.model;
namespace PurpleYam_POS.helper
{
   public class Duplicate:ValidationAttribute
    {

        public string table { get; set; }
        public string column { get; set; }

        private MySqlConnection conn;
        private readonly string connString = "host=localhost;user=root;pass=;database=purpleyam_db;port=3306;";
        private string sql;
        public Duplicate(): base("{0} is already inserted.") {}
      
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string strValue = value as string;
            if (!string.IsNullOrEmpty(strValue))
            {
                Unit unit = (Unit)validationContext.ObjectInstance;
                if (unit.Id != 0)
                    sql = $"SELECT * FROM {table} where deleted = false and Id != {unit.Id} and {column} = @{column}";
                else
                    sql = $"SELECT * FROM {table} where deleted = false and {column} = @{column}";
                
                using(conn = new MySqlConnection(connString))
                {
                    using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue($"@{column}", strValue);
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
