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
            int lenght = 10, width = 5;
            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < lenght; i++)
                {
                    if (j == 0 || j == width - 1) Console.Write("*");
                    else if (i == 0 || i == lenght - 1) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }

            int Height = 6;
            int h = 2 * Height - 1;
            int w = 1;
            for (int i = 0; i < h; i++)
            {

                for (int j = 0; j < w; j++)
                {
                    Console.Write("*");
                }
                if (i < Height - 1)
                    w++;
                else
                    w--;
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
