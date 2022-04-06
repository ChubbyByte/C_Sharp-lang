using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    internal class Program
    {
        // Global variables -> can work anywere
        static double balance = 999;
        static void Main(string[] args)
        {
            // Local variables
            double balance2 = 1250;
            Console.WriteLine($"balance1 = {balance}");
            Console.WriteLine($"balance2 = {balance2}");
            myAcc();
            deposite(1001);
            myAcc();
        }

        static void myAcc()
        {
            Console.WriteLine($"Money = {balance}");
        }

        static void deposite(double amount)
        {
            //double amount = 5001;
            Console.WriteLine("Amount = {0}", amount);
            balance += amount;
        }
    }
}

