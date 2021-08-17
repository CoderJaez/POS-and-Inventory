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
    public partial class InventorySettings : UserControl
    {
        private InventoryViewModel viewModel;

        public Panel MainPanel
        {
            get { return mPanel; }
        }
        public InventorySettings()
        {
            InitializeComponent();
            viewModel = new InventoryViewModel();
            viewModel.ucInventorySettings = this;
            tvInventoryMenu.NodeMouseClick += viewModel.InventoryMenu;
        }
    }
}
