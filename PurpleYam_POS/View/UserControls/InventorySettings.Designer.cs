namespace PurpleYam_POS.View.UserControls
{
    partial class InventorySettings
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Stock Entry");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Stock Adjustment");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Raw Materials", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Stock Entry");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Stock Adjustment");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Productions", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.tvInventoryMenu = new System.Windows.Forms.TreeView();
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // tvInventoryMenu
            // 
            this.tvInventoryMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(45)))), ((int)(((byte)(148)))));
            this.tvInventoryMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvInventoryMenu.ForeColor = System.Drawing.Color.White;
            this.tvInventoryMenu.FullRowSelect = true;
            this.tvInventoryMenu.ItemHeight = 39;
            this.tvInventoryMenu.LineColor = System.Drawing.Color.White;
            this.tvInventoryMenu.Location = new System.Drawing.Point(0, 0);
            this.tvInventoryMenu.Name = "tvInventoryMenu";
            treeNode1.Name = "StockIn";
            treeNode1.Tag = "RawMatStockIn";
            treeNode1.Text = "Stock Entry";
            treeNode2.Name = "StockAdj";
            treeNode2.Tag = "RawMatAdj";
            treeNode2.Text = "Stock Adjustment";
            treeNode3.Name = "RawMat";
            treeNode3.Tag = "RawMat";
            treeNode3.Text = "Raw Materials";
            treeNode4.Name = "StockIn";
            treeNode4.Tag = "ProductionStockIn";
            treeNode4.Text = "Stock Entry";
            treeNode5.Name = "StockAdj";
            treeNode5.Tag = "ProductionAdj";
            treeNode5.Text = "Stock Adjustment";
            treeNode6.Name = "Production";
            treeNode6.Tag = "Production";
            treeNode6.Text = "Productions";
            this.tvInventoryMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6});
            this.tvInventoryMenu.Size = new System.Drawing.Size(223, 612);
            this.tvInventoryMenu.TabIndex = 2;
            // 
            // mPanel
            // 
            this.mPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mPanel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 10;
            this.mPanel.Location = new System.Drawing.Point(223, 44);
            this.mPanel.Name = "mPanel";
            this.mPanel.Padding = new System.Windows.Forms.Padding(10);
            this.mPanel.Size = new System.Drawing.Size(713, 568);
            this.mPanel.TabIndex = 4;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(223, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(713, 44);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Inventory Settings";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseStyleColors = true;
            // 
            // InventorySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.tvInventoryMenu);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "InventorySettings";
            this.Size = new System.Drawing.Size(936, 612);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvInventoryMenu;
        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
