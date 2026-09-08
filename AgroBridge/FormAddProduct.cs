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
    public partial class FormAddProduct : Form
    {
        private Farmer farmer;
        private FormFarmerHome formFarmerHome;
        public FormAddProduct(int farmerID)
        {
            InitializeComponent();
            farmer = new Farmer(farmerID);
        }

        public FormAddProduct(FormFarmerHome formFarmerHome, int farmerID)
        {
            InitializeComponent();
            this.formFarmerHome = formFarmerHome;
            this.farmer = new Farmer(farmerID);
        }

        private void FormAddProduct_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text) ||
                string.IsNullOrEmpty(txtProductPrice.Text) ||
                string.IsNullOrEmpty(txtProductQuantity.Text))
            {
                MessageBox.Show("Fill-up all the information first!");
                this.txtProductName.Clear();
                this.txtProductPrice.Clear();
                this.txtProductQuantity.Clear();
                txtProductName.Focus();
            }
            else
            {
                farmer.AddProduct(txtProductName.Text, int.Parse(txtProductPrice.Text), int.Parse(txtProductQuantity.Text));
                MessageBox.Show("Product Added Successfully!");
                this.txtProductName.Clear();
                this.txtProductPrice.Clear();
                this.txtProductQuantity.Clear();
                txtProductName.Focus();
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            formFarmerHome.Show();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}