using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal interface IDoctor
    {

       // int Did { get; set; }
       // string? DName { get; set; }
         void AddNewDoctor(int did,string? dname);
         void  ModifyDoctor(int did, string? dname);

         

    }
}
