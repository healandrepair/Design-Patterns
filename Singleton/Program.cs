// See https://aka.ms/new-console-template for more information

using Singleton;

Console.WriteLine("Creating database instance");

Database database = Database.GetInstance();

database.Query("SELECT * FROM Employees");

// Approximation of memory address of object
Console.WriteLine($"Approx memory hashcode: {database.GetHashCode()}");

Console.WriteLine("Creating database instance");

Database database2 = Database.GetInstance();

database2.Query("SELECT * FROM Payments");

// Approximation of memory address of object
Console.WriteLine($"Approx memory hashcode: {database2.GetHashCode()}");
