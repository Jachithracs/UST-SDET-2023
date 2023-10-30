using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignments
{
    internal class Product1Info<T> 
    {
        private List<Product1<T>> products = new List<Product1<T>>();

        public void AddProduct(Product1<T> product)
        {
            products.Add(product);
            
        }

        public bool RemoveProduct(int productId)
        {
            Product1<T> removeP = products.Find(x => x.ProductId == productId);
            if (removeP != null)
            {
                products.Remove(removeP);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateProduct(int productid,string? name,double price,int stock)
        {
            Product1<T> updateP = products.Find(x=>x.ProductId == productid);
            if (updateP != null)
            {
               updateP.Name = name;
                updateP.Price = price;
                updateP.StockQuantity = stock;

                return true;
            }
            else
            {
                return false;
            }
        }

        public Product1<T> GetProductById(int productid)
        {
            return products.Find(p => p.ProductId == productid);
        }
        public List<Product1<T>> GetProductByName(string name)
        {
            return products.FindAll(p => p.Name == name);
        }



    }
}
