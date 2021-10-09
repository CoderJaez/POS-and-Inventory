using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Repository.DataAccess;
using PurpleYam_POS.View.UserControls;
using PurpleYam_POS.Model;

namespace PurpleYam_POS.ViewModel
{
    public class SaleTransactionViewModel
    {
        //UserControl
        public SaleTransaction ucST;
        //BindingSource
        public BindingSource SaleTransactionBS { get; set; }

        //Constructor
        public SaleTransactionViewModel()
        {

        }

        public async void LoadTransactions()
        {
            SaleTransactionBS.DataSource = await LoadData<SaleTransactionModel, dynamic>("select * from tbl_sale_transaction order by TransactionDate DESC",new { });
        }
    }
}
