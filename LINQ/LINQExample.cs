using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class LINQExample
    {
        public void Eg1()
        {
            List<string> courses  = new List<string>();
            courses.Add("C Tutorial");
            courses.Add("C++ Tutorial");
            courses.Add("Java Tutorial");
            courses.Add("Web Tech");
            courses.Add("DBMS");
            courses.Add("UI Exp");

            /*
            var result = from item in courses
                         where item.Equals("DBMS")
                         select item;
            */
            //var result = courses.Where(c => c.Equals("DBMS"));

            var result = courses.Where(c => c.Contains("Tutorial"));



            foreach (var res in result)
            {
                Console.WriteLine(res);
            }
            
        }
        public void Eg2()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(101,"Shirin","CSE"));
            students.Add(new Student(102, "Jachithra", "ECE"));
            students.Add(new Student(103, "Gokul", "IT"));
            students.Add(new Student(104, "Vishnu", "CSE"));
            students.Add(new Student(105, "Devu", "ECE"));
            students.Add(new Student(106, "Ganga", "CSE"));

            //var stud = students.Where(s => s.Id == 102);

            /*
            foreach (var s in stud)
            {
                Console.WriteLine(s.Id + " " + s.Name + " " + s.Dept);
            }
            */

            Student stud = (Student)students.FirstOrDefault(s => s.Id == 102);

            if (stud != null)
            {
                Console.WriteLine(stud.Id + " " + stud.Name + " " + stud.Dept);
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            List<Student> stud1 = (List<Student>)students.FindAll(s => s.Name == "Shirin"
            || s.Name == "Devu");

            foreach (var s in stud1)
            {
                Console.WriteLine(s.Id + " " + s.Name + " " + s.Dept);
            }
            Console.WriteLine(">=5");
            List<Student> stud2 = (List<Student>)students.FindAll(s => s.Id>=105);

            foreach (var s in stud2)
            {
                Console.WriteLine(s.Id + " " + s.Name + " " + s.Dept);
            }
            /*
            var stud1 = students.Where(s => s.Name == "Shirin");

            foreach (var s in stud1)
            {
                Console.WriteLine(s.Id + " " + s.Name + " " + s.Dept);
            }
            */
        }

        public void FilteringOfType()
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add("Two");
            array.Add(3);
            array.Add(4);
            array.Add("Five");

            var numbers = array.OfType<int>();
            var strings = array.OfType<string>();

            foreach (int inte in numbers)
            {
                Console.WriteLine("Integer : " + inte);
            }
            Console.WriteLine();
            foreach (string str in strings)
            {
                Console.WriteLine("String : "+str);
            }

        }

        public void SortingOrderBy()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(101, "Shirin", "CSE"));
            students.Add(new Student(102, "Jachithra", "ECE"));
            students.Add(new Student(103, "Gokul", "IT"));
            students.Add(new Student(104, "Vishnu", "CSE"));
            students.Add(new Student(105, "Devu", "ECE"));
            students.Add(new Student(106, "Ganga", "CSE"));
            var result = students.OrderBy(s=>s.Name).ThenBy(s=>s.Dept);

            foreach (var s in result)
            {
                Console.WriteLine( s.Name + " " + s.Dept);
            }
        }
        public void Grouping()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(101, "Shirin", "CSE"));
            students.Add(new Student(102, "Jachithra", "ECE"));
            students.Add(new Student(103, "Gokul", "IT"));
            students.Add(new Student(104, "Vishnu", "CSE"));
            students.Add(new Student(105, "Devu", "ECE"));
            students.Add(new Student(106, "Ganga", "CSE"));

            var result = students.ToLookup(s => s.Name);

            foreach (var s in result)
            {
                Console.WriteLine(s.Key);
                foreach (var x in s)
                    Console.WriteLine(x.Id + " " + x.Dept);
            }
        }
    }
}

