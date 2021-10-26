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
    public partial class Checkout : UserControl
    {
        private PosViewModel viewModel;


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
        public string Balance
        {
            get { return labelBalance.Text; }
            set { labelBalance.Text = value; }
        }

        public string DownPayment
        {
            get { return tbDownPayment.Text;}
            set { tbDownPayment.Text = value; }
        }

        public string CashTendered
        {
            get { return tbCashTendered.Text; }
            set { tbCashTendered.Text = value; }
        }

        public Checkout(PosViewModel _viewModel)
        {
            InitializeComponent();
            viewModel = _viewModel;
            viewModel.CheckoutBS = ProductBS;
            btnSearch.Click += viewModel.OpenCustomerClick;

        }

        private void dgOrders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgOrders.ClearSelection();
        }

        private void tbDownPayment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void tbDownPayment_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbDownPayment.Text))
            {
                if(decimal.Parse(tbDownPayment.Text) <= viewModel.stModel.TotalAmount)
                {
                    viewModel.stModel.DownPayment = decimal.Parse(tbDownPayment.Text);
                    viewModel.stModel.Balance = viewModel.stModel.TotalAmount - viewModel.stModel.DownPayment;
                    Balance = viewModel.stModel.Balance.ToString("N");
                } else
                {
                    Notification.ValidationMessage(FormMain.Instance, "The down payment must not exceed to the total amount to be paid", "Amount exceed");
                    DownPayment = null;
                    Balance = "0.00";
                    tbDownPayment.Focus();
                }

            }
            else
                Balance = "0.00";

        }

        private void tbCashTendered_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(tbCashTendered.Text))
            {
                MakePayment();
            }
        }

        private void tbCashTendered_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbCashTendered.Text))
            {
                MakePayment();
            }
        }

        private void MakePayment()
        {
            
            viewModel.stModel.ReservationDate = DateTime.Parse($"{reserveDate.Value.ToString("yyyy-MM-dd")} {reserveTime.Value.ToString("HH:mm:ss")}");
            viewModel.stModel.CashTendered = decimal.Parse(tbCashTendered.Text);
            viewModel.stModel.Change = viewModel.stModel.CashTendered - viewModel.stModel.DownPayment;
            viewModel.SettlePayment();

        }

        public void AssignCustomer()
        {
            lblCustomer.Text = viewModel.stModel.Customer.Fullname;
            lblContactNo.Text = viewModel.stModel.Customer.ContactNo;
        }
    }
}
