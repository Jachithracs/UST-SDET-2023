using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CallRecord
    {
        public static List<CallRecord> call = new List<CallRecord>();
        public CallRecord(int callId, long phoneNumber, double timeStamp)
        {
            CallId = callId;
            PhoneNumber = phoneNumber;
            TimeStamp = timeStamp;
        }

        public int CallId { get; set; }
        public long PhoneNumber { get; set; }
        public double TimeStamp { get; set; }

        public static void DisplayPhoneHistoryDetails(long phonenumber)
        {
            var callph = call.FindAll(c => c.PhoneNumber == phonenumber);
            if (callph.Count > 0)
            {
                Console.WriteLine("Records of phone number "+phonenumber);
                foreach (var item in callph)
                {
                    Console.WriteLine("Call Id : {0} \n Time Stamp : {1}", item.CallId,
                         item.TimeStamp);
                    Console.WriteLine();
                }
               
            }
            else
            {
                Console.WriteLine("Call History Not Found");
            }
            Console.WriteLine();
        }
        public static void DisplayTotalHistoryCalls()
        {
            Dictionary<long,int> totalcall = new Dictionary<long,int>();
            foreach (var item in call)
            {
                if(totalcall.ContainsKey(item.PhoneNumber))
                {
                    totalcall[item.PhoneNumber]++;
                }
                else
                {
                    totalcall[item.PhoneNumber] = 1;
                }

            }
            Console.WriteLine("Total Call History :");
            foreach (var items in totalcall)
            {
              
                Console.WriteLine(items.Key+" : "+items.Value);
            }
        }
    }
}
