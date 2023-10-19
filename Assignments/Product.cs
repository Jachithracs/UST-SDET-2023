using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Product
    {
        private string? productName;
        private double price;
        private int quantity;

        public string? ProductName { get => productName; set => productName = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public Product(string? productName, double price, int quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        public double SetPrice(double newPrice)
        {
           Price = newPrice;
            return Price;
        }
         
        public double ProductValue()
        {
            return Price * Quantity;
        }
    }
}
