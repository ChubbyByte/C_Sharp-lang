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
            // Data type & Casting --> Convert : TryParse : Parse : Widening(Auto) : Narrowing(Manual)

            // Convert :: str/number/bool
            string mystr = "123";

            byte mybyte = Convert.ToByte(mystr);           // byte    (0 ~ 127)
            byte mySbyte = (byte)Convert.ToSByte(mystr);   // sbyte   (-128 ~ 127)
            short myshort = Convert.ToInt16(mystr);        // short   (0 ~ 32767)
            int myint = Convert.ToInt32(mystr);            // int     (0 ~ 2147483647)
            long mylong = Convert.ToInt64(mystr);          // long    (0 ~ 9223372036854775807)
            float myfloat = Convert.ToSingle(mystr);       // float   (0 ~ 3.402823E+38)
            double mydouble = Convert.ToDouble(mystr);     // double  (0 ~ 1.7976931348623157E+308)

            Console.WriteLine($"mybyte1 = {mybyte}" + "\n" + $"mySbyte = {-mySbyte + 1}");
            Console.WriteLine($"myshort = {myshort + 1000}");
            Console.WriteLine($"myint = {myint + 7}");
            Console.WriteLine($"mydoube = {mydouble + -10.5}");

            string result = Convert.ToString(mydouble);     // double to string
            Console.WriteLine("double to string = {0}", result + 111);

            bool mybool = true;                             // boolean to String
            string myboolSTR = Convert.ToString(mybool);    // bool    (true/false)
            Console.WriteLine($"mybool    = {mybool} : {mybool.GetType()}");
            Console.WriteLine($"myboolSTR = {myboolSTR} : {myboolSTR.GetType()}\n");


            // Parse :: input(string) output number
            string x = "100";

            byte x1 = byte.Parse(x);
            int x2 = int.Parse(x);
            short x3 = short.Parse(x);

            Console.WriteLine("x1 = {0}", x1 + 1);
            Console.WriteLine("x2 = {0}", x2 + 100);
            Console.WriteLine("x3 = {0}\n", x3 + 1000);

            // TryParse
            string z = "100.15";
            Console.WriteLine("z = {0}", z);

            int myInt;
            bool checkInt = int.TryParse(z, out myInt);
            Console.WriteLine("checkInt = {0}", checkInt);
            Console.WriteLine("myInt = {0}", myInt);

            double myDouble = double.TryParse(z, out double checkDouble) ? checkDouble : 0;
            Console.WriteLine("myDouble = {0}", myDouble + 0.35);

            float myFloat;
            bool checkFloat = float.TryParse(z, out myFloat);
            Console.WriteLine("checkFloat = {0}", checkFloat);
            Console.WriteLine("myFloat = {0}\n", myFloat);




            // Widening :: (Auto) น้อย -> มาก
            float ii = 100.15f;
            double jj = ii;
            Console.WriteLine("ii = {0}", ii);
            Console.WriteLine("jj = {0}\n", jj);

            // Narrowing :: (Manual) มาก -> น้อย
            double i = 100.15;
            int j = (int)i;
            float k = (float)i;
            Console.WriteLine("i = {0}", i);
            Console.WriteLine("j = {0}", j);
            Console.WriteLine("k = {0}\n", k);




        }
    }
}
