﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class BankDetailsNew : BankDetails
    {
        public BankDetailsNew(int custid, long accno, string? name, string? status) : base(custid, accno, name, status)
        {

        }
        public new void WelcomeMessage()
        {
            Console.WriteLine("Welcome {0} !!!",Name);
        }
        public  void WelcomeMessage(string? name)
        {
            Console.WriteLine("Welcome {0} !!!", name);
        }

        
    }
}
