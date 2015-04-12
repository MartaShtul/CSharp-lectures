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
            int x = 5, y = 10, z = 15;
            x += y >> x++ * z;
            Console.WriteLine("{0}, {1}, {2}", x, y, z);

            x = 5; y = 10; z = 15;
            z = ++x & y * 5;
            Console.WriteLine("{0}, {1}, {2}", x, y, z);

            x = 5; y = 10; z = 15;
            y /= x + 5 | z;
            Console.WriteLine("{0}, {1}, {2}", x, y, z);

            x = 5; y = 10; z = 15;
            z = x++ & y * 5;
            Console.WriteLine("{0}, {1}, {2}", x, y, z);

            x = 5; y = 10; z = 15;
            x = y << x++ ^ z;
            Console.WriteLine("{0}, {1}, {2}", x, y, z);
            Console.ReadLine();
        }
    }
}
