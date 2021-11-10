using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurpleYam_POS.Model;
using System.IO;
using PurpleYam_POS.helper;

namespace PurpleYam_POS.Components
{
    public partial class Product : UserControl
    {
      public Button ButtonProduct
        { get { return btnProduct; } }
        public SoldProductModel productModel { get; set; }
        public Product()
        {
            InitializeComponent();
        }
       
        
        public void SetProduct()
        {
            lblProduct.Text = $"{productModel.Product}\n{productModel.Price.ToString("N")}";
            if (productModel.Image != null)
            {
                btnProduct.BackgroundImage = ImageLoader.ImageFromStream(productModel.Image);
            }
            else
            {
                btnProduct.Text = $"{productModel.Product} {productModel.UnitCode}\n{productModel.Price.ToString("N")}";
                lblProduct.Visible = false;
            }
        }

        public void SerProductForBaking()
        {

            lblProduct.Text = $"{productModel.Product}\nQTY:{productModel.Qty}";
            if (productModel.Image != null)
            {
                btnProduct.BackgroundImage = ImageLoader.ImageFromStream(productModel.Image);
            }
            else
            {
                btnProduct.Text = $"{productModel.Product}\nQTY:{productModel.Qty}";
                lblProduct.Visible = false;
            }
        }
    }
}
