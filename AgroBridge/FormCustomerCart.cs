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
    public partial class FormCustomerCart : Form
    {
        private Customer customer;
        private FormCustomerHome formCustomerHome;

        public FormCustomerCart(Customer customer, FormCustomerHome formCustomerHome)
        {
            InitializeComponent();
            this.customer = customer;
            this.formCustomerHome = formCustomerHome;

            LoadCartUI();
        }

        private void LoadCartUI()
        {
            flowLayoutPanelCart.Controls.Clear();

            if (customer.Cart.Count == 0)
            {
                Label lblEmpty = new Label
                {
                    Text = "Your cart is empty.",
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Red,
                    Margin = new Padding(10)
                };

                flowLayoutPanelCart.Controls.Add(lblEmpty);
                UpdateTotalPrice();
                return;
            }

            foreach (var item in customer.Cart)
            {
                Panel card = new Panel
                {
                    Width = 300,
                    Height = 120,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(10),
                    BackColor = Color.WhiteSmoke
                };

                Label lblName = new Label
                {
                    Text = $"Product: {item.ProductName}",
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Location = new Point(10, 10),
                    AutoSize = true
                };

                Label lblPrice = new Label
                {
                    Text = $"Price: {item.Price} BDT",
                    Location = new Point(10, 40),
                    AutoSize = true
                };

                Label lblProductID = new Label
                {
                    Text = $"ProductID: {item.ProductID}",
                    Location = new Point(150, 40),
                    AutoSize = true
                };

                Label lblQty = new Label
                {
                    Text = "Quantity:",
                    Location = new Point(10, 70),
                    AutoSize = true
                };

                NumericUpDown numQty = new NumericUpDown
                {
                    Value = item.Quantity,
                    Minimum = 1,
                    Maximum = 100,
                    Location = new Point(80, 68),
                    Width = 60,
                    Tag = item
                };
                numQty.ValueChanged += (s, e) =>
                {
                    var cartItem = (CartItem)((NumericUpDown)s).Tag;
                    cartItem.Quantity = (int)((NumericUpDown)s).Value;
                    UpdateTotalPrice();
                };

                Button btnRemove = new Button
                {
                    Text = "Remove",
                    Location = new Point(180, 68),
                    Width = 80,
                    Tag = item.ProductID
                };
                btnRemove.Click += BtnRemove_Click;

                card.Controls.Add(lblName);
                card.Controls.Add(lblPrice);
                card.Controls.Add(lblProductID);
                card.Controls.Add(lblQty);
                card.Controls.Add(numQty);
                card.Controls.Add(btnRemove);

                flowLayoutPanelCart.Controls.Add(card);
            }
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            double total = customer.Cart.Sum(i => i.Price * i.Quantity);
            lblTotalPrice.Text = $"Total: {total} BDT";
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                int productId = (int)btn.Tag;
                customer.RemoveFromCart(productId);
                LoadCartUI();
            }
        }

        private void FormCustomerCart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGoBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            formCustomerHome.RefreshProducts();
            formCustomerHome.Show();
        }

        private void btnOrder_Click_1(object sender, EventArgs e)
        {
            if (customer.Cart.Count == 0)
            {
                MessageBox.Show("Your cart is empty.");
                return;
            }

            try
            {
                Order order = new Order(customer.CustomerID, customer.Cart);

                order.PlaceOrder();

                MessageBox.Show("Order confirmed!");

                LoadCartUI();
                UpdateTotalPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Order failed: " + ex.Message);
            }
        }

        private void flowLayoutPanelCart_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
