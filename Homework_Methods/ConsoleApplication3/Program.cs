using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите любое число");
            string sign = Console.ReadLine();
            int result = int.Parse(sign);

            Number(result);
            NewNumber(result);
            bool IsPrime=Module(result);
            if (IsPrime)
            { Console.WriteLine("Число является простым"); }
            else
            { Console.WriteLine("Число не является простым"); }
            Console.WriteLine();
            Console.ReadLine();
        }

        
        static void Number(int a)
        {
            
            if (a < 0)
            {
                Console.WriteLine("Вы ввели отрицательное число");

            }
            else
            {
                Console.WriteLine("Вы ввели положительное число");
            }
        }

        static void NewNumber(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("число делится на 2 без остатка");
            }
            else
            {
                Console.WriteLine("число делится на 2 с остатком");
            }
            if (a % 5 == 0)
            {
                Console.WriteLine("число делится на 5 без остатка");
            }
            else
            {
                Console.WriteLine("число делится на 5 с остатком");
            }
            if (a % 3 == 0)
            {
                Console.WriteLine("число делится на 3 без остатка");
            }
            else
            {
                Console.WriteLine("число делится на 3 с остатком");
            }
            if (a % 6 == 0)
            {
                Console.WriteLine("число делится на 6 без остатка");
            }
            else
            {
                Console.WriteLine("число делится на 6 с остатком");
            }
            if (a % 9 == 0)
            {
                Console.WriteLine("число делится на 9 без остатка");
            }
            else
            {
                Console.WriteLine("число делится на 9 с остатком");
            }
        }

        static bool Module(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }       
    }
}


