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
            //IndexOutOfRangeException
            try
            {
                int[] score = { 10, 20, 30 };
                Console.WriteLine(score[1]);
                Console.WriteLine(score[100]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("try...catch...finished!\n");
            }

            //DivideByZeroException
            try
            {
                int x = 50, y = 0;
                Console.WriteLine(x / y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\n");
            }

            //FormatException : Input string was not in a correct format
            try
            {
                Console.Write("input number: ");
                string input = Console.ReadLine();
                int number = int.Parse(input) * 10;
                Console.WriteLine($"{number} * 10 = " + number);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Invalid input format");
                Console.WriteLine(e.Message + "\n");
            }

        }
    }
}

