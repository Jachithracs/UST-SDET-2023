using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.ExceptionMessages
{
    internal class MedicalException
    {
        public static Dictionary<string, string>exlist = new Dictionary<string, string>()

        {
            { "Age", "Age must be between 0 & 120" },
            { "Name", "Name cannot be null or empty" },
            {"Diagnosis", "Diagnosis cannot be null or empty"},
            {"RecId","Record Id should not be empty or null" },
            {"TreatCost","Treatment Cost should be a positive value" }


        };
    }
    internal class RecIdException : Exception
    {
        public RecIdException(string message) : base(message) { }
    }
    internal class CostException : Exception
    {
        public CostException(string message) : base(message) { }
    }
}
