using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Repository.DataAccess;
using static Repository.ProductionInventory;
using PurpleYam_POS.Model;
using PurpleYam_POS.ViewModel;
using PurpleYam_POS.View.UserControls;
using PurpleYam_POS.Components;
namespace PurpleYam_POS.ViewModel
{

    public class BakerViewModel
    {
        //UserControl
        public Baker ucBaker;

        private ProductModel model;

        public BindingSource ProductionBS { get; set; }



        public async void LoadPendingProduction()
        {
            var production = await LoadData<SoldProductModel, dynamic>("select Id,ProductId, Product, Particulars, Quality, QtyOnhand AS Qty,Status, DateStockin from production_stockin where Status = 'pending' Order by DateStockin ASC", new { });
            ucBaker.productPanel.Controls.Clear();
            production.ForEach(product =>
            {
                var prodComponent = new Product
                {
                    productModel = product,

                };
                prodComponent.SerProductForBaking();
                ucBaker.productPanel.Controls.Add(prodComponent);
                prodComponent.ButtonProduct.Click += new EventHandler(DoneProduction);
            });

        }

        private void DoneProduction(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var comp = btn.Parent as Product;
            if(Notification.Confim(FormMain.Instance,$"Is {comp.productModel.Product} done?","Cake status") == DialogResult.Yes)
            {
                ucBaker.productPanel.Controls.Remove(comp);
                UpdatePRStocks(comp.productModel.Id, comp.productModel.ProductId, comp.productModel.Qty);
                ProductionBS.Add(comp.productModel);
            }

        }
    }
}
