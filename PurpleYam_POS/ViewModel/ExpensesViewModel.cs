using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using PurpleYam_POS.Components;
using PurpleYam_POS.Model;
using PurpleYam_POS.View.UserControls;
using static Repository.DataAccess;

namespace PurpleYam_POS.ViewModel
{
    public class ExpensesViewModel
    {
        public ExpensesSettings ucExpSettings;
        public Expenses ucExpenses;
        public BindingSource ExpensesBS { get; set; }
        public BindingSource ExpenseCatBS { get; set; }

        private string sql;

        public ExpensesModel expensesModel;
        

        public ExpensesViewModel()
        {

        }
        #region Expenses Category

        public void SaveExpenseCat()
        {
            ValidationContext context = new ValidationContext(expensesModel);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(expensesModel, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage}\n");
                Notification.ValidationMessage(FormMain.Instance, errorMsg.ToString(), "Validation Error");
                return;
            }

            var p = new
            {
                Id = expensesModel.Id,
                Description = expensesModel.Description
            };

            if (expensesModel.Id == 0)
            {
                expensesModel.Id = SaveGetId("insert into tbl_expenses_cat (Description) values (@Description); SELECT last_insert_id();", p);
                ExpenseCatBS.Add(expensesModel);
                Notification.AlertMessage("New expenses description added", "Success", Notification.AlertType.SUCCESS);

            }
            else
            {
                SaveData("update tbl_expenses_cat set Description = @Description where Id = @Id", p);
                Notification.AlertMessage("Expenses description updated", "Success", Notification.AlertType.SUCCESS);
                ((DataGridView)ucExpSettings.Controls["dgExpenses"]).ClearSelection();
            }

            ClearExpenseCat();
        }

        public void ClearExpenseCat()
        {
            ucExpSettings.description = null;
            expensesModel = null;
        }

        public void DgExpensesCellClick(object sender, DataGridViewCellEventArgs e)
        {
            expensesModel = (ExpensesModel)ExpenseCatBS.Current;
            var dg = (DataGridView)sender;

            switch (dg.Columns[e.ColumnIndex].Name)
            {
                case "delete":
                    if (Notification.Confim(FormMain.Instance, "Do you want to delete selected row?", "Delete expense decription.") == DialogResult.Yes)
                    {
                        SaveData("update tbl_expenses_cat set Deleted = true where Id = @Id", new { Id = expensesModel.Id });
                        ExpenseCatBS.RemoveCurrent();
                        Notification.AlertMessage("Expenses description deleted", "Success", Notification.AlertType.SUCCESS);
                        expensesModel = null;
                    }
                    break;
                case "edit":
                    ucExpSettings.description = expensesModel.Description;
                    break;
                case "Deleted":
                    expensesModel.Deleted = !expensesModel.Deleted;
                    ((DataGridView)ucExpSettings.Controls["dgExpenses"]).ClearSelection();
                    break;
            }

        }

        public void DeleteSelectedExpenseCat()
        {
            var ListToDelete = ExpenseCatBS.List.OfType<ExpensesModel>().ToList().FindAll(p => p.Deleted);
           if(ListToDelete.Count.Equals(0))
            {
                Notification.AlertMessage("No expenses selected", "Select expenses", Notification.AlertType.WARNING);
                return;
            }

            if (Notification.Confim(FormMain.Instance, "Do you to delete rows?", "Delete Raw Materials") == DialogResult.Yes)
            {
                var query = new StringBuilder();
               
                query.Append("UPDATE tbl_expenses_cat SET ");
                ListToDelete.ForEach(model =>
                {
                    query.Append($"Deleted = CASE WHEN Id = {model.Id} THEN true ELSE Deleted END, ");
                });

                query.Remove(query.Length - 2, 1);
                query.Append("WHERE Id IN ( ");
                ListToDelete.ForEach(model =>
                {
                    query.Append($"{model.Id}, ");
                });
                query.Remove(query.Length - 2, 1);
                query.Append(" )");
                SaveData(query.ToString(), new { });
                Notification.AlertMessage("Expenses deleted", "Success", Notification.AlertType.SUCCESS);
                ListToDelete.ForEach(m => ExpenseCatBS.Remove(m));
                ((CheckBox)ucExpSettings.Controls["cxbAll"]).Checked = false;
            }

        }

        public async void LoadExpensesCat(string search = null)
        {
            ExpenseCatBS.DataSource = await LoadData<ExpensesModel, dynamic>("select * from tbl_expenses_cat where Deleted = false and Description LIKE @Search", new { Search = $"%{search}%" });
        }
        #endregion


        #region Expenses
        public async void LoadExpenses()
        {
            ExpensesBS.DataSource = await LoadData<ExpensesModel, dynamic>("select ex.*,e.Description from tbl_expenses ex left join tbl_expenses_cat e on e.Id = ex.ExpenseId where ex.Deleted = false and ex.DateTimeStamp between @DateFrom and @DateTo", new {DateFrom =  ucExpenses.DtpFrom.AddDays(-1), DateTo = ucExpenses.DtpTo.AddDays(1)});
        }

        public void SaveExpense()
        {
            ValidationContext context = new ValidationContext(expensesModel);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(expensesModel, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage}\n");
                Notification.ValidationMessage(FormMain.Instance, errorMsg.ToString(), "Validation Error");
                return;
            }

            var p = new
            {
                Id = expensesModel.Id,
                ExpenseId = expensesModel.ExpenseId,
                Amount = expensesModel.Amount,
                Date = expensesModel.DateTimeStamp,
                ReceiptNo = expensesModel.ReceiptNo,
                Remarks = expensesModel.Remarks
            };

            if (expensesModel.Id == 0)
            {
                expensesModel.Id = SaveGetId("insert into tbl_expenses (ExpenseId, Amount, DateTimeStamp, ReceiptNo, Remarks) values (@ExpenseId, @Amount, @Date, @ReceiptNo, @Remarks);select last_insert_id()", p);
                ExpensesBS.Add(expensesModel);
                Notification.AlertMessage("New expense added", "Success", Notification.AlertType.SUCCESS);

            }
            else
            {
                SaveData("update tbl_expenses set ExpenseId = @ExpenseId, Amount = @Amount, DateTimeStamp = @Date, ReceiptNo = @ReceiptNo, Remarks = @Remarks  where Id = @Id", p);
                Notification.AlertMessage("Expense updated", "Success", Notification.AlertType.SUCCESS);
                ExpensesBS.EndEdit();
                ((DataGridView)ucExpenses.Controls["dgExpenses"]).ClearSelection();
            }
            ucExpenses.BtnCancel.PerformClick();
        }

        public void DgExpenseCellClick(object sender, DataGridViewCellEventArgs e)
        {
            expensesModel = (ExpensesModel)ExpensesBS.Current;
            var dg = (DataGridView)sender;

            switch (dg.Columns[e.ColumnIndex].Name)
            {
                case "delete":
                    if (Notification.Confim(FormMain.Instance, "Do you want to delete selected row?", "Delete expense decription.") == DialogResult.Yes)
                    {
                        SaveData("update tbl_expenses set Deleted = true where Id = @Id", new { Id = expensesModel.Id });
                        ExpensesBS.RemoveCurrent();
                        Notification.AlertMessage("Expense deleted", "Success", Notification.AlertType.SUCCESS);
                        expensesModel = null;
                    }
                    break;
                case "edit":
                    ucExpenses.SetExpenseField();
                    break;
            }

        }



        #endregion
    }
}
