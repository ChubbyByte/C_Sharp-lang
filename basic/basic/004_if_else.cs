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
            int score;

            // if statement
            Console.Write("Enter a score: ");
            int.TryParse(Console.ReadLine(), out score);

            if (score >= 80)
            {
                if (score >= 85)
                {
                    Console.WriteLine("A+");
                }
                else if (score < 85)
                {
                    Console.WriteLine("A");
                }
            }
            else if (score >= 70)
            {
                Console.WriteLine("B");
            }
            else if (score >= 60)
            {
                Console.WriteLine("C");
            }
            else if (score >= 50)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
