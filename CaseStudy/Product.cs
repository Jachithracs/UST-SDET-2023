using CaseStudy.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static CaseStudy.CustomException.OrderException;

namespace CaseStudy
{
    internal class Product
    {

        public int ProductId { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        public static void AddProduct(DigitalProduct product)
        {
            if (product.ProductId <= 0)
            {
                throw new UserException(OrderException.exMessageList["One"]);
            }
            if (string.IsNullOrEmpty(product.Name))
            {
                throw new UserException(OrderException.exMessageList["Four"]);
            }
            if (product.Price <= 0)
            {
                throw new UserException(OrderException.exMessageList["Three"]);
            }
            if (product.StockQuantity <= 0)
            {
                throw new UserException(OrderException.exMessageList["Two"]);
            }

        }
        public static void AddProducts(PhysicalProduct product)
        {
            if (product.ProductId <= 0)
            {
                throw new UserException(OrderException.exMessageList["One"]);
            }
            if (string.IsNullOrEmpty(product.Name))
            {
                throw new UserException(OrderException.exMessageList["Four"]);
            }
            if (product.Price <= 0)
            {
                throw new UserException(OrderException.exMessageList["Three"]);
            }
            if (product.Weight <= 0)
            {
                throw new UserException(OrderException.exMessageList["Five"]);
            }
            

        }

    }
}
