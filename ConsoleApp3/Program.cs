using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USRS_2_Gurskii
{
    class Program
    {
        public static double a, b;
        static void Main(string[] args)
        {
            Do();
            {
                if (a > b && a > 10)
                {
                    Console.WriteLine("True"); //sorry , что опоздал, я сделал давно. отправлял по почте, так как на гит не получалось залить, были проблемы с этим
                }
                else
                {
                    Console.WriteLine("False");
                }
                if (a < b || a < 10)
                {
                    Console.WriteLine("True");
                }
                else
                {
                    Console.WriteLine("False");
                }
            }
        }
        static void Do()
        {
            Console.WriteLine("введите первое число");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("введите второе число");
            b = double.Parse(Console.ReadLine());
        }
    }
}
