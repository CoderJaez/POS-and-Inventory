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
    public partial class AddOns : UserControl
    {
        private AddonViewModel viewModel;
        public DataGridView DgAddons
        {
            get { return dgProducts; }
        }
        public AddOns()
        {
            InitializeComponent();
            viewModel = new AddonViewModel();
            viewModel.AddonsBS = AddonBS;
            viewModel.uc = this;
            btnAdd.Click += delegate { viewModel.New(); };
            dgProducts.DataBindingComplete += delegate { dgProducts.ClearSelection(); };
            dgProducts.CellClick += viewModel.AddonsCellClick;
        }


        public async void LoadData()
        {
            await  this.viewModel.GetAllAddons(mtbSearch.Text);
        }

       

        private void mtbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadData();
        }
    }
}
