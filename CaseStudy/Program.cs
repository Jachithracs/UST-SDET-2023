//*********************21-10-2023********************
//Case Study 1

using CaseStudy;

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

//Case Study 2

//
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
        Console.WriteLine("choose your option\n1.Add product to cart\n2.view all product\n3.place order\n4.Support\n5.view orders");
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
                    Console.WriteLine("No Product Found found");
                }
                foreach (var item in DigitalProduct.Products)
                {
                    Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                        item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
                }
                foreach (var item in PhysicalProduct.Products)
                {
                    Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                        "\tDimension:{5}", item.ProductId,
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
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                         item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
                        item.PlaceOrder();
                        item.ProcessPayment();
                        item.DeliveryOrder();
                        
                    }
                    foreach (var item in customer.ordersphy)
                    {
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                       "\tDimension:{5}", item.ProductId,item.Name, item.Price, item.StockQuantity, item.Weight, item.Dimensions);
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
                Console.WriteLine("call this number for support 987654321");
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
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                        item.Name, item.Price, item.StockQuantity, item.FileFormat, item.DownloadLink);
                    }
                    foreach (var item in customer2.confirmedordersphy)
                    {
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                       "\tDimension:{5}", item.ProductId,
                       item.Name, item.Price, item.StockQuantity, item.StockQuantity, item.Dimensions);
                    }
                }
                break;
            default:
                Console.WriteLine("invalid input");

                break;
        }




    }
    else if (option == 2)
    {
        Console.WriteLine("choose option\n1.Add Product\n2.View report");
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

                PhysicalProduct.Products.Add(physicalProduct);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
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