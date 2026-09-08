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
    public partial class FormCustomerProfile : Form
    {
        private Customer customer;
        private FormCustomerHome formCustomerHome;

        public FormCustomerProfile(Customer customer, FormCustomerHome formCustomerHome)
        {
            InitializeComponent();
            this.customer = customer;
            this.formCustomerHome = formCustomerHome;
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            formCustomerHome.Show();
        }

        private void FormCustomerProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnOrderDetails_Click(object sender, EventArgs e)
        {
            FormCustomerOrders formCustomerOrders = new FormCustomerOrders(customer);
            formCustomerOrders.Show();
            this.Hide();
        }
    }
}