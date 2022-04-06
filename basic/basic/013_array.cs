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
            //Array ไม่ประกาศค่าเริ่มต้น --> จองพื้นที่ไว้เพื่อเก็บค่า 2 ช่อง
            int[] number = new int[3];
            number[0] = 10;
            number[1] = 20;
            number[2] = 30;
            //Console.WriteLine(number[0]);

            Console.Write("number = ");
            for (int i = 0; i < number.Length; i++)
            {
                Console.Write(number[i] + " ");
            }
            Console.WriteLine();

            //Array ประกาศ ขนาด และ จำนวนสมาชิก ภายในไว้แล้ว
            string[] letter = new string[3] { "A", "B", "C" };

            Console.Write("letter = ");
            foreach (string element in letter)  //element ต้องกำหนด ชนิดตัวแปล เหมือนกับ array letter
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            letter[0] = "Z";
            Console.WriteLine("letter[0] = " + letter[0]);
            Console.WriteLine("Array lettet = " + letter.Length + " member");

        }
    }
}
