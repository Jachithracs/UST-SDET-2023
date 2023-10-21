using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
    internal class Doctor : IDoctor,IAppointment
    {
        public int Did { get; set; }
        public string? DName { get; set; }
        //public Doctor(int did, string? dName)
        //{
        //    Did = did;
        //    DName = dName;
        //}

        

        public void AddNewDoctor(int did, string? dName)
        {
            Did = did;
            DName = dName;
        }

        public void ModifyDoctor(int did, string? dName)
        {
            Did = did;
            DName = dName;
        }

        public void DisplayDoctorDetails() 
        {
            Console.WriteLine("Did : {0} \t Name : {1} ",Did,DName);
        }

        public void BookApp(int did, string pname)
        {
            Console.WriteLine("Booked app for {0} with Doctor {1}",pname,did);
        }

        public void DelApp(string pname)
        {
            Console.WriteLine("Canceled app for {0}", pname);
        }
    }
}
