using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MyMatrix
    {
        public int Columns { get; set; }
        public int Rows { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var matr = new MyMatrix();
            matr.Columns = 10;
            matr.Rows = 20;

            for (int i = 0; i < matr.Columns; i++)
            {
                for (int r = 0; r < matr.Rows; r++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
