namespace PurpleYam_POS.View.UserControls
{
    partial class StockAdjProduction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ckBRemove = new System.Windows.Forms.CheckBox();
            this.ckBAdd = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRemarks = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgProductionInv = new System.Windows.Forms.DataGridView();
            this.dgProductionStock = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.particularsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductionInvBS = new System.Windows.Forms.BindingSource(this.components);
            this.ProductionStockBS = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.particularsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStockinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductionInv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductionStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductionInvBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductionStockBS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(883, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Production Stock Adjustments";
            // 
            // tbProduct
            // 
            this.tbProduct.Enabled = false;
            this.tbProduct.Location = new System.Drawing.Point(109, 42);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(211, 23);
            this.tbProduct.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbQty);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbProduct);
            this.panel1.Controls.Add(this.ckBRemove);
            this.panel1.Controls.Add(this.ckBAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbRemarks);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 106);
            this.panel1.TabIndex = 21;
            // 
            // tbQty
            // 
            this.tbQty.Location = new System.Drawing.Point(109, 71);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(211, 23);
            this.tbQty.TabIndex = 24;
            this.tbQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQty_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(31, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Quantity:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ckBRemove
            // 
            this.ckBRemove.AutoSize = true;
            this.ckBRemove.Location = new System.Drawing.Point(488, 44);
            this.ckBRemove.Name = "ckBRemove";
            this.ckBRemove.Size = new System.Drawing.Size(85, 21);
            this.ckBRemove.TabIndex = 21;
            this.ckBRemove.Text = "Remove:";
            this.ckBRemove.UseVisualStyleBackColor = true;
            this.ckBRemove.CheckedChanged += new System.EventHandler(this.ckBRemove_CheckedChanged);
            // 
            // ckBAdd
            // 
            this.ckBAdd.AutoSize = true;
            this.ckBAdd.Location = new System.Drawing.Point(428, 44);
            this.ckBAdd.Name = "ckBAdd";
            this.ckBAdd.Size = new System.Drawing.Size(54, 21);
            this.ckBAdd.TabIndex = 21;
            this.ckBAdd.Text = "Add";
            this.ckBAdd.UseVisualStyleBackColor = true;
            this.ckBAdd.CheckedChanged += new System.EventHandler(this.ckBAdd_CheckedChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(350, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 20;
            this.label4.Text = "Remarks:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(31, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Product:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbRemarks
            // 
            this.cbRemarks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRemarks.FormattingEnabled = true;
            this.cbRemarks.Items.AddRange(new object[] {
            "ERRONEOUS ENTRY",
            "EXPIRED",
            "DAMAGE",
            "SHORTAGE"});
            this.cbRemarks.Location = new System.Drawing.Point(428, 71);
            this.cbRemarks.Name = "cbRemarks";
            this.cbRemarks.Size = new System.Drawing.Size(191, 25);
            this.cbRemarks.TabIndex = 19;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(45)))), ((int)(((byte)(148)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(625, 71);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 27);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // dgProductionInv
            // 
            this.dgProductionInv.AllowUserToAddRows = false;
            this.dgProductionInv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgProductionInv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProductionInv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgProductionInv.AutoGenerateColumns = false;
            this.dgProductionInv.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgProductionInv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgProductionInv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductionInv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProductionInv.ColumnHeadersHeight = 30;
            this.dgProductionInv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.qualityDataGridViewTextBoxColumn,
            this.particularsDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn});
            this.dgProductionInv.DataSource = this.ProductionInvBS;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProductionInv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgProductionInv.EnableHeadersVisualStyles = false;
            this.dgProductionInv.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgProductionInv.Location = new System.Drawing.Point(8, 155);
            this.dgProductionInv.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.dgProductionInv.MultiSelect = false;
            this.dgProductionInv.Name = "dgProductionInv";
            this.dgProductionInv.ReadOnly = true;
            this.dgProductionInv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductionInv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgProductionInv.RowHeadersVisible = false;
            this.dgProductionInv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgProductionInv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgProductionInv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgProductionInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductionInv.Size = new System.Drawing.Size(414, 529);
            this.dgProductionInv.TabIndex = 25;
            this.dgProductionInv.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgRawMat_DataBindingComplete);
            // 
            // dgProductionStock
            // 
            this.dgProductionStock.AllowUserToAddRows = false;
            this.dgProductionStock.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            this.dgProductionStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgProductionStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProductionStock.AutoGenerateColumns = false;
            this.dgProductionStock.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgProductionStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgProductionStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductionStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgProductionStock.ColumnHeadersHeight = 30;
            this.dgProductionStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.ProductId,
            this.productDataGridViewTextBoxColumn1,
            this.qualityDataGridViewTextBoxColumn1,
            this.particularsDataGridViewTextBoxColumn1,
            this.dateStockinDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn1});
            this.dgProductionStock.DataSource = this.ProductionStockBS;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProductionStock.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgProductionStock.EnableHeadersVisualStyles = false;
            this.dgProductionStock.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgProductionStock.Location = new System.Drawing.Point(428, 155);
            this.dgProductionStock.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.dgProductionStock.MultiSelect = false;
            this.dgProductionStock.Name = "dgProductionStock";
            this.dgProductionStock.ReadOnly = true;
            this.dgProductionStock.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProductionStock.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgProductionStock.RowHeadersVisible = false;
            this.dgProductionStock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgProductionStock.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgProductionStock.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgProductionStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProductionStock.Size = new System.Drawing.Size(447, 529);
            this.dgProductionStock.TabIndex = 24;
            this.dgProductionStock.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgRawMat_DataBindingComplete);
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
            // qualityDataGridViewTextBoxColumn
            // 
            this.qualityDataGridViewTextBoxColumn.DataPropertyName = "Quality";
            this.qualityDataGridViewTextBoxColumn.HeaderText = "Quality";
            this.qualityDataGridViewTextBoxColumn.Name = "qualityDataGridViewTextBoxColumn";
            this.qualityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // particularsDataGridViewTextBoxColumn
            // 
            this.particularsDataGridViewTextBoxColumn.DataPropertyName = "Particulars";
            this.particularsDataGridViewTextBoxColumn.HeaderText = "Particulars";
            this.particularsDataGridViewTextBoxColumn.Name = "particularsDataGridViewTextBoxColumn";
            this.particularsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProductionInvBS
            // 
            this.ProductionInvBS.DataSource = typeof(PurpleYam_POS.Model.ProductModel);
            // 
            // ProductionStockBS
            // 
            this.ProductionStockBS.DataSource = typeof(PurpleYam_POS.Model.ProductModel);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "ProductId";
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Visible = false;
            // 
            // productDataGridViewTextBoxColumn1
            // 
            this.productDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productDataGridViewTextBoxColumn1.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn1.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn1.Name = "productDataGridViewTextBoxColumn1";
            this.productDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // qualityDataGridViewTextBoxColumn1
            // 
            this.qualityDataGridViewTextBoxColumn1.DataPropertyName = "Quality";
            this.qualityDataGridViewTextBoxColumn1.HeaderText = "Quality";
            this.qualityDataGridViewTextBoxColumn1.Name = "qualityDataGridViewTextBoxColumn1";
            this.qualityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // particularsDataGridViewTextBoxColumn1
            // 
            this.particularsDataGridViewTextBoxColumn1.DataPropertyName = "Particulars";
            this.particularsDataGridViewTextBoxColumn1.HeaderText = "Particulars";
            this.particularsDataGridViewTextBoxColumn1.Name = "particularsDataGridViewTextBoxColumn1";
            this.particularsDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateStockinDataGridViewTextBoxColumn
            // 
            this.dateStockinDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dateStockinDataGridViewTextBoxColumn.DataPropertyName = "DateStockin";
            this.dateStockinDataGridViewTextBoxColumn.HeaderText = "DateStockin";
            this.dateStockinDataGridViewTextBoxColumn.Name = "dateStockinDataGridViewTextBoxColumn";
            this.dateStockinDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateStockinDataGridViewTextBoxColumn.Width = 5;
            // 
            // qtyDataGridViewTextBoxColumn1
            // 
            this.qtyDataGridViewTextBoxColumn1.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn1.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn1.Name = "qtyDataGridViewTextBoxColumn1";
            this.qtyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // StockAdjProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgProductionInv);
            this.Controls.Add(this.dgProductionStock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StockAdjProduction";
            this.Size = new System.Drawing.Size(883, 687);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductionInv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductionStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductionInvBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductionStockBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckBRemove;
        private System.Windows.Forms.CheckBox ckBAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRemarks;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgProductionInv;
        private System.Windows.Forms.DataGridView dgProductionStock;
        private System.Windows.Forms.BindingSource ProductionInvBS;
        private System.Windows.Forms.BindingSource ProductionStockBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn particularsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qualityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn particularsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStockinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn1;
    }
}
