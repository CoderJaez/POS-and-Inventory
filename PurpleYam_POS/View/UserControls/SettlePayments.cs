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
using PurpleYam_POS.Components;

namespace PurpleYam_POS.View.UserControls
{
    public partial class SettlePayments : UserControl
    {


        private PosViewModel viewModel;

        public string TransactionNo { get; set; }

        public string TotalAmount
        {
            get { return labelTotal.Text; }
            set { labelTotal.Text = value; }
        }

        public string SubTotal
        {
            get { return labelSubTotal.Text; }
            set { labelSubTotal.Text = value; }
        }

        public string Tax
        {
            get { return labelTax.Text; }
            set { labelTax.Text = value; }
        }

        public string CashTendered
        {
            get { return tbCashTendered.Text; }
            set { tbCashTendered.Text = value; }
        }

        public string Balance
        {
            get { return tbBalance.Text; }
            set { tbBalance.Text = value; }
        }
        public SettlePayments(PosViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            this.viewModel.CheckoutBS  = ProductBS;
        }

        private void CashTendered_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void dgOrders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgOrders.ClearSelection();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            tbCashTendered.Text += $"{btn.Text}";
        }

        private void btnClearCashTendered(object sender, EventArgs e)
        {
            tbCashTendered.Clear();
        }

        private void tbCashTendered_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            if (decimal.Parse(Balance) > 0)
            {
                if (string.IsNullOrEmpty(CashTendered) || decimal.Parse(CashTendered) < decimal.Parse(Balance))
                {
                    Notification.AlertMessage("The cash amount is not enough to pay the balance. \nPlease try again.","Payment unsuccessful",Notification.AlertType.WARNING);
                    return;
                }

                viewModel.stModel.TransactionNo = TransactionNo;
                viewModel.stModel.CashTendered = decimal.Parse(CashTendered);
                viewModel.stModel.Change = viewModel.stModel.CashTendered - viewModel.stModel.TotalAmount;
                viewModel.stModel.Customer = new Model.CustomerModel();
                viewModel.stModel.DownPayment = 0;
                viewModel.stModel.Balance = 0;
                viewModel.SettlePayment();

            } else
            {
               if(decimal.Parse(CashTendered) < decimal.Parse(TotalAmount))
                {
                    Notification.AlertMessage("The cash amount is not enough. \nPlease try again.", "Payment unsuccessful", Notification.AlertType.WARNING);
                    return;
                }
                viewModel.stModel.CashTendered = decimal.Parse(CashTendered);
                viewModel.stModel.Change = viewModel.stModel.CashTendered - viewModel.stModel.TotalAmount;
                viewModel.stModel.Customer = new Model.CustomerModel();
                viewModel.stModel.DownPayment = 0;
                viewModel.SettlePayment();
            }
        }
    }
}
