namespace PurpleYam_POS.View.UserControls
{
    partial class Checkout
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Checkout));
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbCashTendered = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.btnSettlePayment = new System.Windows.Forms.Button();
            this.tbDownPayment = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.reserveTime = new System.Windows.Forms.DateTimePicker();
            this.reserveDate = new System.Windows.Forms.DateTimePicker();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgOrders = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductBS = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBS)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(971, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checkout";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.panelTotal);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.dgOrders);
            this.mainPanel.Location = new System.Drawing.Point(57, 78);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(856, 542);
            this.mainPanel.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblContactNo);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.tbCashTendered);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.labelBalance);
            this.panel1.Controls.Add(this.btnSettlePayment);
            this.panel1.Controls.Add(this.tbDownPayment);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.reserveTime);
            this.panel1.Controls.Add(this.reserveDate);
            this.panel1.Controls.Add(this.lblCustomer);
            this.panel1.Location = new System.Drawing.Point(456, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 490);
            this.panel1.TabIndex = 24;
            // 
            // tbCashTendered
            // 
            this.tbCashTendered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbCashTendered.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCashTendered.Location = new System.Drawing.Point(21, 360);
            this.tbCashTendered.Name = "tbCashTendered";
            this.tbCashTendered.Size = new System.Drawing.Size(349, 32);
            this.tbCashTendered.TabIndex = 23;
            this.tbCashTendered.TextChanged += new System.EventHandler(this.tbCashTendered_TextChanged);
            this.tbCashTendered.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCashTendered_KeyDown);
            this.tbCashTendered.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDownPayment_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 337);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Cash tendered:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelBalance
            // 
            this.labelBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBalance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBalance.Location = new System.Drawing.Point(21, 293);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(349, 38);
            this.labelBalance.TabIndex = 21;
            this.labelBalance.Text = "0.00";
            this.labelBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSettlePayment
            // 
            this.btnSettlePayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettlePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.btnSettlePayment.FlatAppearance.BorderSize = 0;
            this.btnSettlePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettlePayment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettlePayment.ForeColor = System.Drawing.Color.White;
            this.btnSettlePayment.Location = new System.Drawing.Point(15, 428);
            this.btnSettlePayment.Name = "btnSettlePayment";
            this.btnSettlePayment.Size = new System.Drawing.Size(358, 48);
            this.btnSettlePayment.TabIndex = 19;
            this.btnSettlePayment.Text = "Settle payment";
            this.btnSettlePayment.UseVisualStyleBackColor = false;
            this.btnSettlePayment.Click += new System.EventHandler(this.btnSettlePayment_Click);
            // 
            // tbDownPayment
            // 
            this.tbDownPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDownPayment.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDownPayment.Location = new System.Drawing.Point(21, 239);
            this.tbDownPayment.Name = "tbDownPayment";
            this.tbDownPayment.Size = new System.Drawing.Size(349, 25);
            this.tbDownPayment.TabIndex = 20;
            this.tbDownPayment.TextChanged += new System.EventHandler(this.tbDownPayment_TextChanged);
            this.tbDownPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDownPayment_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 270);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "Balance:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 216);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Down payment:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(466, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer Information\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Customer Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Contact Number:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 164);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(250, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Time:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reserveTime
            // 
            this.reserveTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.reserveTime.Location = new System.Drawing.Point(253, 180);
            this.reserveTime.Name = "reserveTime";
            this.reserveTime.Size = new System.Drawing.Size(117, 23);
            this.reserveTime.TabIndex = 16;
            // 
            // reserveDate
            // 
            this.reserveDate.Location = new System.Drawing.Point(21, 187);
            this.reserveDate.Name = "reserveDate";
            this.reserveDate.Size = new System.Drawing.Size(226, 23);
            this.reserveDate.TabIndex = 15;
            // 
            // panelTotal
            // 
            this.panelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTotal.BackColor = System.Drawing.Color.White;
            this.panelTotal.Controls.Add(this.labelTax);
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Controls.Add(this.labelSubTotal);
            this.panelTotal.Controls.Add(this.label8);
            this.panelTotal.Controls.Add(this.label9);
            this.panelTotal.Controls.Add(this.label10);
            this.panelTotal.Location = new System.Drawing.Point(5, 413);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(445, 103);
            this.panelTotal.TabIndex = 23;
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
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 19);
            this.label9.TabIndex = 1;
            this.label9.Text = "Tax";
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
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 26);
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.dgOrders.Location = new System.Drawing.Point(5, 58);
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
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(295, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
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
            // lblCustomer
            // 
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomer.Location = new System.Drawing.Point(21, 71);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(349, 25);
            this.lblCustomer.TabIndex = 26;
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblContactNo
            // 
            this.lblContactNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContactNo.Location = new System.Drawing.Point(21, 129);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(349, 25);
            this.lblContactNo.TabIndex = 27;
            this.lblContactNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Checkout";
            this.Size = new System.Drawing.Size(971, 689);
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource ProductBS;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBalance;
        private System.Windows.Forms.Button btnSettlePayment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker reserveTime;
        private System.Windows.Forms.DateTimePicker reserveDate;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox tbCashTendered;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbDownPayment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblCustomer;
    }
}
