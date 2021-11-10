namespace PurpleYam_POS
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.MainPanel = new MetroFramework.Controls.MetroPanel();
            this.panelUser = new System.Windows.Forms.Panel();
            this.pbUser = new PurpleYam_POS.Components.RoundPictureBox();
            this.lblFullname = new System.Windows.Forms.Label();
            this.flpUserOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.mlBack = new MetroFramework.Controls.MetroLink();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.flpUserOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPanel.HorizontalScrollbarBarColor = true;
            this.MainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.MainPanel.HorizontalScrollbarSize = 13;
            this.MainPanel.Location = new System.Drawing.Point(0, 78);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1089, 510);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.VerticalScrollbarBarColor = true;
            this.MainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.MainPanel.VerticalScrollbarSize = 13;
            // 
            // panelUser
            // 
            this.panelUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUser.Controls.Add(this.pbUser);
            this.panelUser.Controls.Add(this.lblFullname);
            this.panelUser.Location = new System.Drawing.Point(799, 23);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(287, 48);
            this.panelUser.TabIndex = 2;
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.Color.DarkGray;
            this.pbUser.Image = global::PurpleYam_POS.Properties.Resources.user;
            this.pbUser.Location = new System.Drawing.Point(3, 11);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(52, 34);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 2;
            this.pbUser.TabStop = false;
            // 
            // lblFullname
            // 
            this.lblFullname.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullname.Image = global::PurpleYam_POS.Properties.Resources.sort_right;
            this.lblFullname.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFullname.Location = new System.Drawing.Point(61, 15);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(211, 26);
            this.lblFullname.TabIndex = 1;
            this.lblFullname.Text = "Administrator";
            this.lblFullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFullname.Click += new System.EventHandler(this.lblFullname_Click);
            // 
            // flpUserOptions
            // 
            this.flpUserOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flpUserOptions.Controls.Add(this.btnProfile);
            this.flpUserOptions.Controls.Add(this.btnLogout);
            this.flpUserOptions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpUserOptions.Location = new System.Drawing.Point(852, 67);
            this.flpUserOptions.Name = "flpUserOptions";
            this.flpUserOptions.Size = new System.Drawing.Size(231, 91);
            this.flpUserOptions.TabIndex = 2;
            this.flpUserOptions.Visible = false;
            this.flpUserOptions.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flpUserOptions_MouseClick);
            // 
            // btnProfile
            // 
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(3, 3);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(228, 39);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            this.btnProfile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flpUserOptions_MouseClick);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(3, 48);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLogout.Size = new System.Drawing.Size(228, 34);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flpUserOptions_MouseClick);
            // 
            // mlBack
            // 
            this.mlBack.Image = ((System.Drawing.Image)(resources.GetObject("mlBack.Image")));
            this.mlBack.ImageSize = 30;
            this.mlBack.Location = new System.Drawing.Point(4, 23);
            this.mlBack.Margin = new System.Windows.Forms.Padding(4);
            this.mlBack.Name = "mlBack";
            this.mlBack.Size = new System.Drawing.Size(29, 31);
            this.mlBack.TabIndex = 0;
            this.mlBack.UseSelectable = true;
            this.mlBack.Click += new System.EventHandler(this.mlBack_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 588);
            this.Controls.Add(this.panelUser);
            this.Controls.Add(this.flpUserOptions);
            this.Controls.Add(this.mlBack);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(0, 78, 0, 0);
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "  Purple Yam : Home Made Cakes and Pastries";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.flpUserOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink mlBack;
        private MetroFramework.Controls.MetroPanel MainPanel;
        private System.Windows.Forms.Panel panelUser;
        private System.Windows.Forms.Label lblFullname;
        private System.Windows.Forms.FlowLayoutPanel flpUserOptions;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private Components.RoundPictureBox pbUser;
    }
}