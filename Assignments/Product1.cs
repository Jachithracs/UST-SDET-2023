using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Product1<T>
    {
        public Product1(int productId, string? name, double price, int stockQuantity)
        {
            ProductId = productId;
            Name = name;
            Price = price;
            StockQuantity = stockQuantity;
        }

        public int ProductId { get; set; }
        public string? Name { get; set; }
        public double  Price { get; set; }
        public int StockQuantity { get; set; }


    }
}
