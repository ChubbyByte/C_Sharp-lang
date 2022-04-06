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
            //ลดรูป Ternary Operator
            int point = 50; string result;
            /*
            if (point >= 50)
            {
                result = "Pass";
            }
            else
            {
                result = "Fail";
            }
            */
            result = (point >= 50) ? "Pass" : "Fail";
            Console.WriteLine("Status = {0}", result);

        }
    }
}
