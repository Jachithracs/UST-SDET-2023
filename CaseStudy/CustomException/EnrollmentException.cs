using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.CustomException
{
    internal class EnrollmentException 
    {
        public static Dictionary<string, string> ExcepCourses = new Dictionary<string, string>()
        {
            {"Course","Course Full"  },
            {"Duplicate","Duplicate Enrollment " }
            

        };

        internal class CourseFullException : Exception
        {
            public CourseFullException(string message) : base(message)
            {

            }
        }
        internal class DuplicateEnrollmentException : Exception
        {
            public DuplicateEnrollmentException(string message) : base(message)
            {

            }
        }

    }
}
