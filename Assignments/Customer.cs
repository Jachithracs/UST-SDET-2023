using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Customer
    {
        public static List<Customer> customers = new List<Customer>();
        public int CustomerId { get; set; }
        public string? CustomerName { get; set; }
        public int PhoneNumber { get; set; }
        public double Balance { get; set; }

        public Customer(int customerId, string? customerName, int phoneNumber, double balance)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            Balance = balance;
        }


        public static void DisplayBalanceDetails(int phonenumber)
        {
            var custom = customers.Find(c => c.PhoneNumber == phonenumber);
            if (custom != null)
            {
                Console.WriteLine("Customer Name : {0} \n Balance : {1} ", custom.CustomerName,
                                        custom.Balance);
            }
            else
            {
                Console.WriteLine("Customer Not Found");
            }
            Console.WriteLine();       
               
        }
        public static void DisplayCustomerDetails()
        {
            foreach (var cust in customers)
            {
                Console.WriteLine("Customer Id : {0}\n Customer Name :{1}\n Phone Number : {2} \n Balance : {3}",
                    cust.CustomerId,cust.CustomerName,cust.PhoneNumber,cust.Balance);
                Console.WriteLine();
            }
        }
         
    }
}
