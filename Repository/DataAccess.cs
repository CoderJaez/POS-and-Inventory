using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using System.Data;

namespace Repository
{
    public static class DataAccess
    {
        private static string connString = "host=localhost;user=root;pass=;database=purpleyam_db;port=3306;";

        public  static List<T> LoadData<T,U>(string sql, U parameters)
        {
            using (IDbConnection conn = new MySqlConnection(connString))
            {
                List<T> result = conn.Query<T>(sql, parameters).ToList();
                return result;
            }
        }

        public static  bool SaveData<T>(string sql, T parameters)
        {
            using (IDbConnection conn = new MySqlConnection(connString))
            {
                conn.Execute(sql, parameters);
                return true;
            }
        }
       

    }
}
