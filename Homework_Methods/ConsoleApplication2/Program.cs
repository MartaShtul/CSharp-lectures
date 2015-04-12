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

            Console.WriteLine("Введите знак арифметической операции");
            string sign = Console.ReadLine();

            Console.WriteLine("Введите любое число");
            string a = Console.ReadLine();
            int D = int.Parse(a);

            Console.WriteLine("Введите второе любое число");
            string b = Console.ReadLine();
            int C = int.Parse(b);

            switch (sign)
            {

                case "+":
                    {
                        int c = Add(D, C);
                        Console.WriteLine(c);
                        break;
                    }
                case "-":
                    {
                        int y = Sub(D, C);
                        Console.WriteLine(y);
                        break;
                    }
                case "*":
                    {
                        int i = Mul(D, C);
                        Console.WriteLine(i);
                        break;
                    }
                case "/":
                    {

                        if (C == 0)
                        {
                            Console.WriteLine("Нельзя делить на ноль");
                        }
                        else
                        {
                            double h = Div(D, C);
                            Console.WriteLine(h);
                        }
                        break;

                    }
                default:
                    {
                        Console.WriteLine("Введен не правильный арифметический знак");
                        break;
                    }

            }


            Console.ReadLine();
        }


        static int Add(int a, int b)
        {

            return a + b;
        }

        static int Mul(int a, int b)
        {
            return a * b;
        }

        static int Sub(int a, int b)
        {
            return a - b;
        }

        static double Div(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Нельзя делить на ноль");
                return 0; 
            }
            else
            {
                return a / b;
            }
        }
    }
}

