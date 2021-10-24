using System;
using System.Globalization;

namespace ExeUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee one = new Employee();
            Employee two = new Employee();

            Console.WriteLine("First employee data");
            Console.Write("Name : ");
            one.Name = Console.ReadLine();
            Console.Write("Salary of Employee : ");
            one.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            Console.WriteLine("Second employee data");
            Console.Write("Name : ");
            two.Name = Console.ReadLine();
            Console.Write("Salary of employee : ");
            two.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("");

            double average = (one.Salary + two.Salary) / 2.0;

            Console.WriteLine($"Average salary : {average.ToString("F2", CultureInfo.InvariantCulture)} ");  
        }
    }
}
