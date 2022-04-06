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
            int money;
            do
            {
                Console.Write("Input money: ");
                int.TryParse(Console.ReadLine(), out money);

            } while ((money % 100 != 0) || (money >= 20000) || (money == 0)); // เช็คจำนวนเงิน ว่า เป็น หลักหน่วย หรือ หลักสิบ หรือไม่
            Console.WriteLine("money is {0}", money);
            Console.WriteLine("1000 Baht {0}", money / 1000);
            money %= 1000;
            Console.WriteLine("500 Baht {0}", money / 500);
            money %= 500;
            Console.WriteLine("100 Baht {0}", money / 100);
        }
    }
}
