namespace AgroBridge
{
    partial class FormWelcome
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
            this.btnGoToReg = new System.Windows.Forms.Button();
            this.btnGoToLogin = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGoToReg
            // 
            this.btnGoToReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoToReg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGoToReg.Location = new System.Drawing.Point(211, 208);
            this.btnGoToReg.Name = "btnGoToReg";
            this.btnGoToReg.Size = new System.Drawing.Size(267, 104);
            this.btnGoToReg.TabIndex = 0;
            this.btnGoToReg.Text = "Go to Registration\r\n";
            this.btnGoToReg.UseVisualStyleBackColor = false;
            this.btnGoToReg.Click += new System.EventHandler(this.GoToRegistration_Click);
            // 
            // btnGoToLogin
            // 
            this.btnGoToLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoToLogin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGoToLogin.Location = new System.Drawing.Point(211, 351);
            this.btnGoToLogin.Name = "btnGoToLogin";
            this.btnGoToLogin.Size = new System.Drawing.Size(267, 104);
            this.btnGoToLogin.TabIndex = 2;
            this.btnGoToLogin.Text = "Go to Login";
            this.btnGoToLogin.UseVisualStyleBackColor = false;
            this.btnGoToLogin.Click += new System.EventHandler(this.GoToLogin_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Imprint MT Shadow", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(65, 115);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(530, 39);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "WELCOME TO AGROBRIDGE\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(247, 532);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnGoToLogin);
            this.Controls.Add(this.btnGoToReg);
            this.Name = "FormWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormWelcome_FormClosed);
            this.Load += new System.EventHandler(this.WelcomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoToReg;
        private System.Windows.Forms.Button btnGoToLogin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button button1;
    }
}

