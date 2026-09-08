using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroBridge
{
    public class CartItem
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public CartItem(int productId, string productName, double price, int quantity = 1)
        {
            ProductID = productId;
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        public double TotalPrice
        {
            get { return Price * Quantity; }
        }
    }
}
