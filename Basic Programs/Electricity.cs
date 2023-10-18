using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Programs
{
     class Electricity
    {
        public int consumernumber, prevreading, currentReading;
        public string? consumername;

        //public Electricity() 
        //{ 
        //    consumernumber = 12345;//0
        //    prevreading = 9000;
        //    currentReading = 9300;
        //    consumername = "XXX"; //String.Empty;

        //}

        public Electricity(int consumernumber, int prevreading, int currentReading, string? consumername)
        {
            this.consumernumber = consumernumber;
            this.prevreading = prevreading;
            this.currentReading = currentReading;
            this.consumername = consumername;
        }

        public double CalculateBill()
        {
            double billamount ;
            int reading = currentReading - prevreading;
            if (reading <= 100) 
            {
                billamount = reading * 2.00;

            }
            else if(reading <= 200 && reading >= 101)
            {
                billamount = (100 * 2) + (( reading - 100 ) * 2.5);
            }
            else if (reading <= 401 && reading >= 201)
            {
                billamount = (100 * 2) + (100 * 2.5) + ((reading - 200) * 3.5);
               
            }
            else 
            {
                billamount = (100 * 2) + (100 * 2.5) + (200 * 3.5) + ((reading - 400) * 5.00);
            }

            return billamount;
        }
     }
}
