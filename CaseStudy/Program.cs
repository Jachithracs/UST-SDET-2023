//21-10-2023
//Case Study 1

using CaseStudy;
using System.Reflection;


int choice = 1;
string? title;
int customerid;
string? customerName;
double contactDetail;
string? orderDate;
int total;

do
{


    Console.WriteLine("Online Book Store");
    Console.WriteLine("Choose Any Option : ");
    Console.WriteLine("1.Add Book \n 2.Add Customer \n 3.Order Book & View Order \n 4.Search Book  \n 5.Exit");
    int option = Convert.ToInt32(Console.ReadLine());


    Genre[] genre = new Genre[]
    {
    new("The Queen","S Chand",101,1500,"Yes","Drama")
    };
    switch (option)
    {

        case 1:

            Console.WriteLine("Book Added Successfully ");
            foreach (Genre gen in genre)
            {
                gen.DisplayBookDetails();
            }
            break;
        case 2:

            Console.WriteLine("Enter Customer Id :");
            customerid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Customer Name :");
            customerName = Console.ReadLine();
            Console.WriteLine("Enter Contact Details :");
            contactDetail = Convert.ToInt32(Console.ReadLine());

            Customer customer = new Customer();
            customer.DisplayCustomerDetails();
            break;
        case 3:
            Console.WriteLine("Enter Book Title");
            title = Console.ReadLine();

            if (genre[0].Title.Equals(title))
            {
                foreach (var genres in genre)
                {
                    Console.WriteLine("Enter Order Date :");
                    orderDate = Console.ReadLine();
                    Console.WriteLine("Order is Confirmed!!!");
                    total = genres.Price;

                    Order order = new Order();

                    Console.WriteLine("Details are : ");
                    order.OrderConfirmed();
                    Console.WriteLine("Book Title :{0} \n Book Price {1} \n Book Type {2} ",
                        title, genres.Price, genres.BookType);
                }
            }
            else
            {
                Console.WriteLine("Books are not available");
            }

            break;
        case 4:
            Console.WriteLine("Enter Book Title");
            title = Console.ReadLine();
            foreach (var gen in genre)
            {
                if (gen.Title.Equals(title))
                {
                    Console.WriteLine("Book Title :{0} \n Book Price {1} \n Book Availability {2} ",
                                            title, gen.Price, gen.Availability);
                }
                else
                {
                    Console.WriteLine("Books are not available");
                }
            }
            break;

        case 5:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Choice");
            break;
            Console.WriteLine("Do you want to continue 1.Yes or 2.No");
            choice = Convert.ToInt32(Console.ReadLine());
    }

    } while (choice != 0) ;
