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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mpNav
            // 
            this.mpNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.mpNav.HorizontalScrollbarBarColor = true;
            this.mpNav.HorizontalScrollbarHighlightOnWheel = false;
            this.mpNav.HorizontalScrollbarSize = 10;
            this.mpNav.Location = new System.Drawing.Point(0, 0);
            this.mpNav.Name = "mpNav";
            this.mpNav.Size = new System.Drawing.Size(195, 503);
            this.mpNav.Style = MetroFramework.MetroColorStyle.Purple;
            this.mpNav.TabIndex = 0;
            this.mpNav.UseCustomBackColor = true;
            this.mpNav.VerticalScrollbarBarColor = true;
            this.mpNav.VerticalScrollbarHighlightOnWheel = false;
            this.mpNav.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(195, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(758, 44);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Settings";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.UseStyleColors = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(45)))), ((int)(((byte)(148)))));
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.mpNav);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(953, 503);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel mpNav;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}
