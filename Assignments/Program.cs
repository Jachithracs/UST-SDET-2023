
using Assignments;
using Assignments.ExceptionMessages;
using System;

// *****18-10-2023******

//Student Class

/*
Console.WriteLine("Enter name :");
string? StudentName = Console.ReadLine();
Console.WriteLine("Enter first mark :");
double markOne = double.Parse(Console.ReadLine());
Console.WriteLine("Enter second mark :");
double markTwo = double.Parse(Console.ReadLine());
Console.WriteLine("Enter third mark :");
double markThree = double.Parse(Console.ReadLine());

Student student = new Student(StudentName, markOne, markTwo, markThree);

Console.WriteLine("Student Name is : " + StudentName);
Console.WriteLine("Total Mark is : " + student.TotalMark());
Console.WriteLine("Average Mark is : " + student.CalculateAverage());
Console.WriteLine("Grade is : " +student.DisplayGrade());
*/

//********19-10-2023***********

//Product Class

/*
Product[] products = new Product[3];

products[0] = new("Tv", 20000, 5);
products[1] = new("Radio", 10000, 10);
products[2] = new("Mobile", 30000, 14);

foreach (var product in products)
{
    Console.WriteLine("Product Name : {0} \n Price : {1} \n Quantity : {2} " ,product.ProductName,
        product.Price,product.Quantity);
    Console.WriteLine("Product Value : {0} ", product.ProductValue());
    Console.WriteLine();
    
}
*/

//Students Class
/*
Students[] students = new Students[]
{
    new("Devu",new double[]{98,90,95},"A"),
    new("Lakshmi",new double[]{88,80,85},"B"),
    new("Bhagya",new double[]{76,72,79},"c")

};
foreach (Students student in students)
{
    Console.WriteLine("Student Name : " + student.StudentName);
    Console.WriteLine("Total Marks : " + student.TotalMark());
    Console.WriteLine("Average Marks : "+student.CalculateAverage());
    Console.WriteLine("Grade : "+student.Grade);

    double[] mark = new double[3];
    int i = 0;
    Console.WriteLine("Marks are : ");
    foreach (var marks in student.Marks)
    {
        mark[i] = marks;
        Console.WriteLine(mark[i] +"\t");
        i++;
    }
    Console.WriteLine("\n"+student.GetMarksSummary());
    Console.WriteLine();
}
*/

//**********20-10-2023************

//Single Inheritance
/*
ElectronicsProduct eproduct = new("Tv",10000,5,2);
Console.WriteLine("Product Name : "+eproduct.ProductName);
Console.WriteLine("Product Price :"+eproduct.Price);
Console.WriteLine("Product Quantity :"+eproduct.Quantity);
Console.WriteLine("Warranty Period :"+eproduct.DisplayWarrantyPeriod());
Console.WriteLine("Product Value :"+eproduct.ProductValue());
*/

//Multi-level Inheritance
/*
DigitalProduct dproduct = new("Radio", 20000, 8, 5,"PDF");
Console.WriteLine("Product Name : " + dproduct.ProductName);
Console.WriteLine("Product Price :" + dproduct.Price);
Console.WriteLine("Product Quantity :" + dproduct.Quantity);
Console.WriteLine("Warranty Period :" + dproduct.DisplayWarrantyPeriod());
Console.WriteLine("Product Value :" + dproduct.ProductValue());
dproduct.DisplayFileFormat();
*/

//Hierarchical Inheritance
/*
ElectronicsProduct eproduct = new("Tv", 10000, 5, 2);
DigitalProduct dproduct = new("Radio", 20000, 8, 5, "PDF");
ClothingProduct cproduct = new("Shirt", 1500, 10, "Medium");
Console.WriteLine("Product value of Electronic Product :"+eproduct.ProductValue());
Console.WriteLine("Product value of Digital Product :" + dproduct.ProductValue());
Console.WriteLine("Product value of Clothing Product :" + cproduct.ProductValue());
*/

//**************23-10-2023*************

//Employee,Person & IDisplayable class
/*
Employee employee = new("Devu", "S", 24, 101);
employee.DisplayInfo();
*/

//Shape,Circle,Rectangle,IDrawable class
/*
Circle circle = new Circle();
circle.Radius = 2;
circle.Draw();

Rectangle rectangle = new Rectangle();
rectangle.Length = 5;
rectangle.Width = 5;
rectangle.Draw();
*/

//**********************25-10-2023******************

//Insurance Policy Class

/*
InsurancePolicy insurancePolicy = new InsurancePolicy("Health",101,15000);
insurancePolicy.RenewPolicy();
insurancePolicy.RenewPolicy(2000);
*/

//AbstractInsurancePolicy , LifeInsurance & CarInsurance Policy

/*
LifeInsurance lifeInsurance = new LifeInsurance();
lifeInsurance.PolicyName = "Health";
lifeInsurance.PolicyId = 101;
lifeInsurance.PremiumAmount = 3000;
lifeInsurance.Age = 74;
Console.WriteLine("Life Insurance : ");
Console.WriteLine("Policy Name : {0}\n Policy Id : {1} \n Premium Amount : {2}",lifeInsurance.PolicyName,lifeInsurance.PolicyId,
    lifeInsurance.PremiumAmount);
Console.WriteLine("Insurance Amount : "+lifeInsurance.CalculatePremium());

Console.WriteLine();

CarInsurance carInsurance = new CarInsurance();
carInsurance.PolicyName = "Accident";
carInsurance.PolicyId = 999;
carInsurance.PremiumAmount = 8000;
carInsurance.VehicleType = "BMW";
Console.WriteLine("Car Insurance : ");
Console.WriteLine("Policy Name : {0}\n Policy Id : {1} \n Premium Amount : {2}", carInsurance.PolicyName, carInsurance.PolicyId,
    carInsurance.PremiumAmount);
Console.WriteLine("Insurance Amount : " + carInsurance.CalculatePremium());
*/

//****************26-10-2023*********************

//Customer Class
/*
Customer customer = new(999,"Devu",987654321,15000);
Customer customer2 = new(1001, "Lakshmi", 976584123, 23000);
Customer customer3 = new(1002, "Ganga", 968472614, 17000);

Customer.customers.Add(customer);
Customer.customers.Add(customer2);
Customer.customers.Add(customer3);

Console.WriteLine("Enter Phone number : ");
int phoneNumber = Convert.ToInt32(Console.ReadLine());
Customer.DisplayBalanceDetails(phoneNumber);

Customer.DisplayCustomerDetails();
*/

//CallRecord Class
/*
CallRecord callRecord = new(201,987654321,5);
CallRecord callRecord2 = new(301, 9867452313, 9);
CallRecord callRecord3 = new(401, 918273645, 15);
CallRecord callRecord4 = new(501, 987654321, 8);
CallRecord callRecord5 = new(601, 918273645, 10);

CallRecord.call.Add(callRecord);
CallRecord.call.Add(callRecord2);
CallRecord.call.Add(callRecord3);
CallRecord.call.Add(callRecord4);
CallRecord.call.Add(callRecord5);

Console.WriteLine("Enter Phone Number :");
long phone = Convert.ToInt64(Console.ReadLine());
CallRecord.DisplayPhoneHistoryDetails(phone);
CallRecord.DisplayTotalHistoryCalls();
*/

//Patient Class & MyException Class
/*
Patient patient1 = new Patient(101, "Deeran", 23, "Dengue");
try
{
    Patient.AddPatientInfo(patient1);

}
catch (AgeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (NameException naex)
{
    Console.WriteLine(naex.Message);
}
catch (DiagnosisException diex)
{
    Console.WriteLine(diex.Message);
}
catch (Exception eex)
{
    Console.WriteLine(eex.Message);
}

Patient.DisplayPatientDetails();
*/

//*****************27/10/2023************

//Medical Record  & MedicalException class
/*
MedicalRecord medicalRecord = new(101, "Renjan", 30, "Fever", 3421,12300);
try
{
    MedicalRecord.AddMedicalDetails(medicalRecord);
}
catch (AgeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (NameException naex)
{
    Console.WriteLine(naex.Message);
}
catch (DiagnosisException diex)
{
    Console.WriteLine(diex.Message);
}
catch(RecIdException rex)
{
    Console.WriteLine(rex.Message);
}
catch(CostException cex)
{ 
    Console.WriteLine(cex.Message);
}
catch (Exception eex)
{
    Console.WriteLine(eex.Message);
}
MedicalRecord.DisplayMedicalInfo();
*/

//Patient Class
/*
int num = 1;
do
{
    Console.WriteLine("Patient Details");
Console.WriteLine("1.Add Patient Details 2.Display Patient Details 3.Exit");
int choice =Convert.ToInt32(Console.ReadLine());


    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter Patient Id :");
            int pId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Patient Name :");
            string? name = Console.ReadLine();
            Console.WriteLine("Enter Patient Age :");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Diagnosis :");
            string? diagnosis = Console.ReadLine();
            Patient patient=new(pId, name, age, diagnosis);
            Patient.AddPatientInfo(patient);

        break;
        case 2:
            
            Patient.DisplayPatientDetails();
        break; 
        case 3:
            Environment.Exit(0);
        break;
        default:
            Console.WriteLine("Invalid Choice!!!");
         break;
    }
    Console.WriteLine("Do you want to continue Press 1 or 0 to exit");
    num = Convert.ToInt32(Console.ReadLine());

} while (num == 1);

*/
//Medical History Class
/*
int num = 1;
do
{
    Console.WriteLine("Medical History");
    Console.WriteLine("1.Add Patient Details 2.Display Patient History 3.Exit");
    int choice = Convert.ToInt32(Console.ReadLine());
    

    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter Record Id :");
            int rId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Patient Id :");
            int pId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Description :");
            string? descript = Console.ReadLine();
            Console.WriteLine("Enter Date :");
            string? dat = Console.ReadLine();
            MedicalHistory medicalHistory = new(rId,pId,descript, dat);
            MedicalHistory.AddPatientInfo(medicalHistory);
            MedicalHistory.AddPatientHistFile(medicalHistory);
        break;
        case 2:
            Console.WriteLine("Enter Patient Id for Search the details : ");
            int pid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Patient History :");
            MedicalHistory.DisplayPatientDetails(pid);
        break;
        case 3:
            Environment.Exit(0);
        break;
        default:
            Console.WriteLine("Invalid Choice!!!");
        break;
    }
    Console.WriteLine("Do you want to continue Press 1 or 0 to exit");
    num = Convert.ToInt32(Console.ReadLine());

} while (num == 1);
*/

//**********30-10-2023***************

//************HotelRoom & RoomReservation class****************

/*

HotelRoom hotel = new HotelRoom(401, "Double", true);
RoomReservation<HotelRoom> room = new();

room.BookRoom(hotel);
Console.WriteLine("Hotel Room booked Successfully");
Console.WriteLine("Details are :");
string? status;
foreach (var item in RoomReservation<HotelRoom>.values)
{
    if (item.IsBooked)
        status = "Engaged";
    else
        status = "Not Engaged";
    Console.WriteLine("Room Number:{0} Room Type:{1} Status:{2} ", item.RoomNumber, item.RoomType, status);
}
Console.WriteLine("Enter the room number for canceling:");
int num = Convert.ToInt32(Console.ReadLine());
var roomNum = HotelRoom.GetRoom(num);
if (roomNum != null)
{
    room.CancelRoom(roomNum);
    Console.WriteLine("Room is canceled");
}
else
{
    Console.WriteLine("Room doesn't exist");
}
*/
//Product1 & Product1Info class
/*
Product1Info<string> product = new Product1Info<string>();
int choice, option;
do
{
    Console.WriteLine("Choose The option");
    Console.WriteLine("1.Add Product\n2.Remove Product\n3.Update Product\n4.Get Product By Id\n5.Get Product By Name");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter The Product Id :");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Product Name :");
            string? productname = Console.ReadLine();
            Console.WriteLine("Enter The Price :");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the stock quantity");
            int quantity = Convert.ToInt32(Console.ReadLine());
            product.AddProduct(new Product1<string>(id, productname, price, quantity));
        break;
        case 2:
            Console.WriteLine("Enter the product Id to Delete");
            int productId = Convert.ToInt32(Console.ReadLine());
            var item = product.GetProductById(productId);
            if (item != null)
            {
                product.RemoveProduct(productId);
                Console.WriteLine("Product Deleted Successfully!!!!");
            }
            else
            {
                Console.WriteLine("No Product Found!!!");
            }
            break;
           
        case 3:
            Console.WriteLine("Enter the product id for updation");
            int productid = Convert.ToInt32(Console.ReadLine());
            var prId = product.GetProductById(productid);
            if (prId != null)
            {
                Console.WriteLine("Enter the Product Name :");
                string? name = Console.ReadLine();
                Console.WriteLine("Enter the price :");
                double pric = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the stock quantity :");
                int qt = Convert.ToInt32(Console.ReadLine());
                product.UpdateProduct(productid, name, pric, qt);
                Console.WriteLine("Updated Successfully ");

            }
            else
            {
                Console.WriteLine("No Product Found!!!");
            }

            break;

        case 4:
            Console.WriteLine("View Product BY Id");
            Console.WriteLine("Enter The Product Id");
            int pid = Convert.ToInt32(Console.ReadLine());
            Product1<string> pro = product.GetProductById(pid);
            if (pro != null)
            {
                Console.WriteLine($"Product Id:{pro.ProductId}\nProduct Name:{pro.Name}" +
                    $"\nPrice:{pro.Price}\nQuantity:{pro.StockQuantity}");
            }
            else
            {
                Console.WriteLine("No Product Found!!!");
            }



            break;
        case 5:
            Console.WriteLine("Search Product By Name");
            string? proname = Console.ReadLine();
            List<Product1<string>> data = product.GetProductByName(proname);
            if (data != null)
            {
                foreach (Product1<string> p in data)
                {
                    Console.WriteLine($"Product Id:{p.ProductId}\nProduct Name:{p.Name}" +
                    $"\nPrice:{p.Price}\nQuantity:{p.StockQuantity}");
                }
            }
            else
            {
                Console.WriteLine("No Product Found!!!");
            }
            break;
        case 6:
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid Option!!!!");
            break;
    }
    Console.WriteLine("Do you want to continue \n1. Yes \n2.No");
    option = Convert.ToInt32(Console.ReadLine());

} while (option == 1);
*/

//*************31-10-2023*****************

//Employees Class
/*
class Program
{
    public delegate double BonusCalculation(Employees emp);
    public static void Main(string[] args)
    {
        Employees employees = new();
        Console.WriteLine("Enter Employee Id :");
        employees.EmployeeId=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name :");
        employees.Name=Console.ReadLine();
        Console.WriteLine("Enter performance rating between 1.0 - 5.0 :");
        employees.PerformanceRating=Convert.ToDouble(Console.ReadLine());
        int n;
        do
        {
            Console.WriteLine("Choose any one of the bonus calculation :");
            Console.WriteLine("1.Performance Bonus \n 2.Variable Pay Bonus\n 3.Special Bonus");
            Console.WriteLine("Choose any one :");
            int option = Convert.ToInt32(Console.ReadLine());
            double bonus;

            switch (option)
            {
                case 1:
                    Console.WriteLine("Performance Bonus : ");
                    BonusCalculation bonus1 = employees.CalculatePerformanceBonus;
                    bonus = bonus1(employees);
                    DisplayDetails(employees, bonus);
                    break;
                case 2:
                    Console.WriteLine("Variable Pay Bonus : ");
                    BonusCalculation bonus2 = employees.CalculateVariableBonus;
                    bonus = bonus2(employees);
                    DisplayDetails(employees, bonus);
                    break;
                case 3:
                    Console.WriteLine("Special Bonus : ");
                    BonusCalculation bonus3 = employees.CalculateSpecialBonus;
                    bonus = bonus3(employees);
                    DisplayDetails(employees, bonus);
                    break;
                default:
                    Console.WriteLine("Invalid Option!!!");
                    break;
                    

            }
            Console.WriteLine("Do you want to continue 1.Yes 2. No");
            n=Convert.ToInt32(Console.ReadLine());
        } while (n == 1);


    }
    public static void DisplayDetails(Employees employees,double bon)
    {
        Console.WriteLine("Employee Id :{0}\n Employee Name :{1} \n Performance Rating :{2}\nBonus Amount:{3} ",
            employees.EmployeeId, employees.Name, employees.PerformanceRating, bon);
    }
}
*/

//HotelEvent Class
/*
class Program
{
    public delegate string? NotificationMessage1(string message);
    public delegate string? NotificationMessage2(string message);
    public static void Main(string[] args)
    {
        HotelEvent hotel = new("Camp Fire", "Kochi", "10-07-2023 : 16:48", 8);
        NotificationMessage1 messageOne = HotelEvent.EventRegistration;
        if(hotel != null) 
        {
            Console.WriteLine(messageOne($" {hotel.EventName} is Successfully Registered the event at {hotel.Location} on {hotel.EventDate} "));
        }
        else
        {
            Console.WriteLine(messageOne("Unsuccessfully registered"));
        }
        HotelEvent hotelOne = new("Onam Celebration", "Kozhicode", "09-02-2023 : 01:34", 3);

        NotificationMessage2 messageTwo = HotelEvent.EventRegistration;
        if (hotelOne != null)
        {
            Console.WriteLine(messageTwo($" {hotelOne.EventName} is Successfully Registered the event at {hotelOne.Location} on {hotelOne.EventDate}"));
        }
        else
        {
            Console.WriteLine(messageTwo("Unsuccessfully registered"));
        }
    }
}
*/

//****************01-11-2023******************

//TourismDestination Class
/*
TourismDestination destination = new TourismDestination("Ponmudi","India",4);
TourismDestination destination1 = new TourismDestination("Pattaya", "Thailand", 5);
TourismDestination destination2 = new TourismDestination("Twins Tower", "Malaysia", 2);

TourismDestination.tourisms.Add(destination);
TourismDestination.tourisms.Add(destination1);
TourismDestination.tourisms.Add(destination2);

TourismDestination.SortingDestination();
*/


TouristDestination destination = new TouristDestination("Ponmudi", "India", 9.9,1200);
TouristDestination destination1 = new TouristDestination("Pattaya", "Thailand",8.8,15000 );
TouristDestination destination2 = new TouristDestination("Twins Tower", "Malaysia", 5,20000);
TouristDestination destination3 = new TouristDestination("Munnar", "India", 4.5, 2500);
TouristDestination destination4 = new TouristDestination("Mini Coy", "Lakshadweep", 6, 3000);


TouristDestination.tourisms.Add(destination);
TouristDestination.tourisms.Add(destination1);
TouristDestination.tourisms.Add(destination2);
TouristDestination.tourisms.Add(destination3);
TouristDestination.tourisms.Add(destination4);


int n;
do
{
    Console.WriteLine("Choose the Option :");
    Console.WriteLine(" 1.Display the Top-rated Tourist Destinations \n 2.Display the Destinations based on Price \n 3.Display the Destinations based on Specific Location");
    int option = Convert.ToInt32(Console.ReadLine());
    switch(option)
    {
        case 1:
            Console.WriteLine("Tourism Destinations based on Top-Rating : ");
            TouristDestination.SortingDestinationBasedRating();
        break;
        case 2:
            Console.WriteLine("Tourism Destinations based on Price Per Night : ");
            TouristDestination.SortingDestinationBasedPrice();
        break;
        case 3:
            Console.WriteLine("Filtering Tourism Destinations based on Location : ");
            Console.WriteLine("Enter the location to search");
            string? place = Console.ReadLine();
            TouristDestination.FilteringDestinationBasedLocation(place);
            break;
        default:
            Console.WriteLine("Invalid Choice");
        break;

    }
    Console.WriteLine();
    Console.WriteLine("Do you want to continue 1.Yes 2.No");
    n= Convert.ToInt32(Console.ReadLine());
} while (n == 1);