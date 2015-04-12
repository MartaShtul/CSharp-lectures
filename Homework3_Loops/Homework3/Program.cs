using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5;
            int B = 19;
            for (int C = A+1; C < B; C++)
            {
                    Console.WriteLine(C);
            }
            for (int C = A + 1; C < B; C++)
            {
                if (C % 2 == 0)
                    Console.WriteLine(C);
            }
            Console.ReadLine();
        }
    }
}




