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
    public partial class StockAdjRawMat : UserControl
    {
        private InventoryViewModel viewModel;
        public BindingSource ucRawmatBS
        {
            get { return RawMatBS; }
        }

        public TextBox TbProduct
        {
            get { return tbProduct; }
        }
        public TextBox TbQty
        {
            get { return tbQty; }
        }

        public ComboBox CbRemarks
        {
            get { return cbRemarks; }
        }

        public CheckBox CkbAdd
        {
            get { return ckBAdd; }
        }

        public CheckBox CkbRemove
        {
            get { return ckBRemove; }
        }
        public StockAdjRawMat(InventoryViewModel _viewModel)
        {
            InitializeComponent();
            viewModel = _viewModel;
            viewModel.InventoryBS = InvRawMatBS;
            viewModel.RawmatBS = RawMatBS;
            btnSave.Click += delegate { viewModel.AdjustRawmatStock(); };
            dgRawMat.CellClick += delegate
            {
                viewModel.SelectRawmat();
            };
            dgRMInventory.CellClick += delegate {
                if(dgRMInventory.Rows.Count > 0)
                {
                    var obj = viewModel.InventoryBS.Current as RawMaterial;
                    viewModel.StockinRawmat(obj.Id);
                }
            };
        }

        private void ckBAdd_CheckedChanged(object sender, EventArgs e)
        {
            ckBRemove.Checked = false;
        }

        private void ckBRemove_CheckedChanged(object sender, EventArgs e)
        {
            ckBAdd.Checked = false;
        }

        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgRMInventory_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }
    }
}
