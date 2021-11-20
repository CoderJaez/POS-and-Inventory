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
    public partial class ExpensesSettings : UserControl
    {
        private ExpensesViewModel viewModel;
        public string description
        {
            get { return tbDesciption.Text; }
            set { tbDesciption.Text = value; }
        }
        public ExpensesSettings()
        {
            InitializeComponent();
            viewModel = new ExpensesViewModel();
            viewModel.ucExpSettings = this;
            viewModel.ExpenseCatBS = ExpenseCatBS;
            btnSave.Click +=  delegate {
                if(viewModel.expensesModel == null)
                {
                    viewModel.expensesModel = new Model.ExpensesModel
                    {
                        Description = description
                    };
                } else
                {
                    viewModel.expensesModel.Description = description;
                }
                viewModel.SaveExpenseCat();
            };
            dgExpenses.DataBindingComplete += delegate { dgExpenses.ClearSelection(); };
            dgExpenses.CellClick += viewModel.DgExpensesCellClick;
            btnCancel.Click += delegate { viewModel.ClearExpenseCat(); };
            cxbAll.CheckedChanged += delegate
            {
                foreach (DataGridViewRow row in dgExpenses.Rows)
                    row.Cells["Deleted"].Value = cxbAll.Checked;
            };
            btnDeleteSelected.Click += delegate { viewModel.DeleteSelectedExpenseCat(); };

        }

        public void LoadData()
        {
            viewModel.LoadExpensesCat(mtbSearch.Text);
        }
        private void mtbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                LoadData();
            }
        }
    }
}
