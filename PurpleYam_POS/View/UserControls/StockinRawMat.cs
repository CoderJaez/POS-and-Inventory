using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurpleYam_POS.View.UserControls;
using PurpleYam_POS.View.Forms;
using PurpleYam_POS.Model;
using PurpleYam_POS.ViewModel;
namespace PurpleYam_POS.View.UserControls
{
    public partial class StockinRawMat : UserControl
    {
        private InventoryViewModel viewModel;
        public DateTime DateArrival
        {
            get { return dateTPDateArrival.Value; }
        }

        public ComboBox CbUnitCode
        {
            get { return cbUnitCode; }
        }
       
        public DataGridView DgStockIn
        {
            get { return dgRawMatStockin; }
        }
        public DateTimePicker DateExpiryDTP
        {
            get { return dateTimePicker; }
        }

        public BindingSource ucRamatBS
        {
            get { return RawMatBS; }
        }
        public StockinRawMat(InventoryViewModel _viewMdodel)
        {
            InitializeComponent();
            viewModel = _viewMdodel;
            viewModel.RawmatBS = RawMatBS;
            viewModel.StockInBS = StockInBS;
            viewModel.UnitBS = UnitBS;
            btnSave.Click += delegate {
                if (viewModel.StockInBS.Count <= 0) return;
                viewModel.StockInRawMat(); };
            this.Load += delegate {
                dgRawMatStockin.CellClick += viewModel.DgStockinCellClick;
                dgRawMat.CellClick += viewModel.AddToStock;
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

        private void dgRawMatStockin_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Qty_KeyPress);
            TextBox tb = e.Control as TextBox;
            if (tb != null)
            {
                tb.KeyPress += new KeyPressEventHandler(Qty_KeyPress);
            }
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var currentRow = viewModel.StockInBS.Current as RawMaterial;
           if(currentRow != null)
            {
                currentRow.DateExpiry = dateTimePicker.Value;
                dgRawMatStockin.CurrentRow.Selected = false;
                viewModel.StockInBS.EndEdit();
            } else
                dateTimePicker.Visible = false;
        }

        private void dgRawMatStockin_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

       
        private void cbUnitCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbUnitCode.SelectedValue != null)
            {
                var currentRow = viewModel.StockInBS.Current as RawMaterial;
                if (currentRow != null)
                {
                    currentRow.UnitId = (int)cbUnitCode.SelectedValue;
                    currentRow.DisplayUnit = cbUnitCode.Text;
                    cbUnitCode.Visible = false;
                }
                else
                    cbUnitCode.Visible = false;
            }

        }
    }
}
