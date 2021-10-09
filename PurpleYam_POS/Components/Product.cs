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

namespace PurpleYam_POS.Components
{
    public partial class Product : UserControl
    {
        public string productName { get { return lblProductName.Text; } set { lblProductName.Text = value; } }
        public string Price { get { return lblPrice.Text; } set { lblPrice.Text = value; } }
        public PictureBox Img { get { return pictureBox; } set { pictureBox = value; } }
        public SoldProductModel productModel { get; set; }
        public Product()
        {
            InitializeComponent();
        }
       
        
        public void SetProduct()
        {
            productName = productModel.Product;
            Price = productModel.Price.ToString();
            if (productModel.Image != null)
            {
                using (var ms = new MemoryStream(productModel.Image))
                    Img.BackgroundImage = Image.FromStream(ms);
            } else
                Img.BackgroundImage = Properties.Resources.cake_96px;
        }
    }
}
