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
        public DateTime DtprFrom { get { return dtprFrom.Value; } }
        public DateTime DtprTo { get { return dtprTo.Value; } }
        public DateTime DtpwFrom { get { return dtpwFrom.Value; } }
        public DateTime DtpwTo { get { return dtpwTo.Value; } }
        public DataGridView DgReservation { get { return dgReservation; } }
        public MetroFramework.Controls.MetroTabControl TabSales { get { return tabSales; } }
        public string Search { get { return tbSearch.Text; } set { tbSearch.Text = value; } }
        public SaleTransaction()
        {
            InitializeComponent();
            viewModel = new SaleTransactionViewModel();
            viewModel.ucST = this;
            viewModel.SaleTransactionBS = SaleTransactionBS;
            viewModel.ProductBS = ProductBS;
            dgProduction.CellClick += viewModel.DgTransactionClick;
            dgReservation.CellClick += viewModel.DgTransactionClick;
        }

        private void dgProduction_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgProduction.ClearSelection();
        }

        public void LoadSales()
        {
            viewModel.LoadWalkinTransaction();
        }

        public void LoadReservation()
        {
            viewModel.LoadReservation();
        }

        private void DtpWalkin_ValueChanged(object sender, EventArgs e)
        {
            viewModel.LoadWalkinTransaction();
        }

        private void DtpReservation_ValueChanged(object sender, EventArgs e)
        {
            viewModel.LoadReservation();
        }
    }
}
