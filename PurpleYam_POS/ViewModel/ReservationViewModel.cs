using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Repository.DataAccess;
using PurpleYam_POS.Model;
using PurpleYam_POS.View.Forms;
using PurpleYam_POS.View.UserControls;
using System.Windows.Forms;
using PurpleYam_POS.Components;
using System.ComponentModel;
using System.Threading;

namespace PurpleYam_POS.ViewModel
{
   public class ReservationViewModel
    {
        //Binding Source 
        public BindingSource ProductBS { get; set; }
        //Model
        private SaleTransactionModel stModel { get; set; }

        //Usercontrols
        public Reservations ucReservation;
        public PosViewModel posViewModel;
        //Form
        private LoadingScreen loadingScreen;


        private string sql;
        private string transactionNo;

        //BackgroundWorker
        private BackgroundWorker backgroundWorker;
        struct DataParams
        {
            public int Process;
            public int Delay;
        }
        private DataParams InputParams;


        public ReservationViewModel()
        {

            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
        }

     

        public void LoadReservation(string search = null)
        {
            ucReservation.DgReservation.Rows.Clear();
            int index = 0;
            var list = GetReservation("select r.*, c.* from tbl_sale_transaction r left join tbl_customer c on c.Id = r.CustomerId Where TransactionType != 'WALK_IN' AND (c.Lastname LIKE @Search or c.Firstname LIKE @Search ) and r.ReservationDate >= @ReservationDate", new { Search = $"%{ucReservation.Search}%", ReservationDate = ucReservation.DateReservation.AddDays(-1) });
            list.ForEach(p =>
            {
                ucReservation.DgReservation.Rows.Add(
                    p.TransactionNo,
                    p.Customer.Fullname,
                    p.DownPayment,
                    p.Balance,
                    p.TotalAmount,
                    p.CashTendered,
                    p.TransactionDate,
                    p.ReservationDate,
                    p.Vat,
                    p.SubTotal,
                    p.TransactionType,
                    p.ClaimStatus
                    );
                ucReservation.DgReservation.Rows[index].Cells["pay"].Value = decimal.Parse(ucReservation.DgReservation.Rows[index].Cells["Balance"].Value.ToString()) > 0 ? Properties.Resources.settle_payment : Properties.Resources.paid;
                ucReservation.DgReservation.Rows[index].Cells["cancel"].Value = ucReservation.DgReservation.Rows[index].Cells["TransactionType"].Value.ToString() == "CANCELLED" ? Properties.Resources.order_cancelled : Properties.Resources.cancel_order;
                ucReservation.DgReservation.Rows[index].Cells["claim"].Value = ucReservation.DgReservation.Rows[index].Cells["ClaimStatus"].Value != null  ? Properties.Resources.claimed : Properties.Resources.claim;
                index++;
            });
        }


        public void DgSettlePayment(object sender, DataGridViewCellEventArgs e)
        {
            var dg = (DataGridView)sender;
            
            if(dg.Rows.Count > 0)
            {
                var currentRow = dg.CurrentRow;
                GetProductOrdered(currentRow.Cells["TransactionNo"].Value.ToString());
                transactionNo = dg.CurrentRow.Cells["TransactionNo"].Value.ToString();
                switch(dg.Columns[e.ColumnIndex].Name)
                {
                    case "pay":
                        if(decimal.Parse(currentRow.Cells["Balance"].Value.ToString()) > 0 )
                        {
                           if(!FormMain.Instance.MetroContainer.Controls.ContainsKey("SettlePayments"))
                            {
                                posViewModel.ucSettlePayment = new SettlePayments(posViewModel);
                                posViewModel.ucSettlePayment.Dock = DockStyle.Fill;
                                FormMain.Instance.MetroContainer.Controls.Add(posViewModel.ucSettlePayment);
                            }
                            GetProductOrdered(currentRow.Cells["TransactionNo"].Value.ToString());
                            posViewModel.ucSettlePayment.TransactionNo = currentRow.Cells["TransactionNo"].Value.ToString();
                            posViewModel.ucSettlePayment.SubTotal = currentRow.Cells["SubTotal"].Value.ToString();
                            posViewModel.ucSettlePayment.Balance = currentRow.Cells["Balance"].Value.ToString();
                            posViewModel.ucSettlePayment.Tax = currentRow.Cells["Vat"].Value.ToString();
                            posViewModel.ucSettlePayment.TotalAmount = currentRow.Cells["TotalAmount"].Value.ToString();
                            posViewModel.CheckoutBS.Clear();
                            posViewModel.CheckoutBS.DataSource = ProductBS.DataSource;
                            FormMain.Instance.UserControl.Add("SettlePayments");
                            FormMain.Instance.MetroContainer.Controls["SettlePayments"].BringToFront();
                        }
                        break;

                    case "cancel":
                       if(currentRow.Cells["TransactionType"].Value.ToString() != "CANCELLED")
                        {
                            if (Notification.Confim(FormMain.Instance, "Do you want to cancel the reservation?", "Cancel reservation") == DialogResult.Yes)
                            {
                                CancelTransaction();

                            }
                        }
                        break;
                    case "claim":
                        if(decimal.Parse(currentRow.Cells["Balance"].Value.ToString()) > 0)
                        {
                            Notification.AlertMessage("Settle the remaining balance before claiming.", "Settle balance", Notification.AlertType.INFO);
                            return;
                        }
                        if (currentRow.Cells["TransactionType"].Value.ToString() == "CANCELLED")
                        {
                            Notification.AlertMessage("The selected reservation is already cancelled.", "Cancelled reservation", Notification.AlertType.INFO);
                            return;

                        }

                        if (currentRow.Cells["ClaimStatus"].Value == null)
                        {
                            if (Notification.Confim(FormMain.Instance, "Click YES to confirm.", "Reservation claim") == DialogResult.Yes)
                                OrderClaim();
                        }

                        break;
                    default:
                        break;
                }
            }
        }

        private void OrderClaim()
        {
            SaveData("update tbl_sale_transaction set ClaimStatus = 'CLAIMED' where TransactionNo = @TransactionNo", new { TransactionNo = transactionNo });
            Notification.AlertMessage("", "Success", Notification.AlertType.SUCCESS);
            LoadReservation();
        }
        public async void GetProductOrdered(string TransactionNo)
        {
           ProductBS.DataSource = await LoadData<SoldProductModel, dynamic>("select ps.*,p.Product, u.UnitCode from tbl_product_sold ps LEFT JOIN tbl_product p on p.Id = ps.ProductId LEFT JOIN tbl_unit u ON u.Id = p.UnitId  where ps.TransactionNo = @TransactionNo", new { TransactionNo = TransactionNo });
        }

        public void CancelTransaction()
        {
            GetProductOrdered(transactionNo);
            if (!backgroundWorker.IsBusy)
            {
                loadingScreen = new LoadingScreen();
                InputParams.Delay = 200;
                InputParams.Process = ProductBS.Count;
                backgroundWorker.RunWorkerAsync(InputParams);
                loadingScreen.ShowDialog();
            }

        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var p = new
            {
                TransactionNo = transactionNo,
                Status = "CANCELLED",

            };
            SaveData("update tbl_sale_transaction set TransactionType = @Status where TransactionNo = @TransactionNo; update tbl_product_sold set SoldStatus = @Status where TransactionNo = @TransactionNo", p);
            loadingScreen.Close();
            Notification.AlertMessage("The reseravation is now cancelled", "Cancel reservation", Notification.AlertType.INFO);
            LoadReservation();
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            loadingScreen.LabelLoading.Text = $"Processing... {e.ProgressPercentage}%";
            loadingScreen.ProgressBar.Value = e.ProgressPercentage;
            loadingScreen.ProgressBar.Update();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = ((DataParams)e.Argument).Process;
            int delay = ((DataParams)e.Argument).Delay;
            int index = 1;
            try
            {
                ProductBS.List.OfType<SoldProductModel>().ToList().ForEach(p => {
                    var param = new
                    {
                        Qty = p.Qty,
                        ProductId = p.ProductId,
                    };
                    SaveData("update tbl_production_stockin set QtyOnhand = QtyOnhand + @Qty where ProductId = @ProductId order by DateStockin ASC limit 1", param);
                    backgroundWorker.ReportProgress(index++ * 100 / process);
                    Thread.Sleep(delay);
                });
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                Notification.ValidationMessage(FormMain.Instance, "Something went wrong!", "Please contact the system administrator");
            }
        }


        public void ClearOrders()
        {
            ProductBS.Clear();
        }


    }
}
