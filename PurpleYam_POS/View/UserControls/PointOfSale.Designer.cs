namespace PurpleYam_POS.View.UserControls
{
    partial class PointOfSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PointOfSale));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.UnitCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnReservation = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.add = new System.Windows.Forms.DataGridViewImageColumn();
            this.minus = new System.Windows.Forms.DataGridViewImageColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductBS = new System.Windows.Forms.BindingSource(this.components);
            this.panelTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            this.panelOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBS)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTotal
            // 
            this.panelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTotal.BackColor = System.Drawing.Color.White;
            this.panelTotal.Controls.Add(this.labelTax);
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Controls.Add(this.labelSubTotal);
            this.panelTotal.Controls.Add(this.label4);
            this.panelTotal.Controls.Add(this.label3);
            this.panelTotal.Controls.Add(this.label2);
            this.panelTotal.Location = new System.Drawing.Point(645, 349);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(445, 103);
            this.panelTotal.TabIndex = 1;
            // 
            // labelTax
            // 
            this.labelTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTax.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.Location = new System.Drawing.Point(316, 37);
            this.labelTax.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(118, 16);
            this.labelTax.TabIndex = 7;
            this.labelTax.Text = "0.00";
            this.labelTax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(320, 65);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(114, 23);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "0.00";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSubTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.Location = new System.Drawing.Point(316, 10);
            this.labelSubTotal.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(118, 16);
            this.labelSubTotal.TabIndex = 3;
            this.labelSubTotal.Text = "0.00";
            this.labelSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tax";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subtotal";
            // 
            // panelProducts
            // 
            this.panelProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProducts.AutoScroll = true;
            this.panelProducts.BackColor = System.Drawing.Color.White;
            this.panelProducts.Location = new System.Drawing.Point(32, 75);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(607, 266);
            this.panelProducts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(645, 30);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(445, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Order";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Location = new System.Drawing.Point(32, 30);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(5);
            this.panelMenu.Size = new System.Drawing.Size(607, 39);
            this.panelMenu.TabIndex = 4;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1020, 38);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgOrders
            // 
            this.dgOrders.AllowUserToAddRows = false;
            this.dgOrders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOrders.AutoGenerateColumns = false;
            this.dgOrders.BackgroundColor = System.Drawing.Color.White;
            this.dgOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgOrders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgOrders.ColumnHeadersHeight = 30;
            this.dgOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.UnitCode,
            this.productIdDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.add,
            this.qtyDataGridViewTextBoxColumn,
            this.minus,
            this.subTotalDataGridViewTextBoxColumn});
            this.dgOrders.DataSource = this.ProductBS;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrders.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgOrders.EnableHeadersVisualStyles = false;
            this.dgOrders.Location = new System.Drawing.Point(645, 67);
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
            this.dgOrders.Size = new System.Drawing.Size(445, 274);
            this.dgOrders.TabIndex = 6;
            this.dgOrders.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgOrders_DataBindingComplete);
            // 
            // UnitCode
            // 
            this.UnitCode.DataPropertyName = "UnitCode";
            this.UnitCode.HeaderText = "UnitCode";
            this.UnitCode.Name = "UnitCode";
            this.UnitCode.ReadOnly = true;
            this.UnitCode.Visible = false;
            // 
            // panelOptions
            // 
            this.panelOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOptions.Controls.Add(this.button8);
            this.panelOptions.Controls.Add(this.button12);
            this.panelOptions.Controls.Add(this.btnCustomer);
            this.panelOptions.Controls.Add(this.btnReservation);
            this.panelOptions.Location = new System.Drawing.Point(32, 349);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Padding = new System.Windows.Forms.Padding(15);
            this.panelOptions.Size = new System.Drawing.Size(607, 166);
            this.panelOptions.TabIndex = 7;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(18, 18);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(133, 41);
            this.button8.TabIndex = 2;
            this.button8.Text = "Account settings";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(157, 18);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(176, 39);
            this.button12.TabIndex = 6;
            this.button12.Text = "Enable Printing Reciept";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(339, 18);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(176, 39);
            this.btnCustomer.TabIndex = 7;
            this.btnCustomer.Text = "Cutomers";
            this.btnCustomer.UseVisualStyleBackColor = false;
            // 
            // btnReservation
            // 
            this.btnReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.btnReservation.FlatAppearance.BorderSize = 0;
            this.btnReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReservation.ForeColor = System.Drawing.Color.White;
            this.btnReservation.Location = new System.Drawing.Point(18, 65);
            this.btnReservation.Name = "btnReservation";
            this.btnReservation.Size = new System.Drawing.Size(176, 39);
            this.btnReservation.TabIndex = 8;
            this.btnReservation.Text = "Resevations";
            this.btnReservation.UseVisualStyleBackColor = false;
            // 
            // btnCheckout
            // 
            this.btnCheckout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(645, 458);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(445, 48);
            this.btnCheckout.TabIndex = 8;
            this.btnCheckout.Text = "[F4] &Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle5.NullValue")));
            this.dataGridViewImageColumn1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 11;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            this.dataGridViewImageColumn2.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 11;
            // 
            // add
            // 
            this.add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle2.NullValue")));
            this.add.DefaultCellStyle = dataGridViewCellStyle2;
            this.add.HeaderText = "";
            this.add.Image = ((System.Drawing.Image)(resources.GetObject("add.Image")));
            this.add.Name = "add";
            this.add.ReadOnly = true;
            this.add.Width = 11;
            // 
            // minus
            // 
            this.minus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.minus.DefaultCellStyle = dataGridViewCellStyle3;
            this.minus.HeaderText = "";
            this.minus.Image = ((System.Drawing.Image)(resources.GetObject("minus.Image")));
            this.minus.Name = "minus";
            this.minus.ReadOnly = true;
            this.minus.Width = 11;
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
            // PointOfSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.dgOrders);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelTotal);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(30);
            this.Name = "PointOfSale";
            this.Size = new System.Drawing.Size(1120, 562);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            this.panelOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.FlowLayoutPanel panelProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel panelMenu;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.BindingSource ProductBS;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.FlowLayoutPanel panelOptions;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn add;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn minus;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnReservation;
    }
}
