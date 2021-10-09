using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurpleYam_POS.Model;
using PurpleYam_POS.Components;
using PurpleYam_POS.View.UserControls;
using PurpleYam_POS.View.Forms;
using static Repository.DataAccess;
using static Repository.ProductionInventory;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;
using System.ComponentModel.DataAnnotations;

namespace PurpleYam_POS.ViewModel
{
   public class PosViewModel
    {

        //Forms
        private LoadingScreen loadingScreen;
        //UserControl
        private PointOfSale uc;
        private Checkout ucCheckout;
        //Model
        private SoldProductModel productModel;
        public SaleTransactionModel stModel = new SaleTransactionModel();
        //BingdingSources
        public BindingSource OrderList { get; set; }

        //Local variables
        private string sql;
        
        //Binding Source
        public BindingSource ProductBS { get; set; }
        public BindingSource CheckoutBS { get; set; }

        //BackgroundWorker
        private BackgroundWorker backgroundWorker;
        struct DataParams
        {
            public int Process;
            public int Delay;
        }
        private DataParams InputParams;


        //Constructor
        public PosViewModel(PointOfSale _uc)
        {
            uc = _uc;
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            loadingScreen.LabelLoading.Text = $"Processing... {e.ProgressPercentage}%";
            loadingScreen.ProgressBar.Value = e.ProgressPercentage;
            loadingScreen.ProgressBar.Update();
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            SaveData("insert into tbl_sale_transaction (TransactionNo, CustomerName,ContactNo, DownPayment, Balance, Vat, SubTotal, TotalAmount, CashTendered, `Change`, ReservationDate) values (@TransactionNo,@CustomerName,@ContactNo, @DownPayment, @Balance, @Vat, @SubTotal, @TotalAmount, @CashTendered, @Change,@ReservationDate)", new { TransactionNo = stModel.TransactionNo, CustomerName = stModel.CustomerName, ContactNo = stModel.ContactNo, DownPayment = stModel.DownPayment, Balance = stModel.Balance, Vat = stModel.Vat, SubTotal = stModel.SubTotal, TotalAmount = stModel.TotalAmount, CashTendered = stModel.CashTendered, Change = stModel.Change, ReservationDate = stModel.ReservationDate });
         ;
            loadingScreen.PanelChange.Visible = true;
            loadingScreen.Change = stModel.Change.ToString("N");
            ClearCheckout();
            FormMain.Instance.Back.PerformClick();
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int process = ((DataParams)e.Argument).Process;
            int delay = ((DataParams)e.Argument).Delay;
            int index = 1;
            try
            {
                CheckoutBS.List.OfType<SoldProductModel>().ToList().ForEach(p => {
                    var param = new
                    {
                        Qty = p.Qty,
                        ProductId = p.ProductId
                    };
                    SaveData("update tbl_production_stockin set QtyOnhand = QtyOnhand - @Qty where ProductId = @ProductId order by DateStockin ASC limit 1", param);
                    SaveData("insert into tbl_product_sold(TransactionNo, ProductId, Qty, Price, SubTotal) values (@TransactionNo,@ProductId, @Qty, @Price, @SubTotal)", new { TransactionNo = stModel.TransactionNo, ProductId = p.ProductId, Qty = p.Qty, Price = p.Price, SubTotal = p.SubTotal });
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

        public async void LoadProducts(string particulars = null)
        {
            var list = await LoadData<SoldProductModel, dynamic>("select Id, ProductId, Product,Price, Image from product_inventory where QtyOnhand > 0 and Particulars LIKE @Particulars order by Product ASC", new { Particulars = $"%{particulars}%" });
            uc.PanelProducts.Controls.Clear();
            list.ForEach(product => {
                var prodComponent = new Product
                {
                    productModel =  product,
                    
                };
                prodComponent.SetProduct();
                uc.PanelProducts.Controls.Add(prodComponent);
                prodComponent.Img.Click += new EventHandler(AddToCart);
            });
        }

        
        private void AddToCart(object sender, EventArgs e)
        {
            var obj = sender as PictureBox;
            var uc = obj.Parent as Product;
            var product = ProductBS.List.OfType<SoldProductModel>().ToList().Find(p => p.ProductId == uc.productModel.ProductId);
            if (product == null)
            {
                uc.productModel.Qty = 0;
                uc.productModel.Qty += 1;
                uc.productModel.SubTotal = uc.productModel.Price * uc.productModel.Qty;
                ProductBS.Add(uc.productModel);
            } else
            {
                product.Qty += 1;
                product.SubTotal = product.Price * product.Qty;
                ProductBS.ResetBindings(true);
            }
            ComputePayments();
        }


        private void ComputePayments()
        {
            stModel.TotalAmount = 0;
            ProductBS.List.OfType<SoldProductModel>().ToList().ForEach(
                pr =>
                {
                    stModel.TotalAmount += pr.SubTotal;
                });

            stModel.Vat = Math.Round((stModel.TotalAmount * (decimal)0.12 )/ (decimal)1.12,2);
            stModel.SubTotal = stModel.TotalAmount - stModel.Vat;
            uc.SubTotal = stModel.SubTotal.ToString("N");
            uc.Tax = stModel.Vat.ToString("N");
            uc.TotalAmount = stModel.TotalAmount.ToString("N");
        }

        public void AdjustQty(object sender, DataGridViewCellEventArgs e)
        {
            var dg = (DataGridView)sender;
            var currentProd = ProductBS.Current as SoldProductModel;
            switch (dg.Columns[e.ColumnIndex].Name)
            {
                case "add":
                    currentProd.Qty += 1;
                    currentProd.SubTotal = currentProd.Price * currentProd.Qty;
                    break;
                case "minus":
                    if (currentProd.Qty > 1)
                    {
                         currentProd.Qty -= 1;
                        currentProd.SubTotal = currentProd.Price * currentProd.Qty;

                    }
                    else
                    {
                        ProductBS.RemoveCurrent();
                    }
                    break;
                case "delete":
                        ProductBS.RemoveCurrent();
                    break;

            }
            ProductBS.ResetBindings(true);
            ComputePayments();
          }



        #region Checkout
        public void Checkout_Click(object sender, EventArgs e)
        {
            if(ProductBS.List.Count == 0)
            {
                Notification.AlertMessage("No products added to cart", "Add products to cart", Notification.AlertType.WARNING);
                return;
            }
            if(!FormMain.Instance.MetroContainer.Controls.ContainsKey("Checkout"))
            {
                ucCheckout = new Checkout(this);
                ucCheckout.Dock = DockStyle.Fill;
                FormMain.Instance.MetroContainer.Controls.Add(ucCheckout);
            }
            CheckoutBS.List.Clear();
            ProductBS.List.OfType<SoldProductModel>().ToList().ForEach(p => CheckoutBS.Add(p));
            ucCheckout.SubTotal = stModel.SubTotal.ToString("N");
            ucCheckout.Tax = stModel.Vat.ToString("N");
            ucCheckout.TotalAmount = stModel.TotalAmount.ToString("N");
            stModel.DownPayment = 0;
            stModel.Balance = 0;
            stModel.CashTendered = 0;
            ucCheckout.Balance = "0.00";
            ucCheckout.DownPayment = null;
            ucCheckout.CashTendered = null;
            FormMain.Instance.UserControl.Add("Checkout");
            FormMain.Instance.MetroContainer.Controls["Checkout"].BringToFront();
        }


        public void SettlePayment()
        {

            ValidationContext context = new ValidationContext(stModel);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(stModel, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage}\n");
                Notification.ValidationMessage(FormMain.Instance, errorMsg.ToString(), "Validation Error");
                return;
            }

            //New Transaction
            if (string.IsNullOrEmpty(stModel.TransactionNo))
            {
                stModel.TransactionNo = TransactioNo();
                if (!backgroundWorker.IsBusy)
                {
                    loadingScreen = new LoadingScreen();
                    InputParams.Delay = 200;
                    InputParams.Process = CheckoutBS.Count;
                    backgroundWorker.RunWorkerAsync(InputParams);
                    loadingScreen.ShowDialog();
                }
            }
            else
            {
                //Update Transaction
            }
        }
        private void ClearCheckout()
        {
            CheckoutBS.List.Clear();
            uc.BtnClearOrders.PerformClick();
            stModel = new SaleTransactionModel();
            ucCheckout.Balance = "0.00";
            ucCheckout.DownPayment = null;
            ucCheckout.CashTendered = null;
            
        }
        #endregion
    }


}
