using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Repository.DataAccess;
using System.Windows.Forms;
using PurpleYam_POS.Model;
using System.ComponentModel.DataAnnotations;
using PurpleYam_POS.View.Forms;
using PurpleYam_POS.Components;

namespace PurpleYam_POS.ViewModel
{
    public class UnitViewModel:IDisposable
    {
        public BindingSource UnitBindingSource { get; set; }
        private FormUnit frmUnit;
        private string sql;

        public async Task LoadDataAsync()
        {
            string sql = "SELECT * FROM tbl_unit where Deleted = false";
            UnitBindingSource.DataSource = await Task.Run(()=> LoadData<Unit, dynamic>(sql, new {}));
            
        }

        public void New(Unit _unit)
        {
            using (frmUnit = FormUnit.Instance(this, _unit))
            {
                frmUnit.ShowDialog();
            }  
        }

        public void Delete(Unit unit)
        {
            DialogResult res = Notification.Confim(FormMain.Instance, "Do want to delete selected row?", "Delete unit");
            if (res == DialogResult.Yes)
            {
                sql = $"UPDATE tbl_unit set Deleted = true where Id = @Id";
                var p = new
                {
                    Id = unit.Id
                };

                 Task.Run(() => SaveData(sql, p));
                    Notification.AlertMessage("Unit deleted", "Success", Notification.AlertType.SUCCESS);
                    UnitBindingSource.RemoveCurrent();

            }
        }

        public void Save(Unit currentUnit)
        {
            ValidationContext context = new ValidationContext(currentUnit);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if(!Validator.TryValidateObject(currentUnit, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage}\n");
                Notification.ValidationMessage(FormMain.Instance, errorMsg.ToString(), "Validation Error");
                return;
            }

            if (currentUnit.Id == 0)
                 sql = "INSERT INTO tbl_unit (UnitCode, UnitDesc) values (@UnitCode, @UnitDesc); SELECT last_insert_id()";
            else
                 sql = $"update tbl_unit set UnitCode = @UnitCode, UnitDesc = @UnitDesc where id = {currentUnit.Id}";


            var p = new 
            {
                UnitCode = currentUnit.UnitCode,
                UnitDesc = currentUnit.UnitDesc 
            };

            
            
              if (currentUnit.Id == 0)
                {
                    currentUnit.Id = SaveGetId(sql, p); ;
                    Notification.AlertMessage("New unit saved","Success", Notification.AlertType.SUCCESS);
                    UnitBindingSource.Add(currentUnit);
                }
                else
                {
                    SaveData(sql, p);
                    Notification.AlertMessage("Unit updated","Success", Notification.AlertType.SUCCESS );
                    UnitBindingSource.EndEdit();
                }
                frmUnit.Close();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
