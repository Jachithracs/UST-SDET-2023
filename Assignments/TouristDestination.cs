using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TouristDestination
    {
        public TouristDestination(string? name, string? location, double rating, int pricePerNight)
        {
            Name = name;
            Location = location;
            Rating = rating;
            PricePerNight = pricePerNight;
        }

        public string? Name { get; set; }
        public string? Location { get; set; }
        public double Rating { get; set; }
        public int PricePerNight { get; set; }

        public static List<TouristDestination> tourisms = new List<TouristDestination>();

        public static void SortingDestinationBasedRating()
        {
            var destination = tourisms.FindAll(t => t.Rating >= 8.5);
            
            foreach (var item in destination)
            {

                Console.WriteLine("\n Name : {0}\n Country  : {1}\n Rating : {2} \n Price Per Night : {3} "
                    , item.Name, item.Location, item.Rating,item.PricePerNight);
            }

        }
        public static void SortingDestinationBasedPrice()
        {
            var destinations = tourisms.OrderBy(t => t.PricePerNight);
            
            foreach (var tour in destinations)
            {

                Console.WriteLine("\n Name : {0}\n Country  : {1}\n Rating : {2} \n Price Per Night : {3} "
                    , tour.Name, tour.Location, tour.Rating, tour.PricePerNight);
            }

        }
        public static void FilteringDestinationBasedLocation(string? place)
        {
            var locations = tourisms.FindAll(d => d.Location == place);
            
            foreach (var tour in locations)
            {

                Console.WriteLine("\n Name : {0}\n Country  : {1}\n Rating : {2} \n Price Per Night : {3} "
                    , tour.Name, tour.Location, tour.Rating, tour.PricePerNight);
            }

        }

    }
}
