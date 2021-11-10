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
        public static string ErrMsg;

        //static ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
        //private static string connString = settings["Development"].ConnectionString;
        private static string connString = Properties.Settings.Default.ConnString;
        public static string ConnectionString { get { return connString; } set { connString = value; } }


        public static void UpdateDBConfig(string conn)
        {
            Properties.Settings.Default.ConnString = conn;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
        }

        public static bool IsDBConnected(string conString = null)
        {
            try
            {
                string sql;
                if (!string.IsNullOrEmpty(conString))
                    sql = conString;
                else
                    sql = connString;
                using (IDbConnection conn = new MySqlConnection(sql))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                ErrMsg = ex.Message;
                //ValidationDialog.Show("Database disconnected", "Update your database configuration.\n", ValidationDialog.AlertType.ERROR);
                return false;
            }
        }
    }

    public static class DataAccess
    {

        public static string ErrMsg;
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
                return result.SingleOrDefault();
            }
        }

        public static  List<R> GetReservation<R,C,P>(string sql, P p)
        {
            using (IDbConnection conn = new MySqlConnection(connString))
            {

                var result =  conn.Query<R, C, R>(sql, (r, c) => 
                {
                    r.GetType().GetProperty("Customer").SetValue(r, c);
                    return r;
                },p);
                return result.AsList();

            }
        }

        public static List<U> GetUsers<U, C, T>(string sql, T p)
        {
            using (IDbConnection conn = new MySqlConnection(connString))
            {

                var result = conn.Query<U, C, U>(sql, (r, c) =>
                {
                    r.GetType().GetProperty("Customer").SetValue(r, c);
                    return r;
                }, p);
                return result.AsList();

            }
        }
        public static T GetUser<T,C, P>(string sql, P p)
        {
            using (IDbConnection conn = new MySqlConnection(connString))
            {

                var result = conn.Query<T, C, T>(sql, (r, c) =>
                {
                    r.GetType().GetProperty("Customer").SetValue(r,c) ;
                    return r;
                }, p);
                return result.SingleOrDefault();

            }
        }

        public static bool InsertUser<U>(U user)
        {
            
            using (IDbConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                var tr = conn.BeginTransaction();
                try
                {

                    var id = conn.Query<int>("insert into tbl_customer (Firstname, Middlename, Lastname, ContactNo,Image) values(@Firstname, @Middlename, @Lastname, @ContactNo,@Image); select last_insert_id();", user).Single();
                    conn.Execute("insert tbl_user (CustomerId, Username, Password, AccessRole) values (@CustomerId, @Username, @Password, @AccessRole)",new {
                        CustomerId = id,
                        Username = user.GetType().GetProperty("Username").GetValue(user,null),
                        Password = user.GetType().GetProperty("Password").GetValue(user, null),
                        AccessRole = user.GetType().GetProperty("AccessRole").GetValue(user, null),
                    });
                    tr.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    tr.Rollback();
                    ErrMsg = e.Message;
                    return false;
                }
               

            }
        }

    }
}
