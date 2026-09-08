using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace AgroBridge
{
    public partial class FormLogin : Form
    {
        private FormWelcome formWelcome;
        public FormLogin()
        {
            InitializeComponent();
        }
        public FormLogin(FormWelcome formWelcome)
        {
            InitializeComponent();
            this.formWelcome = formWelcome;
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLoginGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormWelcome formWelcome = new FormWelcome();

            formWelcome.Show();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM RegistrationTable " +
             "WHERE Username = '" + this.txtLoginUsername.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS " +
             "AND Password = '" + this.txtLoginPassword.Text + "' COLLATE SQL_Latin1_General_CP1_CS_AS;";
            SqlConnection sqlCon = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=AgroBridgeDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True"); sqlCon.Open();
            SqlCommand sqlcmd = new SqlCommand(sql, sqlCon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            if (ds.Tables[0].Rows.Count == 1)
            {
                if (Convert.ToInt32(ds.Tables[0].Rows[0][5]) == 1)
                {
                    if (ds.Tables[0].Rows[0][4].ToString() == "Admin")
                    {
                        this.Hide();
                        FormAdminHome formAdminHome = new FormAdminHome(this);
                        formAdminHome.Show();
                        MessageBox.Show("Login Successful!");
                        this.txtLoginUsername.Clear();
                        this.txtLoginPassword.Clear();
                    }

                    else if (ds.Tables[0].Rows[0][4].ToString() == "Customer")
                    {
                        this.Hide();

                        int customerID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
                        string customerName = ds.Tables[0].Rows[0]["Name"].ToString();

                        Customer customer = new Customer(customerID, customerName);
                        FormCustomerHome formCustomerHome = new FormCustomerHome(customer, this);
                        formCustomerHome.Show();

                        MessageBox.Show("Login Successful!");
                        this.txtLoginUsername.Clear();
                        this.txtLoginPassword.Clear();
                    }

                    else if (ds.Tables[0].Rows[0][4].ToString() == "Farmer")
                    {
                        this.Hide();
                        int farmerID = Convert.ToInt32(ds.Tables[0].Rows[0]["ID"]);
                        FormFarmerHome formFarmerHome = new FormFarmerHome(this, farmerID);
                        formFarmerHome.Show();
                        MessageBox.Show("Login Successful!");
                        this.txtLoginUsername.Clear();
                        this.txtLoginPassword.Clear();
                    }
                }

                else if (Convert.ToInt32(ds.Tables[0].Rows[0][5]) == 0)
                {
                    MessageBox.Show("Inactive user. Contact Admin!");
                    this.txtLoginUsername.Clear();
                    this.txtLoginPassword.Clear();
                    txtLoginUsername.Focus();
                    return;
                }
            }

            else if (string.IsNullOrEmpty(txtLoginUsername.Text) || string.IsNullOrEmpty(txtLoginPassword.Text))
            {
                MessageBox.Show("Fill-up all the information first!");
                this.txtLoginUsername.Clear();
                this.txtLoginPassword.Clear();
                txtLoginUsername.Focus();
                return;
            }

            else
            {
                MessageBox.Show("Wrong Credentials. Try Again!");
                this.txtLoginUsername.Clear();
                this.txtLoginPassword.Clear();
            }

            sqlCon.Close();
        }

        private void btnCngPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormChangePass(this).Show();
        }
    }
}