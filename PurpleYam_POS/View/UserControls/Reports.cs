using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurpleYam_POS.ViewModel;

namespace PurpleYam_POS.View.UserControls
{
    public partial class Reports : UserControl
    {
        private ReportsViewModel viewModel;

        public Reports()
        {
            InitializeComponent();
            viewModel = new ReportsViewModel();
            viewModel.StockBS = StockBS;
            viewModel.ProductionBS = ProductionBS;
            viewModel.DailySalesBS = DailySalesBS;
            viewModel.ExpensesBS = ExpensesBS;
            viewModel.ProductStockinBS = ProductionStockinBS;
            viewModel.RawmatStockinBS = RawmatStockinBS;
            viewModel.ReservationBS = ReservationBS;
        }

        private void tcReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            //switch(tcReports.SelectedTab.Name)
            //{
            //    case "StockRoom":
            //        viewModel.GetStockRawmat(dtpSTRI.Value.ToString("MM-yyyy"));
            //        break;
            //    case "DailySales":
            //        viewModel.GetDailySales(dtpSales.Value);
            //        break;
            //}
        }

        private void dtpSTRI_ValueChanged(object sender, EventArgs e)
        {
            viewModel.GetStockRawmat(dtpSTRI.Value.ToString("MM-yyyy"));
        }

        private void dtpProduction_ValueChanged(object sender, EventArgs e)
        {
        }

        private void DataGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }

        private void dtpSales_ValueChanged(object sender, EventArgs e)
        {
            viewModel.GetDailySales(dtpSales.Value.Date);
            var total = viewModel.DailySalesBS.List.OfType<Model.ProductionStock>().Select(p => p.TotalAmount).Sum();
            lblTotalSales.Text = total.ToString("N");

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            string report = ((Button)sender).Tag.ToString();
            viewModel.PrintPreview(report);
            
        }

        private void dtpExpenses_ValueChanged(object sender, EventArgs e)
        {
            viewModel.GetExpenses(dtpEFrom.Value, dtpETo.Value);
            
            var total =  viewModel.ExpensesBS.List.OfType<Model.ExpensesModel>().Select(exp => exp.Amount).Sum();
            lblTotalExpenses.Text = total.ToString("N");

        }

        private void dtpProductionStockin_ValueChanged(object sender, EventArgs e)
        {
            viewModel.GetProductionStockin(dtpPSFrom.Value, dtpPSTo.Value);

        }

        private void dtpRawmatStockin_ValueChanged(object sender, EventArgs e)
        {
            viewModel.GetRawmatStockin(dtpRSFrom.Value, dtpRSTo.Value);

        }

        private void dtpReservation_ValueChanged(object sender, EventArgs e)
        {
            viewModel.GetReservation(dtpRFrom.Value, dtpRTo.Value);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
