﻿/*
class ThreadExample
{
    static void Main()
    {
        // Create two threads
        Thread thread1 = new Thread(T1);
        Thread thread2 = new Thread(T1);

        // Start the threads
        thread1.Start();
        thread2.Start();

        // Wait for the threads to finish
        thread1.Join();
        thread2.Join();

        Console.WriteLine("Both threads have completed their work.");
    }

    static void T1()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Thread " + Thread.CurrentThread.ManagedThreadId + " is working: " + i);
            Thread.Sleep(100); // Simulate some work
        }
    }
}
*/
using Threads;

//************WareHouse Class******************

/*
WareHouse warehouse = new WareHouse();

Thread worker1 = new Thread(() => warehouse.AddBox(1));
Thread worker2 = new Thread(() => warehouse.AddBox(2));

worker1.Start();
worker2.Start();

worker1.Join();
worker2.Join();

Console.WriteLine("Work completed. Total boxes in the warehouse: " + warehouse.GetTotalBoxes());
*/


//*************CourseRegistration Class****************
/*
CourseRegistration course = new CourseRegistration();
int numberOfStudents = 5;

List<Thread> studentThreads = new List<Thread>();

for (int i = 1; i <= numberOfStudents; i++)
{
    string studentName = $"Student {i}";
    Thread studentThread = new Thread(() => course.RegisterStudent(studentName));
    studentThreads.Add(studentThread);
    studentThread.Start();
}

foreach (Thread studentThread in studentThreads)
{
    studentThread.Join();
}

Console.WriteLine($"Course registration completed. Total registered students: {course.GetRegisteredStudentCount()}");
*/

/*
class Program
{
    static async Task Main()
    {
        Console.WriteLine("Starting the asynchronous operation...");

        // Perform an asynchronous operation
        await PerformAsyncOperation();

        Console.WriteLine("Asynchronous operation completed.");
    }

    static async Task PerformAsyncOperation()
    {
        // Simulate an asynchronous operation
        await Task.Delay(2000); // Delay for 2 seconds (simulating work)
        Console.WriteLine("Async operation is complete.");
    }
}
*/

/*
class Program
{
    static async Task Main()
    {
        List<string> urls = new List<string>
        {
            "https://www.example.com",
            "https://www.google.com",
            "https://www.microsoft.com"
        };

        Console.WriteLine("Downloading web pages asynchronously...");

        List<Task<string>> downloadTasks = new List<Task<string>>();

        foreach (string url in urls)
        {
            downloadTasks.Add(DownloadWebPageAsync(url));
        }

        await Task.WhenAll(downloadTasks);

        foreach (Task<string> task in downloadTasks)
        {
            string content = await task;
            Console.WriteLine($"Downloaded {content.Length} bytes from a web page.");
        }

        Console.WriteLine("All web pages downloaded.");
    }

    static async Task<string> DownloadWebPageAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            string content = await client.GetStringAsync(url);
            return content;
        }
    }
}
*/
class Program
{


    static async Task Main()
    {
        CourseRegistration course = new CourseRegistration();
        int numberOfStudents = 5;

        List<Task> registrationTasks = new List<Task>();

        for (int i = 1; i <= numberOfStudents; i++)
        {
            string studentName = $"Student {i}";
            Task registrationTask = course.RegisterStudentAsync(studentName);
            registrationTasks.Add(registrationTask);
        }

        await Task.WhenAll(registrationTasks);

        Console.WriteLine($"Course registration completed. Total registered students: {course.GetRegisteredStudentCount()}");
    }
}

