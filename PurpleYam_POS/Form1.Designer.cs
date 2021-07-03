namespace PurpleYam_POS
{
    partial class Form1
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
            System.Windows.Forms.Label unitCodeLabel;
            System.Windows.Forms.Label unitDescLabel;
            this.unitCodeTextBox = new System.Windows.Forms.TextBox();
            this.unitDescTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            unitCodeLabel = new System.Windows.Forms.Label();
            unitDescLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // unitCodeLabel
            // 
            unitCodeLabel.AutoSize = true;
            unitCodeLabel.Location = new System.Drawing.Point(41, 68);
            unitCodeLabel.Name = "unitCodeLabel";
            unitCodeLabel.Size = new System.Drawing.Size(57, 13);
            unitCodeLabel.TabIndex = 3;
            unitCodeLabel.Text = "Unit Code:";
            // 
            // unitDescLabel
            // 
            unitDescLabel.AutoSize = true;
            unitDescLabel.Location = new System.Drawing.Point(41, 94);
            unitDescLabel.Name = "unitDescLabel";
            unitDescLabel.Size = new System.Drawing.Size(57, 13);
            unitDescLabel.TabIndex = 5;
            unitDescLabel.Text = "Unit Desc:";
            // 
            // unitCodeTextBox
            // 
            this.unitCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitBindingSource, "UnitCode", true));
            this.unitCodeTextBox.Location = new System.Drawing.Point(104, 65);
            this.unitCodeTextBox.Name = "unitCodeTextBox";
            this.unitCodeTextBox.Size = new System.Drawing.Size(150, 20);
            this.unitCodeTextBox.TabIndex = 4;
            // 
            // unitDescTextBox
            // 
            this.unitDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitBindingSource, "UnitDesc", true));
            this.unitDescTextBox.Location = new System.Drawing.Point(104, 91);
            this.unitDescTextBox.Name = "unitDescTextBox";
            this.unitDescTextBox.Size = new System.Drawing.Size(150, 20);
            this.unitDescTextBox.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.unitCodeDataGridViewTextBoxColumn,
            this.unitDescDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.unitBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(44, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(152, 292);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(233, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(314, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitBindingSource, "Id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(104, 39);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(150, 20);
            this.idTextBox.TabIndex = 4;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // unitCodeDataGridViewTextBoxColumn
            // 
            this.unitCodeDataGridViewTextBoxColumn.DataPropertyName = "UnitCode";
            this.unitCodeDataGridViewTextBoxColumn.HeaderText = "UnitCode";
            this.unitCodeDataGridViewTextBoxColumn.Name = "unitCodeDataGridViewTextBoxColumn";
            // 
            // unitDescDataGridViewTextBoxColumn
            // 
            this.unitDescDataGridViewTextBoxColumn.DataPropertyName = "UnitDesc";
            this.unitDescDataGridViewTextBoxColumn.HeaderText = "UnitDesc";
            this.unitDescDataGridViewTextBoxColumn.Name = "unitDescDataGridViewTextBoxColumn";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(PurpleYam_POS.model.Unit);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 396);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(unitCodeLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.unitCodeTextBox);
            this.Controls.Add(unitDescLabel);
            this.Controls.Add(this.unitDescTextBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.TextBox unitCodeTextBox;
        private System.Windows.Forms.TextBox unitDescTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDescDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox idTextBox;
    }
}

