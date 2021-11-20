using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PurpleYam_POS.View.UserControls;
using PurpleYam_POS.View.Forms;
using PurpleYam_POS.Model;
using static Repository.DataAccess;
using static Repository.ProductionInventory;
using System.Windows.Forms;
using PurpleYam_POS.Components;
using System.Drawing;
using System.ComponentModel;
using System.Threading;

namespace PurpleYam_POS.ViewModel
{
    public class InventoryViewModel
    {
        //Forms
        private LoadingScreen loadingScreen;
        //UserControls
        public InventorySettings ucInventorySettings;
        private StockinRawMat ucRawmatStockin;
        private RawmatInventory ucRawmatInvetory;
        private StockAdjRawMat ucRawmanAdj;
        private ProductionInventory ucProductionInventory;
        private StockinProduction ucProductionStockin;
        private StockAdjProduction ucProductionAdj;

        //Form Controls
        private DataGridView StockInDG;
        private DataGridView RawmatDG;
        private DataGridView ProdStockinDG;
        private DataGridView ProductDG;

        //Production Model
        private ProductModel productModel;

        //RawMat Models
        private RawMaterial rawmatModel;
        //Local Variables
        private string sql;
        private string setStockIn;
        //Public Variables
        public string search = "%%";
        
        //BindingSources for Raw Materials
        public BindingSource StockInBS { get; set; }
        public BindingSource RawmatBS { get; set; }
        public BindingSource UnitBS { get; set; }
        public BindingSource InventoryBS { get; set; }

        //BindingSources for Productions
        public BindingSource ProductBS { get; set; }
        public BindingSource ProductInvBS { get; set; }
        public BindingSource ProductStockinBS { get; set; }
        public BindingSource ProductPendingBS { get; set; }

        private BackgroundWorker backgroundWorker;

        struct DataParams
        {
            public int Process;
            public int Delay;
        }
        private DataParams InputParams;

        public InventoryViewModel()
        {
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            switch(setStockIn)
            {
                case "RawMat":
                    SaveStockInRawMat(e);
                    break;
                case "Production":
                    SaveStockinProduction(e);
                    break;
            }
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loadingScreen.LabelLoading.Text = $"Saving... {e.ProgressPercentage}%";
            loadingScreen.ProgressBar.Value = e.ProgressPercentage;
            loadingScreen.ProgressBar.Update();
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(ucRawmatStockin != null)
            {
                Notification.AlertMessage("New Stocks added.", "Success", Notification.AlertType.SUCCESS);
                ucRawmatStockin.DateExpiryDTP.Visible = false;
                StockInBS.Clear();
                ucRawmatStockin.CbUnitCode.Visible = false;
            }

            if(ucProductionStockin != null)
            {
                Notification.AlertMessage("New Production stocks added.", "Success", Notification.AlertType.SUCCESS);
                ProductStockinBS.Clear();
            }
           
            loadingScreen.Close();
            
        }

        internal void InventoryMenu(object sender, TreeNodeMouseClickEventArgs e)
        {
            var treeView = (TreeView)sender;
            treeView.SelectedNode = e.Node;
            switch (treeView.SelectedNode.Tag.ToString())
            {
                case "RawMatStockIn":
                    if (!ucInventorySettings.MainPanel.Controls.ContainsKey("StockinRawMat"))
                    {
                        ucRawmatStockin = new StockinRawMat(this);
                        ucRawmatStockin.Dock = DockStyle.Fill;
                        ucInventorySettings.MainPanel.Controls.Add(ucRawmatStockin);
                    }
                    StockInBS.Clear();
                    RawmatBS = ucRawmatStockin.ucRamatBS;
                    GetRawMat();
                    ucInventorySettings.MainPanel.Controls["StockinRawMat"].BringToFront();
                    break;
                case "RawMatAdj":
                    if(!ucInventorySettings.MainPanel.Controls.ContainsKey("StockAdjRawMat"))
                    {
                        ucRawmanAdj = new StockAdjRawMat(this);
                        ucRawmanAdj.Dock = DockStyle.Fill;
                        ucInventorySettings.MainPanel.Controls.Add(ucRawmanAdj);
                    }
                    GetRawmatInventory();
                    RawmatBS = ucRawmanAdj.ucRawmatBS;
                    RawmatBS.Clear();
                    ucInventorySettings.MainPanel.Controls["StockAdjRawMat"].BringToFront();
                    break;
                case "RawMat":
                    if (!ucInventorySettings.MainPanel.Controls.ContainsKey("RawmatInventory"))
                    {
                        ucRawmatInvetory = new RawmatInventory(this);
                        ucRawmatInvetory.Dock = DockStyle.Fill;
                        ucInventorySettings.MainPanel.Controls.Add(ucRawmatInvetory);
                    }
                    GetRawmatInventory();
                    ucInventorySettings.MainPanel.Controls["RawmatInventory"].BringToFront();
                    break;
                case "Production":
                    if (!ucInventorySettings.MainPanel.Controls.ContainsKey("ProductionInventory"))
                    {
                        ucProductionInventory = new ProductionInventory(this);
                        ucProductionInventory.Dock = DockStyle.Fill;
                        ucInventorySettings.MainPanel.Controls.Add(ucProductionInventory);
                    }
                    ucProductionInventory.LoadData();
                    ucInventorySettings.MainPanel.Controls["ProductionInventory"].BringToFront();
                    break;

                case "ProductionStockIn":
                    if (!ucInventorySettings.MainPanel.Controls.ContainsKey("StockinProduction"))
                    {
                        ucProductionStockin = new StockinProduction(this);
                        ucProductionStockin.Dock = DockStyle.Fill;
                        ucInventorySettings.MainPanel.Controls.Add(ucProductionStockin);
                    }
                    GetProduct();
                    ucInventorySettings.MainPanel.Controls["StockinProduction"].BringToFront();
                    break;
                case "ProductionAdj":

                    if (!ucInventorySettings.MainPanel.Controls.ContainsKey("StockAdjProduction"))
                    {
                        ucProductionAdj = new StockAdjProduction(this);
                        ucProductionAdj.Dock = DockStyle.Fill;
                        ucInventorySettings.MainPanel.Controls.Add(ucProductionAdj);
                    }
                    ucProductionAdj.LoadData();
                    ucInventorySettings.MainPanel.Controls["StockAdjProduction"].BringToFront();
                    break;
            }
        }

        #region Raw Material

        public void AdjustRawmatStock()
        {
            bool isChecked = ucRawmanAdj.CkbAdd.Checked ? true : (ucRawmanAdj.CkbRemove.Checked ? true : false);
            if (rawmatModel != null)
            {
                if (!isChecked || string.IsNullOrEmpty(ucRawmanAdj.CbRemarks.Text) || string.IsNullOrEmpty(ucRawmanAdj.TbQty.Text))
                {
                    Notification.ValidationMessage(FormMain.Instance, "Fill up all the required fields.\n 1. Quantity\n2. Remarks\n3. Add or Remove checkbox", "Field/s empty");
                    return;
                }
                if( ucRawmanAdj.CkbRemove.Checked && int.Parse(ucRawmanAdj.TbQty.Text) > rawmatModel.Qty)
                {
                    Notification.ValidationMessage(FormMain.Instance, $"The quantity must not exceeded to {rawmatModel.Qty}{rawmatModel.DisplayUnit}.", "Quantity is exceeded.");
                    return;
                }

                if (ucRawmanAdj.CkbAdd.Checked)
                    sql = "update tbl_rawmat_stockin set QtyOnhand = QtyOnhand + @Qty, Qty = Qty + @Qty where Id = @StockInId";
                else if (ucRawmanAdj.CkbRemove.Checked && ucRawmanAdj.CbRemarks.Text == "ERRONEOUS ENTRY") 
                    sql = "update tbl_rawmat_stockin set QtyOnhand = QtyOnhand - @Qty, Qty = Qty - @Qty where Id = @StockInId";
                else if (ucRawmanAdj.CkbRemove.Checked && ucRawmanAdj.CbRemarks.Text == "SPOILAGE")
                    sql = "update tbl_rawmat_stockin set QtyOnhand = QtyOnhand - @Qty, QtyDmg = QtyDmg +  @Qty where Id = @StockInId";
                else
                    sql = "update tbl_rawmat_stockin set QtyOnhand = QtyOnhand - @Qty where Id = @StockInId";

                var p = new
                {
                    Qty = decimal.Parse(ucRawmanAdj.TbQty.Text),
                    StockInId = rawmatModel.Id
                };
                SaveData(sql, p);
                Notification.AlertMessage($"Raw material {rawmatModel.Product} stocks adjusted.", "Success",Notification.AlertType.SUCCESS);
                rawmatModel.Qty += decimal.Parse(ucRawmanAdj.TbQty.Text);
                ucRawmanAdj.TbQty.Text = null;
                ucRawmanAdj.TbProduct.Text = null;
                RawmatBS.Clear();
                GetRawmatInventory();
            }
        }
        public void SelectRawmat()
        {
            rawmatModel = RawmatBS.Current as RawMaterial;
            if(rawmatModel != null)
                ucRawmanAdj.TbProduct.Text = rawmatModel.Product;
        }
        public async void StockinRawmat(int _rawmatId)
        {
            sql = "select * from rawmat_stockin rms where rms.RawmatId = @RawmatId and rms.Qty > 0 order by rms.DateArrival DESC ";
            RawmatBS.DataSource = await LoadData<RawMaterial, dynamic>(sql, new { RawmatId = _rawmatId });
        }
        public async void GetRawmatInventory()
        {
            sql = "select * from rawmat_inventory";
            InventoryBS.DataSource = await LoadData<RawMaterial, dynamic>(sql, new { });
        }
       
        public void StockInRawMat()
        {
            StringBuilder errMsg = new StringBuilder();
            int ErrNos = 0;
            try
            {
                StockInBS.List.OfType<RawMaterial>().ToList().ForEach(rawmat =>
                {
                    if (rawmat.HasExpiry && rawmat.DateExpiry.ToShortDateString() == "1/1/0001")
                    {
                            
                            ucRawmatStockin.DgStockIn.Rows[StockInBS.IndexOf(rawmat)].DefaultCellStyle.BackColor = Color.Red;
                            errMsg.Append($"{rawmat.Product} DateExpiry has not been set.\n");
                            ErrNos++;
                        
                    }
                    if (rawmat.Qty <= 0 || string.IsNullOrEmpty(rawmat.DisplayUnit))
                    {
                        ucRawmatStockin.DgStockIn.Rows[StockInBS.IndexOf(rawmat)].DefaultCellStyle.BackColor = Color.Red;
                        errMsg.Append($"{rawmat.Product} quantity must be greater that 0. and must select unit code.\n");
                        ErrNos++;
                    }

                });

                if (ErrNos > 0)
                {
                    Notification.ValidationMessage(FormMain.Instance, errMsg.ToString(), "");
                    return;
                }
                if (!backgroundWorker.IsBusy)
                {
                    loadingScreen = new LoadingScreen();
                    setStockIn = "RawMat";
                    InputParams.Delay = 200;
                    InputParams.Process = StockInBS.Count;
                    backgroundWorker.RunWorkerAsync(InputParams);
                    loadingScreen.ShowDialog();
                }

            }
            catch (Exception ex)
            {

                Notification.AlertMessage(ex.Message, "Exception Encountered", Notification.AlertType.ERROR);
            }
        }

        private void SaveStockInRawMat(DoWorkEventArgs e)
        {
            int process = ((DataParams)e.Argument).Process;
            int delay = ((DataParams)e.Argument).Delay;
            int index = 1;
            try
            {
                StockInBS.List.OfType<RawMaterial>().ToList().ForEach(rm => {
                        sql = $@"INSERT INTO tbl_rawmat_stockin (RawMatId, GrpUnitId, Qty, QtyOnhand, DateArrival{(rm.HasExpiry ? ", DateExpiry": "" )}) 
                                        VALUES (@RawMatId,@GrpUnitId,@Qty,@QtyOnhand,@DateArrival {(rm.HasExpiry ? ", @DateExpiry":"")}) ";
                    var p = new
                    {
                        RawMatId = rm.Id,
                        GrpUnitId = rm.UnitId,
                        Qty = rm.Qty,
                        QtyOnhand = rm.Qty,
                        DateArrival = ucRawmatStockin.DateArrival,
                        DateExpiry  = rm.DateExpiry
                    };
                    SaveData(sql, p);
                    backgroundWorker.ReportProgress(index++ * 100 / process);
                    Thread.Sleep(delay);
                });
            }
            catch (Exception ex)
            {
                backgroundWorker.CancelAsync();
                Notification.AlertMessage(ex.Message, "", Notification.AlertType.ERROR);
            }

        }


        public async void GetRawMat()
        {
            sql = "select Product, Id, HasExpiry from rawmaterial where Deleted = false and Product LIKE @Search order by Product asc";
            RawmatBS.DataSource = await LoadData<RawMaterial, dynamic>(sql, new { Search = search });
        }

        public void AddToStock(object sender, DataGridViewCellEventArgs e)
        {
            RawmatDG = (DataGridView)sender;
            if (RawmatDG.Rows.Count > 0)
            {
                var currentRow = RawmatBS.Current as RawMaterial;
                if (StockInBS.List.OfType<RawMaterial>().ToList().Find(r => r.Id == currentRow.Id) == null)
                {
                    StockInBS.Add(currentRow);
                        ucRawmatStockin.DgStockIn.Rows[0].Selected = false;
                }
               

            }
        }

     

        public async void DgStockinCellClick(object sender, DataGridViewCellEventArgs e)
        {
            StockInDG = (DataGridView)sender;
            if (StockInDG.Rows.Count > 0)
            {

                var currentRow = StockInBS.Current as RawMaterial;
                var cellSize = StockInDG.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                switch(StockInDG.Columns[e.ColumnIndex].DataPropertyName)
                {
                    case "DateExpiry":
                        ucRawmatStockin.DateExpiryDTP.Size = new System.Drawing.Size(cellSize.Width, cellSize.Height);
                        ucRawmatStockin.DateExpiryDTP.Location = new System.Drawing.Point(cellSize.X + StockInDG.Location.X, cellSize.Y + StockInDG.Location.Y);
                        ucRawmatStockin.DateExpiryDTP.Visible = currentRow.HasExpiry;
                        break;
                    case "DisplayUnit":
                        ucRawmatStockin.CbUnitCode.Size = new Size(cellSize.Width, cellSize.Height);
                        ucRawmatStockin.CbUnitCode.Location = new Point(cellSize.X + StockInDG.Location.X, cellSize.Y + StockInDG.Location.Y);
                        UnitBS.DataSource = await LoadData<Unit, dynamic>("select Id, UnitCode from units where ProductId = @Id", new { Id = currentRow.Id });
                        ucRawmatStockin.CbUnitCode.Visible = true;
                        break;
                    default:
                        if (StockInDG.Columns[e.ColumnIndex].Name == "delete")
                            StockInBS.RemoveCurrent();

                        ucRawmatStockin.CbUnitCode.Visible = false;
                        ucRawmatStockin.DateExpiryDTP.Visible = false;
                        break;
                }
               
            }
        }


        #endregion

        #region Production 
        private DateTime dateProduction;
        public void StockinProduction(DateTime date)
        {
            StringBuilder errMsg = new StringBuilder();
            int errNo = 0;

            ProductStockinBS.List.OfType<ProductModel>().ToList().ForEach(p =>
            {
                if( p.Qty <= 0)
                {
                    errMsg.Append($"{p.Product} qty must be qreater than 0\n");
                    errNo++;
                }
            });

            if(errNo >0)
            {
                Notification.ValidationMessage(FormMain.Instance, errMsg.ToString(), "");
                return;
            }
            dateProduction = date;
            if (!backgroundWorker.IsBusy)
            {
                loadingScreen = new LoadingScreen();
                setStockIn = "Production";
                InputParams.Delay = 200;
                InputParams.Process = ProductStockinBS.Count;
                backgroundWorker.RunWorkerAsync(InputParams);
                loadingScreen.ShowDialog();
            }
        }

        private void SaveStockinProduction(DoWorkEventArgs e)
        {
            int process = ((DataParams)e.Argument).Process;
            int delay = ((DataParams)e.Argument).Delay;
            int index = 1;

            ProductStockinBS.List.OfType<ProductModel>().ToList().ForEach(pr => {
                sql = "insert into tbl_production_stockin (ProductId, Qty, QtyOnhand, UserId,DateStockin) Values (@ProductId, @Qty, @QtyOnhand, @UserId, @Date)";
                var p = new
                {
                    ProductId = pr.Id,
                    Qty = pr.Qty,
                    QtyOnhand = pr.Qty,
                    UserId = 0,
                    Date = dateProduction
                };
                SaveData(sql, p);
                backgroundWorker.ReportProgress(index++ * 100 / process);
                Thread.Sleep(delay);
            });
            
        }
        public void DgProductionCellClick (object sender, DataGridViewCellEventArgs e)
        {
            ProdStockinDG = (DataGridView)sender;
            if(ProdStockinDG.Rows.Count > 0)
            {
                if (ProdStockinDG.Columns[e.ColumnIndex].Name == "delete")
                    ProductStockinBS.RemoveCurrent();
            }
        }

        private async void GetProduct()
        {
            sql = "select Id, Product,Particulars, Quality from tbl_product where Deleted = false and Type = 'Production'";
            ProductBS.DataSource = await LoadData<ProductModel, dynamic>(sql, new { });
        }

        public void AddToStockProduct(object sender, DataGridViewCellEventArgs e)
        {
            ProductDG = (DataGridView)sender;
            if (ProductDG.Rows.Count > 0)
            {
                var currentRow = ProductBS.Current as ProductModel;
                //ProductInvBS.Add(currentRow);
                if (ProductStockinBS.List.OfType<ProductModel>().ToList().Find(r => r.Id == currentRow.Id) == null)
                {
                    ProductStockinBS.Add(currentRow);
                }

            }
        }

        public void ClearProductionStockin()
        {
            ProductStockinBS.Clear();
        }

        public async void LoadProduction()
        {
            ProductInvBS.DataSource = await LoadData<ProductModel, dynamic>("select Id,ProductId, Product, Particulars, Quality, QtyOnhand as Qty from product_inventory    order by Product ASC", new { });
        }

        public async void LoadPendingProduction()
        {
            ProductPendingBS.DataSource = await LoadData<ProductModel,dynamic>("select Id,ProductId, Product, Particulars, Quality, QtyOnhand AS Qty,Status, DateStockin from production_stockin where Status = 'pending' Order by DateStockin ASC", new { });
        }

        public void PendingProdCellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dg = (DataGridView)sender;
            if (dg.Rows.Count > 0)
            {
                if (dg.Columns[e.ColumnIndex].Name == "BakeComplete")
                {
                    if(Notification.Confim(FormMain.Instance, "Is the selected product done?", "Done baked") == DialogResult.Yes)
                    {
                        var product = ProductPendingBS.Current as ProductModel;
                        UpdatePRStocks(product.Id, product.ProductId, product.Qty);
                        ProductPendingBS.RemoveCurrent();
                        Notification.AlertMessage("Production is added to inventory.", "Production completed", Notification.AlertType.SUCCESS);
                    }
                }
            }
        }


        public async void ProductionInvCellClick(object sender, DataGridViewCellEventArgs e)
        {
            var obj = ProductInvBS.Current as ProductModel;
            ProductStockinBS.DataSource = await LoadData<ProductModel, dynamic>("select Id,ProductId, Product, Particulars, Quality, sum(QtyOnhand) as Qty, DateStockin from production_stockin where ProductId = @ProductId and QtyOnhand > 0 ORDER by DateStockin DESC ", new { ProductId = obj.ProductId });
        }



        public void ProductionStockCellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dg = sender as DataGridView;
            if(dg.Rows.Count > 0)
            {
                productModel = ProductStockinBS.Current as ProductModel;
                ucProductionAdj.TbProduct.Text = productModel.Product;
            }
        }


        public void AdjustProductiontStock()
        {
            bool isChecked = ucProductionAdj.CkbAdd.Checked ? true : (ucProductionAdj.CkbRemove.Checked ? true : false);
            
            if (productModel != null)
            {
                if (!isChecked || string.IsNullOrEmpty(ucProductionAdj.CbRemarks.Text) || string.IsNullOrEmpty(ucProductionAdj.TbQty.Text))
                {
                    Notification.ValidationMessage(FormMain.Instance, "Fill up all the required fields.\n 1. Quantity\n2. Remarks\n3. Add or Remove checkbox", "Field/s empty");
                    return;
                }
                if (ucProductionAdj.CkbRemove.Checked && int.Parse(ucProductionAdj.TbQty.Text) > productModel.Qty)
                {
                    Notification.ValidationMessage(FormMain.Instance, $"The quantity must not exceeded to {productModel.Qty}.", "Quantity is exceeded.");
                    return;
                }

                AdjustPRStocks(productModel.Id, productModel.ProductId, decimal.Parse(ucProductionAdj.TbQty.Text), ucProductionAdj.CbRemarks.Text, ucProductionAdj.CkbAdd.Checked);
                Notification.AlertMessage($"Product {productModel.Product} stocks adjusted.", "Success", Notification.AlertType.SUCCESS);
                ucProductionAdj.TbQty.Text = null;
                ucProductionAdj.TbProduct.Text = null;
                ProductStockinBS.Clear();
                LoadProduction();
            }
        }
        #endregion
    }
}
