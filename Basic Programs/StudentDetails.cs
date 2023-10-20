using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class StudentDetails : College
    {
        /*
        public StudentDetails(int rollNo, string? studentName, string? city)
        {
            RollNo = rollNo;
            StudentName = studentName;
            City = city;
        }
        */

        public int RollNo { get; set; }
        public string? StudentName { get; set;}
        public string? City { get; set; }
        
   

    public void DisplayStudentDetails()
    {
        Console.WriteLine("Student Roll No : {0}\n Name : {1} \n City : {2} ",RollNo,StudentName,City);
    }
    }
}
