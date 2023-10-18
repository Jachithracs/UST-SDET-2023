using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Student
    {
        public string? StudentName;
        double markOne, markTwo, markThree;

        public Student(string? studentName, double markOne, double markTwo, double markThree)
        {
            StudentName = studentName;
            this.markOne = markOne;
            this.markTwo = markTwo;
            this.markThree = markThree;
        }


        public double CalculateAverage()
        {
            double totalMark, averageMark;
           

            totalMark = markOne + markTwo + markThree;

            averageMark = totalMark / 3;

            return averageMark;
        }

        public string DisplayGrade()
        {
            string? grade;
            double average = CalculateAverage();

            if (average > 80)
            {
                grade = "A";
            }
            else if (average > 60)
                 {
                    grade = "B";
                 }
            else if (average > 40)
            {
                grade = "C";
            }
            else 
            {
                grade = "Fail";
            }
            return grade;
        }

        public double TotalMark()
        {
            return markOne + markTwo + markThree;
        }
    }
}
