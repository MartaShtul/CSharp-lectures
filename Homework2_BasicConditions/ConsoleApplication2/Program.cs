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
            int operand1 = 15;
            int operand2 = 20;


            Console.WriteLine("Введите знак арифметической операции");
            string sign = Console.ReadLine();

            switch (sign)
            {
                case "+":
                    {
                        int operand3 = operand1 + operand2;
                        Console.WriteLine(operand3);
                        break;
                    }
                case "-":
                    {
                        int operand3 = operand2 - operand1;
                        Console.WriteLine(operand3);
                        break;
                    }
                case "*":
                    {
                        int operand3 = operand1 * operand2;
                        Console.WriteLine(operand3);
                        break;
                    }
                case "/":
                    {
                        if (operand1 == 0)
                        {
                            Console.WriteLine("Нельзя делить на ноль");
                        }
                        else {
                            double operand3 = (double)operand2 / (double)operand1;
                            Console.WriteLine(operand3);
                        }
                    
                       

                        break;

                    }
                default: {
                    Console.WriteLine("Введен не правильный арифметический знак");
                    break;
                }
                    
            }
            Console.Read();
        }
    }
}
