using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class TeachingStaff : StaffDetails
    {
        public string? Specializations { get; set; }
        public int Semester {  get; set; }

        public void DisplayTeachingStaffDetails()
        {
            Console.WriteLine("Specializations : {0}\n Semester : {1} ", Specializations, Semester);

        }

    }
}
