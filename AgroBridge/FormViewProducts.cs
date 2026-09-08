using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroBridge
{
    public partial class FormViewProducts : Form
    {
        private Farmer farmer;
        private FormFarmerHome formFarmerHome;

        public FormViewProducts(int farmerID)
        {
            InitializeComponent();
            farmer = new Farmer(farmerID);
        }

        public FormViewProducts(FormFarmerHome formFarmerHome, int farmerID)
        {
            InitializeComponent();
            this.formFarmerHome = formFarmerHome;
            this.farmer = new Farmer(farmerID);
        }

        private void FormViewProducts_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            formFarmerHome.Show();
        }

        private void LoadProducts(string filter = "")
        {
            DataTable dt = farmer.GetMyProducts(filter);
            dataGridViewShowProducts.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                if (string.IsNullOrWhiteSpace(filter))
                {
                    MessageBox.Show("You currently have no product.");
                }
                else
                {
                    return;
                }
            }
        }

        private void FormViewProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            LoadProducts(txtSearchProduct.Text);
        }

        private void dataGridViewShowProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}