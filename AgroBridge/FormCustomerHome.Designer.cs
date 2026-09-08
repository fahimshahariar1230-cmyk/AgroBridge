namespace AgroBridge
{
    partial class FormCustomerHome
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
            this.flowLayoutPanelProducts = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCustomerGoBack = new System.Windows.Forms.Button();
            this.btnGoToYourCart = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanelProducts
            // 
            this.flowLayoutPanelProducts.AutoScroll = true;
            this.flowLayoutPanelProducts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelProducts.Location = new System.Drawing.Point(12, 144);
            this.flowLayoutPanelProducts.Name = "flowLayoutPanelProducts";
            this.flowLayoutPanelProducts.Size = new System.Drawing.Size(461, 406);
            this.flowLayoutPanelProducts.TabIndex = 1;
            this.flowLayoutPanelProducts.WrapContents = false;
            this.flowLayoutPanelProducts.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelProducts_Paint);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(129, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(412, 32);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "WELCOME TO AGROBRIDGE";
            // 
            // btnCustomerGoBack
            // 
            this.btnCustomerGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCustomerGoBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerGoBack.Location = new System.Drawing.Point(268, 595);
            this.btnCustomerGoBack.Name = "btnCustomerGoBack";
            this.btnCustomerGoBack.Size = new System.Drawing.Size(148, 46);
            this.btnCustomerGoBack.TabIndex = 3;
            this.btnCustomerGoBack.Text = "Go Back";
            this.btnCustomerGoBack.UseVisualStyleBackColor = false;
            this.btnCustomerGoBack.Click += new System.EventHandler(this.btnCustomerGoBack_Click_1);
            // 
            // btnGoToYourCart
            // 
            this.btnGoToYourCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGoToYourCart.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToYourCart.Location = new System.Drawing.Point(501, 331);
            this.btnGoToYourCart.Name = "btnGoToYourCart";
            this.btnGoToYourCart.Size = new System.Drawing.Size(147, 37);
            this.btnGoToYourCart.TabIndex = 4;
            this.btnGoToYourCart.Text = "YOUR CART";
            this.btnGoToYourCart.UseVisualStyleBackColor = false;
            this.btnGoToYourCart.Click += new System.EventHandler(this.btnGoToYourCart_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnProfile.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.Location = new System.Drawing.Point(501, 265);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(147, 37);
            this.btnProfile.TabIndex = 5;
            this.btnProfile.Text = "PROFILE";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduct.Location = new System.Drawing.Point(156, 101);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(260, 27);
            this.txtSearchProduct.TabIndex = 6;
            this.txtSearchProduct.TextChanged += new System.EventHandler(this.txtSearchProduct_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(12, 104);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(129, 19);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search Product:";
            // 
            // FormCustomerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnGoToYourCart);
            this.Controls.Add(this.btnCustomerGoBack);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.flowLayoutPanelProducts);
            this.Name = "FormCustomerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page (Customer)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCustomerHome_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProducts;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCustomerGoBack;
        private System.Windows.Forms.Button btnGoToYourCart;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Label lblSearch;
    }
}