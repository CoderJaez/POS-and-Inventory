namespace PurpleYam_POS.View.UserControls
{
    partial class Expenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Expenses));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgExpenses = new System.Windows.Forms.DataGridView();
            this.cbDescription = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpensesBS = new System.Windows.Forms.BindingSource(this.components);
            this.ExpenseCatBS = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseCatBS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtp);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbDescription);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.tbAmount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(687, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 282);
            this.panel1.TabIndex = 45;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(55, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 30);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnSave.Location = new System.Drawing.Point(170, 225);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 30);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "&Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbAmount
            // 
            this.tbAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbAmount.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAmount.Location = new System.Drawing.Point(21, 141);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(258, 24);
            this.tbAmount.TabIndex = 44;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Amount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(45)))), ((int)(((byte)(148)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(298, 39);
            this.label2.TabIndex = 41;
            this.label2.Text = "Manage Expense";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.label1.Size = new System.Drawing.Size(1015, 39);
            this.label1.TabIndex = 44;
            this.label1.Text = "Expenses";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgExpenses
            // 
            this.dgExpenses.AllowUserToAddRows = false;
            this.dgExpenses.AllowUserToResizeRows = false;
            this.dgExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgExpenses.AutoGenerateColumns = false;
            this.dgExpenses.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgExpenses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgExpenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgExpenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgExpenses.ColumnHeadersHeight = 30;
            this.dgExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.Amount,
            this.DateTimeStamp,
            this.edit,
            this.delete});
            this.dgExpenses.DataSource = this.ExpensesBS;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgExpenses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgExpenses.EnableHeadersVisualStyles = false;
            this.dgExpenses.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgExpenses.Location = new System.Drawing.Point(26, 106);
            this.dgExpenses.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.dgExpenses.MultiSelect = false;
            this.dgExpenses.Name = "dgExpenses";
            this.dgExpenses.ReadOnly = true;
            this.dgExpenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgExpenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgExpenses.RowHeadersVisible = false;
            this.dgExpenses.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgExpenses.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgExpenses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgExpenses.Size = new System.Drawing.Size(629, 446);
            this.dgExpenses.TabIndex = 42;
            // 
            // cbDescription
            // 
            this.cbDescription.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ExpensesBS, "ExpenseId", true));
            this.cbDescription.DataSource = this.ExpenseCatBS;
            this.cbDescription.DisplayMember = "Description";
            this.cbDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDescription.FormattingEnabled = true;
            this.cbDescription.Location = new System.Drawing.Point(21, 85);
            this.cbDescription.Name = "cbDescription";
            this.cbDescription.Size = new System.Drawing.Size(258, 25);
            this.cbDescription.TabIndex = 47;
            this.cbDescription.ValueMember = "ExpenseId";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 48;
            this.label4.Text = "Amount";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(26, 77);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(121, 23);
            this.dtpFrom.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Date from:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 17);
            this.label6.TabIndex = 49;
            this.label6.Text = "Date to:";
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(168, 77);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(121, 23);
            this.dtpTo.TabIndex = 48;
            // 
            // Amount
            // 
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // DateTimeStamp
            // 
            this.DateTimeStamp.DataPropertyName = "DateTimeStamp";
            this.DateTimeStamp.HeaderText = "Date";
            this.DateTimeStamp.Name = "DateTimeStamp";
            this.DateTimeStamp.ReadOnly = true;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 51;
            this.label7.Text = "Date:";
            // 
            // dtp
            // 
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp.Location = new System.Drawing.Point(21, 196);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(258, 23);
            this.dtp.TabIndex = 50;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ExpensesBS
            // 
            this.ExpensesBS.DataSource = typeof(PurpleYam_POS.Model.ExpensesModel);
            // 
            // ExpenseCatBS
            // 
            this.ExpenseCatBS.DataSource = typeof(PurpleYam_POS.Model.ExpensesModel);
            // 
            // Expenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgExpenses);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Expenses";
            this.Size = new System.Drawing.Size(1015, 568);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseCatBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgExpenses;
        private System.Windows.Forms.BindingSource ExpensesBS;
        private System.Windows.Forms.ComboBox cbDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeStamp;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.BindingSource ExpenseCatBS;
    }
}
