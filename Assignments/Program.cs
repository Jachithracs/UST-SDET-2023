
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



