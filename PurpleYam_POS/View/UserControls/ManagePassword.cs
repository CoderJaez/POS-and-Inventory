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

namespace PurpleYam_POS.View.UserControls
{
    public partial class ManagePassword : UserControl
    {
        public UserViewModel viewModel;
        public string NewPassword { get { return tbPassword.Text; } set { tbPassword.Text = value; } }
        public string ConfirmPassword { get { return tbConfirmPassword.Text; } set { tbConfirmPassword.Text = value; } }
        public Panel MainPanel { get { return panel1; } }
        public ManagePassword()
        {
            InitializeComponent();
        }


        private void Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FormMain.Instance.UserProfile.Password = NewPassword;
                FormMain.Instance.UserProfile.ConfirmPassword = ConfirmPassword;
                viewModel.UpdatePassword();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            viewModel.UpdatePassword();

        }
    }
}
