using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using System.Data;
using Z.Dapper.Plus;

namespace Repository
{
    public static class DataAccess
    {
        private static string connString = "host=localhost;user=root;pass=;database=purpleyam_db;port=3306;";

        public  static async Task<List<T>> LoadData<T,U>(string sql, U parameters)
        {
            using (IDbConnection conn = new MySqlConnection(connString))
            {
                var result = await conn.QueryAsync<T>(sql, parameters);
                return result.ToList();
            }
        }

        public static void  SaveData<T>(string sql, T parameters)
        {
            using (IDbConnection conn = new MySqlConnection(connString))
            {
                  conn.Execute(sql, parameters);
            }
        }

        public static int GetTotalRows<T>(string sql, T p)
        {
            using (IDbConnection conn = new MySqlConnection(connString))
            {
                var id = conn.Query<int>(sql, p);
                return id.Single();
            }
        }


        public static int SaveGetId<T>(string sql, T parameters)
        {
            using (IDbConnection conn = new MySqlConnection(connString))
            {
                var id = conn.Query<int>(sql, parameters);
                return id.Single();
            }
        }

       
    }
}
