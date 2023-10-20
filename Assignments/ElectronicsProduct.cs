using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class ElectronicsProduct : Product
    {
        public int WarrantyPeriod;

        public ElectronicsProduct(string? productName, double price, int quantity,
            int warrantyPeriod) :base(productName, price, quantity)
        {
            ProductName = productName;
            Price = price;
            Quantity = quantity;
            WarrantyPeriod = warrantyPeriod;
        }

        public int DisplayWarrantyPeriod()
        {
            return WarrantyPeriod;
        }
    }
}
