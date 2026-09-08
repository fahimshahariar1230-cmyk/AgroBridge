using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroBridge
{
    public class Farmer
    {
        private int farmerID;
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=AgroBridgeDB;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public Farmer(int id)
        {
            this.farmerID = id;
        }

        public int FarmerID
        {
            get { return farmerID; }
        }

        public void AddProduct(string productName, int price, int quantity)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string sql = "INSERT INTO ProductTable (ProductName, Price, Quantity, FarmerID) VALUES (@pname, @price, @qty, @farmerID)";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                // ✅ FIXED: was @farmerId (wrong) — must match @farmerID in SQL above
                cmd.Parameters.AddWithValue("@farmerID", farmerID);
                cmd.Parameters.AddWithValue("@pname", productName);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@qty", quantity);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product added successfully!");
            }
        }

        public void RemoveProduct(int productId)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                string sql = "DELETE FROM ProductTable WHERE ProductID = @pid AND FarmerID = @farmerID";
                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.Parameters.AddWithValue("@pid", productId);
                cmd.Parameters.AddWithValue("@farmerID", this.farmerID);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    MessageBox.Show("Product removed successfully!");
                else
                {
                    string checkQuery = "SELECT COUNT(*) FROM ProductTable WHERE ProductID = @pid";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, sqlCon);
                    checkCmd.Parameters.AddWithValue("@pid", productId);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                        MessageBox.Show("Product is not available!");
                    else
                        MessageBox.Show("You're not allowed to remove this product!");
                }
            }
        }

        public void UpdateProduct(int productId, string newName, int newPrice, int newQuantity)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                List<string> updates = new List<string>();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlCon;

                if (!string.IsNullOrEmpty(newName))
                {
                    updates.Add("ProductName = @pname");
                    cmd.Parameters.AddWithValue("@pname", newName);
                }
                if (newPrice >= 0)
                {
                    updates.Add("Price = @price");
                    cmd.Parameters.AddWithValue("@price", newPrice);
                }
                if (newQuantity >= 0)
                {
                    updates.Add("Quantity = @qty");
                    cmd.Parameters.AddWithValue("@qty", newQuantity);
                }

                if (updates.Count == 0)
                {
                    MessageBox.Show("No changes provided.");
                    return;
                }

                string sql = $"UPDATE ProductTable SET {string.Join(", ", updates)} WHERE ProductID = @pid AND FarmerID = @farmerID";
                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@pid", productId);
                cmd.Parameters.AddWithValue("@farmerID", farmerID);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                    MessageBox.Show("Product updated successfully!");
                else
                {
                    string checkQuery = "SELECT COUNT(*) FROM ProductTable WHERE ProductID = @pid";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, sqlCon);
                    checkCmd.Parameters.AddWithValue("@pid", productId);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count == 0)
                        MessageBox.Show("Product is not available!");
                    else
                        MessageBox.Show("You're not allowed to update this product!");
                }
            }
        }

        public DataTable GetMyProducts(string productNameFilter = "")
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = @"SELECT ProductID, ProductName, Price, Quantity 
                                 FROM ProductTable 
                                 WHERE FarmerID = @farmerID";

                if (!string.IsNullOrWhiteSpace(productNameFilter))
                    query += " AND ProductName LIKE @pname";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@farmerID", farmerID);

                if (!string.IsNullOrWhiteSpace(productNameFilter))
                    cmd.Parameters.AddWithValue("@pname", "%" + productNameFilter + "%");

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}