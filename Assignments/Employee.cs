using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employee : Person, IDisplayable
    {
        public int EmployeeId;

        public Employee(string? firstName, string? lastName, int age,int employeeId) : base(firstName, lastName, age)
        {
            EmployeeId = employeeId;
        }

      

        public void DisplayInfo()
        {
            Console.WriteLine("Full Name : {0} {1} \n Age : {2}",FirstName,LastName,Age);
        }
    }
}
