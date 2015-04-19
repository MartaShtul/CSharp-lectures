using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public static class Extention
    {
        public static int[] SortByValue(this int[] array)
        {
            bool isSorted = false;
            int temp;
            while (!isSorted)
            {
                isSorted = true;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i != 0 && array[i - 1] > array[i])
                    {
                        temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;
                        isSorted = false;
                    }
                }
            }

            return array;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 2, 4, 11, 21, 23, 22, 12, 33, 5, 11, 7 };

            var newArr = arr.SortByValue();

            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }
        }
    }
}
