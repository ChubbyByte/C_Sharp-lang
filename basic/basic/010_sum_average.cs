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
            int sum = 0, avg = 0;

            //for (int count = 1; count <= 5; count++)
            //{
            //    Console.Write("Enter a number: ");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    sum += num;
            //}
            //Console.WriteLine("The sumation is: " + sum);
            //avg = sum / 5;
            //Console.WriteLine("The average is: " + avg);

            while (true)
            {
                int num;
                Console.Write("Enter a number: ");
                int.TryParse(Console.ReadLine(), out num);
                if (num == 0) break;
                sum += num;
            }
            Console.WriteLine("The sumation is: " + sum);
            avg = sum / 5;
            Console.WriteLine("The average is: " + avg);
        }
    }
}
