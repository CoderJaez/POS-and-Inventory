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
    public partial class StockinProduction : UserControl
    {
        private InventoryViewModel viewModel;
        
        public StockinProduction(InventoryViewModel _viewModel)
        {
            InitializeComponent();
            viewModel = _viewModel;
            viewModel.ProductBS = ProductionBS;
            viewModel.ProductStockinBS = ProductStockinBS;
            btnSave.Click += delegate {
                if (dgProductionStockin.Rows.Count <= 0) return;
                viewModel.StockinProduction(dtpProduction.Value.Date);
            };

            btnClear.Click += delegate { viewModel.ClearProductionStockin(); };
            this.Load += delegate
            {
                dgProduct.CellClick += viewModel.AddToStockProduct;
                dgProductionStockin.CellClick += viewModel.DgProductionCellClick;
            };
        }


        private void Qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allowed numeric and one dot  ex. 10.23
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                 && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void dgProductionStockin_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Qty_KeyPress);
            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(Qty_KeyPress);
            }
        }

        private void dgProductionStockin_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }

        private void dgProductionStockin_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}
