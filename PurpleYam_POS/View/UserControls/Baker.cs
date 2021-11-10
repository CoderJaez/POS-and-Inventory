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
    public partial class Baker : UserControl
    {
        BakerViewModel viewModel;
        public FlowLayoutPanel productPanel { get { return flpProducts; } }
        public Baker()
        {
            InitializeComponent();
            viewModel = new BakerViewModel();
            viewModel.ucBaker = this;
            viewModel.ProductionBS = ProductBS;
            //this.Load += delegate { viewModel.LoadPendingProduction(); };
            dgOrders.DataBindingComplete += delegate { dgOrders.ClearSelection(); };
        }

        public void LoadData()
        {
            viewModel.LoadPendingProduction();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            viewModel.LoadPendingProduction();
        }
    }
}
