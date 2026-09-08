namespace AgroBridge
{
    partial class FormChangePass
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
            this.lblCngPassUsername = new System.Windows.Forms.Label();
            this.txtCngPassUsername = new System.Windows.Forms.TextBox();
            this.txtCngPassPrevPass = new System.Windows.Forms.TextBox();
            this.lblCngPassPrevPass = new System.Windows.Forms.Label();
            this.txtCngPassConfirmPass = new System.Windows.Forms.TextBox();
            this.lblCngPassConfirmPass = new System.Windows.Forms.Label();
            this.txtCngPassNewPass = new System.Windows.Forms.TextBox();
            this.lblCngPassNewPass = new System.Windows.Forms.Label();
            this.btnGoBackToLogin = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblCngPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCngPassUsername
            // 
            this.lblCngPassUsername.AutoSize = true;
            this.lblCngPassUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCngPassUsername.Location = new System.Drawing.Point(63, 137);
            this.lblCngPassUsername.Name = "lblCngPassUsername";
            this.lblCngPassUsername.Size = new System.Drawing.Size(91, 20);
            this.lblCngPassUsername.TabIndex = 0;
            this.lblCngPassUsername.Text = "Username:";
            this.lblCngPassUsername.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCngPassUsername
            // 
            this.txtCngPassUsername.Location = new System.Drawing.Point(243, 137);
            this.txtCngPassUsername.Name = "txtCngPassUsername";
            this.txtCngPassUsername.Size = new System.Drawing.Size(368, 22);
            this.txtCngPassUsername.TabIndex = 1;
            this.txtCngPassUsername.TextChanged += new System.EventHandler(this.txtCngPassUsername_TextChanged);
            // 
            // txtCngPassPrevPass
            // 
            this.txtCngPassPrevPass.Location = new System.Drawing.Point(243, 203);
            this.txtCngPassPrevPass.Name = "txtCngPassPrevPass";
            this.txtCngPassPrevPass.Size = new System.Drawing.Size(368, 22);
            this.txtCngPassPrevPass.TabIndex = 3;
            this.txtCngPassPrevPass.UseSystemPasswordChar = true;
            this.txtCngPassPrevPass.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblCngPassPrevPass
            // 
            this.lblCngPassPrevPass.AutoSize = true;
            this.lblCngPassPrevPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCngPassPrevPass.Location = new System.Drawing.Point(63, 203);
            this.lblCngPassPrevPass.Name = "lblCngPassPrevPass";
            this.lblCngPassPrevPass.Size = new System.Drawing.Size(158, 20);
            this.lblCngPassPrevPass.TabIndex = 2;
            this.lblCngPassPrevPass.Text = "Previous Password:";
            // 
            // txtCngPassConfirmPass
            // 
            this.txtCngPassConfirmPass.Location = new System.Drawing.Point(243, 340);
            this.txtCngPassConfirmPass.Name = "txtCngPassConfirmPass";
            this.txtCngPassConfirmPass.PasswordChar = '*';
            this.txtCngPassConfirmPass.Size = new System.Drawing.Size(368, 22);
            this.txtCngPassConfirmPass.TabIndex = 7;
            // 
            // lblCngPassConfirmPass
            // 
            this.lblCngPassConfirmPass.AutoSize = true;
            this.lblCngPassConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCngPassConfirmPass.Location = new System.Drawing.Point(63, 340);
            this.lblCngPassConfirmPass.Name = "lblCngPassConfirmPass";
            this.lblCngPassConfirmPass.Size = new System.Drawing.Size(152, 20);
            this.lblCngPassConfirmPass.TabIndex = 6;
            this.lblCngPassConfirmPass.Text = "Confirm Password:";
            // 
            // txtCngPassNewPass
            // 
            this.txtCngPassNewPass.Location = new System.Drawing.Point(243, 274);
            this.txtCngPassNewPass.Name = "txtCngPassNewPass";
            this.txtCngPassNewPass.PasswordChar = '*';
            this.txtCngPassNewPass.Size = new System.Drawing.Size(368, 22);
            this.txtCngPassNewPass.TabIndex = 5;
            this.txtCngPassNewPass.TextChanged += new System.EventHandler(this.txtCngPassNewPass_TextChanged);
            // 
            // lblCngPassNewPass
            // 
            this.lblCngPassNewPass.AutoSize = true;
            this.lblCngPassNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCngPassNewPass.Location = new System.Drawing.Point(63, 274);
            this.lblCngPassNewPass.Name = "lblCngPassNewPass";
            this.lblCngPassNewPass.Size = new System.Drawing.Size(126, 20);
            this.lblCngPassNewPass.TabIndex = 4;
            this.lblCngPassNewPass.Text = "New Password:";
            // 
            // btnGoBackToLogin
            // 
            this.btnGoBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGoBackToLogin.Location = new System.Drawing.Point(67, 459);
            this.btnGoBackToLogin.Name = "btnGoBackToLogin";
            this.btnGoBackToLogin.Size = new System.Drawing.Size(197, 49);
            this.btnGoBackToLogin.TabIndex = 8;
            this.btnGoBackToLogin.Text = "<< Go Back";
            this.btnGoBackToLogin.UseVisualStyleBackColor = false;
            this.btnGoBackToLogin.Click += new System.EventHandler(this.btnGoBackToLogin_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConfirm.Location = new System.Drawing.Point(414, 459);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(197, 49);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm >>";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblCngPass
            // 
            this.lblCngPass.AutoSize = true;
            this.lblCngPass.Font = new System.Drawing.Font("Imprint MT Shadow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCngPass.Location = new System.Drawing.Point(139, 32);
            this.lblCngPass.Name = "lblCngPass";
            this.lblCngPass.Size = new System.Drawing.Size(392, 39);
            this.lblCngPass.TabIndex = 10;
            this.lblCngPass.Text = "CHANGE PASSWORD";
            // 
            // FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.lblCngPass);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnGoBackToLogin);
            this.Controls.Add(this.txtCngPassConfirmPass);
            this.Controls.Add(this.lblCngPassConfirmPass);
            this.Controls.Add(this.txtCngPassNewPass);
            this.Controls.Add(this.lblCngPassNewPass);
            this.Controls.Add(this.txtCngPassPrevPass);
            this.Controls.Add(this.lblCngPassPrevPass);
            this.Controls.Add(this.txtCngPassUsername);
            this.Controls.Add(this.lblCngPassUsername);
            this.Name = "FormChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormChangePass_FormClosed);
            this.Load += new System.EventHandler(this.FormChangePass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCngPassUsername;
        private System.Windows.Forms.TextBox txtCngPassUsername;
        private System.Windows.Forms.TextBox txtCngPassPrevPass;
        private System.Windows.Forms.Label lblCngPassPrevPass;
        private System.Windows.Forms.TextBox txtCngPassConfirmPass;
        private System.Windows.Forms.Label lblCngPassConfirmPass;
        private System.Windows.Forms.TextBox txtCngPassNewPass;
        private System.Windows.Forms.Label lblCngPassNewPass;
        private System.Windows.Forms.Button btnGoBackToLogin;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblCngPass;
    }
}