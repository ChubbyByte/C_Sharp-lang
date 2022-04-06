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
            // while
            int i = 0;
            while (i < 3)
            {
                if (i == 2) { Console.WriteLine(i); }
                else { Console.Write(i + ", "); }
                i++;
            }

            // do while
            int j = 0;
            do
            {
                if (j == 2) { Console.WriteLine(j); }
                else { Console.Write(j + ", "); }
                j++;
            } while (j < 3);

            // for
            for (int k = 0; k < 3; k++)
            {
                if (k == 2) { Console.WriteLine(k); }
                else { Console.Write(k + ", "); }
            }

            // foreach
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            for (int x = 0; x < cars.Length; x++)
            {
                if (x < cars.Length - 1) { Console.Write(cars[x] + ", "); }
                else { Console.WriteLine(cars[x]); }
            }

            foreach (string x in cars)
            {
                Console.Write(x + " ");
            }
        }
    }
}
