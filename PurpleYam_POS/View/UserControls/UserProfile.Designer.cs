namespace PurpleYam_POS.View.UserControls
{
    partial class UserProfile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Profile = new System.Windows.Forms.Label();
            this.btnSettlePayment = new System.Windows.Forms.Button();
            this.gbEmp = new System.Windows.Forms.GroupBox();
            this.cbPass = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbContactNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMIddlename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLastname = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnSavePass = new System.Windows.Forms.Button();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pbUser = new PurpleYam_POS.Components.RoundPictureBox();
            this.panel1.SuspendLayout();
            this.gbEmp.SuspendLayout();
            this.cbPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbPass);
            this.panel1.Controls.Add(this.gbEmp);
            this.panel1.Controls.Add(this.btnSettlePayment);
            this.panel1.Controls.Add(this.pbUser);
            this.panel1.Controls.Add(this.Profile);
            this.panel1.Location = new System.Drawing.Point(115, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 432);
            this.panel1.TabIndex = 0;
            // 
            // Profile
            // 
            this.Profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.Profile.Dock = System.Windows.Forms.DockStyle.Top;
            this.Profile.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile.ForeColor = System.Drawing.Color.White;
            this.Profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile.Location = new System.Drawing.Point(0, 0);
            this.Profile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Profile.Name = "Profile";
            this.Profile.Padding = new System.Windows.Forms.Padding(5);
            this.Profile.Size = new System.Drawing.Size(820, 40);
            this.Profile.TabIndex = 1;
            this.Profile.Text = "Employee\'s Profile";
            this.Profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSettlePayment
            // 
            this.btnSettlePayment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettlePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.btnSettlePayment.FlatAppearance.BorderSize = 0;
            this.btnSettlePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettlePayment.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettlePayment.ForeColor = System.Drawing.Color.White;
            this.btnSettlePayment.Location = new System.Drawing.Point(50, 194);
            this.btnSettlePayment.Name = "btnSettlePayment";
            this.btnSettlePayment.Size = new System.Drawing.Size(106, 27);
            this.btnSettlePayment.TabIndex = 20;
            this.btnSettlePayment.Text = "Select Image";
            this.btnSettlePayment.UseVisualStyleBackColor = false;
            this.btnSettlePayment.Click += new System.EventHandler(this.btnSettlePayment_Click);
            // 
            // gbEmp
            // 
            this.gbEmp.Controls.Add(this.btnSaveProfile);
            this.gbEmp.Controls.Add(this.label4);
            this.gbEmp.Controls.Add(this.tbContactNo);
            this.gbEmp.Controls.Add(this.label3);
            this.gbEmp.Controls.Add(this.tbMIddlename);
            this.gbEmp.Controls.Add(this.label2);
            this.gbEmp.Controls.Add(this.tbFirstname);
            this.gbEmp.Controls.Add(this.label1);
            this.gbEmp.Controls.Add(this.tbLastname);
            this.gbEmp.Enabled = false;
            this.gbEmp.Location = new System.Drawing.Point(202, 83);
            this.gbEmp.Name = "gbEmp";
            this.gbEmp.Size = new System.Drawing.Size(278, 296);
            this.gbEmp.TabIndex = 21;
            this.gbEmp.TabStop = false;
            this.gbEmp.Text = "Employee Information";
            // 
            // cbPass
            // 
            this.cbPass.Controls.Add(this.btnSavePass);
            this.cbPass.Controls.Add(this.label7);
            this.cbPass.Controls.Add(this.tbConfirmPassword);
            this.cbPass.Controls.Add(this.label6);
            this.cbPass.Controls.Add(this.tbPassword);
            this.cbPass.Enabled = false;
            this.cbPass.Location = new System.Drawing.Point(500, 83);
            this.cbPass.Name = "cbPass";
            this.cbPass.Size = new System.Drawing.Size(276, 192);
            this.cbPass.TabIndex = 22;
            this.cbPass.TabStop = false;
            this.cbPass.Text = "Change password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Contact No:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbContactNo
            // 
            this.tbContactNo.Location = new System.Drawing.Point(17, 218);
            this.tbContactNo.Name = "tbContactNo";
            this.tbContactNo.Size = new System.Drawing.Size(245, 26);
            this.tbContactNo.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Middlename:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMIddlename
            // 
            this.tbMIddlename.Location = new System.Drawing.Point(17, 166);
            this.tbMIddlename.Name = "tbMIddlename";
            this.tbMIddlename.Size = new System.Drawing.Size(245, 26);
            this.tbMIddlename.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Firstname:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbFirstname
            // 
            this.tbFirstname.Location = new System.Drawing.Point(17, 114);
            this.tbFirstname.Name = "tbFirstname";
            this.tbFirstname.Size = new System.Drawing.Size(245, 26);
            this.tbFirstname.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lastname:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbLastname
            // 
            this.tbLastname.Location = new System.Drawing.Point(17, 60);
            this.tbLastname.Name = "tbLastname";
            this.tbLastname.Size = new System.Drawing.Size(245, 26);
            this.tbLastname.TabIndex = 9;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(16, 60);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(245, 26);
            this.tbPassword.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "New Password:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Confirm New Password:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(16, 112);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(245, 26);
            this.tbConfirmPassword.TabIndex = 18;
            // 
            // btnSavePass
            // 
            this.btnSavePass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSavePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.btnSavePass.FlatAppearance.BorderSize = 0;
            this.btnSavePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePass.ForeColor = System.Drawing.Color.White;
            this.btnSavePass.Location = new System.Drawing.Point(155, 159);
            this.btnSavePass.Name = "btnSavePass";
            this.btnSavePass.Size = new System.Drawing.Size(106, 27);
            this.btnSavePass.TabIndex = 21;
            this.btnSavePass.Text = "Save";
            this.btnSavePass.UseVisualStyleBackColor = false;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(44)))), ((int)(((byte)(121)))));
            this.btnSaveProfile.FlatAppearance.BorderSize = 0;
            this.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveProfile.ForeColor = System.Drawing.Color.White;
            this.btnSaveProfile.Location = new System.Drawing.Point(156, 263);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(106, 27);
            this.btnSaveProfile.TabIndex = 21;
            this.btnSaveProfile.Text = "Save";
            this.btnSaveProfile.UseVisualStyleBackColor = false;
            this.btnSaveProfile.Click += new System.EventHandler(this.btnSaveProfile_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(436, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 25);
            this.button1.TabIndex = 22;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(734, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 25);
            this.button2.TabIndex = 23;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.Color.DarkGray;
            this.pbUser.Location = new System.Drawing.Point(18, 62);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(167, 142);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUser.TabIndex = 2;
            this.pbUser.TabStop = false;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserProfile";
            this.Size = new System.Drawing.Size(1022, 627);
            this.panel1.ResumeLayout(false);
            this.gbEmp.ResumeLayout(false);
            this.gbEmp.PerformLayout();
            this.cbPass.ResumeLayout(false);
            this.cbPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Profile;
        private Components.RoundPictureBox pbUser;
        private System.Windows.Forms.GroupBox cbPass;
        private System.Windows.Forms.GroupBox gbEmp;
        private System.Windows.Forms.Button btnSettlePayment;
        private System.Windows.Forms.Button btnSavePass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbConfirmPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbContactNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMIddlename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLastname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
