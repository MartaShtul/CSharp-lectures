using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Введите количество отработанных лет");
                string number = Console.ReadLine();
                int value = int.Parse(number);
                int zp = 1000;


                if (value >= 0 && value < 5)
                {
                    Console.WriteLine(zp * 0.10 + zp);

                }
                else if (value >= 5 && value < 10)
                {
                    Console.WriteLine(zp * 0.15 + zp);
                }
                else if (value >= 10 && value < 15)
                {
                    Console.WriteLine(zp * 0.25 + zp);
                }
                else if (value >= 15 && value < 20)
                {
                    Console.WriteLine(zp * 0.35 + zp);
                }
                else if (value >= 20 && value < 25)
                {
                    Console.WriteLine(zp * 0.45 + zp);
                }
                else if (value >= 25)
                {
                    Console.WriteLine(zp * 0.50 + zp);
                }

                else
                {
                    Console.WriteLine("Вы ввели не правильное число");
                }

            }
        }
    }
}
