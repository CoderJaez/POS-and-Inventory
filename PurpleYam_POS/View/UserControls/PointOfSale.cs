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
            viewModel = new PosViewModel(this);
            viewModel.ProductBS = ProductBS;
            dgOrders.CellClick += viewModel.AdjustQty;
            btnCheckout.Click += viewModel.Checkout_Click;
            this.Load +=  delegate {  viewModel.LoadProducts(); };
        }

        private void dgOrders_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgOrders.ClearSelection();
        }

        private void btnFilterProduct_Click(object sender, EventArgs e)
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
            viewModel.ProductBS.Clear();
            Tax = "0.00";
            SubTotal = "0.00";
            TotalAmount = "0.00";
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
    }
}
