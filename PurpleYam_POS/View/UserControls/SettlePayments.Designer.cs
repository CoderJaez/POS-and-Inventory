namespace PurpleYam_POS.View.UserControls
{
    partial class SettlePayments
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductBS = new System.Windows.Forms.BindingSource(this.components);
            this.tbCashTendered = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSettlePayment = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.tbBalance = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBS)).BeginInit();
            this.panelTotal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 34);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tax";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 26);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(445, 33);
            this.label2.TabIndex = 22;
            this.label2.Text = "Orders";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgOrders
            // 
            this.dgOrders.AllowUserToAddRows = false;
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
            this.productIdDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn});
            this.dgOrders.DataSource = this.ProductBS;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgOrders.EnableHeadersVisualStyles = false;
            this.dgOrders.Location = new System.Drawing.Point(11, 58);
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
            this.dgOrders.Size = new System.Drawing.Size(445, 352);
            this.dgOrders.TabIndex = 21;
            this.dgOrders.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgOrders_DataBindingComplete);
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
            // tbCashTendered
            // 
            this.tbCashTendered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCashTendered.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCashTendered.Location = new System.Drawing.Point(16, 36);
            this.tbCashTendered.Name = "tbCashTendered";
            this.tbCashTendered.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbCashTendered.Size = new System.Drawing.Size(298, 57);
            this.tbCashTendered.TabIndex = 0;
            this.tbCashTendered.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashTendered_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 16);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Cash tendered:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSettlePayment
            // 
            this.btnSettlePayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettlePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.btnSettlePayment.FlatAppearance.BorderSize = 0;
            this.btnSettlePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettlePayment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettlePayment.ForeColor = System.Drawing.Color.White;
            this.btnSettlePayment.Location = new System.Drawing.Point(13, 278);
            this.btnSettlePayment.Name = "btnSettlePayment";
            this.btnSettlePayment.Size = new System.Drawing.Size(301, 48);
            this.btnSettlePayment.TabIndex = 19;
            this.btnSettlePayment.Text = "Settle payment";
            this.btnSettlePayment.UseVisualStyleBackColor = false;
            this.btnSettlePayment.Click += new System.EventHandler(this.btnSettlePayment_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "Subtotal";
            // 
            // labelTax
            // 
            this.labelTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTax.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTax.Location = new System.Drawing.Point(312, 33);
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
            this.labelTotal.Location = new System.Drawing.Point(316, 56);
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
            this.labelSubTotal.Location = new System.Drawing.Point(312, 10);
            this.labelSubTotal.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(118, 16);
            this.labelSubTotal.TabIndex = 3;
            this.labelSubTotal.Text = "0.00";
            this.labelSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelTotal
            // 
            this.panelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTotal.BackColor = System.Drawing.Color.White;
            this.panelTotal.Controls.Add(this.tbBalance);
            this.panelTotal.Controls.Add(this.lbl);
            this.panelTotal.Controls.Add(this.labelTax);
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Controls.Add(this.labelSubTotal);
            this.panelTotal.Controls.Add(this.label8);
            this.panelTotal.Controls.Add(this.label9);
            this.panelTotal.Controls.Add(this.label10);
            this.panelTotal.Location = new System.Drawing.Point(11, 418);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(445, 141);
            this.panelTotal.TabIndex = 23;
            // 
            // tbBalance
            // 
            this.tbBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBalance.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBalance.Location = new System.Drawing.Point(316, 86);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(114, 23);
            this.tbBalance.TabIndex = 9;
            this.tbBalance.Text = "0.00";
            this.tbBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(15, 86);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(91, 23);
            this.lbl.TabIndex = 8;
            this.lbl.Text = "Balance";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button15);
            this.panel1.Controls.Add(this.button14);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button11);
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbCashTendered);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnSettlePayment);
            this.panel1.Location = new System.Drawing.Point(477, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 490);
            this.panel1.TabIndex = 24;
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(259, 207);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(55, 48);
            this.button15.TabIndex = 38;
            this.button15.Text = "1000";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(259, 153);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(55, 48);
            this.button14.TabIndex = 37;
            this.button14.Text = "500";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(259, 99);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 48);
            this.button13.TabIndex = 36;
            this.button13.Text = "C";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.btnClearCashTendered);
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(198, 207);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(55, 48);
            this.button12.TabIndex = 35;
            this.button12.Text = "200";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(198, 153);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 48);
            this.button11.TabIndex = 34;
            this.button11.Text = "100";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button10
            // 
            this.button10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(198, 99);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(55, 48);
            this.button10.TabIndex = 33;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(137, 153);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 48);
            this.button9.TabIndex = 32;
            this.button9.Text = "6";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(137, 99);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 48);
            this.button8.TabIndex = 31;
            this.button8.Text = "9";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(76, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 48);
            this.button7.TabIndex = 30;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(15, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 48);
            this.button6.TabIndex = 29;
            this.button6.Text = "7";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(76, 153);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 48);
            this.button5.TabIndex = 28;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(15, 153);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 48);
            this.button4.TabIndex = 27;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(137, 207);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 48);
            this.button3.TabIndex = 26;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(76, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 48);
            this.button2.TabIndex = 25;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(15, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 48);
            this.button1.TabIndex = 24;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnNumber_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(949, 40);
            this.label1.TabIndex = 22;
            this.label1.Text = "Settle Payment";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.panelTotal);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.dgOrders);
            this.mainPanel.Location = new System.Drawing.Point(66, 74);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(816, 585);
            this.mainPanel.TabIndex = 23;
            // 
            // SettlePayments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettlePayments";
            this.Size = new System.Drawing.Size(949, 691);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBS)).EndInit();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        public System.Windows.Forms.BindingSource ProductBS;
        private System.Windows.Forms.TextBox tbCashTendered;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSettlePayment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label tbBalance;
        private System.Windows.Forms.Label lbl;
    }
}
