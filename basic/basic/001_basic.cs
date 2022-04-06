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
            //Console.Write("enter name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Your name = {name}");

            int x = 2;
            int y = 1;
            int z = x + y;
            float a = 1.5f;
            double b = 3.5;
            char e = 'Z';
            bool status = true;

            Console.WriteLine("x = {0}, y = {1}, z = {2}", x, y, z);
            Console.WriteLine(a + b);

            int c = (int)a;
            Console.WriteLine(c);

            float d = (float)x;
            Console.WriteLine("d = {0}", d);

            Console.WriteLine($"x --> {x.GetType()}");
            Console.WriteLine($"d --> {d.GetType()}");

            d = 333;
            Console.WriteLine($"d = {d}");

            const int m = 3;
            Console.WriteLine($"m = {m}");
            //m = m++; // error

            //Console.Read()      --> อ่านค่าตัวอักษรจากคีย์บอร์ด
            //Console.ReadKey();  --> Obtains the next character or function key pressed by the user.
            //Console.ReadLine(); --> Reads the next line of characters from the standard input stream.

            //string format
            int num = 12000;
            Console.WriteLine($"num = {num}");
            Console.WriteLine($"num = {num:N0}");   // N0 - number format
            Console.WriteLine($"num = {num:N3}");
            Console.WriteLine($"num = {num:e}");
            Console.WriteLine($"num = {num:f2}");
            Console.WriteLine($"num = {num:F4}");
            Console.WriteLine($"num = {num:g}");
            Console.WriteLine($"num = {num:p3}");   // percent
            Console.WriteLine($"num = {num:x}");    // ฐาน 16

            //Math
            int xx = 3; float yy = 1.6f;
            Console.WriteLine($"Math.PI = {Math.PI}");
            Console.WriteLine($"Math.Sqrt({xx}) = {Math.Sqrt(xx)}");
            Console.WriteLine($"Math.Pow = {Math.Pow(2, 3)}");
            Console.WriteLine($"Math.Abs = {Math.Abs(-3)}");
            Console.WriteLine($"Math.Round = {Math.Round(yy)}");
            Console.WriteLine($"Math.Ceiling = {Math.Ceiling(yy)}");
            Console.WriteLine($"Math.Floor = {Math.Floor(yy)}");

        }
    }
}
