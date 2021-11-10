namespace PurpleYam_POS.View.UserControls
{
    partial class Settings
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
            this.mpNav = new MetroFramework.Controls.MetroPanel();
            this.btnExpenses = new System.Windows.Forms.Button();
            this.btnUnits = new System.Windows.Forms.Button();
            this.btnAddons = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnRawMaterials = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mpNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpNav
            // 
            this.mpNav.Controls.Add(this.btnExpenses);
            this.mpNav.Controls.Add(this.btnUnits);
            this.mpNav.Controls.Add(this.btnAddons);
            this.mpNav.Controls.Add(this.btnProducts);
            this.mpNav.Controls.Add(this.btnRawMaterials);
            this.mpNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.mpNav.HorizontalScrollbarBarColor = true;
            this.mpNav.HorizontalScrollbarHighlightOnWheel = false;
            this.mpNav.HorizontalScrollbarSize = 10;
            this.mpNav.Location = new System.Drawing.Point(0, 0);
            this.mpNav.Name = "mpNav";
            this.mpNav.Size = new System.Drawing.Size(190, 503);
            this.mpNav.Style = MetroFramework.MetroColorStyle.Purple;
            this.mpNav.TabIndex = 0;
            this.mpNav.UseCustomBackColor = true;
            this.mpNav.VerticalScrollbarBarColor = true;
            this.mpNav.VerticalScrollbarHighlightOnWheel = false;
            this.mpNav.VerticalScrollbarSize = 10;
            // 
            // btnExpenses
            // 
            this.btnExpenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExpenses.FlatAppearance.BorderSize = 0;
            this.btnExpenses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnExpenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpenses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpenses.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenses.Location = new System.Drawing.Point(0, 156);
            this.btnExpenses.Name = "btnExpenses";
            this.btnExpenses.Size = new System.Drawing.Size(190, 39);
            this.btnExpenses.TabIndex = 9;
            this.btnExpenses.Text = "Expenses";
            this.btnExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpenses.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExpenses.UseVisualStyleBackColor = true;
            this.btnExpenses.Click += new System.EventHandler(this.buttonMenu);
            // 
            // btnUnits
            // 
            this.btnUnits.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnits.FlatAppearance.BorderSize = 0;
            this.btnUnits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnUnits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnUnits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnits.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnits.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUnits.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnits.Location = new System.Drawing.Point(0, 117);
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.Size = new System.Drawing.Size(190, 39);
            this.btnUnits.TabIndex = 6;
            this.btnUnits.Text = "Unit of Measures";
            this.btnUnits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnits.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUnits.UseVisualStyleBackColor = true;
            this.btnUnits.Click += new System.EventHandler(this.buttonMenu);
            // 
            // btnAddons
            // 
            this.btnAddons.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddons.FlatAppearance.BorderSize = 0;
            this.btnAddons.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnAddons.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnAddons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddons.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddons.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddons.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddons.Location = new System.Drawing.Point(0, 78);
            this.btnAddons.Name = "btnAddons";
            this.btnAddons.Size = new System.Drawing.Size(190, 39);
            this.btnAddons.TabIndex = 8;
            this.btnAddons.Text = "Add-ons";
            this.btnAddons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddons.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddons.UseVisualStyleBackColor = true;
            this.btnAddons.Click += new System.EventHandler(this.buttonMenu);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 39);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(190, 39);
            this.btnProducts.TabIndex = 5;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.buttonMenu);
            // 
            // btnRawMaterials
            // 
            this.btnRawMaterials.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRawMaterials.FlatAppearance.BorderSize = 0;
            this.btnRawMaterials.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnRawMaterials.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(12)))), ((int)(((byte)(61)))));
            this.btnRawMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRawMaterials.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRawMaterials.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRawMaterials.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRawMaterials.Location = new System.Drawing.Point(0, 0);
            this.btnRawMaterials.Name = "btnRawMaterials";
            this.btnRawMaterials.Size = new System.Drawing.Size(190, 39);
            this.btnRawMaterials.TabIndex = 4;
            this.btnRawMaterials.Text = "Raw Materials";
            this.btnRawMaterials.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRawMaterials.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRawMaterials.UseVisualStyleBackColor = true;
            this.btnRawMaterials.Click += new System.EventHandler(this.buttonMenu);
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(190, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(763, 44);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Settings";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseStyleColors = true;
            // 
            // mPanel
            // 
            this.mPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(190, 44);
            this.mPanel.Name = "mPanel";
            this.mPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mPanel.Size = new System.Drawing.Size(763, 459);
            this.mPanel.TabIndex = 2;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(45)))), ((int)(((byte)(148)))));
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mpNav);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(953, 503);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.mpNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpNav;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnUnits;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnRawMaterials;
        private MetroFramework.Controls.MetroPanel mPanel;
        private System.Windows.Forms.Button btnAddons;
        private System.Windows.Forms.Button btnExpenses;
    }
}
