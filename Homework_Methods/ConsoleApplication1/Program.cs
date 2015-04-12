using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите конвертируемое число");
            string sign = Console.ReadLine();
            double a = double.Parse(sign);

            Console.WriteLine("Введите курс валют");
            string money = Console.ReadLine();
            double b = double.Parse(money);

            double result = Mul(a,b);
            Console.WriteLine(result);
           
            Console.ReadLine();
        }

        static double Mul (double a, double b)
        {
            return a * b;
        }
    }
}
