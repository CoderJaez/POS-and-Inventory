using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using PurpleYam_POS.Model;
using PurpleYam_POS.View.Forms;
using PurpleYam_POS.View.UserControls;
using static Repository.DataAccess;
using PurpleYam_POS.Components;
using System.ComponentModel.DataAnnotations;

namespace PurpleYam_POS.ViewModel
{
    public class AddonViewModel
    {
        //Windows Controls
        public AddOns uc;
        public FormManageAddons form;

        //BindingSource
        public BindingSource AddonsBS { get; set; }
        public BindingSource UnitBS { get; set; }

        //Model
        public ProductModel AddonModel { get; set; }

        //Local variables
        private string sql;

        #region New/Update add-ons
        public void New()
        {
            using (form = new FormManageAddons(this))
            {
                if (AddonModel != null)
                    form.SetAddonFields();
                form.ShowDialog();
            }
        }


        public void AddonsCellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dg = (DataGridView)sender;
            if(dg.Columns[e.ColumnIndex].Name == "edit" || dg.Columns[e.ColumnIndex].Name == "delete")
                AddonModel = (ProductModel)AddonsBS.Current;
            switch(dg.Columns[e.ColumnIndex].Name)
            {
                case "edit":
                    New();
                    break;
                case "delete":
                    DeleteAddon();
                    break;
            }
        }

        private void DeleteAddon()
        {
            if(Notification.Confim(FormMain.Instance, "Do you want to delete selected row?", "Delete Add-ons") == DialogResult.Yes)
            {
                sql = "UPDATE tbl_product set Deleted = true where Id = @Id";
                SaveData(sql, new { Id = AddonModel.Id });
                AddonsBS.Remove(AddonModel);
                AddonModel = null;
                Notification.AlertMessage("Selected Add-on deleted.", "Success", Notification.AlertType.SUCCESS);
            }
        }


        public void SaveProduct()
        {
            ValidationContext context = new ValidationContext(AddonModel);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(AddonModel, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage}\n");
                Notification.ValidationMessage(FormMain.Instance, errorMsg.ToString(), "Validation Error");
                return;
            }

            var p = new
            {
                Id = AddonModel.Id,
                Product = AddonModel.Product,
                Price = AddonModel.Price,
                IsAvailable = AddonModel.IsAvailable,
                Type = "Addon",
                UnitId = AddonModel.UnitId
            };

            if (AddonModel.Id == 0)
            {
                sql = "INSERT INTO tbl_product (Product,Price, Type, IsAvailable,UnitId) VALUES (@Product, @Price, @Type, @IsAvailable, @UnitId);SELECT last_insert_id();";
                AddonModel.Id = SaveGetId(sql, p);
                AddonsBS.Add(AddonModel);
                Notification.AlertMessage("New Add-ons saved.", "Success", Notification.AlertType.SUCCESS);
                form.ResetAllFields();
            }
            else
            {
                sql = "UPDATE tbl_product SET Product = @Product,Price = @Price, IsAvailable = @IsAvailable, UnitId = @UnitId WHERE Id = @Id";
                SaveData(sql, p);
                Notification.AlertMessage("Add-ons update.", "Success", Notification.AlertType.SUCCESS);
                uc.DgAddons.ClearSelection();
            }
            AddonModel = null;
        }
        #endregion


        #region GetAll Addons
        public async Task GetAllAddons(string search = null)
        {
            sql = "SELECT p.Id, p.Product, p.Price, p.IsAvailable,p.UnitId, u.UnitCode  FROM tbl_product p LEFT JOIN tbl_unit u ON u.Id = p.UnitId WHERE p.Deleted = FALSE AND p.Type = 'Addon' and p.Product LIKE @Search";
            AddonsBS.DataSource = await LoadData<ProductModel, dynamic>(sql, new { Search = $"%{search}%"});
        }
        #endregion


        #region GetAll Units
        public async Task GetAllUnits()
        {
            sql = "select Id, UnitCode from tbl_unit where Deleted = false Order By UnitCode ASC";
            UnitBS.DataSource = await LoadData<Unit, dynamic>(sql, new { });
        }
        #endregion

    }
}
