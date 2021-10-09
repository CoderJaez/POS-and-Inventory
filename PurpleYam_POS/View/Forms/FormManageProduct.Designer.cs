namespace PurpleYam_POS.View.Forms
{
    partial class FormManageProduct
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

        #region Windows Form Designer generated code

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageProduct));
            this.mcbRawMat = new MetroFramework.Controls.MetroComboBox();
            this.RawMatBS = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dgRawMat = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RawmatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrpUnitId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.RecipeBS = new System.Windows.Forms.BindingSource(this.components);
            this.tbProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbQty = new System.Windows.Forms.TextBox();
            this.mcbParticulars = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mcbQuality = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.btnSaveRecipe = new System.Windows.Forms.Button();
            this.btnNewProduct = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Img = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RawMatBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRawMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeBS)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // mcbRawMat
            // 
            this.mcbRawMat.DataSource = this.RawMatBS;
            this.mcbRawMat.DisplayMember = "Product";
            this.mcbRawMat.FormattingEnabled = true;
            this.mcbRawMat.ItemHeight = 23;
            this.mcbRawMat.Location = new System.Drawing.Point(161, 43);
            this.mcbRawMat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcbRawMat.Name = "mcbRawMat";
            this.mcbRawMat.Size = new System.Drawing.Size(167, 29);
            this.mcbRawMat.TabIndex = 10;
            this.mcbRawMat.UseSelectable = true;
            this.mcbRawMat.ValueMember = "Id";
            // 
            // RawMatBS
            // 
            this.RawMatBS.DataSource = typeof(PurpleYam_POS.Model.RawMaterial);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Raw Material:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgRawMat
            // 
            this.dgRawMat.AllowUserToAddRows = false;
            this.dgRawMat.AllowUserToResizeRows = false;
            this.dgRawMat.AutoGenerateColumns = false;
            this.dgRawMat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgRawMat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgRawMat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRawMat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRawMat.ColumnHeadersHeight = 30;
            this.dgRawMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.UnitCode,
            this.RawmatId,
            this.GrpUnitId,
            this.qtyDataGridViewTextBoxColumn,
            this.edit,
            this.delete});
            this.dgRawMat.DataSource = this.RecipeBS;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRawMat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgRawMat.EnableHeadersVisualStyles = false;
            this.dgRawMat.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgRawMat.Location = new System.Drawing.Point(398, 216);
            this.dgRawMat.MultiSelect = false;
            this.dgRawMat.Name = "dgRawMat";
            this.dgRawMat.ReadOnly = true;
            this.dgRawMat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRawMat.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgRawMat.RowHeadersVisible = false;
            this.dgRawMat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgRawMat.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgRawMat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgRawMat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRawMat.Size = new System.Drawing.Size(447, 208);
            this.dgRawMat.TabIndex = 15;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UnitCode
            // 
            this.UnitCode.DataPropertyName = "UnitCode";
            this.UnitCode.HeaderText = "UnitCode";
            this.UnitCode.Name = "UnitCode";
            this.UnitCode.ReadOnly = true;
            // 
            // RawmatId
            // 
            this.RawmatId.DataPropertyName = "RawmatId";
            this.RawmatId.HeaderText = "RawmatId";
            this.RawmatId.Name = "RawmatId";
            this.RawmatId.ReadOnly = true;
            this.RawmatId.Visible = false;
            // 
            // GrpUnitId
            // 
            this.GrpUnitId.DataPropertyName = "GrpUnitId";
            this.GrpUnitId.HeaderText = "GrpUnitId";
            this.GrpUnitId.Name = "GrpUnitId";
            this.GrpUnitId.ReadOnly = true;
            this.GrpUnitId.Visible = false;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Width = 6;
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
            // RecipeBS
            // 
            this.RecipeBS.DataSource = typeof(PurpleYam_POS.Model.Recipe);
            // 
            // tbProduct
            // 
            this.tbProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProduct.Location = new System.Drawing.Point(140, 65);
            this.tbProduct.Name = "tbProduct";
            this.tbProduct.Size = new System.Drawing.Size(238, 29);
            this.tbProduct.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbQty
            // 
            this.tbQty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQty.Location = new System.Drawing.Point(164, 79);
            this.tbQty.Name = "tbQty";
            this.tbQty.Size = new System.Drawing.Size(113, 29);
            this.tbQty.TabIndex = 12;
            this.tbQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQty_KeyPress);
            // 
            // mcbParticulars
            // 
            this.mcbParticulars.FormattingEnabled = true;
            this.mcbParticulars.ItemHeight = 23;
            this.mcbParticulars.Items.AddRange(new object[] {
            "LARGE",
            "MEDIUM",
            "TIN CAN",
            "SLICE"});
            this.mcbParticulars.Location = new System.Drawing.Point(140, 168);
            this.mcbParticulars.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcbParticulars.Name = "mcbParticulars";
            this.mcbParticulars.Size = new System.Drawing.Size(238, 29);
            this.mcbParticulars.TabIndex = 4;
            this.mcbParticulars.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Particulars:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mcbQuality
            // 
            this.mcbQuality.FormattingEnabled = true;
            this.mcbQuality.ItemHeight = 23;
            this.mcbQuality.Items.AddRange(new object[] {
            "CHOCO",
            "DURIAN",
            "UBE"});
            this.mcbQuality.Location = new System.Drawing.Point(140, 132);
            this.mcbQuality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mcbQuality.Name = "mcbQuality";
            this.mcbQuality.Size = new System.Drawing.Size(238, 29);
            this.mcbQuality.TabIndex = 3;
            this.mcbQuality.UseSelectable = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Quality:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelUnit);
            this.groupBox1.Controls.Add(this.tbQty);
            this.groupBox1.Controls.Add(this.btnSaveRecipe);
            this.groupBox1.Controls.Add(this.mcbRawMat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 155);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Recipies";
            // 
            // labelUnit
            // 
            this.labelUnit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnit.Location = new System.Drawing.Point(283, 79);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(45, 29);
            this.labelUnit.TabIndex = 1;
            this.labelUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSaveRecipe
            // 
            this.btnSaveRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(45)))), ((int)(((byte)(148)))));
            this.btnSaveRecipe.Enabled = false;
            this.btnSaveRecipe.FlatAppearance.BorderSize = 0;
            this.btnSaveRecipe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnSaveRecipe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnSaveRecipe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveRecipe.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRecipe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveRecipe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveRecipe.Location = new System.Drawing.Point(213, 114);
            this.btnSaveRecipe.Name = "btnSaveRecipe";
            this.btnSaveRecipe.Size = new System.Drawing.Size(115, 30);
            this.btnSaveRecipe.TabIndex = 20;
            this.btnSaveRecipe.Text = "Save &Recipe";
            this.btnSaveRecipe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveRecipe.UseVisualStyleBackColor = false;
            // 
            // btnNewProduct
            // 
            this.btnNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(45)))), ((int)(((byte)(148)))));
            this.btnNewProduct.Enabled = false;
            this.btnNewProduct.FlatAppearance.BorderSize = 0;
            this.btnNewProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnNewProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewProduct.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewProduct.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNewProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewProduct.Location = new System.Drawing.Point(140, 206);
            this.btnNewProduct.Name = "btnNewProduct";
            this.btnNewProduct.Size = new System.Drawing.Size(112, 30);
            this.btnNewProduct.TabIndex = 18;
            this.btnNewProduct.Text = "&New Product";
            this.btnNewProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewProduct.UseVisualStyleBackColor = false;
            this.btnNewProduct.Click += new System.EventHandler(this.btnNewProduct_Click);
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
            this.btnSave.Location = new System.Drawing.Point(266, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 30);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "&Save Product";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(405, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Recipies";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Img
            // 
            this.Img.BackgroundImage = global::PurpleYam_POS.Properties.Resources.cake_96px;
            this.Img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Img.Location = new System.Drawing.Point(398, 65);
            this.Img.Name = "Img";
            this.Img.Size = new System.Drawing.Size(135, 102);
            this.Img.TabIndex = 20;
            this.Img.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(45)))), ((int)(((byte)(148)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(410, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 21;
            this.button1.Text = "&Open File";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(140, 100);
            this.tbPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(238, 25);
            this.tbPrice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 447);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Img);
            this.Controls.Add(this.btnNewProduct);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbProduct);
            this.Controls.Add(this.dgRawMat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mcbQuality);
            this.Controls.Add(this.mcbParticulars);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormManageProduct";
            this.Padding = new System.Windows.Forms.Padding(23, 78, 23, 26);
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Manage Product";
            ((System.ComponentModel.ISupportInitialize)(this.RawMatBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRawMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecipeBS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox mcbRawMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgRawMat;
        private System.Windows.Forms.TextBox tbProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbQty;
        private MetroFramework.Controls.MetroComboBox mcbParticulars;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox mcbQuality;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveRecipe;
        private System.Windows.Forms.Button btnNewProduct;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource RawMatBS;
        private System.Windows.Forms.BindingSource RecipeBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn RawmatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrpUnitId;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.PictureBox Img;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown tbPrice;
        private System.Windows.Forms.Label label2;
    }
}