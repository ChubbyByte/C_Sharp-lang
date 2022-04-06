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
            int[] pointScience = { 50, 50, 65, 10, 30 };
            int[] copyPoint = copyArray(pointScience);

            Console.Write("copyArray = ");
            foreach (int i in copyPoint)
            {
                if (i != copyPoint.Last())
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

        }

        static int[] copyArray(int[] originalArr)
        {
            int[] newArr = new int[originalArr.Length];     // copy the length of the original array
            for (int i = 0; i < originalArr.Length; i++)    // run throught each element in array
            {
                newArr[i] = originalArr[i];                 // copy each element
            }
            return newArr;                                  // return the new array
        }
    }
}

