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
            int min = int.MaxValue, max = 0;
            while (true)
            {
                int num;
                Console.Write("Enter a number: ");
                int.TryParse(Console.ReadLine(), out num);
                if (num <= 0) break;
                if (num > max) max = num;
                if (num < min) min = num;
            }
            Console.WriteLine("Max: {0}", max);
            Console.WriteLine("Min: {0}", min);

        }
    }
}
