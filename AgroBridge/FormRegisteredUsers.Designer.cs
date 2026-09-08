namespace AgroBridge
{
    partial class FormRegisteredUsers
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
            this.lblRegisteredUserTable = new System.Windows.Forms.Label();
            this.dataGridViewRegUsers = new System.Windows.Forms.DataGridView();
            this.lblSearchByUsername = new System.Windows.Forms.Label();
            this.txtSearchUsername = new System.Windows.Forms.TextBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegisteredUserTable
            // 
            this.lblRegisteredUserTable.AutoSize = true;
            this.lblRegisteredUserTable.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisteredUserTable.Location = new System.Drawing.Point(200, 9);
            this.lblRegisteredUserTable.Name = "lblRegisteredUserTable";
            this.lblRegisteredUserTable.Size = new System.Drawing.Size(256, 37);
            this.lblRegisteredUserTable.TabIndex = 0;
            this.lblRegisteredUserTable.Text = "Registered Users";
            // 
            // dataGridViewRegUsers
            // 
            this.dataGridViewRegUsers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewRegUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegUsers.Location = new System.Drawing.Point(12, 74);
            this.dataGridViewRegUsers.Name = "dataGridViewRegUsers";
            this.dataGridViewRegUsers.RowHeadersWidth = 51;
            this.dataGridViewRegUsers.RowTemplate.Height = 24;
            this.dataGridViewRegUsers.Size = new System.Drawing.Size(658, 253);
            this.dataGridViewRegUsers.TabIndex = 1;
            this.dataGridViewRegUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRegUsers_CellContentClick);
            // 
            // lblSearchByUsername
            // 
            this.lblSearchByUsername.AutoSize = true;
            this.lblSearchByUsername.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByUsername.Location = new System.Drawing.Point(12, 362);
            this.lblSearchByUsername.Name = "lblSearchByUsername";
            this.lblSearchByUsername.Size = new System.Drawing.Size(153, 22);
            this.lblSearchByUsername.TabIndex = 2;
            this.lblSearchByUsername.Text = "Search Username:";
            this.lblSearchByUsername.Click += new System.EventHandler(this.lblSearchByUsername_Click);
            // 
            // txtSearchUsername
            // 
            this.txtSearchUsername.Location = new System.Drawing.Point(186, 363);
            this.txtSearchUsername.Name = "txtSearchUsername";
            this.txtSearchUsername.Size = new System.Drawing.Size(313, 22);
            this.txtSearchUsername.TabIndex = 3;
            this.txtSearchUsername.TextChanged += new System.EventHandler(this.txtSearchUsername_TextChanged);
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdateStatus.Location = new System.Drawing.Point(532, 352);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(138, 45);
            this.btnUpdateStatus.TabIndex = 4;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = false;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGoBack.Location = new System.Drawing.Point(281, 552);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(138, 45);
            this.btnGoBack.TabIndex = 5;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(186, 425);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(313, 22);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Remove ID: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(532, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRegisteredUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 653);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.btnUpdateStatus);
            this.Controls.Add(this.txtSearchUsername);
            this.Controls.Add(this.lblSearchByUsername);
            this.Controls.Add(this.dataGridViewRegUsers);
            this.Controls.Add(this.lblRegisteredUserTable);
            this.Name = "FormRegisteredUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registered Users";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegisteredUsers_FormClosed);
            this.Load += new System.EventHandler(this.FormRegisteredUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegisteredUserTable;
        private System.Windows.Forms.DataGridView dataGridViewRegUsers;
        private System.Windows.Forms.Label lblSearchByUsername;
        private System.Windows.Forms.TextBox txtSearchUsername;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}