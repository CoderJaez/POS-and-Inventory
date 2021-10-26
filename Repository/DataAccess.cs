using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Dapper;
using System.Data;
using Z.Dapper.Plus;
using System.Configuration;
using Repository.Model;

namespace Repository
{
    public static class DatabaseConnection
    {
        static ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
        private static string connString = settings["Development"].ConnectionString;
        public static string ConnectionString { get { return connString; } set { connString = value; } }
    }

    public static class DataAccess
    {
        private static string connString = DatabaseConnection.ConnectionString;

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

        public static T Get<T, U>(string sql, U parameter)
        {
            using (IDbConnection conn = new MySqlConnection(connString))
            {
                var result = conn.Query<T>(sql, parameter);
                return result.Single();
            }
        }

        public static  List<SaleTransactionModel> GetReservation<P>(string sql, P p)
        {
            using (IDbConnection conn = new MySqlConnection(connString))
            {

                var result =  conn.Query<SaleTransactionModel, CustomerModel, SaleTransactionModel>(sql, (r, c) => 
                {
                    r.Customer = c;
                    return r;
                },p);
                return result.AsList();

            }
        }

    }
}
