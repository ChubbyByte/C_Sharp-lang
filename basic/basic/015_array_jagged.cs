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
            // Jagged Array :: arr ซ้อน arr :: จำนวน element แต่ละ arr(ย่อย) เท่ากัน หรือ ต่างกัน ได้

            string[][] name = new string[3][];                  // row ขนาด 4 :: column ไม่ระบุขนาด
            name[0] = new string[1] { "John" };                 // row 0 -> 1 ตัว
            name[1] = new string[3] { "Mary", "Jane", "Mark" }; // row 1 -> 3 ตัว
            name[2] = new string[2] { "Peter", "Paul" };        // row 2 -> 2 ตัว
            for (int row = 0; row < name.Length; row++)
            {
                for (int col = 0; col < name[row].Length; col++)
                {
                    Console.Write($"name[{row}][{col}] = {name[row][col]} \t");
                }
                Console.WriteLine("\n");
            }


            //ลดรูป (Ternary) + ไม่ระบุ element แต่ละแถว
            string[][] color = {
                new string[] { "Red", "Green" },
                new string[] { "Yellow", "Orange", "Pink" },
                new string[] { "Black" }
            };

            foreach (string[] row in color)
            {
                foreach (string col in row)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
