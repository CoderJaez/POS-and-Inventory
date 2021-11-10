using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurpleYam_POS.ViewModel;
using PurpleYam_POS.helper;

namespace PurpleYam_POS.View.Forms
{
    public partial class FormManageUser : MetroFramework.Forms.MetroForm
    {
        public UserViewModel viewModel;

        public FormManageUser()
        {
            InitializeComponent();
        }

      

        private void btnSave_Click(object sender, EventArgs e)
        {
            viewModel.model = new Model.UserModel
            {
                Username = tbUsername.Text,
                Password = "12345",
                ConfirmPassword = "12345",
                AccessRole = cbAccessRole.Text,
                Customer = new Model.CustomerModel
                {
                    Firstname = tbFirstname.Text,
                    Middlename = tbMIddlename.Text,
                    Lastname = tbLastname.Text,
                    ContactNo = tbContactNo.Text,
                    Image = ImageLoader.ImageBuffer(pbImage.BackgroundImage)
                }
            };

            viewModel.SaveUser();
        }

      
        public void ResetAllFields()
        {
            groupBox1.Controls.OfType<Control>().ToList().ForEach(c => {
                if (c.GetType() == typeof(TextBox))
                    ((TextBox)c).Clear();
            });
           
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png) | *.jpg; *.jpeg; *.bmp; *.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbImage.Image = null;
                    pbImage.BackgroundImage = ImageLoader.ResizeImage(ofd.FileName, new Size(300, 300));

                }
            }
        }
    }
}
