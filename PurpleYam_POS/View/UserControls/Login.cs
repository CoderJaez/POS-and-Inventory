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
using PurpleYam_POS.Components;

namespace PurpleYam_POS.View.UserControls
{
    public partial class Login : MetroFramework.Controls.MetroUserControl
    {

        private UserViewModel viewModel;
        public Panel MainPanel
        {
            get { return panel1; }
        }
        public string Username { get { return tbUsername.Text; } set { tbUsername.Text = value; } }
        public string Password { get { return tbPassword.Text; } set { tbPassword.Text = value; } }

        public Login()
        {
            InitializeComponent();
            viewModel = new UserViewModel();
            viewModel.ucLogin = this;
        }


        private void Textbox_KeyDown(object sender, KeyEventArgs e)
        {
            var tb = (TextBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
                viewModel.LoginAuthentication();
                
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            viewModel.LoginAuthentication();
        }


    }
}
