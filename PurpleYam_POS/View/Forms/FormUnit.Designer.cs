namespace PurpleYam_POS.View.Forms
{
    partial class FormUnit
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtUnitCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mtUnitDesc = new MetroFramework.Controls.MetroTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(99, 84);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Unit code:";
            // 
            // mtUnitCode
            // 
            // 
            // 
            // 
            this.mtUnitCode.CustomButton.Image = null;
            this.mtUnitCode.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.mtUnitCode.CustomButton.Name = "";
            this.mtUnitCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtUnitCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtUnitCode.CustomButton.TabIndex = 1;
            this.mtUnitCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtUnitCode.CustomButton.UseSelectable = true;
            this.mtUnitCode.CustomButton.Visible = false;
            this.mtUnitCode.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitBindingSource, "UnitCode", true));
            this.mtUnitCode.Lines = new string[0];
            this.mtUnitCode.Location = new System.Drawing.Point(173, 84);
            this.mtUnitCode.MaxLength = 32767;
            this.mtUnitCode.Name = "mtUnitCode";
            this.mtUnitCode.PasswordChar = '\0';
            this.mtUnitCode.PromptText = "Ex. Kg...";
            this.mtUnitCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtUnitCode.SelectedText = "";
            this.mtUnitCode.SelectionLength = 0;
            this.mtUnitCode.SelectionStart = 0;
            this.mtUnitCode.ShortcutsEnabled = true;
            this.mtUnitCode.Size = new System.Drawing.Size(168, 23);
            this.mtUnitCode.TabIndex = 1;
            this.mtUnitCode.UseSelectable = true;
            this.mtUnitCode.WaterMark = "Ex. Kg...";
            this.mtUnitCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtUnitCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(90, 113);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(77, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Description:";
            // 
            // mtUnitDesc
            // 
            // 
            // 
            // 
            this.mtUnitDesc.CustomButton.Image = null;
            this.mtUnitDesc.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.mtUnitDesc.CustomButton.Name = "";
            this.mtUnitDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtUnitDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtUnitDesc.CustomButton.TabIndex = 1;
            this.mtUnitDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtUnitDesc.CustomButton.UseSelectable = true;
            this.mtUnitDesc.CustomButton.Visible = false;
            this.mtUnitDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.unitBindingSource, "UnitDesc", true));
            this.mtUnitDesc.Lines = new string[0];
            this.mtUnitDesc.Location = new System.Drawing.Point(173, 113);
            this.mtUnitDesc.MaxLength = 32767;
            this.mtUnitDesc.Name = "mtUnitDesc";
            this.mtUnitDesc.PasswordChar = '\0';
            this.mtUnitDesc.PromptText = "Eg. Kilogram|Grams";
            this.mtUnitDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtUnitDesc.SelectedText = "";
            this.mtUnitDesc.SelectionLength = 0;
            this.mtUnitDesc.SelectionStart = 0;
            this.mtUnitDesc.ShortcutsEnabled = true;
            this.mtUnitDesc.Size = new System.Drawing.Size(168, 23);
            this.mtUnitDesc.TabIndex = 2;
            this.mtUnitDesc.UseSelectable = true;
            this.mtUnitDesc.WaterMark = "Eg. Kilogram|Grams";
            this.mtUnitDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtUnitDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.btnSave.Location = new System.Drawing.Point(243, 156);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(328, 156);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(79, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(PurpleYam_POS.Model.Unit);
            // 
            // FormUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(430, 209);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.mtUnitDesc);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mtUnitCode);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUnit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Manage Unit of Measures";
            this.Load += new System.EventHandler(this.FormUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox mtUnitCode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox mtUnitDesc;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource unitBindingSource;
    }
}