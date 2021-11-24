using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PurpleYam_POS.ViewModel;

namespace PurpleYam_POS.View.Forms
{
    public partial class FormManageCustomer : MetroFramework.Forms.MetroForm
    {
        private PosViewModel viewModel;
        public string Search { get { return tbSearch.Text; } set { tbSearch.Text = value; } }
        public FormManageCustomer(PosViewModel vm)
        {
            InitializeComponent();
            viewModel = vm;
            viewModel.page = new helper.Pagination(PaginationFlp);
            viewModel.page.btnFirstPage.Click += viewModel.FirstPage;
            viewModel.page.btnLastPage.Click += viewModel.LastPage;
            viewModel.page.btnNext.Click += viewModel.NextPage;
            viewModel.page.btnPrev.Click += viewModel.PreviousPage;
            viewModel.page.cbPerPage.SelectedValueChanged += viewModel.LimitPerPage;
            viewModel.page.bindingSource = CustomerBS;
            btnSave.Click += delegate {
                if(viewModel.customerModel == null)
                {
                    viewModel.customerModel = new Model.CustomerModel
                    {
                        Firstname = tbFirstname.Text,
                        Middlename = tbMiddlename.Text,
                        Lastname = tbLastname.Text,
                        ContactNo = tbContoctNo.Text
                    };
                } 
                else
                {
                    viewModel.customerModel.Lastname = tbLastname.Text;
                    viewModel.customerModel.Middlename = tbMiddlename.Text;
                    viewModel.customerModel.Firstname = tbFirstname.Text;
                    viewModel.customerModel.ContactNo = tbContoctNo.Text;
                }
                viewModel.SaveCustomer();
            };
            dgCustomer.CellClick += viewModel.dgCustomer_CellClick;
            dgCustomer.DataBindingComplete += delegate { dgCustomer.ClearSelection(); };
        }

        public void SetCustomerField()
        {
            tbLastname.Text = viewModel.customerModel.Lastname;
            tbMiddlename.Text = viewModel.customerModel.Middlename;
            tbFirstname.Text = viewModel.customerModel.Firstname;
            tbContoctNo.Text = viewModel.customerModel.ContactNo;
        }

        public void ClearCustomerFied()
        {
            foreach(Control ctr in panel1.Controls)
            {
                if(ctr.GetType() == typeof(TextBox) )
                {
                    ((TextBox)ctr).Clear();
                }
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                viewModel.page.start = 0;
                viewModel.page.page = 0;
                viewModel.LoadCustomers(Search);
            }
        }
    }
}
