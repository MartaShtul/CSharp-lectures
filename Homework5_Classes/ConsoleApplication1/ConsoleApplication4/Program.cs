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
            Converter myCOnvert = new Converter(5.0, 8.0, 0.005);

            Console.WriteLine("100 EUR is : {0} UAH", myCOnvert.EurToUah(100));
            Console.WriteLine("100 USD is : {0} UAH", myCOnvert.UsdToUah(100));
            Console.WriteLine("100 RUB is : {0} UAH", myCOnvert.RubToUah(100));
            Console.WriteLine("100 UAH is : {0} USD", myCOnvert.UahToUsd(100));
            Console.WriteLine("100 UAH is : {0} EUR", myCOnvert.UahToEur(100));
            Console.WriteLine("100 UAH is : {0} RUB", myCOnvert.UahToRub(100));

            Console.ReadLine();
        }
    }

    class Converter
    {
        double _usd;
        double _eur;
        double _rub;

        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }

        public double UsdToUah(double usd)
        {
            return usd * _usd;
        }

        public double UahToUsd(double uah)
        {
            return uah / _usd;
        }

        public double EurToUah(double eur)
        {
            return eur * _eur;
        }

        public double UahToEur(double uah)
        {
            return uah / _eur;
        }

        public double RubToUah(double rub)
        {
            return rub * _rub;
        }

        public double UahToRub(double uah)
        {
            return uah / _rub;
        }
    }
}
