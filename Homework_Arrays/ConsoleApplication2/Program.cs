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
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            Displayer(array);
            array = MyReverse(array);
            Displayer(array);
            array = SubArray(array,7,5);
            Displayer(array);
            Console.ReadLine();
        }

        static int[] MyReverse(int[] array)
        {
            int[] reversedArray = new int[array.Length];
            for (int i = array.Length; i >= 1; i--)
            {
                reversedArray[array.Length - i] = array[i - 1];
            }
            return reversedArray;
        }

        static void Displayer(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static int[] SubArray(int[] array, int index, int count)
        {
            int[] Partial = new int[count];
            for (int i = 0; i < count; i++)
            {
                int number = index + i;
                if (number < array.Length)
                {
                    Partial[i] = array[number];
                }
                else
                {
                    Partial[i] = 1;
                }
            }
            return Partial;
        }
    }
}

