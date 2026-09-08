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
    public partial class FormUpdateProduct : Form
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=AgroBridgeDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        private Farmer farmer;
        private FormFarmerHome formFarmerHome;

        // constructor for simple ID
        public FormUpdateProduct(int farmerID)
        {
            InitializeComponent();
            farmer = new Farmer(farmerID);
        }

        // constructor for navigating back home
        public FormUpdateProduct(FormFarmerHome formFarmerHome, int farmerID)
        {
            InitializeComponent();
            this.formFarmerHome = formFarmerHome;
            this.farmer = new Farmer(farmerID);
        }

        private void FormUpdateProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (formFarmerHome != null)
            {
                formFarmerHome.Show();
            }
        }

        private void FormUpdateProduct_Load(object sender, EventArgs e)
        {
            // Keeping this empty so controls stay visible as per your design
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int ProductID;
            if (!int.TryParse(txtSearchProductID.Text, out ProductID))
            {
                MessageBox.Show("Please enter a valid numeric Product ID.");
                this.txtSearchProductID.Clear();
                txtSearchProductID.Focus();
                return;
            }

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                try
                {
                    sqlCon.Open();
                    string query = "SELECT * FROM ProductTable WHERE ProductID = @pid";
                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@pid", ProductID);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Product is not available!");
                        this.txtSearchProductID.Clear();
                        return;
                    }

                    int ownerId = Convert.ToInt32(dt.Rows[0]["FarmerID"]);
                    if (ownerId != farmer.FarmerID)
                    {
                        MessageBox.Show("You do not own this product.");
                        return;
                    }

                    dataGridViewProduct.Visible = true;
                    dataGridViewProduct.DataSource = dt;

                    // Fill textboxes with current data
                    txtNewName.Text = dt.Rows[0]["ProductName"].ToString();
                    txtNewPrice.Text = dt.Rows[0]["Price"].ToString();
                    txtNewQuantity.Text = dt.Rows[0]["Quantity"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Ensure a product is actually selected
            if (dataGridViewProduct.DataSource == null || dataGridViewProduct.Rows.Count == 0)
            {
                MessageBox.Show("Search for a product first!");
                return;
            }

            int productId = Convert.ToInt32(dataGridViewProduct.Rows[0].Cells["ProductID"].Value);
            string newName = string.IsNullOrWhiteSpace(txtNewName.Text) ? null : txtNewName.Text;

            int.TryParse(txtNewPrice.Text, out int newPrice);
            int.TryParse(txtNewQuantity.Text, out int newQuantity);

            // SAVE TO DATABASE
            farmer.UpdateProduct(productId, newName, newPrice, newQuantity);

            // ONLY ONE MESSAGE BOX HERE
            MessageBox.Show("Update Successful!");

            // Reset UI
            this.txtNewName.Clear();
            this.txtNewPrice.Clear();
            this.txtNewQuantity.Clear();
            this.txtSearchProductID.Clear();
            txtSearchProductID.Focus();
        }

        // Empty methods to prevent errors if clicked by accident in Designer
        private void lblProductID_Click(object sender, EventArgs e) { }
        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void lblNewName_Click(object sender, EventArgs e) { }
    }
}