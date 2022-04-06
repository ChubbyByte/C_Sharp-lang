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
            string myIP = getIP(); //127.0.0.1
            Console.WriteLine("My IP = " + myIP + "\n");


            Console.Write("Enter a number: ");
            int num = int.TryParse(Console.ReadLine(), out num) ? num : 0;
            bool even_odd = checkNum(num);
            if (even_odd == true)
            {
                Console.WriteLine($"{num} = Even Number\n");
            }
            else
            {
                Console.WriteLine($"{num} = Odd Number\n");
            }



            int x = getMax(1, 3);
            Console.WriteLine($"Max = {x}\n");


            int[] arr = new int[2];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter a number[{i + 1}]: ");
                arr[i] = int.TryParse(Console.ReadLine(), out arr[i]) ? arr[i] : 0;
                //Console.WriteLine(arr[i].GetType());

                if (i == arr.Length - 1)
                {
                    getSum(arr[0], arr[1]);
                }
            }
        }

        // method :: return
        static string getIP()
        {
            return "127.0.0.1";
        }

        // method :: get and return
        static bool checkNum(int x)
        {
            int number = x;
            if (number % 2 == 0) return true;
            else return false;
        }

        static int getMax(int x, int y)
        {
            return x > y ? x : y;
        }

        static void getSum(int x, int y)
        {
            if (x < 0 || y < 0)
            {
                return;
            }
            int sum = x + y;
            Console.WriteLine($"Sum = {sum}\n");
        }
    }
}

