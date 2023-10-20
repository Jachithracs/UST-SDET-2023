
using Assignments;

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
ElectronicsProduct eproduct = new("Tv", 10000, 5, 2);
DigitalProduct dproduct = new("Radio", 20000, 8, 5, "PDF");
ClothingProduct cproduct = new("Shirt", 1500, 10, "Medium");
Console.WriteLine("Product value of Electronic Product :"+eproduct.ProductValue());
Console.WriteLine("Product value of Digital Product :" + dproduct.ProductValue());
Console.WriteLine("Product value of Clothing Product :" + cproduct.ProductValue());


