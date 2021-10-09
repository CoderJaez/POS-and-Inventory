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
using PurpleYam_POS.Model;

namespace PurpleYam_POS.View.UserControls
{
    public partial class RawmatInventory : UserControl
    {
        private InventoryViewModel viewModel;
        public DataGridView DgRawmat
        {
            get { return dgRawMat;}
        }

       
        public string Title
        {
            get { return labelTitle.Text; }
            set { labelTitle.Text = value; }
        }
        public RawmatInventory(InventoryViewModel _viewModel)
        {
            InitializeComponent();
            viewModel = _viewModel;
            viewModel.InventoryBS = RawMatBS;
        }

        private void dgRawMat_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }
    }
}
