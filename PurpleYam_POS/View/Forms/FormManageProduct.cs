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
using System.IO;
using System.Drawing.Drawing2D;

namespace PurpleYam_POS.View.Forms
{
    public partial class FormManageProduct : MetroFramework.Forms.MetroForm
    {
        private ProductViewModel viewModel;
        private ProductUnitModel unit;
        private MemoryStream ms;
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
            viewModel.RecipeBS = RecipeBS;
            mcbRawMat.SelectedValueChanged +=  delegate
            {
                if (mcbRawMat.SelectedValue != null)
                {
                    unit = viewModel.BaseUnit((int)mcbRawMat.SelectedValue);
                    labelUnit.Text = unit.UnitCode;
                }
            };
            btnSave.Click += delegate {
                using (ms = new MemoryStream())
                {
                    Img.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

                }

                if (viewModel.productModel == null)
                {
                   
                        viewModel.productModel = new Model.ProductModel
                        {
                            Product = tbProduct.Text,
                            Quality = mcbQuality.Text,
                            Particulars = mcbParticulars.Text,
                            Price = tbPrice.Value,
                            Image = ms.GetBuffer(),
                            WithAddon = cbWithAddon.Checked
                        };
                }
                else
                {
                    viewModel.productModel.Product = tbProduct.Text;
                    viewModel.productModel.Particulars = mcbParticulars.Text;
                    viewModel.productModel.Quality = mcbQuality.Text;
                    viewModel.productModel.Image = ms.GetBuffer();
                    viewModel.productModel.Price = tbPrice.Value;
                    viewModel.productModel.WithAddon = cbWithAddon.Checked;
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
                        GrpUnitId = unit.Id,
                        UnitCode = unit.UnitCode,
                        
                    };
                }
                else
                {
                    viewModel.recipeModel.Product = mcbRawMat.Text;
                    viewModel.recipeModel.RawmatId = mcbRawMat.SelectedValue != null ? (int)mcbRawMat.SelectedValue : 0;
                    viewModel.recipeModel.Qty = !string.IsNullOrEmpty(tbQty.Text) ? decimal.Parse(tbQty.Text) : 0;
                    viewModel.recipeModel.GrpUnitId = !string.IsNullOrEmpty(unit.UnitCode) ? unit.Id : 0;
                    viewModel.recipeModel.UnitCode = unit.UnitCode;
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
            tbPrice.Value = 0;
            cbWithAddon.Checked = false;
            Img.BackgroundImage = Properties.Resources.cake_96px;
            tbProduct.Focus();
            

        }

        public void SetProductField()
        {
            tbProduct.Text = viewModel.productModel.Product;
            mcbParticulars.Text = viewModel.productModel.Particulars;
            mcbQuality.Text = viewModel.productModel.Quality;
            tbPrice.Value = viewModel.productModel.Price;
            cbWithAddon.Checked = viewModel.productModel.WithAddon;
            viewModel.recipeModel = new Recipe { ProductId = viewModel.productModel.Id };
            if(viewModel.productModel.Image != null)
                using (ms = new MemoryStream(viewModel.productModel.Image))
                {
                    Img.BackgroundImage = Image.FromStream(ms);

                }
            btnSaveRecipe.Enabled = true;
        }

        private void tbQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png) | *.jpg; *.jpeg; *.bmp; *.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Img.BackgroundImage = resizeImage(ofd.FileName, new Size(300,300));

                }
            }
        }

        private System.Drawing.Image resizeImage(string path, Size size)
        {
            Image img = new Bitmap(path);
            //Get the image current width  
            int sourceWidth = img.Width;
            //Get the image current height  
            int sourceHeight = img.Height;
            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //Calulate  width with new desired size  
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //Calculate height with new desired size  
            nPercentH = ((float)size.Height / (float)sourceHeight);
            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //New Width  
            int destWidth = (int)(sourceWidth * nPercent);
            //New Height  
            int destHeight = (int)(sourceHeight * nPercent);
            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            // Draw image with new width and height  
            g.DrawImage(img, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }

        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            viewModel.productModel = null;
            viewModel.recipeModel = null;
            btnSave.Enabled = true;
            btnNewProduct.Enabled = false;
            viewModel.RecipeBS.Clear();
            ResetField();
            
        }

        private void cbWithAddon_CheckedChanged(object sender, EventArgs e)
        {
            cbWithAddon.Text = cbWithAddon.Checked ? "With add-ons" : "Without add-ons";
        }
    }
}
