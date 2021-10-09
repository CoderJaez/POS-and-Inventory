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
    public partial class SaleTransaction : MetroFramework.Controls.MetroUserControl
    {
        private SaleTransactionViewModel viewModel;
        public SaleTransaction()
        {
            InitializeComponent();
            viewModel = new SaleTransactionViewModel();
            viewModel.ucST = this;
            viewModel.SaleTransactionBS = SaleTransactionBS;
        }

        private void dgProduction_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgProduction.ClearSelection();
        }

        public void LoadSales()
        {
            viewModel.LoadTransactions();
        }
    }
}
