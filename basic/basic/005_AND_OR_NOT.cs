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
            string gender = "male";
            int height = 160;

            //AND &&
            if (gender == "male" && height >= 160)
            {
                Console.WriteLine("Pass");
            }
            else
            {
                Console.WriteLine("Not pass");
            }


            //OR ||
            gender = "female"; height = 159;
            if (gender == "female" || height >= 160)
            {
                Console.WriteLine($"Not male!, but have {height:f1} (cm) --> Pass");
            }
            else
            {
                Console.WriteLine($"male!, and have {height:f1} (cm) --> Not pass");
            }

            //NOT !
            gender = "female"; height = 160;
            if (gender != "male" && height == 160)
            {
                Console.WriteLine("you are female");
            }

        }
    }
}
