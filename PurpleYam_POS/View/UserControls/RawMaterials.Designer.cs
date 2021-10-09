namespace PurpleYam_POS.View.UserControls
{
    partial class RawMaterials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RawMaterials));
            this.dgRawMat = new System.Windows.Forms.DataGridView();
            this.checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BaseUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasExpiry = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DaysBeforeExpiry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.cbAll = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.mtbSearch = new MetroFramework.Controls.MetroTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdAtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RawMatBS = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgRawMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RawMatBS)).BeginInit();
            this.SuspendLayout();
            // 
            // dgRawMat
            // 
            this.dgRawMat.AllowUserToAddRows = false;
            this.dgRawMat.AllowUserToResizeRows = false;
            this.dgRawMat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgRawMat.AutoGenerateColumns = false;
            this.dgRawMat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgRawMat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgRawMat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRawMat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRawMat.ColumnHeadersHeight = 30;
            this.dgRawMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.checkbox,
            this.productDataGridViewTextBoxColumn,
            this.BaseUnit,
            this.DisplayUnit,
            this.ReOrder,
            this.HasExpiry,
            this.DaysBeforeExpiry,
            this.createdAtDataGridViewTextBoxColumn,
            this.edit,
            this.delete});
            this.dgRawMat.DataSource = this.RawMatBS;
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
            this.dgRawMat.Location = new System.Drawing.Point(30, 89);
            this.dgRawMat.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.dgRawMat.MultiSelect = false;
            this.dgRawMat.Name = "dgRawMat";
            this.dgRawMat.ReadOnly = true;
            this.dgRawMat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgRawMat.Size = new System.Drawing.Size(804, 482);
            this.dgRawMat.TabIndex = 13;
            this.dgRawMat.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgRawMat_DataBindingComplete);
            // 
            // checkbox
            // 
            this.checkbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.checkbox.DataPropertyName = "Deleted";
            this.checkbox.HeaderText = "";
            this.checkbox.Name = "checkbox";
            this.checkbox.ReadOnly = true;
            this.checkbox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkbox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkbox.Width = 22;
            // 
            // BaseUnit
            // 
            this.BaseUnit.DataPropertyName = "BaseUnit";
            this.BaseUnit.HeaderText = "BaseUnit";
            this.BaseUnit.Name = "BaseUnit";
            this.BaseUnit.ReadOnly = true;
            // 
            // DisplayUnit
            // 
            this.DisplayUnit.DataPropertyName = "DisplayUnit";
            this.DisplayUnit.HeaderText = "DisplayUnit";
            this.DisplayUnit.Name = "DisplayUnit";
            this.DisplayUnit.ReadOnly = true;
            // 
            // ReOrder
            // 
            this.ReOrder.DataPropertyName = "ReOrder";
            this.ReOrder.HeaderText = "ReOrder";
            this.ReOrder.Name = "ReOrder";
            this.ReOrder.ReadOnly = true;
            // 
            // HasExpiry
            // 
            this.HasExpiry.DataPropertyName = "HasExpiry";
            this.HasExpiry.HeaderText = "HasExpiry";
            this.HasExpiry.Name = "HasExpiry";
            this.HasExpiry.ReadOnly = true;
            // 
            // DaysBeforeExpiry
            // 
            this.DaysBeforeExpiry.DataPropertyName = "DaysBeforeExpiry";
            this.DaysBeforeExpiry.HeaderText = "DaysBeforeExpiry";
            this.DaysBeforeExpiry.Name = "DaysBeforeExpiry";
            this.DaysBeforeExpiry.ReadOnly = true;
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
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(45)))), ((int)(((byte)(148)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(640, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(79, 30);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&Add new";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(45)))), ((int)(((byte)(148)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(864, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "Raw Materials";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            // 
            // cbAll
            // 
            this.cbAll.AutoSize = true;
            this.cbAll.BackColor = System.Drawing.Color.Purple;
            this.cbAll.Location = new System.Drawing.Point(38, 99);
            this.cbAll.Name = "cbAll";
            this.cbAll.Size = new System.Drawing.Size(15, 14);
            this.cbAll.TabIndex = 14;
            this.cbAll.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(12)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(725, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 30);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "&Delete selected";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // mtbSearch
            // 
            // 
            // 
            // 
            this.mtbSearch.CustomButton.Image = null;
            this.mtbSearch.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.mtbSearch.CustomButton.Name = "";
            this.mtbSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbSearch.CustomButton.TabIndex = 1;
            this.mtbSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbSearch.CustomButton.UseSelectable = true;
            this.mtbSearch.CustomButton.Visible = false;
            this.mtbSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbSearch.Lines = new string[0];
            this.mtbSearch.Location = new System.Drawing.Point(44, 60);
            this.mtbSearch.MaxLength = 32767;
            this.mtbSearch.Name = "mtbSearch";
            this.mtbSearch.PasswordChar = '\0';
            this.mtbSearch.PromptText = "Search raw material";
            this.mtbSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbSearch.SelectedText = "";
            this.mtbSearch.SelectionLength = 0;
            this.mtbSearch.SelectionStart = 0;
            this.mtbSearch.ShortcutsEnabled = true;
            this.mtbSearch.Size = new System.Drawing.Size(188, 23);
            this.mtbSearch.TabIndex = 15;
            this.mtbSearch.UseSelectable = true;
            this.mtbSearch.WaterMark = "Search raw material";
            this.mtbSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mtbSearch_KeyDown);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(365, 577);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(469, 36);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 48;
            // 
            // productDataGridViewTextBoxColumn
            // 
            this.productDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            this.productDataGridViewTextBoxColumn.HeaderText = "Product";
            this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            this.productDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // createdAtDataGridViewTextBoxColumn
            // 
            this.createdAtDataGridViewTextBoxColumn.DataPropertyName = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.FillWeight = 200F;
            this.createdAtDataGridViewTextBoxColumn.HeaderText = "CreatedAt";
            this.createdAtDataGridViewTextBoxColumn.Name = "createdAtDataGridViewTextBoxColumn";
            this.createdAtDataGridViewTextBoxColumn.ReadOnly = true;
            this.createdAtDataGridViewTextBoxColumn.Width = 200;
            // 
            // RawMatBS
            // 
            this.RawMatBS.DataSource = typeof(PurpleYam_POS.Model.RawMaterial);
            // 
            // RawMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.mtbSearch);
            this.Controls.Add(this.cbAll);
            this.Controls.Add(this.dgRawMat);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Name = "RawMaterials";
            this.Size = new System.Drawing.Size(864, 628);
            ((System.ComponentModel.ISupportInitialize)(this.dgRawMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RawMatBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRawMat;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn rawMaterialDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource RawMatBS;
        private System.Windows.Forms.CheckBox cbAll;
        private System.Windows.Forms.Button btnDelete;
        private MetroFramework.Controls.MetroTextBox mtbSearch;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BaseUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReOrder;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HasExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn DaysBeforeExpiry;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdAtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}
