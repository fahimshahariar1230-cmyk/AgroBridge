namespace AgroBridge
{
    partial class FormFarmerHome
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
            this.btnFarmerGoBack = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRmvProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFarmerGoBack
            // 
            this.btnFarmerGoBack.BackColor = System.Drawing.Color.Red;
            this.btnFarmerGoBack.Location = new System.Drawing.Point(264, 511);
            this.btnFarmerGoBack.Name = "btnFarmerGoBack";
            this.btnFarmerGoBack.Size = new System.Drawing.Size(127, 47);
            this.btnFarmerGoBack.TabIndex = 0;
            this.btnFarmerGoBack.Text = "Go Back";
            this.btnFarmerGoBack.UseVisualStyleBackColor = false;
            this.btnFarmerGoBack.Click += new System.EventHandler(this.btnFarmerGoBack_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAddProduct.Location = new System.Drawing.Point(159, 83);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(326, 52);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRmvProduct
            // 
            this.btnRmvProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRmvProduct.Location = new System.Drawing.Point(159, 164);
            this.btnRmvProduct.Name = "btnRmvProduct";
            this.btnRmvProduct.Size = new System.Drawing.Size(326, 52);
            this.btnRmvProduct.TabIndex = 2;
            this.btnRmvProduct.Text = "Remove Product";
            this.btnRmvProduct.UseVisualStyleBackColor = false;
            this.btnRmvProduct.Click += new System.EventHandler(this.btnRmvProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdateProduct.Location = new System.Drawing.Point(159, 260);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(326, 52);
            this.btnUpdateProduct.TabIndex = 3;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.BackColor = System.Drawing.Color.Silver;
            this.btnViewProduct.Location = new System.Drawing.Point(159, 356);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(326, 52);
            this.btnViewProduct.TabIndex = 4;
            this.btnViewProduct.Text = "View Your Product";
            this.btnViewProduct.UseVisualStyleBackColor = false;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // FormFarmerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.btnViewProduct);
            this.Controls.Add(this.btnUpdateProduct);
            this.Controls.Add(this.btnRmvProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnFarmerGoBack);
            this.Name = "FormFarmerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page (Farmer)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFarmerHome_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFarmerGoBack;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRmvProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnViewProduct;
    }
}