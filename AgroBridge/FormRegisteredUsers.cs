using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AgroBridge
{
    public partial class FormRegisteredUsers : Form
    {
        private FormAdminHome formAdminHome;
        private DataTable dt = new DataTable();

        public FormRegisteredUsers()
        {
            InitializeComponent();
            dataGridViewRegUsers.AllowUserToAddRows = false;
        }

        public FormRegisteredUsers(FormAdminHome formAdminHome)
        {
            InitializeComponent();
            this.formAdminHome = formAdminHome;
            dataGridViewRegUsers.AllowUserToAddRows = false;

            lblSearchByUsername.Text = "Search ID/User:";
            lblSearchByUsername.Left = 15;
            lblSearchByUsername.Width = 130;

            txtSearchUsername.Left = 150;
            txtSearchUsername.Width = 260;
        }

        private void FormRegisteredUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormRegisteredUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            dt.Clear();

            string sql = "SELECT ID, Username, Name, Role, Status FROM RegistrationTable ORDER BY ID";

            SqlConnection sqlCon = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=AgroBridgeDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
            sqlCon.Open();

            SqlCommand sqlCmd = new SqlCommand(sql, sqlCon);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
            sda.Fill(dt);

            sqlCon.Close();

            dataGridViewRegUsers.DataSource = dt;
            dataGridViewRegUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRegUsers.MultiSelect = false;
            dataGridViewRegUsers.ReadOnly = true;
            dataGridViewRegUsers.AllowUserToAddRows = false;

            foreach (DataGridViewColumn col in dataGridViewRegUsers.Columns)
            {
                col.ReadOnly = true;
            }
        }

        private void txtSearchUsername_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearchUsername.Text.Replace("'", "''");

            DataView dv = dt.DefaultView;

            if (searchText == "")
            {
                dv.RowFilter = "";
            }
            else
            {
                dv.RowFilter = "Username LIKE '%" + searchText + "%' OR Convert(ID, 'System.String') LIKE '%" + searchText + "%'";
            }

            dataGridViewRegUsers.DataSource = dv;
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (dataGridViewRegUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dataGridViewRegUsers.SelectedRows[0];

            object usernameValue = selectedRow.Cells["Username"].Value;
            object statusValue = selectedRow.Cells["Status"].Value;

            if (usernameValue == null || usernameValue == DBNull.Value || usernameValue.ToString() == "")
            {
                MessageBox.Show("Please select a valid user row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (statusValue == null || statusValue == DBNull.Value || statusValue.ToString() == "")
            {
                MessageBox.Show("Please select a valid user row with status.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string username = usernameValue.ToString();
            string currentStatus = statusValue.ToString();
            string newStatus = currentStatus == "0" ? "1" : "0";

            SqlConnection sqlCon = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=AgroBridgeDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
            sqlCon.Open();

            string updateSQL = "UPDATE RegistrationTable SET Status = @Status WHERE Username = @Username";
            SqlCommand sqlCmd = new SqlCommand(updateSQL, sqlCon);
            sqlCmd.Parameters.AddWithValue("@Status", newStatus);
            sqlCmd.Parameters.AddWithValue("@Username", username);

            int rowsAffected = sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Status updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            if (formAdminHome != null)
            {
                formAdminHome.Show();
            }
            else
            {
                FormAdminHome adminHome = new FormAdminHome();
                adminHome.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idToDelete = textBox2.Text.Trim();

            if (idToDelete == "")
            {
                MessageBox.Show("Please enter an ID to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userId;

            if (!int.TryParse(idToDelete, out userId))
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                return;
            }

            SqlConnection sqlCon = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=AgroBridgeDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
            sqlCon.Open();

            string deleteSQL = "DELETE FROM RegistrationTable WHERE ID = @ID";
            SqlCommand sqlCmd = new SqlCommand(deleteSQL, sqlCon);
            sqlCmd.Parameters.AddWithValue("@ID", userId);

            int rowsAffected = sqlCmd.ExecuteNonQuery();
            sqlCon.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Record deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox2.Clear();
                LoadUsers();
            }
            else
            {
                MessageBox.Show("Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblSearchByUsername_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewRegUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}