namespace AgroBridge
{
    partial class FormCustomerOrders
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.flowLayoutPanelOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(658, 40);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "YOUR ORDER HISTORY";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // flowLayoutPanelOrders — FIXED: was Dock=Fill which covered the button
            this.flowLayoutPanelOrders.AutoScroll = true;
            this.flowLayoutPanelOrders.Location = new System.Drawing.Point(12, 65);
            this.flowLayoutPanelOrders.Name = "flowLayoutPanelOrders";
            this.flowLayoutPanelOrders.Size = new System.Drawing.Size(658, 490);
            this.flowLayoutPanelOrders.TabIndex = 0;
            this.flowLayoutPanelOrders.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelOrders_Paint);

            // button1 — FIXED: was "EXIT" calling Application.Exit()
            this.button1.BackColor = System.Drawing.Color.FromArgb(192, 0, 0);
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(270, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);

            // FormCustomerOrders
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanelOrders);
            this.Name = "FormCustomerOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Your Orders";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCustomerOrders_FormClosed);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrders;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblTitle;
    }
}