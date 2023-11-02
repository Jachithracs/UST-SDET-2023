using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Hotel : TourismDestination
    {
        public Hotel(string? name, string? country, int rating,string? hotelName,
            int availableRooms) : base(name,country, rating)
        {
            HotelName = hotelName;
            AvailableRooms = availableRooms;
        }
        public string? HotelName {  get; set; }
        public int AvailableRooms { get; set; }

        public async Task AddHotelBooking(int room)
        {

            if (room <= AvailableRooms)
            {
                await Task.Delay(2000);
                AvailableRooms = AvailableRooms - room;

                Console.WriteLine("Hotel booked for:{0} \t Rooms left:{1}", HotelName, AvailableRooms);
            }
            else
            {
                await Console.Out.WriteLineAsync("All rooms are booked");
            }
        }
    }
}
