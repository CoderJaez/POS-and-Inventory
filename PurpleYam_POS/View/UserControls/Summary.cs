using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using PurpleYam_POS.ViewModel;
using System.Threading;

namespace PurpleYam_POS.View.UserControls
{
    public partial class Summary : MetroFramework.Controls.MetroUserControl
    {
        private SummaryViewModel viewModel;
        public Chart ChartProductSold { get { return chartProductSold; } }
        public Chart ChartSalesExpenses { get { return chartSalesExpenses; } }
        public Chart ChartResevation { get { return chartReservation; } }

        public string LabelSales { get { return lblSales.Text; } set { lblSales.Text = value; } }
        public string LabelProduct { get { return lblProduction.Text; } set { lblProduction.Text = value; } }
         public string labelReservation { get { return lblResevation.Text; } set { lblResevation.Text = value; } }
        public string LabelRawmat { get { return lblRawmats.Text; } set { lblRawmats.Text = value; } }

        public Summary()
        {
            InitializeComponent();
            viewModel = new SummaryViewModel();
            LoadSummary();
        }


        public async void LoadSummary()
        {
            LabelSales = await viewModel.TotalSales();
            LabelProduct = await viewModel.TotalProductionStocks();
            labelReservation = await viewModel.TotalReservation();
            LabelRawmat = await viewModel.TotalExpiryRawmats();
            ProductSeries();
            MonthlySalesExpenses();
            MonthlyReservation();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        public  void ProductSeries()
        {
            chartProductSold.Titles[0].Text = $"Product sold(qty) as of  {DateTime.Now.Year}";
            chartProductSold.Series.Clear();
            viewModel.productSeries.ForEach( p => 
            {

                chartProductSold.Series.Add(p.Product);
                chartProductSold.Series[p.Product].ChartArea = "ChartArea1";
                chartProductSold.Series[p.Product].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                //chartProductSold.Series[p.Product].IsValueShownAsLabel = true;
                chartProductSold.Series[p.Product].Label = p.Product;
            });

            viewModel.monthlyProductSold.ForEach( mps => {
                int index = 0;
                chartProductSold.Series.ToList().ForEach(series => {
                    series.Points.AddXY(mps.Month, mps.Product[index].Qty);
                    index++;
                });
            });


        }


        public void MonthlySalesExpenses()
        {
            chartSalesExpenses.Titles[0].Text = $"Monthly Sales and Expenses as of {DateTime.Now.Year}";
            chartSalesExpenses.Series.ToList().ForEach(series => series.Points.Clear());
            viewModel.monthlySalesExpenses.ForEach(se => {
                chartSalesExpenses.Series["Sales"].Points.AddXY(se.Month, se.Sales);
                chartSalesExpenses.Series["Expenses"].Points.AddXY(se.Month, se.Expenses);

            });
        }

        public async void MonthlyReservation()
        {
            chartReservation.Titles[0].Text = $"Monthly number of reservation as of  {DateTime.Now.Year}";
            var list = await viewModel.LoadMonthlyReservation();

            chartReservation.Series.ToList().ForEach(series => series.Points.Clear());
            list.ForEach(r => {
                chartReservation.Series["Reservation"].Points.AddXY(r.Month, r.Qty);
            });
        }

        
    }
}
