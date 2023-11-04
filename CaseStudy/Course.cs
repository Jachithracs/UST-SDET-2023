using CaseStudy.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static CaseStudy.CustomException.EnrollmentException;

namespace CaseStudy
{
    internal class Course : IEnrollable
    {
        public int MaximumCount { get; set; }
        public int CourseCode { get; set; }
        public string? Title { get; set; }
        public string? Instructor { get; set; }


        public static List<Course> course = new List<Course>();
        public List<Student> Enrollments = new List<Student>();

        public void CourseRegistration(int id, int stuid)
        {
            var reg = course.Find(x => x.CourseCode == id && x.MaximumCount >= x.Enrollments.Count);
            var checkName = Student.students.Find(x => x.StudentId == stuid);
            var e = reg.Enrollments.Find(x => x.StudentId == stuid);

            if (reg == null)
            {
                throw new CourseFullException(EnrollmentException.ExcepCourses["Course"]);
            }
            else if (e != null)
            {
                throw new DuplicateEnrollmentException(EnrollmentException.ExcepCourses["Duplicate"]);
            }
            else
            {
                reg.Enrollments.Add(checkName);
                Console.WriteLine("Successfully Added!!!");
            }
        }

        public void CourseWithdrawal(int id)
        {
            var datas = course.Find(x => x.CourseCode == id);
            var removeEnroll = datas.Enrollments.RemoveAll(x => x.StudentId == id);
            if (removeEnroll != null)
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Not Success");
            }

        }
     
    }
}
