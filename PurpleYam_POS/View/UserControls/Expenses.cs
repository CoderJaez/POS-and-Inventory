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
using PurpleYam_POS.Components;

namespace PurpleYam_POS.View.UserControls
{
    public partial class Expenses : UserControl
    {
        private ExpensesViewModel viewModel;
        public DateTime DtpFrom { get { return dtpFrom.Value; } }
        public DateTime DtpTo { get { return dtpTo.Value; } }
        public Button BtnCancel { get { return btnCancel; } }
        public Expenses()
        {
            InitializeComponent();
            viewModel = new ExpensesViewModel();
            viewModel.ucExpenses = this;
            viewModel.ExpensesBS = ExpensesBS;
            viewModel.ExpenseCatBS = ExpenseCatBS;
            dgExpenses.CellClick += viewModel.DgExpenseCellClick;
            dgExpenses.DataBindingComplete += delegate { dgExpenses.ClearSelection(); };
        }


        public void LoadData()
        {
            viewModel.LoadExpenses();
            viewModel.LoadExpensesCat();

        }

        public void SetExpenseField()
        {
            var obj = viewModel.ExpenseCatBS.List.OfType<Model.ExpensesModel>().ToList().Find(e => e.Id == viewModel.expensesModel.ExpenseId);
            viewModel.ExpenseCatBS.Position = viewModel.ExpenseCatBS.IndexOf(obj);
            tbReciept.Text = viewModel.expensesModel.ReceiptNo;
            tbRemarks.Text = viewModel.expensesModel.Remarks;
            tbAmount.Text = viewModel.expensesModel.Amount.ToString() ;
        }

        private void Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbAmount.Clear();
            tbReciept.Clear();
            tbRemarks.Clear();
            dtp.Value = DateTime.Today;
            viewModel.ExpenseCatBS.Position = 0;
            viewModel.expensesModel = null;
            dgExpenses.ClearSelection();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbAmount.Text))
            {
                Notification.AlertMessage("The amount field is empty.","Manage Expense", Notification.AlertType.WARNING);
                return;
            }

            if(viewModel.expensesModel == null)
            {
                viewModel.expensesModel = new Model.ExpensesModel
                {
                    ExpenseId = ((Model.ExpensesModel)ExpenseCatBS.Current).Id,
                    Amount = decimal.Parse(tbAmount.Text),
                    DateTimeStamp = dtp.Value,
                    Description = ((Model.ExpensesModel)ExpenseCatBS.Current).Description,
                    ReceiptNo = tbReciept.Text,
                    Remarks = tbRemarks.Text
                };
            } else
            {
                viewModel.expensesModel.ExpenseId = ((Model.ExpensesModel)ExpenseCatBS.Current).Id;
                viewModel.expensesModel.Amount = decimal.Parse(tbAmount.Text);
                viewModel.expensesModel.DateTimeStamp = dtp.Value;
                viewModel.expensesModel.Remarks = tbRemarks.Text;
                viewModel.expensesModel.ReceiptNo = tbReciept.Text;

            }
            viewModel.SaveExpense();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            viewModel.LoadExpenses();
        }

        private void cbDescription_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgExpenses_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgExpenses.ClearSelection();
        }
    }
}
