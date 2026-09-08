namespace AgroBridge
{
    partial class FormAdminHome
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
            this.lblWelcomeAdmin = new System.Windows.Forms.Label();
            this.btnRegisteredUsers = new System.Windows.Forms.Button();
            this.btnAdminGoBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcomeAdmin
            // 
            this.lblWelcomeAdmin.AutoSize = true;
            this.lblWelcomeAdmin.Font = new System.Drawing.Font("Imprint MT Shadow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeAdmin.Location = new System.Drawing.Point(152, 25);
            this.lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            this.lblWelcomeAdmin.Size = new System.Drawing.Size(354, 39);
            this.lblWelcomeAdmin.TabIndex = 0;
            this.lblWelcomeAdmin.Text = "WELCOME ADMIN!";
            // 
            // btnRegisteredUsers
            // 
            this.btnRegisteredUsers.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegisteredUsers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisteredUsers.Location = new System.Drawing.Point(235, 100);
            this.btnRegisteredUsers.Name = "btnRegisteredUsers";
            this.btnRegisteredUsers.Size = new System.Drawing.Size(202, 88);
            this.btnRegisteredUsers.TabIndex = 1;
            this.btnRegisteredUsers.Text = "Registered Users";
            this.btnRegisteredUsers.UseVisualStyleBackColor = false;
            this.btnRegisteredUsers.Click += new System.EventHandler(this.btnRegisteredUsers_Click);
            // 
            // btnAdminGoBack
            // 
            this.btnAdminGoBack.BackColor = System.Drawing.Color.Brown;
            this.btnAdminGoBack.Location = new System.Drawing.Point(235, 579);
            this.btnAdminGoBack.Name = "btnAdminGoBack";
            this.btnAdminGoBack.Size = new System.Drawing.Size(202, 49);
            this.btnAdminGoBack.TabIndex = 2;
            this.btnAdminGoBack.Text = "Go Back";
            this.btnAdminGoBack.UseVisualStyleBackColor = false;
            this.btnAdminGoBack.Click += new System.EventHandler(this.btnAdminGoBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(235, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 95);
            this.button1.TabIndex = 3;
            this.button1.Text = "Sells Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdminGoBack);
            this.Controls.Add(this.btnRegisteredUsers);
            this.Controls.Add(this.lblWelcomeAdmin);
            this.Name = "FormAdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Page (Admin)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormHome_FormClosed);
            this.Load += new System.EventHandler(this.FormAdminHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeAdmin;
        private System.Windows.Forms.Button btnRegisteredUsers;
        private System.Windows.Forms.Button btnAdminGoBack;
        private System.Windows.Forms.Button button1;
    }
}