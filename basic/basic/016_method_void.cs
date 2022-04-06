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
            greeting();
            greeting("John");
            greeting("John", "Snow");
            plusNum(3, 5);
            plusNum(3.5, 6.4);
        }

        //create method
        static void greeting()
        {
            Console.WriteLine("Hello!, World\n");
        }

        //with parameter :: overide --> greeting() --> with parameter
        static void greeting(string fname = "ไม่ระบุ", string lname = "ไม่ระบุ")
        {
            Console.WriteLine("firstName: " + fname + " | lastName: " + lname);
        }

        static void plusNum(int x, int y)
        {
            int result = x + y;
            Console.WriteLine($"\n{x} + {y} = {result}");
        }

        static void plusNum(double x, double y)
        {
            double result = x + y;
            Console.WriteLine($"{x} + {y} = {result:f2}\n");
        }

    }
}
