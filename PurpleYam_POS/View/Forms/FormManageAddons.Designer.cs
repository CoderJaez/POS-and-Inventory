namespace PurpleYam_POS.View.Forms
{
    partial class FormManageAddons
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbHasUnit = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.UnitBS = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.cbAvailable = new System.Windows.Forms.CheckBox();
            this.tbPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAddon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbHasUnit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbUnit);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.cbAvailable);
            this.panel1.Controls.Add(this.tbPrice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbAddon);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(91, 44);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 192);
            this.panel1.TabIndex = 0;
            // 
            // cbHasUnit
            // 
            this.cbHasUnit.AutoSize = true;
            this.cbHasUnit.Location = new System.Drawing.Point(340, 104);
            this.cbHasUnit.Name = "cbHasUnit";
            this.cbHasUnit.Size = new System.Drawing.Size(74, 21);
            this.cbHasUnit.TabIndex = 23;
            this.cbHasUnit.Text = "No Unit";
            this.cbHasUnit.UseVisualStyleBackColor = true;
            this.cbHasUnit.CheckedChanged += new System.EventHandler(this.cbHasUnit_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Unit:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbUnit
            // 
            this.cbUnit.DataSource = this.UnitBS;
            this.cbUnit.DisplayMember = "UnitCode";
            this.cbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnit.Enabled = false;
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(169, 100);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(165, 25);
            this.cbUnit.TabIndex = 21;
            this.cbUnit.ValueMember = "Id";
            // 
            // UnitBS
            // 
            this.UnitBS.DataSource = typeof(PurpleYam_POS.Model.Unit);
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
            this.btnSave.Location = new System.Drawing.Point(304, 159);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 30);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "&Save Addon";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // cbAvailable
            // 
            this.cbAvailable.AutoSize = true;
            this.cbAvailable.Checked = true;
            this.cbAvailable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAvailable.Location = new System.Drawing.Point(169, 126);
            this.cbAvailable.Name = "cbAvailable";
            this.cbAvailable.Size = new System.Drawing.Size(88, 21);
            this.cbAvailable.TabIndex = 5;
            this.cbAvailable.Text = "Available";
            this.cbAvailable.UseVisualStyleBackColor = true;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(169, 71);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(247, 23);
            this.tbPrice.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Is available:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbAddon
            // 
            this.tbAddon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbAddon.Location = new System.Drawing.Point(169, 42);
            this.tbAddon.Name = "tbAddon";
            this.tbAddon.Size = new System.Drawing.Size(247, 23);
            this.tbAddon.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormManageAddons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 281);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormManageAddons";
            this.Padding = new System.Windows.Forms.Padding(27, 78, 27, 26);
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Manage Addons";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbAvailable;
        private System.Windows.Forms.NumericUpDown tbPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAddon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource UnitBS;
        private System.Windows.Forms.CheckBox cbHasUnit;
    }
}