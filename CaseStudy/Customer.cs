using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Customer
    {
        public Customer(int customerId,string? customerName, double contactDetail)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            ContactDetail = contactDetail;
            
        }
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public double ContactDetail { get; set; }
       
       

        public void DisplayCustomerDetails()
        {
            Console.WriteLine($"CustomerId is:{CustomerId}\nCustomerName:{CustomerName}\nContact Details:{ContactDetail}");
        }

    }
}
