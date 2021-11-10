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
    public partial class Accounts : UserControl
    {
        private UserViewModel viewModel;
        public Accounts()
        {
            InitializeComponent();
            viewModel = new UserViewModel();
            viewModel.AccountBS = UsersBS;
            btnAdd.Click += delegate { viewModel.New(); };
            dgProducts.DataBindingComplete += delegate { dgProducts.ClearSelection(); };
            dgProducts.CellClick += viewModel.DeleteUser;
        }


        public void LoadData()
        {
            viewModel.LoadUser();
        }

        private void mtbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                viewModel.LoadUser(mtbSearch.Text);

        }
    }
}
