using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Customer
    {
        public string? CustomerName { get; set; }
        public double ContactDetail { get; set; }
       
        public int CustomerId { get; set; }

        public void DisplayCustomerDetails()
        {
            Console.WriteLine("Customer Id :{0} \n Customer Name : {1} \n Contact Details : {2} ",CustomerId,
                CustomerName,ContactDetail);
        }

    }
}
