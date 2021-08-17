using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Repository.DataAccess;
using PurpleYam_POS.View.Forms;
using PurpleYam_POS.View.UserControls;
using PurpleYam_POS.helper;
using PurpleYam_POS.Model;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using PurpleYam_POS.Components;

namespace PurpleYam_POS.ViewModel
{
    public class ProductViewModel
    {
        /// <summary>
        /// Forms and UserControl
        /// </summary>
        private FormManageProduct form;
        private string sql;
        public Products uc;

        //Form controls
        DataGridView dg;
        //Components pagination
        public Pagination page;


        /// <summary>
        /// Models
        /// </summary>
        public ProductModel productModel;
        public Recipe recipeModel;
        /// <summary>
        /// Binding Sources
        /// </summary>
        public BindingSource RawMatBS { get; set; }
        public BindingSource UnitBS { get; set; }
        public BindingSource RecipeBS { get; set; }
      
        internal async void FirstPage(object sender, EventArgs e)
        {
            page.start += page.limit;
            page.page += 1;

            if ((page.totalRows - page.start) <= page.limit)
            {

                page.btnLastPage.Enabled = false;
                page.btnNext.Enabled = false;
            }

            page.btnPrev.Enabled = true;
            page.btnFirstPage.Enabled = true;
            await GetAllAsync(uc.SearchProduct);
        }

        internal async void LimitPerPage(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            page.limit = cb.Text == "" ? 50 : int.Parse(cb.Text);
            page.start = 0;
            page.page = 1;

            await GetAllAsync(uc.SearchProduct);
        }

        internal async void LastPage(object sender, EventArgs e)
        {
            page.page = page.totalRows / page.limit;
            page.start = page.page * page.limit;
            page.btnPrev.Enabled = true;
            page.btnLastPage.Enabled = false;
            page.btnFirstPage.Enabled = true;

            await GetAllAsync(uc.SearchProduct);
        }

        internal async void NextPage(object sender, EventArgs e)
        {
            page.start += page.limit;
            page.page += 1;

            if ((page.totalRows - page.start) <= page.limit)
            {

                page.btnLastPage.Enabled = false;
                page.btnNext.Enabled = false;
            }

            page.btnPrev.Enabled = true;
            page.btnFirstPage.Enabled = true;
            await GetAllAsync(uc.SearchProduct);
        }

      

        internal async void PreviousPage(object sender, EventArgs e)
        {
            page.start -= page.limit;
            page.page -= 1;
            if (page.start <= 0)
            {
                page.start = 0;
                page.page = 1;
                page.btnPrev.Enabled = false;
                page.btnFirstPage.Enabled = false;
            }
            page.btnLastPage.Enabled = true;
            await GetAllAsync(uc.SearchProduct);
        }

        public async Task GetAllAsync(string search)
        {
            sql = "SELECT Id, Product,Quality, Particulars,DateTimeStamp, ( SELECT COUNT(*) FROM tbl_recipe WHERE ProductId = tbl_product.Id)  AS Recipies FROM tbl_product WHERE Deleted = FALSE AND Product LIKE @Product ORDER BY Product ASC ";
            var p = new
            {
                Product = $"%{search}%"
            };

            page.sql = sql;
            page.search = search;
            page.totalRowsQry = @"SELECT COUNT(*) AS total FROM tbl_product where Deleted = false ";
            page.fileteredQry = @"SELECT COUNT(*) AS total FROM tbl_product where Deleted = false AND @Product LIKE @Product";

            if (uc.DgProducts.Rows.Count > 0)
                uc.DgProducts.Rows[0].Selected = false;
            await page.LoadDataTableAsync<ProductModel, dynamic>(p);
        }

        #region AddProducts
        public void dgProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             dg = (DataGridView)sender;
            if (dg.Rows.Count > 0)
            {
                productModel = page.bindingSource.Current as ProductModel;
                switch(dg.Columns[e.ColumnIndex].Name)
                {
                    case "edit":
                        New();
                        break;
                    case "delete":
                        DeleteProduct();
                        break;

                }
            }
        }

        /// <summary>
        /// Add New Products
        /// </summary>
        public void New()
        {
            using (form = new FormManageProduct(this))
            {
                
                if (productModel != null )
                {
                    form.SetProductField();
                    GetRecipes(productModel.Id);
                    if(recipeModel == null)
                        recipeModel = new Recipe { ProductId = productModel.Id };
                }
                form.ShowDialog();
                form.BtnSaveProduct.Enabled = true;
                form.BtnNewProduct.Enabled = false;
                form.BtnSaveRecipe.Enabled = false;
            }
        }

        public async  Task GetRawMat()
        {
            sql = "select * from rawmaterial where Deleted = false order by Product ASC";
            RawMatBS.DataSource = await Task.Run(() => LoadData<RawMaterial,dynamic>(sql, new { }));
        }

        public async void GetRecipes(int productId)
        {
            sql = @"SELECT r.*, rm.Product, units.UnitCode FROM tbl_recipe r 
	                    LEFT JOIN rawmaterial rm ON rm.Id = r.RawmatId
	                    LEFT JOIN units ON units.Id = r.GrpUnitId
	                    WHERE r.Deleted = FALSE and r.ProductId = @ProductId";
            RecipeBS.DataSource = await LoadData<Recipe, dynamic>(sql, new { ProductId = productId });
        }
        public async Task GetUnit(int Id)
        {
            sql = "select Id, UnitCode from units where ProductId =@ProductId  ";
            UnitBS.DataSource = await Task.Run(()=>LoadData<Unit, dynamic>(sql, new { ProductId = Id }));
            
        }


        public void SaveProduct()
        {
            ValidationContext context = new ValidationContext(productModel);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(productModel, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage}\n");
                Notification.ValidationMessage(FormMain.Instance, errorMsg.ToString(), "Validation Error");
                return;
            }

            var p = new
            {
                Product = productModel.Product,
                Particulars = productModel.Particulars,
                Quality = productModel.Quality,
                Id = productModel.Id
            };

            if (productModel.Id == 0)
            {
                sql = "INSERT INTO tbl_product (Product, Particulars, Quality) VALUES (@Product, @Particulars, @Quality);SELECT last_insert_id();";
                productModel.Id = SaveGetId(sql, p);
                page.bindingSource.Add(productModel);
                Notification.AlertMessage("New product saved.", "Success", Notification.AlertType.SUCCESS);
                form.BtnSaveProduct.Enabled = false;
                form.BtnNewProduct.Enabled = true;
                form.BtnSaveRecipe.Enabled = true;
            } else
            {
                sql = "UPDATE tbl_product SET Product = @Product, Particulars = @Particulars, Quality = @Quality WHERE Id = @Id";
                SaveData(sql, p);
                uc.DgProducts.Rows[0].Selected = false;
                page.bindingSource.EndEdit();
                Notification.AlertMessage("Product update.", "Success", Notification.AlertType.SUCCESS);
                form.ResetField();
                form.BtnSaveProduct.Enabled = false;
                form.BtnNewProduct.Enabled = true;
            }

        }

        private void DeleteProduct()
        {
            if (Notification.Confim(FormMain.Instance, "Do you want to delete selected product?", "Delete product") == DialogResult.Yes)
            {
                sql = "UPDATE tbl_product SET Deleted = true WHERE Id = @Id";
                SaveData(sql, new { Id = productModel.Id });
                Notification.AlertMessage("Recipe deleted.", "Success", Notification.AlertType.SUCCESS);
                page.bindingSource.Remove(productModel);
                productModel = null;
            }
        }
        #endregion

        #region Recipe
        public void SaveRecipe()
        {
            ValidationContext context = new ValidationContext(recipeModel);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(recipeModel, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage}\n");
                Notification.ValidationMessage(FormMain.Instance, errorMsg.ToString(), "Validation Error");
                return;
            }

            var p = new
            {
                ProductId = recipeModel.ProductId,
                RawmatId = recipeModel.RawmatId,
                GrpUnitId = recipeModel.GrpUnitId,
                Qty = recipeModel.Qty,
                Id = recipeModel.Id
            };
            if (recipeModel.Id == 0)
            {
                sql = "INSERT INTO tbl_recipe (ProductId, RawmatId, GrpUnitId, Qty) VALUES (@ProductId, @RawmatId, @GrpUnitId, @Qty);select last_insert_id()";
                recipeModel.Id = SaveGetId(sql, p);
                Notification.AlertMessage("Recipe added.", "Success", Notification.AlertType.SUCCESS);
                RecipeBS.Add(recipeModel);
                form.TbQty.Text = null;
                recipeModel = null;
            } else
            {
                sql = "UPDATE tbl_recipe SET RawmatId = @RawmatId, GrpUnitId = @GrpUnitId, Qty = @Qty WHERE Id = @Id";
                SaveData(sql, p);
                Notification.AlertMessage("Recipe updated.", "Success", Notification.AlertType.SUCCESS);
                RecipeBS.EndEdit();
                dg.CurrentRow.Selected = false;
                form.TbQty.Text = null;
                recipeModel = null;

            }

        }

        private void DeleteRecipe()
        {
            if(Notification.Confim(FormMain.Instance, "Do you want to delete selected recipe?","Delete recipe") == DialogResult.Yes)
            {
                sql = "UPDATE tbl_recipe SET Deleted = true WHERE Id = @Id";
                SaveData(sql, new { Id = recipeModel.Id });
                Notification.AlertMessage("Recipe deleted.", "Success", Notification.AlertType.SUCCESS);
                RecipeBS.Remove(recipeModel);
                recipeModel = null;
            }
        }

        public void EditRecipe(object sender, DataGridViewCellEventArgs e)
        {
             dg = (DataGridView)sender;
            if(dg.Rows.Count > 0)
            {
                 recipeModel = RecipeBS.Current as Recipe;
                switch(dg.Columns[e.ColumnIndex].Name)
                {
                    case "edit":
                        var rawmatIndex = RawMatBS.List.OfType<RawMaterial>().ToList().Find(r => r.Id == recipeModel.RawmatId);
                        RawMatBS.Position = RawMatBS.IndexOf(rawmatIndex);
                        form.TbQty.Text = recipeModel.Qty.ToString();
                        break;
                    case "delete":
                        DeleteRecipe();
                        break;
                }
            }
        }
        #endregion
    }
}
