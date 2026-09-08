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
    public partial class SellsReport : Form
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=AgroBridgeDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public SellsReport()
        {
            InitializeComponent();
        }

        private void SellsReport_Load(object sender, EventArgs e)
        {
            LoadSellsReport();
        }

        private void LoadSellsReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("========== AGROBRIDGE SELLS REPORT ==========");
            sb.AppendLine();

            double grandTotal = 0;
            int totalOrders = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Get all orders with customer name
                    string orderQuery = @"
                        SELECT o.OrderID, o.OrderDate, o.TotalAmount, o.Quantity,
                               r.Name AS CustomerName, r.Username
                        FROM OrderTable o
                        LEFT JOIN RegistrationTable r ON o.CustomerID = r.ID
                        ORDER BY o.OrderDate DESC";

                    SqlCommand orderCmd = new SqlCommand(orderQuery, connection);
                    SqlDataReader orderReader = orderCmd.ExecuteReader();

                    List<OrderRow> orders = new List<OrderRow>();
                    while (orderReader.Read())
                    {
                        orders.Add(new OrderRow
                        {
                            OrderID = orderReader.GetInt32(0),
                            OrderDate = orderReader.IsDBNull(1) ? DateTime.MinValue : orderReader.GetDateTime(1),
                            Total = orderReader.IsDBNull(2) ? 0 : Convert.ToDouble(orderReader[2]),
                            Quantity = orderReader.IsDBNull(3) ? 0 : orderReader.GetInt32(3),
                            CustomerName = orderReader.IsDBNull(4) ? "Unknown" : orderReader.GetString(4),
                            Username = orderReader.IsDBNull(5) ? "Unknown" : orderReader.GetString(5)
                        });
                    }
                    orderReader.Close();

                    foreach (var order in orders)
                    {
                        totalOrders++;
                        grandTotal += order.Total;

                        sb.AppendLine($"Order ID   : {order.OrderID}");
                        sb.AppendLine($"Customer   : {order.CustomerName} ({order.Username})");
                        sb.AppendLine($"Date       : {order.OrderDate:dd MMM yyyy, hh:mm tt}");
                        sb.AppendLine($"Items      : {order.Quantity}");
                        sb.AppendLine($"Total      : {order.Total:N2} BDT");
                        sb.AppendLine("---------------------------------------------");
                    }

                    sb.AppendLine();
                    sb.AppendLine($"TOTAL ORDERS : {totalOrders}");
                    sb.AppendLine($"GRAND TOTAL  : {grandTotal:N2} BDT");
                    sb.AppendLine("=============================================");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBox1.Text = sb.ToString();
        }

        public class OrderRow
        {
            public int OrderID { get; set; }
            public DateTime OrderDate { get; set; }
            public double Total { get; set; }
            public int Quantity { get; set; }
            public string CustomerName { get; set; }
            public string Username { get; set; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAdminHome formAdminHome = new FormAdminHome();
            formAdminHome.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
    }
}