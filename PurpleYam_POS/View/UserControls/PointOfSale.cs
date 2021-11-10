using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurpleYam_POS.Components;
using PurpleYam_POS.Model;
using PurpleYam_POS.ViewModel;

namespace PurpleYam_POS.View.UserControls
{
    public partial class PointOfSale : UserControl
    {
        private PosViewModel viewModel;
        public FlowLayoutPanel PanelProducts
        {
            get { return panelProducts; }
        }

        public string TotalAmountB
        {
            set { lblTotalBig.Text = value; }
        }
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
      
         public BindingSource POSProductBS
        {
            get { return ProductBS; }
        }

        public Button BtnClearOrders
        {
            get { return btnClear; }
        }


        public PointOfSale()
        {
            InitializeComponent();
            viewModel = new PosViewModel();
            viewModel.uc = this;
            viewModel.ProductBS = ProductBS;
            dgOrders.CellClick += viewModel.AdjustQty;
            btnCheckout.Click += viewModel.Checkout_Click;
            this.Load +=  delegate {  viewModel.LoadProducts(); viewModel.LoadMenuButtons(); };
            btnCustomer.Click += viewModel.OpenCustomerClick;
            btnReservation.Click += delegate { viewModel.Reservations(); };
            SetPrinter();
            timer1.Start();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void dgOrders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgOrders.ClearSelection();
        }

        public void btnFilterProduct_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            isClicked(btn);
            if (btn.Tag.ToString().ToUpper() == "ALL")
                viewModel.LoadProducts();
            else 
                viewModel.LoadProducts(btn.Tag.ToString().ToUpper());
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            viewModel.stModel = new SaleTransactionModel();
            viewModel.ProductBS.Clear();
            viewModel.LoadProducts();
            Tax = "0.00";
            SubTotal = "0.00";
            TotalAmount = "0.00";
            TotalAmountB = TotalAmount;
        }

        private void isClicked(object button)
        {
            foreach (Control btn in panelMenu.Controls)
            {
                if (btn.GetType() == typeof(Button))
                {
                    if (btn == button)
                    {
                        btn.BackColor = Color.FromArgb(96, 44, 121);
                        btn.ForeColor = Color.White;
                    }
                    else
                    {
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void printer_Click(object sender, EventArgs e)
        {

            if(Notification.Confim(FormMain.Instance,$"{(Properties.Settings.Default.printer ? "Disable printer?":"Enable printer?")}","Printer setup") == DialogResult.Yes)
            {
                Properties.Settings.Default.printer = !Properties.Settings.Default.printer;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
            
            printer.Text = Properties.Settings.Default.printer ? "Printer enabled" : "Printer disabled";
        }

        private void SetPrinter()
        {
            printer.Text = Properties.Settings.Default.printer ? "Printer enabled" : "Printer disabled";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void PointOfSale_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }
    }
}
