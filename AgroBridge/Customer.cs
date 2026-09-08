using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroBridge
{
    public class Customer
    {
        
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=AgroBridgeDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public int CustomerID { get; private set; }
        public string Name { get; private set; }

        public List<CartItem> Cart { get; private set; }

        public Customer(int customerID, string name)
        {
            CustomerID = customerID;
            Name = name;
            Cart = new List<CartItem>();
        }

        public List<Product> LoadProducts()
        {
            List<Product> products = new List<Product>();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string query = "SELECT ProductID, ProductName, Price, Quantity, FarmerID FROM ProductTable";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Product product = new Product
                    {
                        ProductID = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        Price = reader.GetInt32(2),
                        Quantity = reader.GetInt32(3),
                        FarmerID = reader.GetInt32(4)
                    };
                    products.Add(product);
                }
                reader.Close();
            }
            return products;
        }

        public List<Product> SearchProducts(string searchProduct)
        {
            searchProduct = searchProduct.Trim().ToLower();
            List<Product> allProducts = LoadProducts();

            return allProducts
                .Where(p => p.ProductName.ToLower().Contains(searchProduct))
                .ToList();
        }

        public void AddToCart(Product product)
        {
            var existingItem = Cart.FirstOrDefault(c => c.ProductID == product.ProductID);
            if (existingItem != null)
            {
                throw new Exception("You already selected the product.");
            }
            Cart.Add(new CartItem(product.ProductID, product.ProductName, product.Price, 1));
        }

        public void RemoveFromCart(int productId)
        {
            var item = Cart.FirstOrDefault(c => c.ProductID == productId);
            if (item != null)
                Cart.Remove(item);
        }

        public void ClearCart()
        {
            Cart.Clear();
        }
    }
}