using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string A = Console.ReadLine();
                int B = int.Parse(A);


                if (B % 2 == 0)
                    Console.WriteLine("Вы ввели четное число");
                else
                {
                    Console.WriteLine("Вы ввели нечетное число");
                }
            }
            Console.ReadLine();
            }
            
        }
    }

