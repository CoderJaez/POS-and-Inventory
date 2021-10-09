namespace PurpleYam_POS.View.UserControls
{
    partial class StockAdjRawMat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.ckBRemove = new System.Windows.Forms.CheckBox();
            this.ckBAdd = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRemarks = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgRawMat = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayUnitDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateArrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStockinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExpiryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RawMatBS = new System.Windows.Forms.BindingSource(this.components);
            this.dgRMInventory = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvRawMatBS = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRawMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RawMatBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRMInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvRawMatBS)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(966, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "Raw Material Stock Adjustments";
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
            this.panel1.Size = new System.Drawing.Size(966, 106);
            this.panel1.TabIndex = 20;
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
            // tbProduct
            // 
            this.tbProduct.Enabled = false;
            this.tbProduct.Location = new System.Drawing.Point(109, 42);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(211, 23);
            this.tbProduct.TabIndex = 22;
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
            this.ckBRemove.Click += new System.EventHandler(this.ckBRemove_CheckedChanged);
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
            this.ckBAdd.Click += new System.EventHandler(this.ckBAdd_CheckedChanged);
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
            // dgRawMat
            // 
            this.dgRawMat.AllowUserToAddRows = false;
            this.dgRawMat.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgRawMat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRawMat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRawMat.AutoGenerateColumns = false;
            this.dgRawMat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgRawMat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgRawMat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRawMat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgRawMat.ColumnHeadersHeight = 30;
            this.dgRawMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.unitIdDataGridViewTextBoxColumn,
            this.Product,
            this.qtyDataGridViewTextBoxColumn1,
            this.displayUnitDataGridViewTextBoxColumn1,
            this.dateArrivalDataGridViewTextBoxColumn,
            this.dateStockinDataGridViewTextBoxColumn,
            this.dateExpiryDataGridViewTextBoxColumn});
            this.dgRawMat.DataSource = this.RawMatBS;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRawMat.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgRawMat.EnableHeadersVisualStyles = false;
            this.dgRawMat.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgRawMat.Location = new System.Drawing.Point(464, 155);
            this.dgRawMat.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.dgRawMat.MultiSelect = false;
            this.dgRawMat.Name = "dgRawMat";
            this.dgRawMat.ReadOnly = true;
            this.dgRawMat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRawMat.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgRawMat.RowHeadersVisible = false;
            this.dgRawMat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgRawMat.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgRawMat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgRawMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRawMat.Size = new System.Drawing.Size(483, 445);
            this.dgRawMat.TabIndex = 21;
            this.dgRawMat.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgRMInventory_DataBindingComplete);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // unitIdDataGridViewTextBoxColumn
            // 
            this.unitIdDataGridViewTextBoxColumn.DataPropertyName = "UnitId";
            this.unitIdDataGridViewTextBoxColumn.HeaderText = "UnitId";
            this.unitIdDataGridViewTextBoxColumn.Name = "unitIdDataGridViewTextBoxColumn";
            this.unitIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.unitIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn1
            // 
            this.qtyDataGridViewTextBoxColumn1.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn1.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn1.Name = "qtyDataGridViewTextBoxColumn1";
            this.qtyDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // displayUnitDataGridViewTextBoxColumn1
            // 
            this.displayUnitDataGridViewTextBoxColumn1.DataPropertyName = "DisplayUnit";
            this.displayUnitDataGridViewTextBoxColumn1.HeaderText = "DisplayUnit";
            this.displayUnitDataGridViewTextBoxColumn1.Name = "displayUnitDataGridViewTextBoxColumn1";
            this.displayUnitDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateArrivalDataGridViewTextBoxColumn
            // 
            this.dateArrivalDataGridViewTextBoxColumn.DataPropertyName = "DateArrival";
            this.dateArrivalDataGridViewTextBoxColumn.HeaderText = "DateArrival";
            this.dateArrivalDataGridViewTextBoxColumn.Name = "dateArrivalDataGridViewTextBoxColumn";
            this.dateArrivalDataGridViewTextBoxColumn.ReadOnly = true;
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
            // dateExpiryDataGridViewTextBoxColumn
            // 
            this.dateExpiryDataGridViewTextBoxColumn.DataPropertyName = "DateExpiry";
            this.dateExpiryDataGridViewTextBoxColumn.HeaderText = "DateExpiry";
            this.dateExpiryDataGridViewTextBoxColumn.Name = "dateExpiryDataGridViewTextBoxColumn";
            this.dateExpiryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RawMatBS
            // 
            this.RawMatBS.DataSource = typeof(PurpleYam_POS.Model.RawMaterial);
            // 
            // dgRMInventory
            // 
            this.dgRMInventory.AllowUserToAddRows = false;
            this.dgRMInventory.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            this.dgRMInventory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgRMInventory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgRMInventory.AutoGenerateColumns = false;
            this.dgRMInventory.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgRMInventory.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgRMInventory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRMInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgRMInventory.ColumnHeadersHeight = 30;
            this.dgRMInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.ReOrder,
            this.qtyDataGridViewTextBoxColumn,
            this.displayUnitDataGridViewTextBoxColumn});
            this.dgRMInventory.DataSource = this.InvRawMatBS;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRMInventory.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgRMInventory.EnableHeadersVisualStyles = false;
            this.dgRMInventory.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgRMInventory.Location = new System.Drawing.Point(8, 155);
            this.dgRMInventory.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.dgRMInventory.MultiSelect = false;
            this.dgRMInventory.Name = "dgRMInventory";
            this.dgRMInventory.ReadOnly = true;
            this.dgRMInventory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRMInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgRMInventory.RowHeadersVisible = false;
            this.dgRMInventory.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgRMInventory.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgRMInventory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgRMInventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRMInventory.Size = new System.Drawing.Size(414, 445);
            this.dgRMInventory.TabIndex = 23;
            this.dgRMInventory.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgRMInventory_DataBindingComplete);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // ReOrder
            // 
            this.ReOrder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ReOrder.DataPropertyName = "ReOrder";
            this.ReOrder.HeaderText = "ReOrder";
            this.ReOrder.Name = "ReOrder";
            this.ReOrder.ReadOnly = true;
            this.ReOrder.Width = 88;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            this.qtyDataGridViewTextBoxColumn.Width = 5;
            // 
            // displayUnitDataGridViewTextBoxColumn
            // 
            this.displayUnitDataGridViewTextBoxColumn.DataPropertyName = "DisplayUnit";
            this.displayUnitDataGridViewTextBoxColumn.HeaderText = "DisplayUnit";
            this.displayUnitDataGridViewTextBoxColumn.Name = "displayUnitDataGridViewTextBoxColumn";
            this.displayUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // InvRawMatBS
            // 
            this.InvRawMatBS.DataSource = typeof(PurpleYam_POS.Model.RawMaterial);
            // 
            // StockAdjRawMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgRMInventory);
            this.Controls.Add(this.dgRawMat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockAdjRawMat";
            this.Size = new System.Drawing.Size(966, 612);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRawMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RawMatBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRMInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvRawMatBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbQty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.CheckBox ckBRemove;
        private System.Windows.Forms.CheckBox ckBAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRemarks;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgRawMat;
        private System.Windows.Forms.DataGridView dgRMInventory;
        private System.Windows.Forms.BindingSource InvRawMatBS;
        private System.Windows.Forms.BindingSource RawMatBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayUnitDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateArrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStockinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExpiryDataGridViewTextBoxColumn;
    }
}
