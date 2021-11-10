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
using PurpleYam_POS.helper;

namespace PurpleYam_POS.View.UserControls
{
    public partial class UserProfile : UserControl
    {
        private UserViewModel viewModel;
        public UserProfile()
        {
            InitializeComponent();
            viewModel = new UserViewModel();
            btnSavePass.Click += delegate {
                FormMain.Instance.UserProfile.Password = tbPassword.Text;
                FormMain.Instance.UserProfile.ConfirmPassword = tbConfirmPassword.Text;
                viewModel.UpdatePassword(); };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gbEmp.Enabled = !gbEmp.Enabled;
            button1.Text = !gbEmp.Enabled ? "Edit" : "Cancel";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cbPass.Enabled = !cbPass.Enabled;
            button2.Text = !cbPass.Enabled ? "Edit" : "Cancel";
            if(!cbPass.Enabled)
            {
                tbPassword.Clear();
                tbConfirmPassword.Clear();
            }
        }

        public void SetProfile()
        {
            pbUser.Image = ImageLoader.ImageFromStream(FormMain.Instance.UserProfile.Customer.Image);
            tbLastname.Text = FormMain.Instance.UserProfile.Customer.Lastname;
            tbFirstname.Text = FormMain.Instance.UserProfile.Customer.Firstname;
            tbMIddlename.Text = FormMain.Instance.UserProfile.Customer.Middlename;
            tbContactNo.Text = FormMain.Instance.UserProfile.Customer.ContactNo;
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            FormMain.Instance.UserProfile.Customer.Lastname = tbLastname.Text;
            FormMain.Instance.UserProfile.Customer.Middlename = tbMIddlename.Text;
            FormMain.Instance.UserProfile.Customer.Firstname = tbFirstname.Text;
            FormMain.Instance.UserProfile.Customer.ContactNo = tbContactNo.Text;
            FormMain.Instance.UserProfile.Customer.Image = ImageLoader.ImageBuffer(pbUser.Image);
            viewModel.UpdateEmploryeeInfo();
        }

        private void btnSettlePayment_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "Image Files(*.jpg; *.jpeg; *.bmp; *.png) | *.jpg; *.jpeg; *.bmp; *.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbUser.Image = ImageLoader.ResizeImage(ofd.FileName, new Size(300, 300));

                }
            }

        }
    }
}
