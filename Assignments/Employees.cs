using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Employees
    {
        public int EmployeeId { get; set; }
        public string? Name { get; set; }
        public double PerformanceRating { get; set; }

        public double CalculatePerformanceBonus(Employees emp)
        {
            return emp.PerformanceRating * 1500;
        }
        public double CalculateVariableBonus(Employees emp)
        {
            return emp.PerformanceRating * 5500;
        }
        public double CalculateSpecialBonus(Employees emp)
        {
            return emp.PerformanceRating * 9500;
        }

    }
}
