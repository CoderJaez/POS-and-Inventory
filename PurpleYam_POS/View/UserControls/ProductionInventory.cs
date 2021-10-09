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
    public partial class ProductionInventory : UserControl
    {
        private InventoryViewModel viewModel;
        public DataGridView DgProduction
        {
            get { return dgProduction; }
        }

       
        public ProductionInventory(InventoryViewModel _viewModel)
        {
            InitializeComponent();
            viewModel = _viewModel;
            viewModel.ProductPendingBS = ProductionPendingBS;
            viewModel.ProductInvBS = ProductionBS;
            dgProductionPending.CellClick += viewModel.PendingProdCellClick;
            
            this.Load += delegate { LoadData(); };

        }


        public void LoadData()
        {
            viewModel.LoadPendingProduction();
            viewModel.LoadProduction();
        }

        private void dgProduction_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }
    }
}
