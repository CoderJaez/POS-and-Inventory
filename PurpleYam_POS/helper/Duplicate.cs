using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using MySql.Data.MySqlClient;
using PurpleYam_POS.Model;
namespace PurpleYam_POS.helper
{
   public class Duplicate:ValidationAttribute
    {

        public string table { get; set; }
        public string column { get; set; }
        public string query { get; set; }
        private MySqlConnection conn;
        private readonly string connString = "host=localhost;user=root;pass=;database=purpleyam_db;port=3306;";
        private string sql;
        private int id;
        public Duplicate(): base("{0} is already inserted.") {}
      
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string strValue = value as string;
            if (!string.IsNullOrEmpty(strValue))
            {
                var container = validationContext.ObjectInstance.GetType();
                var field = container.GetProperty("Id");
                if(field != null)
                {
                    id = (int)field.GetValue(validationContext.ObjectInstance, null);
                }
                if (id != 0)
                    if (query == null)
                        sql = $"SELECT * FROM {table} where deleted = false and Id != {id} and {column} = @{column}";
                    else
                        sql = $"{query} AND Id != {id}";
                else
                    if (query == null)
                    sql = $"SELECT * FROM {table} where deleted = false and {column} = @{column}";
                else
                    sql = query;
                
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
