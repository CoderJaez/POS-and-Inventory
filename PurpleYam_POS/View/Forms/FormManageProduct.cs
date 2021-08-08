using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using PurpleYam_POS.ViewModel;
namespace PurpleYam_POS.View.Forms
{
    public partial class FormManageProduct : MetroFramework.Forms.MetroForm
    {
        private ProductViewModel viewModel;

        public FormManageProduct(ProductViewModel _viewModel)
        {
            InitializeComponent();
            viewModel = _viewModel;
        }
    }
}
