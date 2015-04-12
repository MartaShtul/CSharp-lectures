using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array1=new int[45];
            int[] Array2=Method(Array1, 34);
            Console.WriteLine(Array2.Length);
            Console.WriteLine(Array2[45]);
            Console.ReadLine();
        }
        static int[] Method(int[] array, int value)
        {
            int[] NewArray = new int[array.Length + 1];
            for (int i = 0; i < NewArray.Length; i++)
            {
                if (i < array.Length)
                {
                    NewArray[i] = array[i];
                }
                else 
                {
                    NewArray[i] = value;
                }
            }
            return NewArray;
        }
    }
}
