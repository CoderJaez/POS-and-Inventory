using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using PurpleYam_POS.ViewModel;
using PurpleYam_POS.Model;

namespace PurpleYam_POS.View.Forms
{
    public partial class FormManageProduct : MetroFramework.Forms.MetroForm
    {
        private ProductViewModel viewModel;

       
        public Button BtnNewProduct
        {
            get { return btnNewProduct; }
        }

        public Button  BtnSaveProduct
        {
            get { return btnSave; }
        }

        public Button BtnSaveRecipe
        {
            get { return btnSaveRecipe; }
        }

        public TextBox TbQty
        {
            get { return tbQty; }
        }
        public FormManageProduct(ProductViewModel _viewModel)
        {
            InitializeComponent();
            viewModel = _viewModel;
            viewModel.RawMatBS = RawMatBS;
            viewModel.UnitBS = UnitBS;
            viewModel.RecipeBS = RecipeBS;
            mcbRawMat.SelectedValueChanged += async delegate
            {
                if (mcbRawMat.SelectedValue != null)
                    await viewModel.GetUnit((int)mcbRawMat.SelectedValue);
            };
            btnSave.Click += delegate {
                if(viewModel.productModel == null)
                    viewModel.productModel = new Model.ProductModel
                    {
                        Product = tbProduct.Text,
                        Quality = mcbQuality.Text,
                        Particulars = mcbParticulars.Text,
                    };
                else
                {
                    viewModel.productModel.Product = tbProduct.Text;
                    viewModel.productModel.Particulars = mcbParticulars.Text;
                    viewModel.productModel.Quality = mcbQuality.Text;
                }
                viewModel.SaveProduct();
            };

            btnSaveRecipe.Click += delegate {
                if (viewModel.recipeModel == null)
                {
                    viewModel.recipeModel = new Recipe
                    {
                        ProductId = viewModel.productModel.Id,
                        Product = mcbRawMat.Text,
                        RawmatId = mcbRawMat.SelectedValue != null ? (int)mcbRawMat.SelectedValue : 0,
                        Qty = !string.IsNullOrEmpty(tbQty.Text) ? decimal.Parse(tbQty.Text) : 0,
                        GrpUnitId = !string.IsNullOrEmpty(mcbUnit.Text) ? (int)mcbUnit.SelectedValue:0,
                        UnitCode = mcbUnit.Text
                    };
                }
                else
                {
                    viewModel.recipeModel.Product = mcbRawMat.Text;
                    viewModel.recipeModel.RawmatId = mcbRawMat.SelectedValue != null ? (int)mcbRawMat.SelectedValue : 0;
                    viewModel.recipeModel.Qty = !string.IsNullOrEmpty(tbQty.Text) ? decimal.Parse(tbQty.Text) : 0;
                    viewModel.recipeModel.GrpUnitId = !string.IsNullOrEmpty(mcbUnit.Text) ? (int)mcbUnit.SelectedValue : 0;
                    viewModel.recipeModel.UnitCode = mcbUnit.Text;
                }
                viewModel.SaveRecipe();
            };

            this.Load += async delegate { await viewModel.GetRawMat(); dgRawMat.CellClick += viewModel.EditRecipe; };
        }

        public void ResetField()
        {
            tbProduct.Text = null;
            mcbParticulars.Text = null;
            mcbQuality.Text = null;
            tbProduct.Focus();

        }

        public void SetProductField()
        {
            tbProduct.Text = viewModel.productModel.Product;
            mcbParticulars.Text = viewModel.productModel.Particulars;
            mcbQuality.Text = viewModel.productModel.Quality;
            viewModel.recipeModel = new Recipe { ProductId = viewModel.productModel.Id };
            btnSaveRecipe.Enabled = true;
        }

        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }
    }
}
