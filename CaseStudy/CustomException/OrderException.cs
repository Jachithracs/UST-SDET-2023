using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.CustomException
{
    internal class OrderException :Exception
    {
        public static Dictionary<string, string> exMessageList = new Dictionary<string, string>()
        {
            { "One","ProductId is not null!!!" },
            { "Two","Quantity not zero"},
            {"Three", "Product Cost is greater than zero" },
            {"Four","ProductName Not Null" },
            {"Five","Weight must be greater than 0" }



        };

        internal class UserException : Exception
        {
            public UserException(string message) : base(message)
            {

            }
        }

    }

}
