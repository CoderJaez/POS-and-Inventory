namespace PurpleYam_POS.Components
{
    partial class LoadingScreen
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
            this.labelLoad = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.panelChange = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelChange = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChange.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLoad
            // 
            this.labelLoad.AutoSize = true;
            this.labelLoad.Location = new System.Drawing.Point(27, 20);
            this.labelLoad.Name = "labelLoad";
            this.labelLoad.Size = new System.Drawing.Size(125, 17);
            this.labelLoad.TabIndex = 3;
            this.labelLoad.Text = "Importing ... 1/100";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(31, 53);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(531, 33);
            this.progressBar.TabIndex = 2;
            // 
            // panelChange
            // 
            this.panelChange.Controls.Add(this.label2);
            this.panelChange.Controls.Add(this.labelChange);
            this.panelChange.Controls.Add(this.label1);
            this.panelChange.Location = new System.Drawing.Point(30, 12);
            this.panelChange.Name = "panelChange";
            this.panelChange.Size = new System.Drawing.Size(532, 83);
            this.panelChange.TabIndex = 4;
            this.panelChange.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Please any key to exit..";
            // 
            // labelChange
            // 
            this.labelChange.AutoSize = true;
            this.labelChange.Font = new System.Drawing.Font("Century Gothic", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChange.ForeColor = System.Drawing.Color.Green;
            this.labelChange.Location = new System.Drawing.Point(178, 10);
            this.labelChange.Name = "labelChange";
            this.labelChange.Size = new System.Drawing.Size(115, 56);
            this.labelChange.TabIndex = 1;
            this.labelChange.Text = "0.00";
            this.labelChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change:";
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 107);
            this.Controls.Add(this.panelChange);
            this.Controls.Add(this.labelLoad);
            this.Controls.Add(this.progressBar);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoadingScreen";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LoadingScreen";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoadingScreen_KeyDown);
            this.panelChange.ResumeLayout(false);
            this.panelChange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLoad;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Panel panelChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelChange;
        private System.Windows.Forms.Label label1;
    }
}