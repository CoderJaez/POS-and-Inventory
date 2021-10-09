namespace PurpleYam_POS.View.UserControls
{
    partial class SaleTransaction
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgProduction = new System.Windows.Forms.DataGridView();
            this.SaleTransactionBS = new System.Windows.Forms.BindingSource(this.components);
            this.transactionNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.downPaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashTenderedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claimStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleTransactionBS)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(914, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Transaction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgProduction
            // 
            this.dgProduction.AllowUserToAddRows = false;
            this.dgProduction.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgProduction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProduction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgProduction.AutoGenerateColumns = false;
            this.dgProduction.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgProduction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgProduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Violet;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgProduction.ColumnHeadersHeight = 35;
            this.dgProduction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionNoDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.contactNoDataGridViewTextBoxColumn,
            this.downPaymentDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.vatDataGridViewTextBoxColumn,
            this.subTotalDataGridViewTextBoxColumn,
            this.totalAmountDataGridViewTextBoxColumn,
            this.cashTenderedDataGridViewTextBoxColumn,
            this.changeDataGridViewTextBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn,
            this.reservationDateDataGridViewTextBoxColumn,
            this.claimStatusDataGridViewTextBoxColumn});
            this.dgProduction.DataSource = this.SaleTransactionBS;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProduction.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgProduction.EnableHeadersVisualStyles = false;
            this.dgProduction.Location = new System.Drawing.Point(30, 110);
            this.dgProduction.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.dgProduction.MultiSelect = false;
            this.dgProduction.Name = "dgProduction";
            this.dgProduction.ReadOnly = true;
            this.dgProduction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProduction.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgProduction.RowHeadersVisible = false;
            this.dgProduction.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgProduction.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgProduction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProduction.Size = new System.Drawing.Size(864, 297);
            this.dgProduction.TabIndex = 27;
            this.dgProduction.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgProduction_DataBindingComplete);
            // 
            // SaleTransactionBS
            // 
            this.SaleTransactionBS.DataSource = typeof(PurpleYam_POS.Model.SaleTransactionModel);
            // 
            // transactionNoDataGridViewTextBoxColumn
            // 
            this.transactionNoDataGridViewTextBoxColumn.DataPropertyName = "TransactionNo";
            this.transactionNoDataGridViewTextBoxColumn.HeaderText = "TransactionNo";
            this.transactionNoDataGridViewTextBoxColumn.Name = "transactionNoDataGridViewTextBoxColumn";
            this.transactionNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactNoDataGridViewTextBoxColumn
            // 
            this.contactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo";
            this.contactNoDataGridViewTextBoxColumn.Name = "contactNoDataGridViewTextBoxColumn";
            this.contactNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // downPaymentDataGridViewTextBoxColumn
            // 
            this.downPaymentDataGridViewTextBoxColumn.DataPropertyName = "DownPayment";
            this.downPaymentDataGridViewTextBoxColumn.HeaderText = "DownPayment";
            this.downPaymentDataGridViewTextBoxColumn.Name = "downPaymentDataGridViewTextBoxColumn";
            this.downPaymentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vatDataGridViewTextBoxColumn
            // 
            this.vatDataGridViewTextBoxColumn.DataPropertyName = "Vat";
            this.vatDataGridViewTextBoxColumn.HeaderText = "Vat";
            this.vatDataGridViewTextBoxColumn.Name = "vatDataGridViewTextBoxColumn";
            this.vatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subTotalDataGridViewTextBoxColumn
            // 
            this.subTotalDataGridViewTextBoxColumn.DataPropertyName = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.HeaderText = "SubTotal";
            this.subTotalDataGridViewTextBoxColumn.Name = "subTotalDataGridViewTextBoxColumn";
            this.subTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            this.totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            this.totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            this.totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cashTenderedDataGridViewTextBoxColumn
            // 
            this.cashTenderedDataGridViewTextBoxColumn.DataPropertyName = "CashTendered";
            this.cashTenderedDataGridViewTextBoxColumn.HeaderText = "CashTendered";
            this.cashTenderedDataGridViewTextBoxColumn.Name = "cashTenderedDataGridViewTextBoxColumn";
            this.cashTenderedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // changeDataGridViewTextBoxColumn
            // 
            this.changeDataGridViewTextBoxColumn.DataPropertyName = "Change";
            this.changeDataGridViewTextBoxColumn.HeaderText = "Change";
            this.changeDataGridViewTextBoxColumn.Name = "changeDataGridViewTextBoxColumn";
            this.changeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transactionDateDataGridViewTextBoxColumn
            // 
            this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.HeaderText = "TransactionDate";
            this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
            this.transactionDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reservationDateDataGridViewTextBoxColumn
            // 
            this.reservationDateDataGridViewTextBoxColumn.DataPropertyName = "ReservationDate";
            this.reservationDateDataGridViewTextBoxColumn.HeaderText = "ReservationDate";
            this.reservationDateDataGridViewTextBoxColumn.Name = "reservationDateDataGridViewTextBoxColumn";
            this.reservationDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // claimStatusDataGridViewTextBoxColumn
            // 
            this.claimStatusDataGridViewTextBoxColumn.DataPropertyName = "ClaimStatus";
            this.claimStatusDataGridViewTextBoxColumn.HeaderText = "ClaimStatus";
            this.claimStatusDataGridViewTextBoxColumn.Name = "claimStatusDataGridViewTextBoxColumn";
            this.claimStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SaleTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgProduction);
            this.Controls.Add(this.label1);
            this.Name = "SaleTransaction";
            this.Size = new System.Drawing.Size(914, 488);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaleTransactionBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgProduction;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn downPaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashTenderedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claimStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource SaleTransactionBS;
    }
}
