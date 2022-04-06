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
            //BMI
            double weight, height, bmi;

            Console.Write("Enter your weight (kg): ");
            double.TryParse(Console.ReadLine(), out weight);

            Console.Write("Enter your height (meter): ");
            double.TryParse(Console.ReadLine(), out height);

            bmi = weight / Math.Pow(height, 2);
            Console.WriteLine($"Your BMI is: {bmi:F2}");

        }
    }
}
