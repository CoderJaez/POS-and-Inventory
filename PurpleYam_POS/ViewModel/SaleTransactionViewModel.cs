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
        public BindingSource ReservationBS { get; set; }
        public BindingSource ProductBS { get; set; }

        //Constructor
        public SaleTransactionViewModel()
        {

        }

        public async void LoadWalkinTransaction()
        {
            SaleTransactionBS.DataSource = await LoadData<SaleTransactionModel, dynamic>("select * from tbl_sale_transaction where TransactionType = 'WALK_IN' and TransactionDate between @dateFrom and @dateTo order by TransactionDate DESC",new { dateFrom =  ucST.DtpwFrom.AddDays(-1), dateTo = ucST.DtpwTo.AddDays(1) });
        }


        public void LoadReservation()
        {
            ucST.DgReservation.Rows.Clear();
            int index = 0;
            ReservationBS.DataSource = GetReservation<SaleTransactionModel,CustomerModel,dynamic>("select r.*, c.* from tbl_sale_transaction r left join tbl_customer c on c.Id = r.CustomerId Where TransactionType != 'WALK_IN' AND (c.Lastname LIKE @Search or c.Firstname LIKE @Search or r.TransactionNo LIKE @Search ) and r.TransactionDate between @dateFrom and @dateTo", new { Search = $"%{ucST.Search}%", dateFrom = ucST.DtprFrom.AddDays(-1), dateTo = ucST.DtprTo.AddDays(1) });
            ReservationBS.List.OfType<SaleTransactionModel>().ToList().ForEach(p =>
            {
                ucST.DgReservation.Rows[index].Cells["cancel"].Value = p.TransactionType == "CANCELLED" ? Properties.Resources.order_cancelled : Properties.Resources.cancel_order;
                ucST.DgReservation.Rows[index].Cells["claim"].Value = p.ClaimStatus != null ? Properties.Resources.claimed : Properties.Resources.claim;
                index++;
            });
        }


        public void DgTransactionClick(object sender, DataGridViewCellEventArgs e)
        {
            var dg = (DataGridView)sender;

            if(dg.Rows.Count > 0)
            {
                string transactionNo = ucST.TabSales.SelectedTab.Name == "reservationTab" ? ((SaleTransactionModel)ReservationBS.Current).TransactionNo:((SaleTransactionModel)SaleTransactionBS.Current).TransactionNo;
                LoadProductSold(transactionNo);
            }
        }

        public async void LoadProductSold(string transactionNo)
        {
            ProductBS.DataSource = await LoadData<SoldProductModel, dynamic>("select ps.*,p.Product, u.UnitCode from tbl_product_sold ps LEFT JOIN tbl_product p on p.Id = ps.ProductId LEFT JOIN tbl_unit u ON u.Id = p.UnitId  where ps.TransactionNo = @TransactionNo", new { TransactionNo = transactionNo });
        }
    }
}
