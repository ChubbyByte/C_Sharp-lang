using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            showData("John", 13000, "IT");
            showData("Mary", 15000, "HR");
            showData("Peter", 17000);
            showData("Jason");
        }

        static void showData(string name, double salary = 0, string department = "None")
        {
            Console.WriteLine($"Name = {name}\nSalary = {salary:f2}\nDepartment = {department}\n");
        }
    }
}

