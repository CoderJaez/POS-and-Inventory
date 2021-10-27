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
using System.Drawing;

namespace PurpleYam_POS.ViewModel
{
   public class PosViewModel
    {

        //Forms
        private LoadingScreen loadingScreen;
        private FormTransaction formTransaction;
        //UserControl
        public PointOfSale uc;
        private Checkout ucCheckout;
        public SettlePayments ucSettlePayment;
        //Model
        private SoldProductModel pProductModel;
        public SaleTransactionModel stModel = new SaleTransactionModel();
        //BingdingSources
        public BindingSource OrderList { get; set; }

        //Local variables
        private string sql;
        private string[] particulars = { "ALL", "LARGE", "MEDIUM", "TIN CAN", "SLICE","NONE" };
        private int totalAddons = 0;
        public enum Transaction
        {
            WALK_IN,
            RESERVATION,
            CANCELLED
        }

        public Transaction transactionType;

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
        public PosViewModel()
        {
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
            SaveData("insert into tbl_sale_transaction (TransactionNo, CustomerId, DownPayment, Balance, Vat, SubTotal, TotalAmount, CashTendered, `Change`, ReservationDate, TransactionType) values (@TransactionNo,@CustomerId, @DownPayment, @Balance, @Vat, @SubTotal, @TotalAmount, @CashTendered, @Change,@ReservationDate,@TransactionType)", 
                new {
                    TransactionNo = stModel.TransactionNo,
                    CustomerId = stModel.Customer.Id,
                    DownPayment = stModel.DownPayment,
                    Balance = stModel.Balance,
                    Vat = stModel.Vat,
                    SubTotal = stModel.SubTotal,
                    TotalAmount = stModel.TotalAmount,
                    CashTendered = stModel.CashTendered,
                    Change = stModel.Change,
                    ReservationDate = stModel.ReservationDate,
                    TransactionType = transactionType.ToString()
                });
         
            loadingScreen.PanelChange.Visible = true;
            loadingScreen.Change = stModel.Change.ToString("N");
            if(transactionType == Transaction.RESERVATION)
                ClearCheckout();
            else
                uc.BtnClearOrders.PerformClick();
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
            var list = await LoadData<SoldProductModel, dynamic>("select Id, ProductId,Type, Product,Price,WithAddon, Image from product_inventory where QtyOnhand > 0 and Particulars LIKE @Particulars order by Product ASC", new { Particulars = $"%{particulars}%" });
            uc.PanelProducts.Controls.Clear();
            list.ForEach(product => {
                var prodComponent = new Product
                {
                    productModel =  product,
                    
                };
                prodComponent.SetProduct();
                uc.PanelProducts.Controls.Add(prodComponent);
                prodComponent.ButtonProduct.Click += new EventHandler(AddToCart);
            });

        }

        public void LoadMenuButtons()
        {
            var menuPanel = uc.Controls["panelMenu"] as FlowLayoutPanel;
            menuPanel.Controls.Clear();
            foreach(string particular in particulars)
            {
                var button = new Button
                {

                    FlatStyle = FlatStyle.Flat,
                    BackColor = menuPanel.Controls.Count > 0 ?  Color.White : Color.FromArgb(96, 44, 121),
                    ForeColor = menuPanel.Controls.Count > 0 ?  Color.Black : Color.White,
                    Tag = particular,
                    Text = particular.ToUpperInvariant(),
                    
                };
                menuPanel.Controls.Add(button);
                button.Click += uc.btnFilterProduct_Click;
            }
        }

        private async void LoadAddons()
        {
            var menuPanel = uc.Controls["panelMenu"] as FlowLayoutPanel;
            menuPanel.Controls.Clear();
            var button = new Button
            {

                FlatStyle = FlatStyle.Flat,
                BackColor = menuPanel.Controls.Count > 0 ? Color.White : Color.FromArgb(96, 44, 121),
                ForeColor = menuPanel.Controls.Count > 0 ?   Color.Black : Color.White,
                Text = "Top Menu",
                Size =  new Size(100,30)

            };
            menuPanel.Controls.Add(button);
            button.Click += delegate { LoadMenuButtons(); LoadProducts(); };
            var addons = await LoadData<SoldProductModel, dynamic>("SELECT p.Id as ProductId,p.Type, p.Product,  u.UnitCode, p.Price FROM tbl_product p LEFT JOIN tbl_unit u ON u.Id = p.UnitId WHERE p.Deleted = FALSE AND p.Type = 'Addon' and p.IsAvailable = true", new { });
            uc.PanelProducts.Controls.Clear();
            totalAddons = addons.Count;
            addons.ForEach(product => {
                var prodComponent = new Product
                {
                    productModel = product,

                };
                prodComponent.SetProduct();
                uc.PanelProducts.Controls.Add(prodComponent);
                prodComponent.ButtonProduct.Click += new EventHandler(AddToCart);
            });

        }


        private void AddToCart(object sender, EventArgs e)
        {
            var obj = sender as Button;
            var uc = obj.Parent as Product;
            SoldProductModel product = null;
          
            if (uc.productModel.Type == "Production")
            {
                product = ProductBS.List.OfType<SoldProductModel>().ToList().Find(p => p.ProductId == uc.productModel.ProductId);
                pProductModel = uc.productModel;
                if (product == null)
                {
                    uc.productModel.Qty = 0;
                    uc.productModel.Qty += 1;
                    uc.productModel.SubTotal = uc.productModel.Price * uc.productModel.Qty;
                    ProductBS.Add(uc.productModel);
                }
                else
                {
                    product.Qty += 1;
                    product.SubTotal = product.Price * product.Qty;
                    ProductBS.ResetBindings(true);

                }
                if (uc.productModel.WithAddon)
                    LoadAddons();
            } else
            {

                product = ProductBS.List.OfType<SoldProductModel>().ToList().Find(p => p.ProductId == pProductModel.ProductId);
                var prIndex = ProductBS.IndexOf(product);
                for (int i = 1; i <= totalAddons; i++)
                {
                    try
                    {
                        var addon = (SoldProductModel)ProductBS.List[prIndex + i];
                        if (addon.ProductId == uc.productModel.ProductId)
                        {
                            addon.Qty += 1;
                            addon.SubTotal = addon.Price * addon.Qty;
                            ProductBS.ResetBindings(true);
                            break;
                        }
                    }
                    catch (Exception)
                    {
                        uc.productModel.Product += $" {uc.productModel.UnitCode}";
                        uc.productModel.Qty = 0;
                        uc.productModel.Qty += 1;
                        uc.productModel.SubTotal = uc.productModel.Price * uc.productModel.Qty;
                        ProductBS.Add(uc.productModel);
                        break;
                    }

                }
              

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

            using (formTransaction = new FormTransaction(this))
                formTransaction.ShowDialog();

            if(transactionType == Transaction.RESERVATION)
            {
                if (!FormMain.Instance.MetroContainer.Controls.ContainsKey("Checkout"))
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
            } else
            {
                if (!FormMain.Instance.MetroContainer.Controls.ContainsKey("SettlePayments"))
                {
                    ucSettlePayment = new SettlePayments(this);
                    ucSettlePayment.Dock = DockStyle.Fill;
                    FormMain.Instance.MetroContainer.Controls.Add(ucSettlePayment);
                }
                if(CheckoutBS != null)
                    CheckoutBS.List.Clear();
                CheckoutBS.DataSource = null;
                ProductBS.List.OfType<SoldProductModel>().ToList().ForEach(p => CheckoutBS.Add(p));
                ucSettlePayment.SubTotal = stModel.SubTotal.ToString("N");
                ucSettlePayment.Tax = stModel.Vat.ToString("N");
                ucSettlePayment.TotalAmount = stModel.TotalAmount.ToString("N");
                ucSettlePayment.Balance = "0.00";
                stModel.CashTendered = 0;
                ucSettlePayment.CashTendered = null;
                FormMain.Instance.UserControl.Add("SettlePayments");
                FormMain.Instance.MetroContainer.Controls["SettlePayments"].BringToFront();
            }

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
                SaveData("UPDATE tbl_sale_transaction set Balance = @Balance, CashTendered = CashTendered + @CashTendered, `Change` = `Change` + @Change where TransactionNo = @TransactionNo ", new { TransactionNo = stModel.TransactionNo, Balance = stModel.Balance, CashTendered = stModel.CashTendered, Change = stModel.Change });
                Notification.AlertMessage("Payment Successfull","Success", Notification.AlertType.SUCCESS);
                using (loadingScreen = new LoadingScreen())
                {
                    loadingScreen.PanelChange.Visible = true;
                    loadingScreen.Change = stModel.Change.ToString("N");
                    loadingScreen.ShowDialog();
                }
                FormMain.Instance.Back.PerformClick();
                ucReservation.LoadData();
            }
        }
        private void ClearCheckout()
        {
            CheckoutBS.List.Clear();
            uc.BtnClearOrders.PerformClick();
            LoadProducts();
            stModel = new SaleTransactionModel();
            ucCheckout.Balance = "0.00";
            ucCheckout.DownPayment = null;
            ucCheckout.CashTendered = null;
            
        }
        #endregion


        #region Cutomer module

        private FormManageCustomer formCustomer;
        public BindingSource CustomerBS { get; set; }
        public CustomerModel customerModel { get; set; }

        public async void LoadCustomers(string search = null)
        {
            sql = "select * from tbl_customer where Deleted = false and (Firstname LIKE @search or Lastname LIKE @search or Middlename LIKE @search) order by Lastname asc ";
            CustomerBS.DataSource = await LoadData<CustomerModel, dynamic>(sql, new { search = $"%{search}%" });
        }


        public void SaveCustomer()
        {
            ValidationContext context = new ValidationContext(customerModel);
            IList<ValidationResult> errs = new List<ValidationResult>();

            if (!Validator.TryValidateObject(customerModel, context, errs, true))
            {
                StringBuilder errorMsg = new StringBuilder();
                foreach (ValidationResult res in errs)
                    errorMsg.Append($"{res.ErrorMessage}\n");
                Notification.ValidationMessage(FormMain.Instance, errorMsg.ToString(), "Validation Error");
                return;
            }

            var p = new
            {
                Lastname = customerModel.Lastname,
                Middlename = customerModel.Middlename,
                Firstname = customerModel.Firstname,
                ContactNo = customerModel.ContactNo,
                Id = customerModel.Id
            };
            if(customerModel.Id == 0)
            {
                sql = "insert into tbl_customer(Lastname, Firstname, Middlename, ContactNo) values (@Lastname, @Firstname, @Middlename, @ContactNo); SELECT last_insert_id();";
                customerModel.Id = SaveGetId(sql, p);
                Notification.AlertMessage("New Customer info saved.", "Success", Notification.AlertType.SUCCESS);
                CustomerBS.Add(customerModel);
            }
            else
            {
                sql = "update tbl_customer set Lastname = @Lastname, Middlename = @Middlename, Firstname = @Firstname, ContactNo = @ContactNo WHERE Id = @Id";
                SaveData(sql, p);
                ((DataGridView)formCustomer.Controls["dgCustomer"]).ClearSelection();
                Notification.AlertMessage("Customer info updated.", "Success", Notification.AlertType.SUCCESS);
            }

            customerModel = null;
            formCustomer.ClearCustomerFied();
        }

        public void OpenCustomerClick(object sender, EventArgs e)
        {
            using (formCustomer = new FormManageCustomer(this))
            {
                LoadCustomers();
                formCustomer.ShowDialog();
            }
        }

        public void dgCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dg = (DataGridView)sender;
            switch (dg.Columns[e.ColumnIndex].Name)
            {
                case "edit":
                    customerModel = CustomerBS.Current as CustomerModel;
                    formCustomer.SetCustomerField();
                    break;
                 default:
                    if(CheckoutBS != null && CheckoutBS.List.Count > 0)
                    {
                        if(Notification.Confim(FormMain.Instance, "Please click YES to confirm","Select customer") == DialogResult.Yes)
                        {
                            stModel.Customer = CustomerBS.Current as CustomerModel;
                            ucCheckout.AssignCustomer();
                            formCustomer.Close();
                        }
                    }
                    break;
            }

        }
        #endregion

        #region Resevations
        private Reservations ucReservation;
        public void Reservations()
        {
            if (!FormMain.Instance.MetroContainer.Controls.ContainsKey("Reservations"))
            {
                ucReservation = new Reservations();
                ucReservation.Dock = DockStyle.Fill;
                ucReservation.viewModel.posViewModel = this;
                FormMain.Instance.MetroContainer.Controls.Add(ucReservation);
            }

            FormMain.Instance.UserControl.Add("Reservations");
            FormMain.Instance.MetroContainer.Controls["Reservations"].BringToFront();
            ucReservation.LoadData();

        }
        #endregion
    }


}
