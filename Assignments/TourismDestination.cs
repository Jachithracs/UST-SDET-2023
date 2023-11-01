using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TourismDestination
    {
        public TourismDestination(string? name, string? country, int rating)
        {
            Name = name;
            Country = country;
            Rating = rating;
        }

        public string? Name { get; set; }
        public string? Country { get; set; }
        public int Rating { get; set; }

        public static List<TourismDestination> tourisms = new List<TourismDestination>();
        public static void SortingDestination()
        {
            var destination = tourisms.OrderByDescending(t => t.Rating);
            Console.WriteLine("Tourism Destinations based on Rating : ");
            foreach (var item in destination)
            {
                
                Console.WriteLine("\n Name : {0}\n Country  : {1}\n Rating : {2}",item.Name,item.Country,item.Rating);
            }

        }

    }
}
