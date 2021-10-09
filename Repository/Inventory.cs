using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Model;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper;
using System.Windows.Forms;

namespace Repository
{
    public static class RawMatInventory
    {
        public static void StockIn(RawMaterialModel model)
        {

        }
    }

    public static class ProductionInventory
    {
        private static string ConnString = DatabaseConnection.ConnectionString;

        public async static void AdjustPRStocks(int ProductStockId, int ProductId, decimal ProductQty, string Remarks, bool isAddStock)
        {
            using (IDbConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                var tr = conn.BeginTransaction();
                try
                {

                    var result = await conn.QueryAsync<Recipe>("select * from recipes where ProductId = @ProductId", new { ProductId = ProductId });
                    var recipes = result.ToList();
                    recipes.ForEach(recipe => {

                        recipe.Qty *= ProductQty;//100 * 2
                        if (recipe.HasExpiry)
                        {
                            if(isAddStock)
                                conn.ExecuteAsync("update tbl_rawmat_stockin set QtyOnhand = QtyOnhand - @Qty where RawmatId = @RamatId ORDER BY DateExpiry ASC", new { Qty = recipe.Qty });
                            else
                                conn.ExecuteAsync("update tbl_rawmat_stockin set QtyOnhand = QtyOnhand + @Qty where RawmatId = @RamatId ORDER BY DateExpiry ASC", new { Qty = recipe.Qty });
                        }
                        else
                        {
                            if(isAddStock)
                                conn.ExecuteAsync("UPDATE tbl_rawmat_stockin SET QtyOnhand = CASE WHEN GrpUnitId = @GrpUnitId THEN QtyOnhand - @Qty ELSE QtyOnhand - (SELECT Qty FROM units WHERE Id = GrpUnitId) / @Qty  END WHERE RawmatId = @RawmatId ORDER BY DateStockin ASC LIMIT 1", new { Qty = recipe.Qty, GrpUnitId = recipe.GrpUnitId, RawmatId = recipe.RawmatId });
                            else
                                conn.ExecuteAsync("UPDATE tbl_rawmat_stockin SET QtyOnhand = CASE WHEN GrpUnitId = @GrpUnitId THEN QtyOnhand + @Qty ELSE QtyOnhand + (SELECT Qty FROM units WHERE Id = GrpUnitId) / @Qty  END WHERE RawmatId = @RawmatId ORDER BY DateStockin ASC LIMIT 1", new { Qty = recipe.Qty, GrpUnitId = recipe.GrpUnitId, RawmatId = recipe.RawmatId });
                        }

                    });

                    if(isAddStock)
                    {
                        conn.Execute("update production_stockin set QtyOnhand = QtyOnhand + @Qty, Qty = Qty + @Qty where Id = @Id", new { Qty = ProductQty, Id = ProductStockId });

                    } else if(!isAddStock && Remarks == "ERRONEOUS ENTRY")
                        conn.Execute("update production_stockin set QtyOnhand = QtyOnhand - @Qty, Qty = Qty - @Qty where Id = @Id", new { Qty = ProductQty, Id = ProductStockId });
                    else
                        conn.Execute("update production_stockin set QtyOnhand = QtyOnhand - @Qty  where Id = @Id", new { Qty = ProductQty, Id = ProductStockId });
                    tr.Commit();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    tr.Rollback();
                }

            }
        }

        public async static void UpdatePRStocks(int ProductStockId, int ProductId, decimal ProductQty)
        {
            using (IDbConnection conn = new MySqlConnection(ConnString))
            {
                conn.Open();
                var tr = conn.BeginTransaction();
                try
                {
                   
                    var result = await conn.QueryAsync<Recipe>("select * from recipes where ProductId = @ProductId", new { ProductId = ProductId });
                    var recipes = result.ToList();
                    recipes.ForEach(recipe => {

                        recipe.Qty *= ProductQty;//100 * 2
                        if(recipe.HasExpiry)
                        {
                            conn.ExecuteAsync("update tbl_rawmat_stockin set QtyOnhand = QtyOnhand - @Qty where RawmatId = @RamatId ORDER BY DateExpiry ASC", new { Qty = recipe.Qty });
                        } else
                        {
                            conn.ExecuteAsync("UPDATE tbl_rawmat_stockin SET QtyOnhand = CASE WHEN GrpUnitId = @GrpUnitId THEN QtyOnhand - @Qty ELSE QtyOnhand - (SELECT Qty FROM units WHERE Id = GrpUnitId) / @Qty  END WHERE RawmatId = @RawmatId ORDER BY DateStockin ASC LIMIT 1", new { Qty = recipe.Qty, GrpUnitId = recipe.GrpUnitId, RawmatId = recipe.RawmatId });
                        }

                    });

                    conn.Execute("update production_stockin set Status = 'done' where Id = @Id", new { Id = ProductStockId });
                    tr.Commit();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    tr.Rollback();
                }

            }
        }

        public static string TransactioNo()
        {
            string transactionNo = DateTime.Now.ToString("yyyyMMddhhmm");
            using (IDbConnection conn = new MySqlConnection(ConnString))
            {
                var result = conn.Query<string>("select TransactionNo from tbl_sale_transaction order by TransactionDate Desc limit 1", new { }).SingleOrDefault();
                if (result != null)
                    transactionNo += (Convert.ToInt32(result.Substring(12, result.Length - 12)) + 1).ToString("D3");
                else
                    transactionNo += "001";
            }
            return transactionNo;
        }
    }


}
