namespace PurpleYam_POS.View.Forms
{
    partial class FormRawMaterial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRawMaterial));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtProductName = new MetroFramework.Controls.MetroTextBox();
            this.rawMaterialsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.dgRawMat = new System.Windows.Forms.DataGridView();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.produUnitModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mtQty = new MetroFramework.Controls.MetroTextBox();
            this.mcUnitCode = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnSaveUnit = new System.Windows.Forms.Button();
            this.mcBaseUnit = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mcDisplayUnit = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRawMat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produUnitModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(66, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Product Name:";
            // 
            // mtProductName
            // 
            // 
            // 
            // 
            this.mtProductName.CustomButton.Image = null;
            this.mtProductName.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.mtProductName.CustomButton.Name = "";
            this.mtProductName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtProductName.CustomButton.TabIndex = 1;
            this.mtProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtProductName.CustomButton.UseSelectable = true;
            this.mtProductName.CustomButton.Visible = false;
            this.mtProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rawMaterialsModelBindingSource, "Product", true));
            this.mtProductName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtProductName.Lines = new string[0];
            this.mtProductName.Location = new System.Drawing.Point(170, 79);
            this.mtProductName.MaxLength = 32767;
            this.mtProductName.Name = "mtProductName";
            this.mtProductName.PasswordChar = '\0';
            this.mtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtProductName.SelectedText = "";
            this.mtProductName.SelectionLength = 0;
            this.mtProductName.SelectionStart = 0;
            this.mtProductName.ShortcutsEnabled = true;
            this.mtProductName.Size = new System.Drawing.Size(314, 23);
            this.mtProductName.TabIndex = 1;
            this.mtProductName.UseSelectable = true;
            this.mtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rawMaterialsModelBindingSource
            // 
            this.rawMaterialsModelBindingSource.DataSource = typeof(PurpleYam_POS.Model.RawMaterial);
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
            this.btnSave.Location = new System.Drawing.Point(376, 108);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save Raw Mat";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // dgRawMat
            // 
            this.dgRawMat.AllowUserToAddRows = false;
            this.dgRawMat.AllowUserToResizeRows = false;
            this.dgRawMat.AutoGenerateColumns = false;
            this.dgRawMat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgRawMat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRawMat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRawMat.ColumnHeadersHeight = 30;
            this.dgRawMat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIdDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.baseUnitDataGridViewTextBoxColumn,
            this.displayUnitDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.edit,
            this.delete});
            this.dgRawMat.DataSource = this.produUnitModelBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRawMat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgRawMat.EnableHeadersVisualStyles = false;
            this.dgRawMat.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgRawMat.Location = new System.Drawing.Point(23, 175);
            this.dgRawMat.MultiSelect = false;
            this.dgRawMat.Name = "dgRawMat";
            this.dgRawMat.ReadOnly = true;
            this.dgRawMat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dgRawMat.Size = new System.Drawing.Size(398, 170);
            this.dgRawMat.TabIndex = 14;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            this.productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            this.productIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // baseUnitDataGridViewTextBoxColumn
            // 
            this.baseUnitDataGridViewTextBoxColumn.DataPropertyName = "BaseUnit";
            this.baseUnitDataGridViewTextBoxColumn.HeaderText = "BaseUnit";
            this.baseUnitDataGridViewTextBoxColumn.Name = "baseUnitDataGridViewTextBoxColumn";
            this.baseUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // displayUnitDataGridViewTextBoxColumn
            // 
            this.displayUnitDataGridViewTextBoxColumn.DataPropertyName = "DisplayUnit";
            this.displayUnitDataGridViewTextBoxColumn.HeaderText = "DisplayUnit";
            this.displayUnitDataGridViewTextBoxColumn.Name = "displayUnitDataGridViewTextBoxColumn";
            this.displayUnitDataGridViewTextBoxColumn.ReadOnly = true;
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
            // produUnitModelBindingSource
            // 
            this.produUnitModelBindingSource.DataSource = typeof(PurpleYam_POS.Model.ProduUnitModel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Raw Material Group Units";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.mtQty);
            this.panel1.Controls.Add(this.mcUnitCode);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Controls.Add(this.metroLabel4);
            this.panel1.Controls.Add(this.btnSaveUnit);
            this.panel1.Location = new System.Drawing.Point(442, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 170);
            this.panel1.TabIndex = 16;
            // 
            // mtQty
            // 
            // 
            // 
            // 
            this.mtQty.CustomButton.Image = null;
            this.mtQty.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.mtQty.CustomButton.Name = "";
            this.mtQty.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtQty.CustomButton.TabIndex = 1;
            this.mtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtQty.CustomButton.UseSelectable = true;
            this.mtQty.CustomButton.Visible = false;
            this.mtQty.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtQty.Lines = new string[0];
            this.mtQty.Location = new System.Drawing.Point(95, 72);
            this.mtQty.MaxLength = 32767;
            this.mtQty.Name = "mtQty";
            this.mtQty.PasswordChar = '\0';
            this.mtQty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtQty.SelectedText = "";
            this.mtQty.SelectionLength = 0;
            this.mtQty.SelectionStart = 0;
            this.mtQty.ShortcutsEnabled = true;
            this.mtQty.Size = new System.Drawing.Size(156, 23);
            this.mtQty.TabIndex = 1;
            this.mtQty.UseSelectable = true;
            this.mtQty.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtQty.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mcUnitCode
            // 
            this.mcUnitCode.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produUnitModelBindingSource, "Id", true));
            this.mcUnitCode.DataSource = this.produUnitModelBindingSource;
            this.mcUnitCode.DisplayMember = "BaseUnit";
            this.mcUnitCode.FormattingEnabled = true;
            this.mcUnitCode.ItemHeight = 23;
            this.mcUnitCode.Location = new System.Drawing.Point(97, 33);
            this.mcUnitCode.Name = "mcUnitCode";
            this.mcUnitCode.Size = new System.Drawing.Size(154, 29);
            this.mcUnitCode.TabIndex = 17;
            this.mcUnitCode.UseSelectable = true;
            this.mcUnitCode.ValueMember = "Id";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(56, 76);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(33, 19);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Qty:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(20, 33);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(71, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Unit Code:";
            // 
            // btnSaveUnit
            // 
            this.btnSaveUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(45)))), ((int)(((byte)(148)))));
            this.btnSaveUnit.FlatAppearance.BorderSize = 0;
            this.btnSaveUnit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnSaveUnit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnSaveUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUnit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveUnit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveUnit.Location = new System.Drawing.Point(114, 125);
            this.btnSaveUnit.Name = "btnSaveUnit";
            this.btnSaveUnit.Size = new System.Drawing.Size(137, 30);
            this.btnSaveUnit.TabIndex = 10;
            this.btnSaveUnit.Text = "Save RawMat Unit";
            this.btnSaveUnit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveUnit.UseVisualStyleBackColor = false;
            // 
            // mcBaseUnit
            // 
            this.mcBaseUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produUnitModelBindingSource, "Id", true));
            this.mcBaseUnit.DataSource = this.produUnitModelBindingSource;
            this.mcBaseUnit.DisplayMember = "BaseUnit";
            this.mcBaseUnit.FormattingEnabled = true;
            this.mcBaseUnit.ItemHeight = 23;
            this.mcBaseUnit.Location = new System.Drawing.Point(83, 371);
            this.mcBaseUnit.Name = "mcBaseUnit";
            this.mcBaseUnit.Size = new System.Drawing.Size(121, 29);
            this.mcBaseUnit.TabIndex = 17;
            this.mcBaseUnit.UseSelectable = true;
            this.mcBaseUnit.ValueMember = "Id";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(11, 371);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Base Unit:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(212, 371);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(80, 19);
            this.metroLabel3.TabIndex = 0;
            this.metroLabel3.Text = "Display Unit:";
            // 
            // mcDisplayUnit
            // 
            this.mcDisplayUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.produUnitModelBindingSource, "Id", true));
            this.mcDisplayUnit.DataSource = this.produUnitModelBindingSource;
            this.mcDisplayUnit.DisplayMember = "DisplayUnit";
            this.mcDisplayUnit.FormattingEnabled = true;
            this.mcDisplayUnit.ItemHeight = 23;
            this.mcDisplayUnit.Location = new System.Drawing.Point(298, 371);
            this.mcDisplayUnit.Name = "mcDisplayUnit";
            this.mcDisplayUnit.Size = new System.Drawing.Size(121, 29);
            this.mcDisplayUnit.TabIndex = 17;
            this.mcDisplayUnit.UseSelectable = true;
            this.mcDisplayUnit.ValueMember = "Id";
            // 
            // FormRawMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 413);
            this.Controls.Add(this.mcDisplayUnit);
            this.Controls.Add(this.mcBaseUnit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgRawMat);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mtProductName);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRawMaterial";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Manage Raw Material";
            this.Load += new System.EventHandler(this.FormRawMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rawMaterialsModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRawMat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produUnitModelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtProductName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgRawMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTextBox mtQty;
        private MetroFramework.Controls.MetroComboBox mcUnitCode;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.Button btnSaveUnit;
        private MetroFramework.Controls.MetroComboBox mcBaseUnit;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox mcDisplayUnit;
        private System.Windows.Forms.BindingSource rawMaterialsModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn baseUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn displayUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.BindingSource produUnitModelBindingSource;
    }
}