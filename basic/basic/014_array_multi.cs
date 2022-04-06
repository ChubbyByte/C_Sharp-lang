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
            string[,] name = new string[2, 2];
            name[0, 0] = "John";
            name[0, 1] = "Jenny";
            name[1, 0] = "Mary";
            name[1, 1] = "Mark";
            Console.WriteLine(name[0, 0]);
            Console.WriteLine("{0} {1}", name[0, 0], name[0, 1]);
            Console.WriteLine("{0} {1}", name[1, 0], name[1, 1]);
            Console.WriteLine();

            int[,] number = new int[2, 3] {
                { 1, 2, 3 },
                { 4, 5, 6 }
            };
            Console.WriteLine($"column = {number.GetLength(0)}");  //find length of row
            Console.WriteLine($"row = {number.GetLength(1)}");     //find length of column
            Console.WriteLine($"element = {number.Length}");          //find length of array
            Console.WriteLine(number[0, 2]);
            Console.WriteLine(number[1, 0]);
            number[1, 2] = 99;
            foreach (var item in number)
            {
                if (item == number.GetLength(0) + 1)    //item start @index[1] | number start @index[0]
                {
                    Console.WriteLine(item);
                }
                else
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine("\n");

            string[,] color = {
                { "red", "green", "blue" },
                { "yellow", "orange", "purple" },
                { "black", "white", "brown" }
            };
            for (int row = 0; row < color.GetLength(0); row++)        //GetLength(0) = ขนาด row
            {
                for (int col = 0; col < color.GetLength(1); col++)    //GetLength(1) = ขนาด column
                {
                    Console.Write($"color[{row}][{col}] = {color[row, col]}\t");
                }
                Console.WriteLine("\n");
            }

        }
    }
}
