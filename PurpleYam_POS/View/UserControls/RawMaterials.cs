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
using PurpleYam_POS.Model;
using PurpleYam_POS.helper;

namespace PurpleYam_POS.View.UserControls
{
    public partial class RawMaterials : MetroFramework.Controls.MetroUserControl
    {
        RawMaterialVM rawMatVM;
       

        public DataGridView dataGridView
        {
            get
            {
                return dgRawMat;
            }
        }

        public string SearchRawMat
        {
           get
            {
                return mtbSearch.Text;
            }
            set { mtbSearch.Text = value; }
        }
        
      
        public RawMaterials()
        {
            InitializeComponent();
            rawMatVM = new RawMaterialVM();
            rawMatVM.uc = this;
            rawMatVM.page = new Pagination(flowLayoutPanel1);
            rawMatVM.page.btnFirstPage.Click += rawMatVM.FirstPage;
            rawMatVM.page.btnLastPage.Click += rawMatVM.LastPage;
            rawMatVM.page.btnNext.Click += rawMatVM.NextPage;
            rawMatVM.page.btnPrev.Click += rawMatVM.PreviousPage;
            rawMatVM.page.cbPerPage.SelectedValueChanged += rawMatVM.LimitPerPage;
            rawMatVM.page.bindingSource = RawMatBS;
            dgRawMat.CellClick += rawMatVM.rawMatCellClick;
            btnAdd.Click += delegate { rawMatVM.New(new RawMaterial()); };
            btnDelete.Click += rawMatVM.DeleteSelected;
            cbAll.CheckedChanged += rawMatVM.rawMatCheckChanged;
            mtbSearch.TextChanged += rawMatVM.SearchRawMat;
          
        }

        private  void RawMaterials_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public async void LoadData()
        {
            await rawMatVM.LoadDataAsync();

        }

        private void mtbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                LoadData();
        }

        private void dgRawMat_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ((DataGridView)sender).ClearSelection();
        }
    }
}
