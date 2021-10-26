namespace PurpleYam_POS.Components
{
    partial class Product
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
            this.btnProduct = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Purple;
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Location = new System.Drawing.Point(0, 0);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(122, 102);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProduct.UseVisualStyleBackColor = false;
            // 
            // lblProduct
            // 
            this.lblProduct.BackColor = System.Drawing.Color.Purple;
            this.lblProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblProduct.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.White;
            this.lblProduct.Location = new System.Drawing.Point(0, 66);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(122, 36);
            this.lblProduct.TabIndex = 1;
            this.lblProduct.Text = "label1";
            this.lblProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.btnProduct);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(122, 102);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Label lblProduct;
    }
}
