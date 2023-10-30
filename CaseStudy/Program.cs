//*********************21-10-2023********************
//Case Study 1

using CaseStudy;
using static CaseStudy.CustomException.OrderException;

/*
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
           // Console.WriteLine(customerid);
            Console.WriteLine("Enter Customer Name :");
            customerName = Console.ReadLine();
            Console.WriteLine("Enter Contact Details :");
            contactDetail = Convert.ToDouble(Console.ReadLine());

            Customer customer = new Customer(customerid,customerName,contactDetail);
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

                    Order order = new Order(orderDate,total);

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
    }
    Console.WriteLine("Do you want to continue 1.Yes or 2.No");
    choice = Convert.ToInt32(Console.ReadLine());
   

    } while (choice != 0) ;
*/

//28-10-2023
//Case Study 2

//

try
{
    Customer1 customer11 = new Customer1();
    customer11.CustomerID = 1;
    customer11.CustomerName = "Anju Babu";
    customer11.CustomerEmail = "anju@ust";
    Customer1.customers.Add(customer11);
    Customer1 customer12 = new Customer1();
    customer12.CustomerID = 2;
    customer12.CustomerName = "devu s";
    customer12.CustomerEmail = "devu@ust";
    Customer1.customers.Add(customer12);
    Customer1 customer13 = new Customer1();
    customer13.CustomerID = 3;
    customer13.CustomerName = "Raman";
    customer13.CustomerEmail = "raman@ust";
    Customer1.customers.Add(customer13);

    while (true)
    {
        Console.WriteLine("*******Welcome to Flipo***************");
        Console.WriteLine("choose your option\n1.User\n2.Admin");
        int option = Convert.ToInt32(Console.ReadLine());
        if (option == 1)
        {
            Console.WriteLine("Enter the customer id");
            int cusId = Convert.ToInt32(Console.ReadLine());
            if (Customer1.customers.Find(x => x.CustomerID == cusId) == null)
            {
                Console.WriteLine("Customer not found");
                break;
            }
            Console.WriteLine("choose your option\n1.Add product to cart\n2.view all product\n3.place order\n4.Customer Support\n5.view orders");
            int optionuser = Convert.ToInt32(Console.ReadLine());
            switch (optionuser)
            {

                case 1:

                    Console.WriteLine("Enter Product id for add to cart");
                    int productId = Convert.ToInt32(Console.ReadLine());
                    Customer1 customer1 = Customer1.customers.Find(x => x.CustomerID == cusId);
                    if (DigitalProduct.Products.Find(x => x.ProductId == productId) == null)
                    {
                        if (PhysicalProduct.Products.Find(x => x.ProductId == productId) == null)
                        {
                            Console.WriteLine("invalid product id");
                        }
                        else
                        {
                            customer1.ordersphy.Add(PhysicalProduct.Products.Find(x => x.ProductId == productId));
                            Console.WriteLine("product added to cart");
                        }
                    }
                    else
                    {
                        customer1.orders.Add(DigitalProduct.Products.Find(x => x.ProductId == productId));
                        Console.WriteLine("product added to cart");
                    }
                    break;
                case 2:
                    Console.WriteLine("Products are");
                    if (DigitalProduct.Products.Count == 0 && PhysicalProduct.Products.Count == 0)
                    {
                        Console.WriteLine("No Product Found ");
                    }
                    foreach (var item in DigitalProduct.Products)
                    {
                        Console.WriteLine("Productid:{0}\nProduct Name:{1}\nPrice:{2}\nProduct Quantity:{3}\nFileFormat:{4}\nDownloadlink:{5}", item.ProductId,
                            item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
                    }
                    foreach (var item in PhysicalProduct.Products)
                    {
                        Console.WriteLine("Productid:{0}\nProduct Name:{1}\nPrice:{2}\nProduct Quantity:{3}\nWeight:{4}" +
                            "\nDimension:{5}", item.ProductId,
                            item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimensions);
                    }
                    break;
                case 3:
                    Customer1 customer = Customer1.customers.Find(x => x.CustomerID == cusId);
                    if (customer.orders.Count == 0 && customer.ordersphy.Count == 0)
                    {
                        Console.WriteLine("no product found in cart");
                    }
                    else
                    {
                        foreach (var item in customer.orders)
                        {
                            Console.WriteLine("Productid:{0}\nProduct Name:{1}\nPrice:{2}\nProduct Quantity:{3}\nFileFormat:{4}\nDownloadlink:{5}", item.ProductId,
                             item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
                            item.PlaceOrder();
                            item.ProcessPayment();
                            item.DeliveryOrder();

                        }
                        foreach (var item in customer.ordersphy)
                        {
                            Console.WriteLine("Productid:{0}\nProduct Name:{1}\nPrice:{2}\nProduct Quantity:{3}\nWeight:{4}" +
                           "\nDimension:{5}", item.ProductId, item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimensions);
                            item.PlaceOrder();
                            item.ProcessPayment();
                            item.DeliveryOrder();
                        }
                        Console.WriteLine("do you want to place all the order\n1.yes\n2.no");
                        int confirm = Convert.ToInt32(Console.ReadLine());
                        if (confirm == 1)
                        {
                            customer.confirmedorders.AddRange(customer.orders);
                            customer.orders.Clear();
                            customer.confirmedordersphy.AddRange(customer.ordersphy);
                            customer.ordersphy.Clear();
                            Console.WriteLine("order placed successfully");
                        }
                        else
                        {
                            Console.WriteLine("removing everything in cart");
                        }


                    }
                    break;
                case 4:
                    Console.WriteLine("For Customer Support !!!\n Dial this number 987654321");
                    break;
                case 5:
                    Customer1 customer2 = Customer1.customers.Find(x => x.CustomerID == cusId);
                    if (customer2.confirmedorders.Count == 0 && customer2.confirmedordersphy.Count == 0)
                    {
                        Console.WriteLine("no order details found");
                    }
                    else
                    {
                        Console.WriteLine("Orders are");
                        foreach (var item in customer2.confirmedorders)
                        {
                            Console.WriteLine("Productid:{0}\nProduct Name:{1}\nPrice:{2}\nProduct Quantity:{3}\nFileFormat:{4}\nDownloadlink:{5}", item.ProductId,
                            item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
                        }
                        foreach (var item in customer2.confirmedordersphy)
                        {
                            Console.WriteLine("Productid:{0}\nProduct Name:{1}\nPrice:{2}\nProduct Quantity:{3}\nWeight:{4}" +
                           "\tDimension:{5}", item.ProductId, item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimensions);
                        }
                    }
                    break;
                default:
                    Console.WriteLine("invalid input");

                    break;
            }

            Console.WriteLine("do you want to continue as user\n1.yes\n2.no");
            int optUser = Convert.ToInt32(Console.ReadLine());
            if (optUser == 1)
            {
                continue;
            }
            else if (optUser == 2)
            {
                break;
            }
            else
            {
                Console.WriteLine("invalid input");
            }


        }
        else if (option == 2)
        {
            Console.WriteLine("choose option\n1.Add Product\n2.View details");
            int optionadmin = Convert.ToInt32(Console.ReadLine());
            if (optionadmin == 1)
            {
                Console.WriteLine("choose the option \n1.Digital Product\n2.Physical Product");
                int optionProduct = Convert.ToInt32(Console.ReadLine());
                if (optionProduct == 1)
                {
                    Console.WriteLine("Enter Product id");
                    int productid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Product Name");
                    string? productName = Console.ReadLine();
                    Console.WriteLine("enter the price");
                    double productCost = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the stock quantity");
                    int stock = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the fileformat");
                    string? fileFormat = Console.ReadLine();
                    Console.WriteLine("Enter downloadLink");
                    string? downloadLink = Console.ReadLine();


                    DigitalProduct digitalProduct = new DigitalProduct();
                    digitalProduct.Name = productName;
                    digitalProduct.ProductId = productid;
                    digitalProduct.FileFormat = fileFormat;
                    digitalProduct.DownloadLink = downloadLink;
                    digitalProduct.Price = productCost;
                    digitalProduct.StockQuantity = stock;
                    Product.AddProduct(digitalProduct);
                    DigitalProduct.Products.Add(digitalProduct);
                }
                else if (optionProduct == 2)
                {
                    Console.WriteLine("Enter Product id");
                    int productid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Product Name");
                    string? productName = Console.ReadLine();
                    Console.WriteLine("enter the price");
                    double productCost = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the stock quantity");
                    int stock = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Weight");
                    int weight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter dimension");
                    string? dimension = Console.ReadLine();

                    PhysicalProduct physicalProduct = new PhysicalProduct();
                    physicalProduct.Name = productName;
                    physicalProduct.ProductId = productid;
                    physicalProduct.Price = productCost;
                    physicalProduct.Dimensions = dimension;
                    physicalProduct.Weight = weight;
                    physicalProduct.StockQuantity = stock;
                    Product.AddProducts(physicalProduct);
                    PhysicalProduct.Products.Add(physicalProduct);
                }
                else
                    Console.WriteLine("invalid");
            }

            else if (optionadmin == 2)
            {
                Console.WriteLine("choose the option \n1.Digital Product\n2.Physical Product");
                int option2Product = Convert.ToInt32(Console.ReadLine());
                if (option2Product == 1)
                {
                    DigitalProduct dp = new DigitalProduct();
                    foreach (var item in DigitalProduct.Products)
                    {
                        Console.WriteLine("Product Id:{0}  Product Name:{1}  Price:{2}  Quantity:{3}  Download Link:{4}  File Format:{5} ", item.ProductId, item.Name, item.Price, item.StockQuantity, item.DownloadLink, item.FileFormat);
                    }

                }
                else if (option2Product == 2)
                {
                    // PhysicalProduct dp = new PhysicalProduct();
                    foreach (var item in PhysicalProduct.Products)
                    {
                        Console.WriteLine("Product Id:{0}  Product Name:{1}  Price:{2}  Quantity:{3}  Weight:{4}  Dimension:{5} ", item.ProductId, item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimensions);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                }

            }
            

            else
            {
                Console.WriteLine("invalid option");
            }
            Console.WriteLine("do you want to continue\n1.yes\n2.no");
            int opt = Convert.ToInt32(Console.ReadLine());
            if (opt == 1)
            {
                continue;
            }
            else if (opt == 2)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("invalid input");
            }

        }
    }

}
catch (UserException ex)
{
    Console.WriteLine(ex.Message);
}
