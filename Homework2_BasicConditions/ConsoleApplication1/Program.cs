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
            while (true)
            {

                Console.WriteLine("Введите число от 0 до 100");
                string number = Console.ReadLine();
                int value = int.Parse(number);



                if (value >= 0 && value <= 14)
                {
                    Console.WriteLine("Введенное число находится в диапазоне 0-14");
                   
                }
                else if (value >= 15 && value <= 35)
                {
                    Console.WriteLine("Введенное число находится в диапазоне 15-35");
                }
                else if (value >= 36 && value <= 50)
                {
                    Console.WriteLine("Введенное число находится в диапазоне 36-50");
                }
                else if (value >= 51 && value <= 100)
                {
                    Console.WriteLine("Введенное число находится в диапазоне 50-100");
                }
                else
                { 
                    Console.WriteLine("Вы ввели не правильное число");
                }

            }
        }

    }
}
