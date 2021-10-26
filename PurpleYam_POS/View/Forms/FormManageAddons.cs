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


namespace PurpleYam_POS.View.Forms
{
    public partial class FormManageAddons : MetroFramework.Forms.MetroForm
    {
        private AddonViewModel viewModel;

      
        public FormManageAddons(AddonViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            this.viewModel.UnitBS = UnitBS;
            btnSave.Click += delegate {
                if(viewModel.AddonModel == null)
                {
                    viewModel.AddonModel = new Model.ProductModel
                    {
                        Product = tbAddon.Text,
                        Price = tbPrice.Value,
                        IsAvailable = cbAvailable.Checked,
                        Quality = "none",
                        Particulars = "none",
                        UnitId =  cbHasUnit.Checked ? ((Model.Unit)UnitBS.Current).Id:0,
                        UnitCode = cbHasUnit.Checked ? ((Model.Unit)UnitBS.Current).UnitCode :""

                    };


                } else
                {
                    viewModel.AddonModel.Product = tbAddon.Text;
                    viewModel.AddonModel.Price = tbPrice.Value;
                    viewModel.AddonModel.IsAvailable = cbAvailable.Checked;
                    viewModel.AddonModel.Quality = "none";
                    viewModel.AddonModel.Particulars = "none";
                    viewModel.AddonModel.UnitId = cbHasUnit.Checked ? ((Model.Unit)UnitBS.Current).Id : 0;
                    viewModel.AddonModel.UnitCode = cbHasUnit.Checked ? ((Model.Unit)UnitBS.Current).UnitCode : null;
                }

                viewModel.SaveProduct();

            };
            this.Load += async delegate  { await this.viewModel.GetAllUnits(); };
        }

        public void SetAddonFields()
        {
            tbAddon.Text = viewModel.AddonModel.Product;
            tbPrice.Value = viewModel.AddonModel.Price;
            cbAvailable.Checked = viewModel.AddonModel.IsAvailable;
            cbUnit.SelectedValue = viewModel.AddonModel.UnitId;
            cbHasUnit.Checked = viewModel.AddonModel.UnitId != 0 ? true : false;
        }


        public void ResetAllFields()
        {
            tbAddon.Clear();
            tbPrice.Value = 0;
            cbAvailable.Checked = false;
        }

        private void cbHasUnit_CheckedChanged(object sender, EventArgs e)
        {
            cbHasUnit.Text = cbHasUnit.Checked ? "Has unit" : "No Unit";
            cbUnit.Enabled = cbHasUnit.Checked;
        }
    }
}
