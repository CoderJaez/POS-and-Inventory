using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Repository
{
   public static class RawMaterial
    {
        private static string connString = DatabaseConnection.ConnectionString;

        public static bool setbaseUnit(int id, int productId)
        {
            using (IDbConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        conn.Execute("UPDATE tbl_unitgroup SET BaseUnit = false where ProductId = @ProductId", new { ProductId = productId});
                        conn.Execute("UPDATE tbl_unitgroup SET BaseUnit = true where Id = @Id", new { Id = id });
                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        trans.Rollback();
                        return false;
                    }
                }
            }
        }

        public static bool setdisplayUnit(int Id, int ProductId)
        {
            using (IDbConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    try
                    {
                        conn.Execute("UPDATE tbl_unitgroup SET DisplayUnit = false where ProductId = @ProductId", new {ProductId = ProductId });
                        conn.Execute("UPDATE tbl_unitgroup SET DisplayUnit = true where Id = @Id", new { Id = Id });
                        trans.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        trans.Rollback();
                        return false;
                    }
                }
            }
        }

    }
}
