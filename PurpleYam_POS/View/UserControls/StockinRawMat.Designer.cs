namespace PurpleYam_POS.View.UserControls
{
    partial class StockinRawMat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockinRawMat));
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
            this.GrpUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTPDateArrival = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbUnitCode = new System.Windows.Forms.ComboBox();
            this.UnitBS = new System.Windows.Forms.BindingSource(this.components);
            this.dgRawMat = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasExpiryDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RawMatBS = new System.Windows.Forms.BindingSource(this.components);
            this.dgRawMatStockin = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasExpiryDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.qtyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.StockInBS = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRawMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RawMatBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRawMatStockin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockInBS)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(981, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Raw Material Stock In";
            // 
            // GrpUnit
            // 
            this.GrpUnit.HeaderText = "Unit";
            this.GrpUnit.Name = "GrpUnit";
            this.GrpUnit.ReadOnly = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker.Location = new System.Drawing.Point(442, 196);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(124, 26);
            this.dateTimePicker.TabIndex = 15;
            this.dateTimePicker.Visible = false;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date Arrival:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTPDateArrival
            // 
            this.dateTPDateArrival.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTPDateArrival.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPDateArrival.Location = new System.Drawing.Point(116, 24);
            this.dateTPDateArrival.Name = "dateTPDateArrival";
            this.dateTPDateArrival.Size = new System.Drawing.Size(161, 24);
            this.dateTPDateArrival.TabIndex = 15;
            this.dateTPDateArrival.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(45)))), ((int)(((byte)(148)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(592, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 30);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTPDateArrival);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 54);
            this.panel1.TabIndex = 19;
            // 
            // cbUnitCode
            // 
            this.cbUnitCode.DataSource = this.UnitBS;
            this.cbUnitCode.DisplayMember = "UnitCode";
            this.cbUnitCode.FormattingEnabled = true;
            this.cbUnitCode.Location = new System.Drawing.Point(344, 207);
            this.cbUnitCode.Name = "cbUnitCode";
            this.cbUnitCode.Size = new System.Drawing.Size(92, 28);
            this.cbUnitCode.TabIndex = 19;
            this.cbUnitCode.ValueMember = "Id";
            this.cbUnitCode.Visible = false;
            this.cbUnitCode.SelectionChangeCommitted += new System.EventHandler(this.cbUnitCode_SelectionChangeCommitted);
            // 
            // UnitBS
            // 
            this.UnitBS.DataSource = typeof(PurpleYam_POS.Model.Unit);
            // 
            // dgRawMat
            // 
            this.dgRawMat.AllowUserToAddRows = false;
            this.dgRawMat.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgRawMat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRawMat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRawMat.AutoGenerateColumns = false;
            this.dgRawMat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgRawMat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgRawMat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRawMat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgRawMat.ColumnHeadersHeight = 30;
            this.dgRawMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Product,
            this.hasExpiryDataGridViewCheckBoxColumn});
            this.dgRawMat.DataSource = this.RawMatBS;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRawMat.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgRawMat.EnableHeadersVisualStyles = false;
            this.dgRawMat.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgRawMat.Location = new System.Drawing.Point(683, 97);
            this.dgRawMat.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.dgRawMat.MultiSelect = false;
            this.dgRawMat.Name = "dgRawMat";
            this.dgRawMat.ReadOnly = true;
            this.dgRawMat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgRawMat.Size = new System.Drawing.Size(287, 445);
            this.dgRawMat.TabIndex = 20;
            this.dgRawMat.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgRawMat_DataBindingComplete);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Product
            // 
            this.Product.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.ReadOnly = true;
            // 
            // hasExpiryDataGridViewCheckBoxColumn
            // 
            this.hasExpiryDataGridViewCheckBoxColumn.DataPropertyName = "HasExpiry";
            this.hasExpiryDataGridViewCheckBoxColumn.HeaderText = "HasExpiry";
            this.hasExpiryDataGridViewCheckBoxColumn.Name = "hasExpiryDataGridViewCheckBoxColumn";
            this.hasExpiryDataGridViewCheckBoxColumn.ReadOnly = true;
            this.hasExpiryDataGridViewCheckBoxColumn.Visible = false;
            // 
            // RawMatBS
            // 
            this.RawMatBS.DataSource = typeof(PurpleYam_POS.Model.RawMaterial);
            // 
            // dgRawMatStockin
            // 
            this.dgRawMatStockin.AllowUserToAddRows = false;
            this.dgRawMatStockin.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            this.dgRawMatStockin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgRawMatStockin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRawMatStockin.AutoGenerateColumns = false;
            this.dgRawMatStockin.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgRawMatStockin.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgRawMatStockin.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRawMatStockin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgRawMatStockin.ColumnHeadersHeight = 30;
            this.dgRawMatStockin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.UnitId,
            this.productDataGridViewTextBoxColumn1,
            this.hasExpiryDataGridViewCheckBoxColumn1,
            this.qtyDataGridViewTextBoxColumn1,
            this.UnitCode,
            this.DateExpiry,
            this.delete});
            this.dgRawMatStockin.DataSource = this.StockInBS;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRawMatStockin.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgRawMatStockin.EnableHeadersVisualStyles = false;
            this.dgRawMatStockin.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgRawMatStockin.Location = new System.Drawing.Point(15, 97);
            this.dgRawMatStockin.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.dgRawMatStockin.MultiSelect = false;
            this.dgRawMatStockin.Name = "dgRawMatStockin";
            this.dgRawMatStockin.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRawMatStockin.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgRawMatStockin.RowHeadersVisible = false;
            this.dgRawMatStockin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgRawMatStockin.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgRawMatStockin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgRawMatStockin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgRawMatStockin.Size = new System.Drawing.Size(658, 445);
            this.dgRawMatStockin.TabIndex = 21;
            this.dgRawMatStockin.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgRawMat_DataBindingComplete);
            this.dgRawMatStockin.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgRawMatStockin_DataError);
            this.dgRawMatStockin.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgRawMatStockin_EditingControlShowing);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // UnitId
            // 
            this.UnitId.DataPropertyName = "UnitId";
            this.UnitId.HeaderText = "UnitId";
            this.UnitId.Name = "UnitId";
            this.UnitId.Visible = false;
            // 
            // productDataGridViewTextBoxColumn1
            // 
            this.productDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productDataGridViewTextBoxColumn1.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn1.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn1.Name = "productDataGridViewTextBoxColumn1";
            this.productDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // hasExpiryDataGridViewCheckBoxColumn1
            // 
            this.hasExpiryDataGridViewCheckBoxColumn1.DataPropertyName = "HasExpiry";
            this.hasExpiryDataGridViewCheckBoxColumn1.HeaderText = "HasExpiry";
            this.hasExpiryDataGridViewCheckBoxColumn1.Name = "hasExpiryDataGridViewCheckBoxColumn1";
            this.hasExpiryDataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // qtyDataGridViewTextBoxColumn1
            // 
            this.qtyDataGridViewTextBoxColumn1.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn1.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn1.Name = "qtyDataGridViewTextBoxColumn1";
            // 
            // UnitCode
            // 
            this.UnitCode.DataPropertyName = "DisplayUnit";
            this.UnitCode.HeaderText = "UnitCode";
            this.UnitCode.Name = "UnitCode";
            this.UnitCode.ReadOnly = true;
            this.UnitCode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UnitCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateExpiry
            // 
            this.DateExpiry.DataPropertyName = "DateExpiry";
            this.DateExpiry.HeaderText = "DateExpiry";
            this.DateExpiry.Name = "DateExpiry";
            this.DateExpiry.ReadOnly = true;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "";
            this.delete.Image = ((System.Drawing.Image)(resources.GetObject("delete.Image")));
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Width = 6;
            // 
            // StockInBS
            // 
            this.StockInBS.DataSource = typeof(PurpleYam_POS.Model.RawMaterial);
            // 
            // StockinRawMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbUnitCode);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.dgRawMatStockin);
            this.Controls.Add(this.dgRawMat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StockinRawMat";
            this.Size = new System.Drawing.Size(981, 563);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRawMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RawMatBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRawMatStockin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockInBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewComboBoxColumn GrpUnit;
        private System.Windows.Forms.BindingSource StockInBS;
        private System.Windows.Forms.BindingSource RawMatBS;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTPDateArrival;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgRawMat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasExpiryDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dgRawMatStockin;
        private System.Windows.Forms.ComboBox cbUnitCode;
        private System.Windows.Forms.BindingSource UnitBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn hasExpiryDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateExpiry;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}
