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

namespace PurpleYam_POS.ViewModel
{
    public class ProductViewModel
    {

        private FormManageProduct form;
        private string sql;
        public Products uc;
        public Pagination page;

        public void New()
        {
            form = new FormManageProduct(this);
            form.Show();
        }

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
            sql = "SELECT Id, Product,Quality, Particulars,CreatedAt, UpdatedAt, ( SELECT COUNT(*) FROM tbl_recipies WHERE ProductId = Id)  AS Recipies FROM tbl_product WHERE Deleted = FALSE AND Product LIKE @Product ORDER BY Product ASC ";
            var p = new
            {
                Product = $"%{search}%"
            };

            page.sql = sql;
            page.search = search;
            page.totalRowsQry = @"SELECT COUNT(*) AS total FROM tbl_product where Deleted = false ";
            page.fileteredQry = @"SELECT COUNT(*) AS total FROM tbl_product where Deleted = false AND @Product LIKE @Product";

            await page.LoadDataTableAsync<ProductModel, dynamic>(p);
        }
    }
}
