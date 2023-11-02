using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourPackage
    {
        public static List<TourPackage> TourPackages = new List<TourPackage>();
        public TourPackage(int packageId, string? destination, string? startDate, double price)
        {
            PackageId = packageId;
            Destination = destination;
            StartDate = startDate;
            Price = price;
        }

        public int PackageId { get; set; }
        public string? Destination { get; set; }
        public string? StartDate { get; set; }
        public double Price { get; set; }

        public static void HotelReservation()
        {

            Console.WriteLine("Enter the id to book package");
            int a = Convert.ToInt32(Console.ReadLine());
            lock (TourPackages)
            {
                var b = TourPackages.Find(x => x.PackageId == a);
                if (b == null)
                {
                    Console.WriteLine("Id is not available");
                }
                else
                {
                    Console.WriteLine("Package booked Destination:{0}\tStart Date:{1}\tPrice:{2}", 
                        b.Destination, b.StartDate, b.Price);
                }
            }
        }

    }
}
