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

namespace PurpleYam_POS.ViewModel
{
    public class UnitViewModel:IDisposable
    {
        public BindingSource UnitBindingSource { get; set; }
        private FormUnit frmUnit;
        private string sql;
        public void Load()
        {
            string sql = "SELECT * FROM tbl_unit where deleted = false";
            UnitBindingSource.DataSource = LoadData<Unit, dynamic>(sql, new {});
            
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
            DialogResult res = MetroFramework.MetroMessageBox.Show(FormMain.Instance,"Do you want to delete selected row?","Delete data", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(res == DialogResult.Yes)
            {
                sql = $"UPDATE tbl_unit set deleted = false where Id = @Id";
                var p = new
                {
                    Id = unit.Id
                };
                if(SaveData(sql, p))
                {
                    MessageBox.Show("Successfully deleted");
                    UnitBindingSource.RemoveCurrent();
                }

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
                MessageBox.Show(errorMsg.ToString());
                return;
            }

            if (currentUnit.Id == 0)
                 sql = "INSERT INTO tbl_unit (UnitCode, UnitDesc) values (@UnitCode, @UnitDesc)";
            else
                 sql = $"update tbl_unit set UnitCode = @UnitCode, UnitDesc = @UnitDesc where id = {currentUnit.Id}";


            var p = new 
            {
                UnitCode = currentUnit.UnitCode,
                UnitDesc = currentUnit.UnitDesc 
            };
            
            if(SaveData(sql, p))
            {
                if (currentUnit.Id == 0)
                {
                    MessageBox.Show("New unit onserted");
                    UnitBindingSource.Add(currentUnit);
                }
                else
                {
                    MessageBox.Show("Unit updated");
                    UnitBindingSource.EndEdit();
                }
                frmUnit.Close();
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
