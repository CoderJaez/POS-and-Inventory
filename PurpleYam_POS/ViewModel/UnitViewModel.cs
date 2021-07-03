using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Repository.DataAccess;
using System.Windows.Forms;
using PurpleYam_POS.model;
using System.ComponentModel.DataAnnotations;
namespace PurpleYam_POS.viewmodel
{
    class UnitViewModel:IDisposable
    {
        public BindingSource UnitBindingSource { get; set; }
        private string sql;
        public void Load()
        {
            string sql = "SELECT * FROM tbl_unit where deleted = false";
            UnitBindingSource.DataSource = LoadData<Unit, dynamic>(sql, new {});
            
        }

        public void New() => UnitBindingSource.AddNew();

        public void Delete() => UnitBindingSource.RemoveCurrent();

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
                UnitDesc = currentUnit.UnitCode
            };
            
            if(SaveData(sql, p))
            {
                if (currentUnit.Id == 0)
                    MessageBox.Show("New unit onserted");
                else
                    MessageBox.Show("Unit updated");

            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
