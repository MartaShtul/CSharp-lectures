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
            Point one = new Point(3, 5, "A");
            Point two = new Point(10, 12, "B");
            Point thre = new Point(16, 18, "C");
            Point four = new Point(0, 4, "D");
            Point five = new Point(20, 15, "E");

            Figure triangle = new Figure(one, two, thre);
            Figure quad = new Figure(one, two, thre, four);
            Figure fiveangle = new Figure(one, two, thre, four, five);

            triangle.Perimeter();

            quad.Perimeter();

            fiveangle.Perimeter();

            Console.ReadLine();
        }
    }

    class Point
    {
        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }

        public int X { get; private set; }

        public int Y { get; private set; }

        public string Name { get; private set; }
    }

    class Figure
    {
        Point _a;
        Point _b;
        Point _c;
        Point _d;
        Point _e;

        public Figure(Point a, Point b, Point c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public Figure(Point a, Point b, Point c, Point d)
            : this (a, b, c)
        {
          _d = d;
        }

        public Figure(Point a, Point b, Point c, Point d, Point e)
            : this(a, b, c, d)
        {
            _e = e;
        }

        private double GetLength(Point a, Point b)
        {
            double first = a.X > b.X ? a.X - b.X : b.X - a.X;
            double second = a.Y > b.Y ? a.Y - b.Y : b.Y - a.Y;

            return Math.Sqrt(first * first + second * second);
        }

        public void Perimeter()
        {
            string name;
            double perimeter;

            if (_e != null)
            {
                name = "PIATIUGOLNIK";
                perimeter = GetLength(_a, _b) + GetLength(_b, _c) + GetLength(_c, _d) + GetLength(_d, _e) + GetLength(_e, _a);
            }
            else if (_d != null)
            {
                name = "CHETIREHUGOLNAK";
                perimeter = GetLength(_a, _b) + GetLength(_b, _c) + GetLength(_c, _d) + GetLength(_d, _a);
            }
            else
            {
                name = "TREHUGOLNAK";
                perimeter = GetLength(_a, _b) + GetLength(_b, _c) + GetLength(_c, _a);
            }

            Console.WriteLine("Name :{0} , Perimeter : {1}", name, perimeter);
        }
    }
}
