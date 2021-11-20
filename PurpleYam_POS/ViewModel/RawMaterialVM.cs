using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurpleYam_POS.Model;
using PurpleYam_POS.View.UserControls;
using PurpleYam_POS.View.Forms;
using static Repository.DataAccess;
using static Repository.RawMaterial;
using System.ComponentModel.DataAnnotations;
using PurpleYam_POS.Components;
using PurpleYam_POS.helper;
using System.Dynamic;
using MetroFramework.Controls;

namespace PurpleYam_POS.ViewModel
{
    public class RawMaterialVM
    {
        private string sql;
        private FormRawMaterial form;
        public RawMaterial model;
        public RawMaterials uc;
        private List<RawMaterial> models = new List<RawMaterial>();
        public Pagination page;
        public ProductUnitModel unitmodel;
        public BindingSource PrudUnitBS { get; set; }
        public BindingSource UnitCodeBS { get; set; }


        /// <summary>
        /// Loads the next page raw material data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal async void NextPage(object sender, EventArgs e)
        {
            page.start += page.limit;
            page.page += 1;

            if ((page.totalRows - page.start) <= page.limit)
            {

                page.btnLastPage.Enabled = false;
                page.btnNext.Enabled = false;
            }

            page.btnPrev.Enabled = true;
            page.btnFirstPage.Enabled = true;
            await LoadDataAsync(uc.SearchRawMat);

        }

        

        internal async void FirstPage(object sender, EventArgs e)
        {
            page.start = 0;
            page.page = 1;
            page.btnFirstPage.Enabled = false;
            page.btnLastPage.Enabled = true;
            page.btnPrev.Enabled = false;
            await LoadDataAsync(uc.SearchRawMat);
        }

        internal void mcUnitCodeSelectedValueChanged(object sender, EventArgs e)
        {
            //if(unitmodel == null)
            //    unitmodel = UnitCodeBS.Current as ProduUnitModel;
        }

        internal async void LimitPerPage(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            page.limit = cb.Text == "" ? 50 : int.Parse(cb.Text);
            page.start = 0;
            page.page = 1;

            await LoadDataAsync(uc.SearchRawMat);
        }

        internal async void LastPage(object sender, EventArgs e)
        {
            page.page = page.totalRows / page.limit;
            page.start = page.page * page.limit;
            page.btnPrev.Enabled = true;
            page.btnLastPage.Enabled = false;
            page.btnFirstPage.Enabled = true;
            
            await LoadDataAsync(uc.SearchRawMat);
        }

        internal async  void PreviousPage(object sender, EventArgs e)
        {
            page.start -= page.limit;
            page.page -= 1;
            if (page.start <= 0)
            {
                page.start = 0;
                page.page = 1;
                page.btnPrev.Enabled = false;
                page.btnFirstPage.Enabled = false;
            }
            page.btnLastPage.Enabled = true;
            await LoadDataAsync(uc.SearchRawMat);
        }

        public async Task LoadDataAsync(string search = "")
        {
            sql = @"SELECT rm.Id, rm.Product,rm.DaysBeforeExpiry, rm.ReOrder, rm.HasExpiry, rm.CreatedAt,  
	                (SELECT u.UnitCode FROM tbl_unit AS u LEFT JOIN tbl_unitgroup AS ugrp ON ugrp.UnitId = u.Id WHERE ugrp.BaseUnit = TRUE AND ugrp.ProductId = rm.Id) AS BaseUnit, 
	                (SELECT u.UnitCode FROM tbl_unit AS u LEFT JOIN tbl_unitgroup AS ugrp ON ugrp.UnitId = u.Id WHERE ugrp.DisplayUnit = TRUE AND ugrp.ProductId = rm.Id) AS DisplayUnit 
	                FROM rawmaterial AS rm where rm.Deleted = false AND rm.Product LIKE @Product ORDER BY rm.Product ASC ";
            var p = new
            {
                Product = $"%{search}%"
            };

            page.sql = sql;
            page.search = search;
            page.totalRowsQry = @"SELECT COUNT(*) AS total FROM rawmaterial AS rm where rm.Deleted = false ";
            page.fileteredQry = @"SELECT COUNT(*) AS total FROM rawmaterial AS rm where rm.Deleted = false AND rm.Product LIKE @Product ORDER BY rm.Product ASC ";

            await page.LoadDataTableAsync<RawMaterial,dynamic>(p);
        }


        internal async void SearchRawMat(object sender, EventArgs e)
        {
            var search = (MetroFramework.Controls.MetroTextBox)sender;
            page.start = 0;
            page.page = 1;
            await LoadDataAsync(search.Text);
        }


        /// <summary>
        /// Deletes every raw materials selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void DeleteSelected(object sender, EventArgs e)
        {
           var ListToDelete =  page.bindingSource.OfType<RawMaterial>().ToList().FindAll(p => p.Deleted == true);
            if(ListToDelete.Count <= 0)
            {
                Notification.AlertMessage("No raw materials selected.", "Select raw material", Notification.AlertType.WARNING);
                return;
            }

            if(Notification.Confim(FormMain.Instance, "Do you to delete rows?","Delete Raw Materials") == DialogResult.Yes)
            {
                var query = new StringBuilder();
                query.Append("UPDATE rawmaterial SET ");
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
                Notification.AlertMessage("Raw materials deleted", "Success", Notification.AlertType.SUCCESS);
                ListToDelete.ForEach(m => page.bindingSource.Remove(m));
                ((CheckBox)uc.Controls["cbAll"]).Checked = false;
            }
           


        }

        internal void rawMatCheckChanged(object sender, EventArgs e)
        {
            var checkbox = (CheckBox)sender;
          
            foreach (DataGridViewRow row in uc.dataGridView.Rows)
            {
                row.Cells["checkbox"].Value = checkbox.Checked;
            }
            
        }


        internal void cbBaseDisplayCellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dg = (DataGridView)sender;
            if(e.RowIndex >= 0)
            {
                var obj = PrudUnitBS.Current as ProductUnitModel;
                switch(dg.Columns[e.ColumnIndex].Name)
                {
                    case "setBaseUnit":
                        if(!obj.BaseUnit)
                        {
                            if(Notification.Confim(FormMain.Instance, "The selected unit will now as base unit. \nDo you want to proceed?","Setting Base unit") == DialogResult.Yes)
                            {
                                setBaseUnit(obj);
                                foreach( DataGridViewRow row in FormRawMaterial.instance.dgRawmatunit.Rows)
                                    row.Cells["setBaseUnit"].Value = false;

                                obj.BaseUnit = !obj.BaseUnit;
                                model.BaseUnit = obj.UnitCode;
                                PrudUnitBS.EndEdit();
                                dg.CurrentRow.Selected = false;
                            }

                        }
                       
                        break;
                    case "setDisplayUnit":

                        if (!obj.DisplayUnit)
                        {
                            if (Notification.Confim(FormMain.Instance, "The selected unit will now as display unit. \nDo you want to proceed?", "Setting Base unit") == DialogResult.Yes)
                            {
                                setDisplayUnit(obj);

                                foreach (DataGridViewRow row in FormRawMaterial.instance.dgRawmatunit.Rows)
                                    row.Cells["setDisplayUnit"].Value = false;

                                obj.DisplayUnit = !obj.DisplayUnit;
                                model.DisplayUnit = obj.UnitCode;
                                PrudUnitBS.EndEdit();
                                dg.CurrentRow.Selected = false;
                            }

                        }
                        break;
                    case "edit":
                        unitmodel = PrudUnitBS.Current as ProductUnitModel;
                        FormRawMaterial.instance.mtQuantity.Text = unitmodel.Qty.ToString();
                        FormRawMaterial.instance.mcunitCode.Text = unitmodel.UnitCode;
                        break;
                    case "delete":
                        if(Notification.Confim(FormMain.Instance, "Do you want to delete selected row?","Delete") == DialogResult.Yes)
                        {
                            deleteRawmatUnit(obj);
                            Notification.AlertMessage("Unit deleted.", "Success", Notification.AlertType.SUCCESS);
                            PrudUnitBS.Remove(obj);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        private void deleteRawmatUnit(ProductUnitModel _model)
        {
            sql = "UPDATE tbl_unitgroup SET Deleted = true where Id = @Id";
            SaveData(sql, new { Id = _model.Id });
        }
        public void rawMatCellClick(Object sender, DataGridViewCellEventArgs e)
        {
            var dg = (DataGridView)sender;
            if(e.RowIndex >= 0)
            {
                var obj = page.bindingSource.Current as RawMaterial;
                switch(dg.Columns[e.ColumnIndex].Name)
                {
                    case "edit":
                        New(obj);
                        dg.CurrentRow.Selected = false;
                        break;
                    case "delete":
                        DeleteRawMat(obj);
                        break;
                    case "checkbox":
                        if(obj.Deleted)
                        {
                            obj.Deleted = false;
                        } else
                        {
                            obj.Deleted = true;
                        }
                        page.bindingSource.EndEdit();
                        break;
                    default:
                        MessageBox.Show(obj.Deleted.ToString());
                        break;
                }
            }
            
        }

        /// <summary>
        /// Loads Units for Raw Material Product Selected.
        /// </summary>
        public async void LoadRawMatUnit()
        {
            sql = @"SELECT * FROM units WHERE ProductId = @ProductId";
            var p = new
            {
                ProductId = model.Id
            };
            PrudUnitBS.DataSource = await LoadData<ProductUnitModel, dynamic>(sql, p);

            sql = @"SELECT Id as UnitId, UnitCode FROM tbl_unit where Deleted = false";
            UnitCodeBS.DataSource = await LoadData<ProductUnitModel, dynamic>(sql, new { });
        }


        public void setBaseUnit(ProductUnitModel _model)
        {
            if(setbaseUnit(_model.Id, model.Id))
            {
                Notification.AlertMessage("Base Unit is now set.", "Success", Notification.AlertType.SUCCESS);
            }
        }

        public void setDisplayUnit(ProductUnitModel _model)
        {
            if (setdisplayUnit(_model.Id, model.Id))
            {
                Notification.AlertMessage("Display Unit is now set.", "Success", Notification.AlertType.SUCCESS);
            }
        }


        public void SaveRawMatUnit()
        {
            if (unitmodel == null)
                unitmodel = new ProductUnitModel();
            int num;
            bool success = int.TryParse(form.mtQuantity.Text, out num);
            unitmodel.UnitID = (int)FormRawMaterial.instance.mcunitCode.SelectedValue;
            unitmodel.UnitCode = FormRawMaterial.instance.mcunitCode.Text;
            unitmodel.Qty = success?num:0;
            unitmodel.ProductId = model.Id;
            ValidationContext context = new ValidationContext(unitmodel);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if(!Validator.TryValidateObject(unitmodel, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage}\n");
                Notification.ValidationMessage(FormMain.Instance, errorMsg.ToString(), "Validation Error");

                return;
            }


            if(unitmodel.Id == 0)
                sql = "INSERT INTO tbl_unitgroup (ProductId, UnitId, Qty) VALUES(@ProductId, @UnitId, @Qty);SELECT last_insert_id()";
            else
                sql = $"UPDATE tbl_unitgroup SET ProductId = @ProductId, UnitId = @UnitId, Qty = @Qty WHERE Id = {unitmodel.Id}";

            var p = new
            {
                ProductId = unitmodel.ProductId,
                UnitId = unitmodel.UnitID,
                Qty = unitmodel.Qty
            };
            try
            {
               
                form.mtQuantity.Text = string.Empty;
                if(unitmodel.Id == 0)
                {
                    unitmodel.Id = SaveGetId(sql, p);
                    Notification.AlertMessage("Product Unit Saved.", "Success", Notification.AlertType.SUCCESS);
                    PrudUnitBS.Add(unitmodel);
                }
                else
                {
                    SaveData(sql, p);
                    PrudUnitBS.EndEdit();
                    Notification.AlertMessage("Product Unit Saved.", "Success", Notification.AlertType.SUCCESS);
                    FormRawMaterial.instance.dgRawmatunit.Rows[0].Selected = false;
                }
                unitmodel = null;
            }
            catch (Exception ex)
            {
                Notification.ValidationMessage(FormMain.Instance, ex.Message, "Error");
            }
        }

        /// <summary>
        /// Shows RawMaterial Form
        /// </summary>
        /// <param name="_model"></param>
        public void New(RawMaterial _model)
        {
            model = _model;
            using (form = FormRawMaterial.Instance(this))
            {
                if (model.Id != 0)
                {
                    form.btnSaveRawmatUnit.Enabled = true;
                    unitmodel = null;
                }
                form.ShowDialog();
            }   
        }

        public void DeleteRawMat(RawMaterial _model)
        {
            if(Notification.Confim(FormMain.Instance, "Do you want to delete selected product","Delete product") == DialogResult.Yes)
            {
                sql = "UPDATE rawmaterial SET Deleted = true where Id = @Id";
                SaveData(sql, new { Id = _model.Id });
                Notification.AlertMessage("Product deleted", "Success", Notification.AlertType.SUCCESS);
                page.bindingSource.Remove(_model);
            }
        }
       
        public void SaveRawMat()
        {
            ValidationContext context = new ValidationContext(model);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(model, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage}\n");
                Notification.ValidationMessage(FormMain.Instance, errorMsg.ToString(), "Validation Error");

                return;
            }
            var p = new { Product = model.Product, DaysBeforeExpiry = model.DaysBeforeExpiry, HasExpiry = model.HasExpiry, ReOrder = model.ReOrder };

            try
            {
                if (model.Id == 0)
                {
                    sql = "INSERT INTO rawmaterial (Product,DaysBeforeExpiry,HasExpiry,ReOrder) VALUES (@Product, @DaysBeforeExpiry, @HasExpiry, @ReOrder); SELECT last_insert_id();";
                    model.Id =  SaveGetId(sql, p);
                    Notification.AlertMessage("Product created.", "Success", Notification.AlertType.SUCCESS);
                    page.bindingSource.Add(model);
                    unitmodel = new ProductUnitModel {
                        ProductId = model.Id
                    };
                    FormRawMaterial.instance.btnSaveRawmatUnit.Enabled = true;
                    FormRawMaterial.instance.mtProduct.Text = null;
                    FormRawMaterial.instance.btnSaveRawmat.Enabled = false;
                    FormRawMaterial.instance.NewRawmat.Enabled = true;
                }
                else
                {
                    sql = $"UPDATE rawmaterial SET Product = @Product, DaysBeforeExpiry = @DaysBeforeExpiry, HasExpiry = @HasExpiry, ReOrder = @ReOrder   WHERE Id = {model.Id}";
                    SaveData(sql, p);
                    page.bindingSource.EndEdit();
                    Notification.AlertMessage("Product updated.", "Success", Notification.AlertType.SUCCESS);
                }
            }
            catch (Exception ex)
            {
                Notification.AlertMessage(ex.Message, "Error", Notification.AlertType.ERROR);
               
            }
           

        }


    }
}
