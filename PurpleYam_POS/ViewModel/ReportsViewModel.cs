using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Repository.DataAccess;
using PurpleYam_POS.View.UserControls;
using PurpleYam_POS.Model;
using PurpleYam_POS.helper;
using Microsoft.Reporting.WinForms;

namespace PurpleYam_POS.ViewModel
{
   public class ReportsViewModel
    {
        public Reports ucReports;
        public PrintPreview ucPrintPreview;

        //BindingSource
        public BindingSource StockBS { get; set; }
        public BindingSource ProductionBS { get; set; }
        public BindingSource DailySalesBS { get; set; }
        public BindingSource ExpensesBS { get; set; }
        public BindingSource ProductStockinBS { get; set; }
        public BindingSource RawmatStockinBS { get; set; }
        public BindingSource ReservationBS { get; set; }

        private ReportDataSource[] rs;
        private ReportParameter[] rp;
        private string rdlcPath;
        private DateTime datePrint;
        public async void GetStockRawmat(string date)
        {
            var dDates =  await LoadData<DateTime, dynamic>("SELECT DISTINCT DATE(DateStockin) AS DateStockin FROM tbl_rawmat_stockin WHERE DATE_FORMAT(DateStockin, '%m-%Y') = @Date", new { Date = date});
            var deliveries = new List<string>();
            int index = 1;
            dDates.ForEach(d => {
                deliveries.Add($"stock_onhand(rawmat_stock('{d.ToString("yyyy-MM-dd")}', rs.RawmatId), u.Qty, rs.RawmatId) AS D{index++}\n");
            });

            StockBS.DataSource = await LoadData<StockRM, dynamic>($@"SELECT  concat(r.Product,'    (',u.UnitCode,')') as RawMaterial,
                stock_onhand(SUM(CASE WHEN DATE_FORMAT(rs.DateArrival, '%mm-%Y') > @Date THEN rs.QtyOnhand ELSE 0 END), u.Qty, rs.RawmatId) AS Beginning,
                {(deliveries.Count > 0 ? string.Join(",", deliveries) + ",": "")}
                stock_onhand( SUM(CASE WHEN DATE_FORMAT(rs.DateArrival, '%mm-%Y') >= @Date THEN rs.QtyOnhand ELSE (-1) * rs.QtyOnhand END), u.Qty, rs.RawmatId) AS Ending,
                stock_onhand( SUM(CASE WHEN DATE_FORMAT(rs.DateArrival, '%mm-%Y') >= @Date THEN rs.QtyDmg ELSE 0 END), u.Qty, rs.RawmatId) AS Spoilage
                FROM tbl_rawmat_stockin rs
                LEFT JOIN rawmaterial r ON r.Id = rs.RawmatId
                LEFT JOIN units u ON u.Id = rs.GrpUnitId
                GROUP BY r.Product
                ORDER BY r.Product ASC", new { Date = date });
        }

       

        public async void GetDailySales(DateTime date)
        {
            datePrint = date;
            DailySalesBS.DataSource = await LoadData<ProductionStock, dynamic>(@"
                SELECT p.Id,p.Product, p.Particulars, p.Quality,p.Price,
	            SUM( CASE WHEN ps.DateStockin < @Date THEN ps.QtyOnhand ELSE 0 END) AS Beginning,
	            SUM( CASE WHEN ps.DateStockin = @Date THEN ps.Qty ELSE 0 END) AS Production,
	            SUM( CASE WHEN ps.DateStockin = @Date THEN ps.QtyDmg ELSE 0 END) AS Spoilage,
	            SUM( CASE WHEN ps.DateStockin <= @Date THEN ps.QtyOnhand ELSE 0 END) AS Ending,
                (SELECT SUM(sp.Qty) FROM tbl_product_sold sp LEFT JOIN tbl_sale_transaction st ON st.TransactionNo = sp.TransactionNo WHERE sp.ProductId = p.Id AND DATE(st.TransactionDate) = @Date ) AS Sold
	            FROM tbl_product p 
	            LEFT JOIN tbl_production_stockin ps ON ps.ProductId = p.Id
	            WHERE p.Deleted = FALSE AND Type = 'Production'
	            GROUP BY p.Product", new { date = date });
            ExpensesBS.DataSource = await LoadData<ExpensesModel, dynamic>("select ex.*,e.Description from tbl_expenses ex left join tbl_expenses_cat e on e.Id = ex.ExpenseId where ex.Deleted = false and ex.DateTimeStamp = @Date ", new { Date = date });
        }


        public async void GetExpenses(DateTime dateF, DateTime dateT)
        {
            ExpensesBS.DataSource =  await LoadData<ExpensesModel, dynamic>("select ex.*,e.Description from tbl_expenses ex left join tbl_expenses_cat e on e.Id = ex.ExpenseId where ex.Deleted = false and ex.DateTimeStamp between @DateFrom and @DateTo", new { DateFrom = dateF.AddDays(-1), DateTo = dateT.AddDays(1) });
        }

       public async void GetProductionStockin(DateTime dateF, DateTime dateT)
        {
            ProductStockinBS.DataSource = await LoadData<ProductModel, dynamic>("select Product, Quality, Particulars, Qty, DateStockin from production_stockin where  DateStockin  between @DateFrom and @DateTo", new { DateFrom = dateF.AddDays(-1), DateTo = dateT.AddDays(1) });
        }

        public async void GetRawmatStockin(DateTime dateF, DateTime dateT)
        {
            RawmatStockinBS.DataSource = await LoadData<RawMaterial, dynamic>(@"
                select r.Product, u.UnitCode as DisplayUnit, rms.Qty, rms.DateArrival, rms.DateExpiry, r.HasExpiry  from tbl_rawmat_stockin rms 
                left join rawmaterial r on r.Id  = rms.RawmatId 
                left join units u on u.Id = rms.GrpUnitId
                Where rms.DateArrival between @DateFrom and @DateTo
                order by rms.DateArrival DESC", new { DateFrom = dateF.AddDays(-1), DateTo = dateT.AddDays(1) });
        }

        public void PrintPreview(string report)
        {
            if(!FormMain.Instance.MetroContainer.Controls.ContainsKey("PrintPreview"))
            {
                ucPrintPreview = new View.UserControls.PrintPreview();
                ucPrintPreview.Dock = DockStyle.Fill;
                FormMain.Instance.MetroContainer.Controls.Add(ucPrintPreview);
            }
            switch(report)
            {
                case "dailysales":
                    PrintDailySales();
                    break;
                case "stockroom":
                    PrintStockInventory();
                    break;
                case "expenses":
                    PrintExpenses();
                    break;
                case "production_stockin":
                    PrintProductionStockin();
                    break;
                case "reservation":
                    PrintReservation();
                    break;
                case "rawmat_stockin":
                    PrintRawmatStockin();
                    break;

            }

            ucPrintPreview.LoadPreview(rs,rdlcPath,rp);
            FormMain.Instance.UserControl.Add("PrintPreview");
            FormMain.Instance.Back.Visible = true;
            FormMain.Instance.MetroContainer.Controls["PrintPreview"].BringToFront();
        }

        public void GetReservation(DateTime dateF, DateTime dateT)
        {
            ReservationBS.DataSource = GetReservation<SaleTransactionModel, CustomerModel, dynamic>("select r.*, c.* from tbl_sale_transaction r left join tbl_customer c on c.Id = r.CustomerId Where r.TransactionType != 'WALK_IN' AND r.TransactionDate between @DateFrom and @DateTo ", new { DateFrom = dateF.AddDays(-1), DateTo = dateT.AddDays(1) });
        }
        private void PrintDailySales()
        {
            rs = new ReportDataSource[]
            {
                 new ReportDataSource { Name = "Production", Value = DailySalesBS.List },
                 new ReportDataSource { Name = "Expenses", Value = ExpensesBS.List },
            };

            rp = new ReportParameter[]
            {
                new ReportParameter("Date", datePrint.ToShortDateString()),
                new ReportParameter("Logo", Convert.ToBase64String(ImageLoader.ImageBuffer(Properties.Resources.logo_header)))
            };

        
            rdlcPath = "PurpleYam_POS.Reports.DailySalesRpt.rdlc";
        }
        private void PrintRawmatStockin()
        {
            rs = new ReportDataSource[]
           {
                 new ReportDataSource { Name = "Rawmat", Value = RawmatStockinBS.List },
            };

            rp = new ReportParameter[]
            {
                new ReportParameter("Logo", Convert.ToBase64String(ImageLoader.ImageBuffer(Properties.Resources.logo_header)))
            };

            rdlcPath = "PurpleYam_POS.Reports.RawmatStockinRpt.rdlc";
        }
        private void PrintExpenses()
        {
            rs = new ReportDataSource[]
             {
                     new ReportDataSource { Name = "Expenses", Value = ExpensesBS.List },
             };

            rp = new ReportParameter[]
            {
                new ReportParameter("Date", DateTime.Now.ToShortDateString()),
                new ReportParameter("Logo", Convert.ToBase64String(ImageLoader.ImageBuffer(Properties.Resources.logo_header)))
            };


            rdlcPath = "PurpleYam_POS.Reports.ExpensesRpt.rdlc";
        }

        private void PrintProductionStockin()
        {
            rs = new ReportDataSource[]
          {
                 new ReportDataSource { Name = "ProductionStockin", Value = ProductStockinBS.List },
          };

            rp = new ReportParameter[]
            {
                new ReportParameter("Logo", Convert.ToBase64String(ImageLoader.ImageBuffer(Properties.Resources.logo_header)))
            };


            rdlcPath = "PurpleYam_POS.Reports.ProductionStockinRpt.rdlc";
        }


        private void PrintStockInventory()
        {
            rs = new ReportDataSource[]
           {
                 new ReportDataSource { Name = "StockRoom", Value = StockBS.List },
           };

            rp = new ReportParameter[]
            {
                new ReportParameter("Date", DateTime.Now.ToShortDateString()),
                new ReportParameter("Logo", Convert.ToBase64String(ImageLoader.ImageBuffer(Properties.Resources.logo_header)))
            };


            rdlcPath = "PurpleYam_POS.Reports.StockRoomRpt.rdlc";
        }

        private void PrintReservation()
        {
            rs = new ReportDataSource[]
         {
                 new ReportDataSource { Name = "Reservation", Value = ReservationBS.List },
         };

            rp = new ReportParameter[]
            {
                new ReportParameter("Logo", Convert.ToBase64String(ImageLoader.ImageBuffer(Properties.Resources.logo_header)))
            };


            rdlcPath = "PurpleYam_POS.Reports.ReservationRpt.rdlc";
        }
    }
}
