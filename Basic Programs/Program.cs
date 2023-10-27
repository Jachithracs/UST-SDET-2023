/*
Console.WriteLine("Enter two numbers :");
int num1, num2, ans;
num1 = Convert.ToInt32((Console.ReadLine()));
num2 = Convert.ToInt32((Console.ReadLine()));

ans = num1 + num2;
Console.WriteLine("Result is "+ ans);
*/

/*
string? s1 = " ";
string? s2 = " ";
string? s3 = " ";

s1 = Console.ReadLine();
s2 = Console.ReadLine();

s3 = s1 + " " + s2;
Console.WriteLine(s3);

Console.WriteLine(s1.Equals(s2));
Console.WriteLine(s1.ToLower());
Console.WriteLine(s1.ToUpper());

Console.WriteLine(s2.Substring(3));

string[] s = s3.Split(' ');
for(int i = 0; i < s.Length; i++)
    Console.WriteLine(s[i]);
*/

/*
int x = 5; //char x = '5'; string x = "5";
switch(x)
{
    case 1: //case '1':  case "1":
        Console.WriteLine();
        break;
    case 2:
        Console.WriteLine();
        break;
    case 3:
        Console.WriteLine();
        break;
    default: Console.WriteLine();
        break;
}
*/


//driver
using Basic_Programs;
using Basic_Programs.ExceptionMessages;

//************Calculation Class*******************

/*
Calculation calculation = new Calculation();

int num1=Convert.ToInt32(Console.ReadLine());
int num2=Convert.ToInt32(Console.ReadLine());

 double res = calculation.Add(num1,num2);
Console.WriteLine(res);
*/

//*******************Electricity Class*************************

//Electricity electricity = new ();
//Electricity electricity = new Electricity();
//double billamount = electricity.CalculateBill();
/*
int consumernumber=Convert.ToInt32(Console.ReadLine());

Electricity electricity1 = new Electricity(consumernumber, 9000, 9300, "XX");
//Electricity electricity1 = new Electricity(12345,9000,9300,"XX");
Console.WriteLine(electricity1.consumername);
Console.WriteLine(electricity1.consumernumber);
Console.WriteLine(electricity1.CalculateBill());


Electricity electricity2 = new Electricity(23456, 9000, 10000, "AA");
Console.WriteLine(electricity2.consumername);
Console.WriteLine(electricity2.consumernumber);
Console.WriteLine(electricity2.CalculateBill());

*/


//**************************Employee Class*******************
/*
Employee employee = new(101, "Devu", "IT", 10000);

//Console.WriteLine("Employee Id : " + employee.EmployeeId);
//Console.WriteLine("Employee Name : " + employee.EmployeeName);
//Console.WriteLine("Department : " + employee.Department);
//Console.WriteLine(employee.BasicPay);

Console.WriteLine("\n Employee Id : {0} \n Employee Name : {1} \n Department : {2} \n " +
                  "Basic Pay : {3}  " , employee.EmployeeId, employee.EmployeeName, employee.Department,
                  employee.BasicPay);

Console.WriteLine("\n Net Pay : {0} " , employee.CalculateSalary());

*/


//*****************************Array Example Class***********************
/*
ArrayExample arrayExample = new ();
//arrayExample.OneDimensional();
//arrayExample.Twodimensional();
arrayExample.JaggedArray();
*/


//**************Student Details & Student Marks & Student Grade Class*******************

/*
//Single Inheritance
//StudentMarks marks = new(1000,"Shirin","EKM",98,89,95,0,0);
StudentMarks marks = new();
marks.RollNo = 1000;
marks.StudentName = "Shirin";
marks.City = "EKM";
marks.Mark1 = 98;
marks.Mark2 = 89;
marks.Mark3 = 95;
marks.DisplayStudentDetails();
Console.WriteLine("Total Marks : "+marks.CalculateTotal());
Console.WriteLine("Average Marks : " + marks.CalculateAverage());
*/

/*
StudentGrade grade = new();
grade.RollNo = 1000;
grade.StudentName = "Devu";
grade.City = "TVM";
grade.Mark1 = 99;
grade.Mark2 = 87;
grade.Mark3 = 95;
grade.DisplayStudentDetails();
Console.WriteLine("Total Marks : " + grade.CalculateTotal());
Console.WriteLine("Average Marks : " + grade.CalculateAverage());
Console.WriteLine("Grade : " + grade.CalculateGrade());
*/

//Hierarchical Inheritance
/*
Console.WriteLine("1.Display Teaching Staff 2.Display Non Teaching Staff 3.Display Student Details");
switch(Convert.ToInt32(Console.ReadLine()))
{
    case 1:
        TeachingStaff ts = new TeachingStaff();
        ts.CollegeId = 1210;
        ts.CollegeName = "LMCST";
        ts.StaffId = 111;
        ts.Name = "Shirin";
        ts.Department = "CS";
       ts.Specializations = "OS,DBMS,DS";
        ts.Semester = 4;
        ts.DisplayCollegeDetails();
        Console.WriteLine("Teaching Staff Details : ");
        ts.DisplayStaffDetails();
        ts.DisplayTeachingStaffDetails();
       
    break;
    case 2:
        NonTeachingStaff nts = new NonTeachingStaff();
        nts.CollegeId = 1210;
        nts.CollegeName = "LMCST";
        nts.StaffId = 222;
        nts.Name = "Jachithra";
        nts.Department = "Admin";
        nts.Responsibilities = "Att,Sal";
        nts.Experience = 4;
        nts.DisplayCollegeDetails();
        Console.WriteLine("Non Teaching Staff Details : ");
        nts.DisplayStaffDetails();
        nts.DisplayNonTeachingStaffDetails();
        
        break;
    case 3:
        StudentDetails stuDet = new StudentDetails();
        stuDet.CollegeId = 1210;
        stuDet.CollegeName = "LMCST";
        stuDet.RollNo = 1;
        stuDet.StudentName = "Bhagya";
        stuDet.City = "TVM";
        stuDet.DisplayCollegeDetails();
        Console.WriteLine("Student Details : ");
        stuDet.DisplayStudentDetails();
        
    break;
}
*/


//*****************Vehicle & EV & PV class*********************
/*
EV ev = new();
ev.vehnum = 1234;
ev.Brand = "XX";
ev.Model = "AA";
ev.Display();
Console.WriteLine(ev.setTypeForVeh());

PV pv = new();
pv.vehnum = 5678;
pv.Brand = "YY";
pv.Model = "BB";
pv.Display();
Console.WriteLine(pv.setTypeForVeh());
*/

//*************Doctor class*******************
/*
Doctor doc = new Doctor();
//IDoctor doc = new Doctor();
doc.AddNewDoctor(1234,"AA");
doc.DisplayDoctorDetails();
doc.ModifyDoctor(9876,"BB");
doc.DisplayDoctorDetails();
doc.BookApp(2345,"XX");
doc.DelApp("XX");
*/

//*************Bank Detail class*******************

//Polymorphism with Over Loading
/* BankDetails bank = new (1234, 1234567890L, "AA", "Inactive");*/
//BankDetails bank1 = new BankDetails();
//BankDetails bank2 = new BankDetails(999,9876543210L,"BB");

//BankDetailsNew bank2 = new BankDetailsNew(999, 9876543210L, "BB","Inactive");
/*
 BankDetails bank2 = new BankDetailsNew(999, 9876543210L, "BB", "Inactive");

bank2.WelcomeMessage();
//bank2.WelcomeMessage("Jachithra");

Console.WriteLine("1.Custid 2.Accno 3.Name");
int ch = Convert.ToInt32(Console.ReadLine());

switch(ch)
{
    case 1:
        Console.WriteLine("Customer Id :");
        bank2.GetAccDetails(Convert.ToInt32(Console.ReadLine()));
    break;
    case 2:
        Console.WriteLine("Acc No :");
        bank2.GetAccDetails(Convert.ToInt64(Console.ReadLine()));
     break;
    case 3:
        Console.WriteLine("Name :");
        bank2.GetAccDetails(Console.ReadLine());
    break;
    default:
        Console.WriteLine("Enter between 1-3");
    break;

}

bank2.ExitMessage();
*/

//***********************NonGenericCollection Class************************
/*
NonGenericCollection ngc = new NonGenericCollection();
//ngc.ArrayListHandling();
//ngc.StackHandling();
//ngc.QueueHandling();
//ngc.HashHandling();
//ngc.SortedListHandling();

//***********************GenericCollection Class************************
GenericCollection genericCollection = new GenericCollection();
//genericCollection.ListHandling();
//genericCollection.StackHandling();
//genericCollection.QueueHandling();
genericCollection.DictionaryHandling();
*/

//**************ExceptionHandling,MyExceptions class & ExceptionMessages Folder***********
/*
ExceptionHandling exception = new ExceptionHandling(10, 107);

try
{
    exception.NumCheck1();
    
}
catch(Num1Exception ex)
{
    Console.WriteLine(ex.Message);
}
try
{
    exception.NumCheck2();
}
catch (Num2Exception ex)
{
    Console.WriteLine(ex.Message);
}
*/

/*
try
{
    exception.Divide();
}
catch (ArithmeticException ex)
{
    //Console.WriteLine(ex.Message);
    //Console.WriteLine(ex.StackTrace);
    //Console.WriteLine(ex.Source);
    // Console.WriteLine(MyExceptions.exmesslist[0]);
    Console.WriteLine(MyExceptions.exmesslist[1]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine(MyExceptions.exmesslist[2]);
}
catch (Exception ex)
{
    Console.WriteLine(MyExceptions.exmesslist[3]);
}
finally
{
    Console.WriteLine("Done");
}
*/


//***********FileOperations Class************
FileOperations fileOperations = new FileOperations();
//fileOperations.CreateFile();
//fileOperations.WriteData();
//fileOperations.ReadData();
//fileOperations.CopyMoveFile();
//fileOperations.DeleteFile();
fileOperations.FileProperties();









