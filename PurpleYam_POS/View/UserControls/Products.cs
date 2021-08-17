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
using PurpleYam_POS.helper;

namespace PurpleYam_POS.View.UserControls
{
    public partial class Products : UserControl
    {
        private ProductViewModel viewModel;
        

        public string SearchProduct
        {
            get { return mtbSearch.Text; }
        }

        public DataGridView DgProducts
        {
            get { return dgProducts; }
        }
        public Products()
        {
            InitializeComponent();
            viewModel = new ProductViewModel();
            viewModel.uc = this;
            viewModel.page = new Pagination(panelPagination);
            viewModel.page.btnFirstPage.Click += viewModel.FirstPage;
            viewModel.page.btnLastPage.Click += viewModel.LastPage;
            viewModel.page.btnNext.Click += viewModel.NextPage;
            viewModel.page.btnPrev.Click += viewModel.PreviousPage;
            viewModel.page.cbPerPage.SelectedValueChanged += viewModel.LimitPerPage;
            viewModel.page.bindingSource = ProductBS;
            btnAdd.Click += delegate { viewModel.productModel = null; viewModel.New(); };
            dgProducts.CellClick += viewModel.dgProducts_CellClick;
            this.Load += async delegate { await viewModel.GetAllAsync(mtbSearch.Text); };    
        }
    }
}
