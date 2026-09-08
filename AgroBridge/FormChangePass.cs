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

namespace AgroBridge
{
    public partial class FormChangePass : Form
    {
        private FormLogin formLogin;

        public FormChangePass()
        {
            InitializeComponent();
        }
        public FormChangePass(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }

        private void FormChangePass_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCngPassUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGoBackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.formLogin.Visible = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * From RegistrationTable WHERE Username = '" + this.txtCngPassUsername.Text + "' AND Password = '" + this.txtCngPassPrevPass.Text + "';";
            SqlConnection sqlCon = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=AgroBridgeDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
            sqlCon.Open();
            SqlCommand sqlcmd = new SqlCommand(sql, sqlCon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlcmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);

            if (string.IsNullOrEmpty(txtCngPassUsername.Text) ||
                string.IsNullOrEmpty(txtCngPassPrevPass.Text) ||
                string.IsNullOrEmpty(txtCngPassNewPass.Text) ||
                string.IsNullOrEmpty(txtCngPassConfirmPass.Text))
            {
                MessageBox.Show("Fill-up all the information first!");
                this.txtCngPassUsername.Clear();
                this.txtCngPassPrevPass.Clear();
                this.txtCngPassNewPass.Clear();
                this.txtCngPassConfirmPass.Clear();
                txtCngPassUsername.Focus();
                return;
            }

            else if (ds.Tables[0].Rows.Count == 1)
            {
                if (txtCngPassNewPass.Text == txtCngPassConfirmPass.Text)
                {
                    string updateSql = "UPDATE RegistrationTable SET Password = '" + txtCngPassConfirmPass.Text + "' WHERE Username = '" + txtCngPassUsername.Text + "'";
                    SqlCommand updateCmd = new SqlCommand(updateSql, sqlCon);
                    updateCmd.ExecuteNonQuery();

                    this.Hide();
                    this.formLogin.Visible = true;
                    MessageBox.Show("Password updated successfully!");
                }
                else
                {
                    MessageBox.Show("New passwords didn't match. Try again!");
                    this.txtCngPassUsername.Clear();
                    this.txtCngPassPrevPass.Clear();
                    this.txtCngPassNewPass.Clear();
                    this.txtCngPassConfirmPass.Clear();
                    txtCngPassUsername.Focus();
                    return;
                }
            }

            else
            {
                MessageBox.Show("Username and Previous Password didn't match. Try again!");
                this.txtCngPassUsername.Clear();
                this.txtCngPassPrevPass.Clear();
                this.txtCngPassNewPass.Clear();
                this.txtCngPassConfirmPass.Clear();
                txtCngPassUsername.Focus();
                return;
            }

            sqlCon.Close();
        }

        private void FormChangePass_Load(object sender, EventArgs e)
        {

        }

        private void txtCngPassNewPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
