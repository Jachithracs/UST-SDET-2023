using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy
{
    internal class Genre : Book
    {
        public string? BookType { get; set; }
        public Genre(string? title, string? author, int iSBN, int price, string? availability,
            string? bookType) : base(title, author, iSBN, price, availability)
        {
            Title = title;
            Author = author;
            ISBN = iSBN;
            Price = price;
            Availability = availability;
            BookType = bookType;
        }


        public void DisplayBookDetails()
        {
            Console.WriteLine("Book Title :" + Title);
            Console.WriteLine("Author's Name :" + Author);
            Console.WriteLine("ISBN : " + ISBN);
            Console.WriteLine("Price : " + Price);
            Console.WriteLine("Availability : " + Availability);
            Console.WriteLine("Book Type :" + BookType);
        }

    }
}
