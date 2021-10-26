namespace PurpleYam_POS.View.UserControls
{
    partial class Reservations
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservations));
            this.label1 = new System.Windows.Forms.Label();
            this.dgReservations = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSearch = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpReservation = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductBS = new System.Windows.Forms.BindingSource(this.components);
            this.TransactionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DownPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CashTendered = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResevationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransactionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClaimStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay = new System.Windows.Forms.DataGridViewImageColumn();
            this.cancel = new System.Windows.Forms.DataGridViewImageColumn();
            this.claim = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(841, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgReservations
            // 
            this.dgReservations.AllowUserToAddRows = false;
            this.dgReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgReservations.BackgroundColor = System.Drawing.Color.White;
            this.dgReservations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgReservations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TransactionNo,
            this.Fullname,
            this.DownPayment,
            this.Balance,
            this.TotalAmount,
            this.CashTendered,
            this.TransactionDate,
            this.ResevationDate,
            this.Vat,
            this.SubTotal,
            this.TransactionType,
            this.ClaimStatus,
            this.pay,
            this.cancel,
            this.claim});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReservations.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgReservations.EnableHeadersVisualStyles = false;
            this.dgReservations.Location = new System.Drawing.Point(30, 115);
            this.dgReservations.Margin = new System.Windows.Forms.Padding(30);
            this.dgReservations.Name = "dgReservations";
            this.dgReservations.ReadOnly = true;
            this.dgReservations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgReservations.RowHeadersVisible = false;
            this.dgReservations.RowHeadersWidth = 40;
            this.dgReservations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgReservations.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReservations.RowTemplate.Height = 45;
            this.dgReservations.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgReservations.Size = new System.Drawing.Size(445, 384);
            this.dgReservations.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(484, 115);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(336, 33);
            this.label2.TabIndex = 25;
            this.label2.Text = "Orders";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgOrders
            // 
            this.dgOrders.AllowUserToAddRows = false;
            this.dgOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOrders.AutoGenerateColumns = false;
            this.dgOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgOrders.ColumnHeadersHeight = 30;
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn});
            this.dgOrders.DataSource = this.ProductBS;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrders.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgOrders.EnableHeadersVisualStyles = false;
            this.dgOrders.Location = new System.Drawing.Point(484, 147);
            this.dgOrders.Margin = new System.Windows.Forms.Padding(30);
            this.dgOrders.Name = "dgOrders";
            this.dgOrders.ReadOnly = true;
            this.dgOrders.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgOrders.RowHeadersVisible = false;
            this.dgOrders.RowHeadersWidth = 40;
            this.dgOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgOrders.RowTemplate.Height = 40;
            this.dgOrders.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgOrders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgOrders.Size = new System.Drawing.Size(336, 352);
            this.dgOrders.TabIndex = 24;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::PurpleYam_POS.Properties.Resources.settle_payment;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 5;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::PurpleYam_POS.Properties.Resources.cancel_order;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn3
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle10.NullValue")));
            this.dataGridViewImageColumn3.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::PurpleYam_POS.Properties.Resources.icons8_reset_16;
            this.btnRefresh.Location = new System.Drawing.Point(383, 125);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(81, 23);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = " Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(719, 125);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 23);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpReservation);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbSearch);
            this.panel1.Location = new System.Drawing.Point(30, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 56);
            this.panel1.TabIndex = 28;
            // 
            // tbSearch
            // 
            // 
            // 
            // 
            this.tbSearch.CustomButton.Image = null;
            this.tbSearch.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.tbSearch.CustomButton.Name = "";
            this.tbSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSearch.CustomButton.TabIndex = 1;
            this.tbSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSearch.CustomButton.UseSelectable = true;
            this.tbSearch.CustomButton.Visible = false;
            this.tbSearch.Lines = new string[0];
            this.tbSearch.Location = new System.Drawing.Point(3, 23);
            this.tbSearch.MaxLength = 32767;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PasswordChar = '\0';
            this.tbSearch.PromptText = "Search Customer";
            this.tbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearch.SelectedText = "";
            this.tbSearch.SelectionLength = 0;
            this.tbSearch.SelectionStart = 0;
            this.tbSearch.ShortcutsEnabled = true;
            this.tbSearch.Size = new System.Drawing.Size(165, 23);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.UseSelectable = true;
            this.tbSearch.WaterMark = "Search Customer";
            this.tbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date reservation";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpReservation
            // 
            this.dtpReservation.Location = new System.Drawing.Point(174, 23);
            this.dtpReservation.Name = "dtpReservation";
            this.dtpReservation.Size = new System.Drawing.Size(200, 23);
            this.dtpReservation.TabIndex = 2;
            this.dtpReservation.ValueChanged += new System.EventHandler(this.dtpReservation_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 72;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 63;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            this.subTotalDataGridViewTextBoxColumn.Width = 95;
            // 
            // ProductBS
            // 
            this.ProductBS.DataSource = typeof(PurpleYam_POS.Model.SoldProductModel);
            // 
            // TransactionNo
            // 
            this.TransactionNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.TransactionNo.HeaderText = "TransactionNo";
            this.TransactionNo.Name = "TransactionNo";
            this.TransactionNo.ReadOnly = true;
            this.TransactionNo.Width = 5;
            // 
            // Fullname
            // 
            this.Fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Fullname.DefaultCellStyle = dataGridViewCellStyle2;
            this.Fullname.HeaderText = "Customer Name";
            this.Fullname.Name = "Fullname";
            this.Fullname.ReadOnly = true;
            // 
            // DownPayment
            // 
            this.DownPayment.HeaderText = "Down payment";
            this.DownPayment.Name = "DownPayment";
            this.DownPayment.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "Balance";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // CashTendered
            // 
            this.CashTendered.HeaderText = "Cash ";
            this.CashTendered.Name = "CashTendered";
            this.CashTendered.ReadOnly = true;
            // 
            // TransactionDate
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TransactionDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.TransactionDate.HeaderText = "Date Transaction";
            this.TransactionDate.Name = "TransactionDate";
            this.TransactionDate.ReadOnly = true;
            this.TransactionDate.Width = 80;
            // 
            // ResevationDate
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResevationDate.DefaultCellStyle = dataGridViewCellStyle4;
            this.ResevationDate.HeaderText = "Date reservation";
            this.ResevationDate.Name = "ResevationDate";
            this.ResevationDate.ReadOnly = true;
            this.ResevationDate.Width = 80;
            // 
            // Vat
            // 
            this.Vat.HeaderText = "Tax";
            this.Vat.Name = "Vat";
            this.Vat.ReadOnly = true;
            this.Vat.Visible = false;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Visible = false;
            // 
            // TransactionType
            // 
            this.TransactionType.HeaderText = "Transaction Type";
            this.TransactionType.Name = "TransactionType";
            this.TransactionType.ReadOnly = true;
            this.TransactionType.Visible = false;
            // 
            // ClaimStatus
            // 
            this.ClaimStatus.HeaderText = "ClaimStatus";
            this.ClaimStatus.Name = "ClaimStatus";
            this.ClaimStatus.ReadOnly = true;
            this.ClaimStatus.Visible = false;
            // 
            // pay
            // 
            this.pay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.pay.HeaderText = "";
            this.pay.Image = global::PurpleYam_POS.Properties.Resources.settle_payment;
            this.pay.Name = "pay";
            this.pay.ReadOnly = true;
            this.pay.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pay.Width = 5;
            // 
            // cancel
            // 
            this.cancel.HeaderText = "";
            this.cancel.Image = global::PurpleYam_POS.Properties.Resources.cancel_order;
            this.cancel.Name = "cancel";
            this.cancel.ReadOnly = true;
            this.cancel.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // claim
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            this.claim.DefaultCellStyle = dataGridViewCellStyle5;
            this.claim.HeaderText = "";
            this.claim.Image = ((System.Drawing.Image)(resources.GetObject("claim.Image")));
            this.claim.Name = "claim";
            this.claim.ReadOnly = true;
            this.claim.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgOrders);
            this.Controls.Add(this.dgReservations);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reservations";
            this.Size = new System.Drawing.Size(841, 553);
            ((System.ComponentModel.ISupportInitialize)(this.dgReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgReservations;
        private System.Windows.Forms.BindingSource ProductBS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpReservation;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroTextBox tbSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn DownPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CashTendered;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResevationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TransactionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaimStatus;
        private System.Windows.Forms.DataGridViewImageColumn pay;
        private System.Windows.Forms.DataGridViewImageColumn cancel;
        private System.Windows.Forms.DataGridViewImageColumn claim;
    }
}
