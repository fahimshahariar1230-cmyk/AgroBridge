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
    public partial class FormCustomerOrders : Form
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=AgroBridgeDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
        private Customer customer;

        public FormCustomerOrders(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            flowLayoutPanelOrders.AutoScroll = true;
            LoadOrders();
        }

        private void LoadOrders()
        {
            flowLayoutPanelOrders.Controls.Clear();

            var orders = Order.GetOrdersByCustomer(customer.CustomerID, connectionString);

            if (orders.Count == 0)
            {
                Label lblEmpty = new Label
                {
                    Text = "You have no orders yet.",
                    Font = new Font("Arial", 11, FontStyle.Bold),
                    ForeColor = Color.DarkRed,
                    AutoSize = true,
                    Margin = new Padding(10)
                };
                flowLayoutPanelOrders.Controls.Add(lblEmpty);
                return;
            }

            foreach (var order in orders)
            {
                Panel card = new Panel
                {
                    Width = 420,
                    Height = 90,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    BackColor = Color.WhiteSmoke
                };

                Label lblInfo = new Label
                {
                    AutoSize = true,
                    Location = new Point(10, 10),
                    Font = new Font("Arial", 10),
                    // ✅ FIXED: shows BDT instead of $, proper date format
                    Text = $"Order ID : {order.OrderID}\n" +
                           $"Date     : {order.OrderDate:dd MMM yyyy, hh:mm tt}\n" +
                           $"Total    : {order.TotalAmount:N2} BDT"
                };

                card.Controls.Add(lblInfo);
                flowLayoutPanelOrders.Controls.Add(card);
            }
        }

        private void FormCustomerOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanelOrders_Paint(object sender, PaintEventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            // ✅ FIXED: was Application.Exit() — now correctly goes back
            this.Hide();
            this.Close();
        }
    }
}