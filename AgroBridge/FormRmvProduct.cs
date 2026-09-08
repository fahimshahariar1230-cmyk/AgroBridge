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
    public partial class FormRmvProduct : Form
    {
        private Farmer farmer;
        private FormFarmerHome formFarmerHome;
        public FormRmvProduct(int farmerID)
        {
            InitializeComponent();
            farmer = new Farmer(farmerID);
        }

        public FormRmvProduct(FormFarmerHome formFarmerHome, int farmerID)
        {
            InitializeComponent();
            this.formFarmerHome = formFarmerHome;
            this.farmer = new Farmer(farmerID);
        }

        private void FormRmvProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRmvProduct_Click(object sender, EventArgs e)
        {
            int productId;

            try
            {
                productId = int.Parse(txtProductID.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a valid numeric Product ID.");
                return;
            }

            farmer.RemoveProduct(productId);
            this.txtProductID.Clear();
            txtProductID.Focus();
                
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            formFarmerHome.Show();
        }
    }
}
