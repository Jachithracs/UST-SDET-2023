using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs.ExceptionMessages
{
    internal class MyExceptions
    {
        /*
    public static List<string> exmesslist = new List<string>()
                  {
                        "Dont give 0 for Denominator",
                         "Index is out of Range" ,
                           "Unknown Exception"
                  };
        
        public static Dictionary<int,string> exmesslist = new Dictionary<int,string>()
        {
            { 1, "Dont give 0 for Denominator" },
            { 2, "Index is out of Range" },
            { 3, "Unknown Exception" }
        };
        */

        public  Dictionary<string, string> exmesslist = new Dictionary<string, string>();
        public MyExceptions() 
        {
            exmesslist.Add("1", "Dont give 0 for Denominator");
            exmesslist.Add("2", "Index is out of Range");
            exmesslist.Add("3", "Unknown Exception" );
            exmesslist.Add("Not 100", "Age is less");
            exmesslist.Add("Not1002", "Age is More");

        }
        
    }
    internal class Num1Exception : Exception
    {
        public Num1Exception(string message) : base(message)
        {

        }
    }
    internal class Num2Exception : Exception
    {
        public Num2Exception(string message) : base(message)
        {

        }
    }
}
