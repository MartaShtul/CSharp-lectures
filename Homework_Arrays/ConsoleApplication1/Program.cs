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
            Console.WriteLine("Введите размер массива");

            string arrayLength = Console.ReadLine();

            int n = int.Parse(arrayLength);

            int[] array = new int[n];
            var random=new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 1000);
            }

            int maxValue = array.Max();
            int minValue = array.Min();
            int sumValue = array.Sum();
            double avgValue = array.Average();

            Console.WriteLine("Максимальное число массива {0}", maxValue);
            Console.WriteLine("Минимальное число массива {0}", minValue);
            Console.WriteLine("Сумма чисел массива {0}", sumValue);
            Console.WriteLine("Среднее арифметическое {0}", avgValue);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine(array[i]);
                }
                
            }

            Console.ReadKey();
        }
    }
}
