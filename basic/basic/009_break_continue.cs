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
            int num = 2;

            for (int i = 1; i <= 12; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                else if (i == 10) { break; }
                Console.WriteLine(num + " x " + i + " = " + num * i);
            }
        }
    }
}
