using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroBridge
{
    public class Order
    {
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=AgroBridgeDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public int CustomerID
        {
            get;
            private set;
        }

        public List<CartItem> CartItems
        {
            get;
            private set;
        }

        public List<CartItem> OrderedItems { get; set; } = new List<CartItem>();

        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalAmount { get; set; }
        public int TotalQuantity { get; set; }

        public Order(int customerID, List<CartItem> cartItems)
        {
            CustomerID = customerID;
            CartItems = cartItems;
        }

        public void PlaceOrder()
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                SqlTransaction transaction = sqlCon.BeginTransaction();

                try
                {
                    string insertOrder = @"INSERT INTO OrderTable (CustomerID, OrderDate, TotalAmount, Quantity) 
                                           OUTPUT INSERTED.OrderID
                                           VALUES (@CustomerID, @OrderDate, @TotalAmount, @Quantity)";

                    SqlCommand cmdOrder = new SqlCommand(insertOrder, sqlCon, transaction);
                    cmdOrder.Parameters.AddWithValue("@CustomerID", CustomerID);
                    cmdOrder.Parameters.AddWithValue("@OrderDate", DateTime.Now);
                    cmdOrder.Parameters.AddWithValue("@TotalAmount", GetTotalAmount());
                    int uniqueProductCount = CartItems.Count;
                    cmdOrder.Parameters.AddWithValue("@Quantity", uniqueProductCount);

                    int orderId = (int)cmdOrder.ExecuteScalar();

                    foreach (var item in CartItems)
                    {
                        string updateQuery = @"UPDATE ProductTable 
                                             SET Quantity = Quantity - @Qty 
                                             WHERE ProductID = @ProductID AND Quantity >= @Qty";

                        SqlCommand cmdUpdate = new SqlCommand(updateQuery, sqlCon, transaction);
                        cmdUpdate.Parameters.AddWithValue("@Qty", item.Quantity);
                        cmdUpdate.Parameters.AddWithValue("@ProductID", item.ProductID);
                       // cmdUpdate.ExecuteNonQuery();

                        int rows = cmdUpdate.ExecuteNonQuery();
                        if (rows == 0)
                        {
                            throw new Exception($"Not enough stock for product ID {item.ProductID}");
                        }
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Order failed: " + ex.Message);
                }
            }

            CartItems.Clear();
        }

        public static List<Order> GetOrdersByCustomer(int customerId, string connectionString)
        {
            List<Order> orders = new List<Order>();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                string query = @"
            SELECT OrderID, OrderDate, TotalAmount, Quantity
            FROM OrderTable
            WHERE CustomerID = @CustomerID
            ORDER BY OrderDate DESC";

                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Order order = new Order(customerId, new List<CartItem>())
                    {
                        OrderID = Convert.ToInt32(reader.GetValue(0)),
                        OrderDate = reader.IsDBNull(1) ? DateTime.MinValue : reader.GetDateTime(1),
                        TotalAmount = reader.IsDBNull(2) ? 0.0 : Convert.ToDouble(reader.GetValue(2)),
                        TotalQuantity = reader.IsDBNull(3) ? 0 : Convert.ToInt32(reader.GetValue(3))
                    };

                    orders.Add(order);
                }
                reader.Close();
                // For each order, load its ordered items (products) and populate OrderedItems
                string itemsQuery = @"SELECT od.ProductID, p.ProductName, p.Price, od.Quantity
                                      FROM OrderDetailsTable od
                                      JOIN ProductTable p ON od.ProductID = p.ProductID
                                      WHERE od.OrderID = @OrderID";

                foreach (var order in orders)
                {
                    using (SqlCommand cmdItems = new SqlCommand(itemsQuery, sqlCon))
                    {
                        cmdItems.Parameters.AddWithValue("@OrderID", order.OrderID);
                        using (SqlDataReader rdr = cmdItems.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                int productId = rdr.IsDBNull(0) ? 0 : Convert.ToInt32(rdr.GetValue(0));
                                string productName = rdr.IsDBNull(1) ? string.Empty : rdr.GetString(1);
                                double price = rdr.IsDBNull(2) ? 0.0 : Convert.ToDouble(rdr.GetValue(2));
                                int qty = rdr.IsDBNull(3) ? 0 : Convert.ToInt32(rdr.GetValue(3));

                                order.OrderedItems.Add(new CartItem(productId, productName, price, qty));
                            }
                        }
                    }
                }
            }


                    return orders;
        }

        public double GetTotalAmount()
        {
            double total = 0;
            foreach (var item in CartItems)
            {
                total += item.Price * item.Quantity;
            }
            return total;
        }
    }
}