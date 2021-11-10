using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurpleYam_POS.Model;
using PurpleYam_POS.View.UserControls;
using static Repository.DataAccess;

namespace PurpleYam_POS.ViewModel
{
    
    public class SummaryViewModel
    {
        public List<SoldProductModel> productSeries { get; set; }
        public List<MonthlyProductSold> monthlyProductSold;
        public List<MonthlySalesExpenses> monthlySalesExpenses;
        private List<SoldProductModel> products { get; set; }
        public SummaryViewModel()
        {
            LoadProductSeries();
            LoadMonthlyProductSold();
            LoadMonthlySalesExpense();
        } 

        private async void LoadProductSeries()
        {
            productSeries = await LoadData<SoldProductModel, dynamic>("Select Product, Id from tbl_product where Deleted = false and `Type` = 'Production' order by Product asc", new { });
        }


       public async void LoadMonthlyProductSold()
        {
            monthlyProductSold = new List<MonthlyProductSold>();
            //Get list month of current year that has product sold
            var months = await LoadData<string, dynamic>("select DATE_FORMAT(TransactionDate, '%M') AS Month from product_sold where  date_format(TransactionDate,'%Y') = DATE_FORMAT(CURRENT_TIMESTAMP(), '%Y') GROUP by MONTH(TransactionDate)", new { });

            //Loop all the months the get the product sold in qty in the current month and year
            months.ForEach(m => {
                 products = new List<SoldProductModel>();
                productSeries.ForEach( p => {
                    var qty = Get<string, dynamic>("SELECT SUM(ps.Qty) FROM product_sold ps WHERE ps.ProductId = @ProductId AND ps.Type != 'CANCELLED' AND DATE_FORMAT(ps.TransactionDate, '%M/%Y') = DATE_FORMAT(CURRENT_TIMESTAMP(), @Month) ", new { ProductId = p.Id, Month = $"{m}/{DateTime.Now.Year}" });
                    products.Add(new SoldProductModel {
                        Product = p.Product,
                        Qty = string.IsNullOrEmpty(qty) ? 0:decimal.Parse(qty)
                    });
                    
                });

                monthlyProductSold.Add(new MonthlyProductSold
                {
                    Month = m,
                    Product = products
                });
            });

        }

        public async Task<string> TotalSales()
        {
            var sales = await Task.Run(()=> Get<string, dynamic>("SELECT SUM(s.TotalAmount) FROM tbl_sale_transaction s WHERE s.TransactionType != 'CANCELLED' AND DATE_FORMAT(s.TransactionDate,'%Y-%M-%d') = DATE_FORMAT(CURRENT_TIMESTAMP(),'%Y-%M-%d')", new {}));
            return !string.IsNullOrEmpty(sales) ? decimal.Parse(sales).ToString("N") : "0.00";

        }

        public async Task<string> TotalProductionStocks()
        {
            var stocks = await Task.Run(() => Get<string, dynamic>("select sum(QtyOnhand) from product_inventory",new { }));
            return !string.IsNullOrEmpty(stocks) ? stocks : "0";
        }

        public async Task<string> TotalReservation()
        {
            var reservation = await Task.Run( () => Get<string, dynamic>("select count(*) from tbl_sale_transaction where TransactionType = 'RESERVATION' and DATE_FORMAT(TransactionDate,'%Y-%M-%d') = DATE_FORMAT(CURRENT_TIMESTAMP(),'%Y-%M-%d')", new {}));
            return reservation;
        }

        public async Task<string> TotalExpiryRawmats()
        {
            var expiry = await Task.Run(() => Get<string, dynamic>("SELECT COUNT(*) FROM expiry_rawmats e WHERE e.NoDaysBExp <= e.DaysBeforeExpiry", new { }));
            return expiry;
        }

        public async Task<List<MonthlyReservation>> LoadMonthlyReservation()
        {
            var list = await LoadData<MonthlyReservation, dynamic>("SELECT COUNT(s.TransactionNo) AS Qty, DATE_FORMAT(s.TransactionDate, '%M') AS Month FROM tbl_sale_transaction s WHERE s.TransactionType = 'RESERVATION' AND DATE_FORMAT(s.TransactionDate, '%Y') = DATE_FORMAT(CURRENT_TIMESTAMP(), '%Y') GROUP BY MONTH(s.TransactionDate)", new { });
            return list;
        }

        public async void LoadMonthlySalesExpense()
        {
            monthlySalesExpenses = new List<MonthlySalesExpenses>();
            //Get list month of current year that has product sold
            var months = await LoadData<string, dynamic>("select DATE_FORMAT(TransactionDate, '%M') AS Month from tbl_sale_transaction where  date_format(TransactionDate,'%Y') = DATE_FORMAT(CURRENT_TIMESTAMP(), '%Y') GROUP by MONTH(TransactionDate)", new { });
            months.ForEach(m => {
                var expenses =  Get<string, dynamic>("select sum(Amount) from tbl_expenses where Deleted = false and date_format(DateTimeStamp, '%M/%Y') = @Date", new { Date = $"{m}/{DateTime.Now.Year}"});
                var sales = Get<string, dynamic>("select sum(s.TotalAmount - s.Balance) from tbl_sale_transaction s where s.TransactionType != 'CANCELLED' and date_format(s.TransactionDate, '%M/%Y') = @Date", new { Date = $"{m}/{DateTime.Now.Year}" });
                monthlySalesExpenses.Add(new MonthlySalesExpenses {
                    Month = m,
                    Sales = !string.IsNullOrEmpty(sales) ? decimal.Parse(sales) : 0,
                    Expenses = !string.IsNullOrEmpty(expenses) ?decimal.Parse(expenses):0
                });
            });
        }
    }

    public class MonthlyProductSold
    {
        public string Month { get; set; }
        public List<SoldProductModel> Product { get; set; }
    }

    public class MonthlySalesExpenses
    {
        public string Month { get; set; }
        public decimal Sales { get; set; }
        public decimal Expenses { get; set; }
    }

    public class MonthlyReservation
    {
        public string Month { get; set; }
        public int Qty { get; set; }
    }
}
