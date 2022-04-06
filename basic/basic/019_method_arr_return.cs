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
            int[] pointMath = { 60, 50, 80, 100 };
            int[] pointEnglish = { 50, 50, 70, 10 };

            Console.Write("Math = ");
            showData(pointMath);

            Console.Write("English = ");
            showData(pointEnglish);

            Console.WriteLine("Max point Math = " + getMax(pointMath));
            Console.WriteLine("Max point English = " + getMax(pointEnglish));
        }

        static void showData(int[] point)
        {
            Console.Write("{ ");
            for (int i = 0; i < point.Length; i++)
            {
                if (i != point.Length - 1)
                {
                    Console.Write(point[i] + ", ");
                }
                else
                {
                    Console.Write(point[i]);
                }
            }
            Console.Write("}\n");
        }

        static int getMax(int[] max)
        {
            int maxPoint = 0;
            for (int i = 0; i < max.Length; i++)
            {
                if (max[i] > maxPoint)
                {
                    maxPoint = max[i];
                }
            }
            return maxPoint;
        }
    }
}

