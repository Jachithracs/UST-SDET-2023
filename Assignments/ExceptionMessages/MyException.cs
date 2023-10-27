using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.ExceptionMessages
{

    internal class MyException
    {
        public static Dictionary<string, string> exmesslist = new Dictionary<string, string>()
      
        {
            { "Age", "Age must be between 0 & 120" },
            { "Name", "Name cannot be null or empty" },
            {"Diagnosis", "Diagnosis cannot be null or empty"}
                 

        };
    }

        internal class AgeException : Exception
        {
            public AgeException(string message) : base(message) { }
        }
        internal class NameException : Exception
        {
            public NameException(string message) : base(message) { }
        }
        internal class DiagnosisException : Exception
        {
            public DiagnosisException(string message) : base(message) { }
        }
       





}

