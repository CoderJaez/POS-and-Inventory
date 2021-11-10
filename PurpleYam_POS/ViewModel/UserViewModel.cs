using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Repository.DataAccess;
using PurpleYam_POS.View.Forms;
using PurpleYam_POS.View.UserControls;
using PurpleYam_POS.Model;
using System.ComponentModel.DataAnnotations;
using PurpleYam_POS.Components;
using PurpleYam_POS.helper;
using System.Drawing;
using System.Threading;

namespace PurpleYam_POS.ViewModel
{
    public class UserViewModel
    {
        public FormManageUser formUser;
        public Accounts ucAccounts;
        public Login ucLogin;
        public ManagePassword ucManagePass;
        public UserProfile ucUserProfile;
        private Baker ucBaker;
        public BindingSource AccountBS { get; set; }

        public UserModel model { get; set; }
        private string sql;

        private string DefaultPass = Convert.ToBase64String(EncryptPass.EncryptStringToBytes_Aes("12345"));
        

        public void LoadUser(string search = null)
        {
            sql = "select u.*, c.* from tbl_user u left join tbl_customer c on c.Id = u.CustomerId where u.Deleted = false and (c.Lastname LIKE @search or u.Username LIKE @search)order by c.Lastname asc";
            AccountBS.DataSource = GetUsers<UserModel,CustomerModel,dynamic>(sql, new { search = $"%{search}%" });
        }


        public void DeleteUser(object sender, DataGridViewCellEventArgs e)
        {
            var dg = (DataGridView)sender;
            if(dg.Columns[e.ColumnIndex].Name == "delete")
            {
                if(Notification.Confim(FormMain.Instance, "Do you want to delete selected user?", "Delete User Account") == DialogResult.Yes)
                {
                    var id = ((Repository.Model.UserModel)AccountBS.Current).Id;
                    SaveData("update tbl_user u left join tbl_customer c on c.Id = u.CustomerId  set c.Deleted = true, u.Deleted = false where u.Id = @Id", new { Id = id });
                    Notification.AlertMessage("Selected user account deleted.", "Success", Notification.AlertType.SUCCESS);
                    AccountBS.RemoveCurrent();
                }
            }
        }
        public void SaveUser()
        {

            ValidationContext context = new ValidationContext(model);
            ValidationContext context1 = new ValidationContext(model.Customer);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(model, context, errs, true) || !Validator.TryValidateObject(model.Customer, context1, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage}\n");
                Notification.ValidationMessage(FormMain.Instance, errorMsg.ToString(), "Validation Error");
                return;
            }

            var p = new
            {
                Firstname = model.Customer.Firstname,
                Middlename = model.Customer.Middlename,
                Lastname = model.Customer.Lastname,
                ContactNo = model.Customer.ContactNo,
                Image = model.Customer.Image,
                Username = model.Username,
                Password = Convert.ToBase64String(EncryptPass.EncryptStringToBytes_Aes(model.Password)),
                AccessRole = model.AccessRole
            }; 

            if(InsertUser(p))
            {
                Notification.AlertMessage("New user has been created.", "Success", Notification.AlertType.SUCCESS);
                AccountBS.Add(model);            

            } else
            {
                //Notification.AlertMessage("There was something. Please contact the administrator", "Failed", Notification.AlertType.ERROR);
                Notification.AlertMessage(ErrMsg, "Failed", Notification.AlertType.ERROR);

            }
            model = null;
            formUser.ResetAllFields();
        }


        public void New()
        {
            using (formUser = new FormManageUser())
            {
                formUser.viewModel = this;
                formUser.ShowDialog();
            }
                
        }


        public void LoginAuthentication()
        {
            if (string.IsNullOrEmpty(ucLogin.Username) || string.IsNullOrEmpty(ucLogin.Password))
            {
                Notification.AlertMessage("Username and Password must be filled.", "Access denied", Notification.AlertType.ERROR);
                return;
            }
            var p = new
            {
                Username = ucLogin.Username,
                Password = Convert.ToBase64String(EncryptPass.EncryptStringToBytes_Aes(ucLogin.Password))
            };

            FormMain.Instance.UserProfile = GetUser<UserModel, CustomerModel, dynamic>("select u.*, c.* from tbl_user u left join tbl_customer c on c.Id = u.CustomerId where u.Deleted = false and u.Username = @Username and u.Password = @Password", p);
            if (FormMain.Instance.UserProfile == null)
            {
                Notification.AlertMessage("Incorrect username/password", "Access denied", Notification.AlertType.ERROR);
                return;
            }

            ucLogin.Username = null;
            ucLogin.Password = null;
            FormMain.Instance.SetUserProfile();
            FormMain.Instance.MetroContainer.Focus();
            if (FormMain.Instance.UserProfile.Password == DefaultPass)
            {
                if (!FormMain.Instance.MetroContainer.Controls.ContainsKey("ManagePassword"))
                {
                    ucManagePass = new ManagePassword();
                    ucManagePass.viewModel = this;
                    ucManagePass.Dock = DockStyle.Fill;
                    ucManagePass.MainPanel.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - ucManagePass.MainPanel.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - ucManagePass.MainPanel.Height) / 4);
                    FormMain.Instance.MetroContainer.Controls.Add(ucManagePass);

                }
                FormMain.Instance.MetroContainer.Controls["ManagePassword"].BringToFront();
                Thread.Sleep(300);
                UserAccessRole();
            }
            else
                UserAccessRole();
        }


        public void UserAccessRole()
        {
            switch (FormMain.Instance.UserProfile.AccessRole)
            {
                case "CASHIER":
                    if (!FormMain.Instance.MetroContainer.Controls.ContainsKey("PointOfSale"))
                    {
                        PointOfSale uc = new PointOfSale();

                        uc.Dock = DockStyle.Fill;
                        FormMain.Instance.MetroContainer.Controls.Add(uc);
                    }
                    FormMain.Instance.MetroContainer.Controls["PointOfSale"].BringToFront();
                    FormMain.Instance.Back.Visible = false;
                    break;
                case "ADMIN":

                    if (!FormMain.Instance.MetroContainer.Controls.ContainsKey("Dashboard"))
                    {
                        Dashboard uc = new Dashboard();

                        uc.Dock = DockStyle.Fill;
                        FormMain.Instance.MetroContainer.Controls.Add(uc);
                    }
                    FormMain.Instance.UserControl.Clear();
                    FormMain.Instance.MetroContainer.Controls["Dashboard"].BringToFront();
                    FormMain.Instance.Back.Visible = false;
                    break;
                case "BAKER":
                    if (!FormMain.Instance.MetroContainer.Controls.ContainsKey("Baker"))
                    {
                        ucBaker = new Baker();
                        ucBaker.Dock = DockStyle.Fill;
                        FormMain.Instance.MetroContainer.Controls.Add(ucBaker);
                    }
                    ucBaker.LoadData();
                    FormMain.Instance.MetroContainer.Controls["Baker"].BringToFront();
                    FormMain.Instance.Back.Visible = false;
                    break;
            }
        }

        public void UpdatePassword()
        {
            //FormMain.Instance.UserProfile.Password = ucManagePass.NewPassword;
            //FormMain.Instance.UserProfile.ConfirmPassword = ucManagePass.ConfirmPassword;
            ValidationContext context = new ValidationContext(FormMain.Instance.UserProfile);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(FormMain.Instance.UserProfile, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage}\n");
                Notification.ValidationMessage(FormMain.Instance, errorMsg.ToString(), "Validation Error");
                return;
            }

            FormMain.Instance.UserProfile.Password = Convert.ToBase64String(EncryptPass.EncryptStringToBytes_Aes(FormMain.Instance.UserProfile.Password));
            sql = "update tbl_user set Password = @Password where Id = @Id";
            SaveData(sql, new { Password = FormMain.Instance.UserProfile.Password, Id = FormMain.Instance.UserProfile.Id });
            Notification.AlertMessage("Password is now updated", "Success", Notification.AlertType.SUCCESS);
            Thread.Sleep(300);
            UserAccessRole();
        }


        public void UpdateEmploryeeInfo()
        {
            ValidationContext context = new ValidationContext(FormMain.Instance.UserProfile.Customer);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(FormMain.Instance.UserProfile.Customer, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage}\n");
                Notification.ValidationMessage(FormMain.Instance, errorMsg.ToString(), "Validation Error");
                return;
            }

            sql = "update tbl_customer set Firstname = @Firstname, Middlename = @Middlename, Lastname = @Lastname, ContactNo = @ContactNo, Image = @Image where Id = @Id";
            SaveData(sql, new {
                Firstname = FormMain.Instance.UserProfile.Customer.Firstname,
                Middlename = FormMain.Instance.UserProfile.Customer.Middlename,
                Lastname = FormMain.Instance.UserProfile.Customer.Lastname,
                ContactNo = FormMain.Instance.UserProfile.Customer.ContactNo,
                Id = FormMain.Instance.UserProfile.Customer.Id,
                Image = FormMain.Instance.UserProfile.Customer.Image
            });
            FormMain.Instance.SetUserProfile();
            Notification.AlertMessage("Employee information is now updated", "Success", Notification.AlertType.SUCCESS);
            
        }


    }
}
