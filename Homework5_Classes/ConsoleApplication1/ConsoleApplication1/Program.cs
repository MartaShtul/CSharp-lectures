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
            Console.WriteLine("Введите любое число");
            string a = Console.ReadLine();
            int height = int.Parse(a);
            Console.WriteLine("Введите второе любое число");
            string b = Console.ReadLine();
            int width = int.Parse(b);
            Rectangle Big = new Rectangle(height, width);
            double area = Big.AreaCalculator();
            double perimeter = Big.PerimeterCalculator();
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
            Console.ReadLine();

            //Big.SetHeight(7);

            //height = Big.GetHeight();
            double hie = Big.Height;
        }
    }

    class Rectangle
    {
        //поля
        double _height;
        double _width;

        //конструктор
        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }

        //public double GetHeight()
        //{
        //    return _height;
        //}

        //public void SetHeight(double height)
        //{
        //    _height = height;
        //}

        //property (свойство)

        public double Height
        {
            get
            {
                return _height;
            }



            //set
            //{
            //    _height = value;
            //}
        }

        public double Width
        {
            get
            {
                return _width;
            }
        }

        //метод
        public double AreaCalculator()
        {
            return _height * _width;
        }

        public double PerimeterCalculator()
        {
            return _height * 2.0 + _width * 2.0;
        }
    }
}
