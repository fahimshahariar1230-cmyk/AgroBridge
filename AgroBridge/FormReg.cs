using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AgroBridge
{
    public partial class FormReg : Form
    {
        private FormWelcome formWelcome;
        public FormReg()
        {
            InitializeComponent();
        }

        public FormReg(FormWelcome formWelcome)
        {
            InitializeComponent();
            this.formWelcome = formWelcome;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormWelcome formWelcome = this.formWelcome;
            formWelcome.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM RegistrationTable WHERE Username COLLATE SQL_Latin1_General_CP1_CS_AS = @username";
            
            SqlConnection sqlCon = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=AgroBridgeDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
            sqlCon.Open();

            SqlCommand sqlcmd = new SqlCommand(sql, sqlCon);
            
            sqlcmd.Parameters.AddWithValue("@username", txtRegUsername.Text);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Username is already taken. Try another one!");
                ClearAllFields();
                txtFirstName.Focus();
                return;
            }

            else if (string.IsNullOrEmpty(txtFirstName.Text) ||
                string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtRegUsername.Text) ||
                string.IsNullOrEmpty(txtRegPassword.Text) ||
                comboBoxGender.SelectedIndex == -1 ||
                comboBoxAge.SelectedIndex == -1 ||
                comboBoxRole.SelectedIndex == -1)
            {
                MessageBox.Show("Fill-up all the information first!");
                ClearAllFields();
                txtFirstName.Focus();
                return;
            }

            string fullName = txtFirstName.Text + " " + txtLastName.Text;

            string sql2 = @"INSERT INTO RegistrationTable (Username, Password, Name, Role, Status) 
                            VALUES (@username, @password, @name, @role, 0);
                            SELECT CAST(SCOPE_IDENTITY() AS INT);";

            SqlCommand sqlcmd2 = new SqlCommand(sql2, sqlCon);
            sqlcmd2.Parameters.AddWithValue("@username", txtRegUsername.Text);
            sqlcmd2.Parameters.AddWithValue("@password", txtRegPassword.Text);
            sqlcmd2.Parameters.AddWithValue("@name", fullName);
            sqlcmd2.Parameters.AddWithValue("@role", comboBoxRole.SelectedItem.ToString());

            int newID = (int)sqlcmd2.ExecuteScalar();

            if (comboBoxRole.SelectedItem.ToString() == "Farmer")
            {
                string sqlFarmer = @"INSERT INTO FarmerTable (FarmerID, FName, Username, FContactInfo, City, Country)
                                     VALUES(@id, @name, @username, NULL, NULL, NULL)";
                SqlCommand sqlcmdFarmer = new SqlCommand(sqlFarmer, sqlCon);
                sqlcmdFarmer.Parameters.AddWithValue("@id", newID);
                sqlcmdFarmer.Parameters.AddWithValue("@name", fullName);
                sqlcmdFarmer.Parameters.AddWithValue("@username", txtRegUsername.Text);
                sqlcmdFarmer.ExecuteNonQuery();
            }
            else if (comboBoxRole.SelectedItem.ToString() == "Customer")
            {
                string sqlCustomer = @"INSERT INTO CustomerTable (CustomerID, CustomerName, CustomerContactInfo, City, Country)
                                       VALUES(@id, @name, NULL, NULL, NULL)";
                SqlCommand sqlcmdCustomer = new SqlCommand(sqlCustomer, sqlCon);
                sqlcmdCustomer.Parameters.AddWithValue("@id", newID);
                sqlcmdCustomer.Parameters.AddWithValue("@name", fullName);
                sqlcmdCustomer.Parameters.AddWithValue("@username", txtRegUsername.Text);
                sqlcmdCustomer.ExecuteNonQuery();
            }

            sqlCon.Close();

            this.Hide();
            this.formWelcome.Visible = true;
            MessageBox.Show("Registration Complete");
        }

        private void ClearAllFields()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtRegUsername.Text = "";
            txtRegPassword.Text = "";
            comboBoxGender.SelectedIndex = -1;
            comboBoxAge.SelectedIndex = -1;
            comboBoxRole.SelectedIndex = -1;
        }

        private void FormReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormReg_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblRegUserName_Click(object sender, EventArgs e)
        {

        }

        private void txtRegUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}