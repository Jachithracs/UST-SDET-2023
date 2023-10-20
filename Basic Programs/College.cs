using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class College
    {
        public int CollegeId { get; set; }
        public string? CollegeName { get; set; }

        public void DisplayCollegeDetails()
        {
            Console.WriteLine("College Id : {0} \n College Name : {1} ", CollegeId, CollegeName);

        }
    }
}
