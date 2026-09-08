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
    public partial class FormFarmerHome : Form
    {
        private Farmer farmer;
        private FormLogin formLogin;
        private int farmerID;

        public FormFarmerHome(int farmerID)
        {
            InitializeComponent();
            farmer = new Farmer(farmerID);
        }

        public FormFarmerHome(FormLogin formLogin, int farmerID)
        {
            InitializeComponent();
            this.formLogin = formLogin;
            this.farmerID = farmerID;
            farmer = new Farmer(farmerID);
        }

        private void FormFarmerHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnFarmerGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = this.formLogin;
            formLogin.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAddProduct formAddProduct = new FormAddProduct(this, farmerID);
            formAddProduct.Show();
        }

        private void btnRmvProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRmvProduct formRmvProduct = new FormRmvProduct(this, farmerID);
            formRmvProduct.Show();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUpdateProduct formUpdateProduct = new FormUpdateProduct(this, farmerID);
            formUpdateProduct.Show();
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormViewProducts formViewProducts= new FormViewProducts(this, farmerID);
            formViewProducts.Show();
        }
    }
}