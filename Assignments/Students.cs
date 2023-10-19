using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Students
    {
        private string? studentName;
        private double[] marks = new double[3];
        private string? grade;

        public Students(string? studentName, double[] marks, string? grade)
        {
            StudentName = studentName;
            Marks = marks;
            Grade = grade;
        }

        public string? StudentName { get => studentName; set => studentName = value; }
        public double[] Marks { get => marks; set => marks = value; }
        public string? Grade { get => grade; set => grade = value; }


        public double CalculateAverage()
        {
            return Marks.Average();
        }
        public double TotalMark()
        {
            return Marks.Sum();
        }

        public string GetMarksSummary()
        {
            return $"{StudentName} has {Marks.Length} marks.\n Highest Mark : {Marks.Max()}," +
                $" Lowest Mark : {Marks.Min()} ";

        }
    }
}
