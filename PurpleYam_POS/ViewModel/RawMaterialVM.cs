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
using System.ComponentModel.DataAnnotations;
using PurpleYam_POS.Components;
using PurpleYam_POS.helper;

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



        internal async void NextPage(object sender, EventArgs e)
        {
            page.start += page.limit;
            page.page += 1;

            if ((page.totalRows - page.start) <= page.limit)
            {

                page.btnLastPage.Enabled = false;
                page.btnNext.Enabled = false;
            }

            //uc.ButtonPrev.Enabled = true;
            //uc.ButtonFirst.Enabled = true;
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
            //btnFirstPage.Enabled = false;
            //btnLastPage.Enabled = true;
            //btnPrev.Enabled = false;
            await LoadDataAsync(uc.SearchRawMat);
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
            //uc.ButtonPrev.Enabled = true;
            //uc.ButtonLast.Enabled = false;
            //uc.ButtonFirst.Enabled = true;
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
                //uc.ButtonFirst.Enabled = false;
            }
            page.btnLastPage.Enabled = true;
            //uc.ButtonLast.Enabled = true;
            await LoadDataAsync(uc.SearchRawMat);
        }
        public async Task LoadDataAsync(string search = "")
        {
            sql = @"SELECT rm.Id, rm.Product, rm.CreatedAt,  
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

        internal void DeleteSelected(object sender, EventArgs e)
        {
            if (models.Count > 0)
            {
                var query = new StringBuilder();
                query.Append("UPDATE rawmaterial SET ");
                models.ForEach(model =>
               {
                   query.Append($"Deleted = CASE WHEN Id = {model.Id} THEN true ELSE Deleted END, ");
               });
                
                query.Remove(query.Length - 2, 1);
                query.Append("WHERE Id IN ( ");
                models.ForEach(model =>
                {
                    query.Append($"{model.Id}, ");
                });
                query.Remove(query.Length - 2, 1);
                query.Append(" )");
                SaveData(query.ToString(), new { });
                var res = Notification.Confim(FormMain.Instance, "Do want to delete selecte raw materials?", "Delete raw material");
                if(res == DialogResult.Yes)
                {
                    Notification.AlertMessage("Raw materials deleted", "Success", Notification.AlertType.SUCCESS);
                    models.ForEach(m => page.bindingSource.Remove(m));
                }
                
            } else 
                Notification.AlertMessage("No raw materials selected.", "Select raw material", Notification.AlertType.WARNING);

        }

        internal void rawMatCheckChanged(object sender, EventArgs e)
        {
            var checkbox = (CheckBox)sender;
            checkbox.Checked = checkbox.Checked?true:false;
            if (!checkbox.Checked)
                models.Clear();
            foreach (DataGridViewRow row in uc.dataGridView.Rows)
            {
                row.Cells["checkbox"].Value = checkbox.Checked;
            }
            
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
                        break;
                    case "delete":
                        break;
                    case "checkbox":
                        if(model.Deleted)
                        {
                            model.Deleted = false;
                            models.Remove(model);
                        } else
                        {
                            model.Deleted = true;
                            models.Add(model);
                        }
                        page.bindingSource.EndEdit();
                        break;
                }
            }
            
        }

        public void LoadRawMatData()
        {
            sql = @"Sel";
        }

        public void Delete()
        {
        }

        public void New(RawMaterial _model)
        {
                model = _model;
            using (form = FormRawMaterial.Instance(this))
            {
                form.ShowDialog();
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
            var p = new { Product = model.Product };

            try
            {
                if (model.Id == 0)
                {
                    sql = "INSERT INTO rawmaterial (Product) VALUES (@Product); SELECT last_insert_id();";
                    model.Id =  SaveGetId(sql, p);
                    page.bindingSource.Add(model);
                    model = new RawMaterial();
                    FormRawMaterial.instance.mtProduct.Text = null;
                }
                else
                {
                    sql = $"UPDATE rawmaterial SET Product = @Product WHERE Id = {model.Id}";
                    SaveData(sql, p);
                    page.bindingSource.EndEdit();
                }
                Notification.AlertMessage("Product saved.", "Success", Notification.AlertType.SUCCESS);
            }
            catch (Exception ex)
            {
                Notification.AlertMessage(ex.Message, "Error", Notification.AlertType.ERROR);
               
            }
           

        }


    }
}
