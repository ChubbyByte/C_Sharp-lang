using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    internal class Program
    {
        enum userRating
        {
            poor,       // 0
            bad,        // 1
            average,    // 2
            good,       // 3
            great       // 4
        }
        static void Main(string[] args)
        {
            Console.Write("Please enter your rating: ");
            string rating = Console.ReadLine();

            userRating myRating;
            if (Enum.TryParse(rating, out myRating))
            {
                Console.WriteLine("Score Rating = {0}", myRating);
                Console.WriteLine("Score Rating = {0}\n", (int)myRating);
            }
            else
            {
                Console.WriteLine("Invalid rating");
            }

            Console.WriteLine("Score Rating = {0}", userRating.poor);
            Console.WriteLine("Score Rating = {0}", (int)userRating.poor);
        }
    }
}

