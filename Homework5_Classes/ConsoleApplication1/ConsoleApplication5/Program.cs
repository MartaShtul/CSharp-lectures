using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice myInvo = new Invoice("Moriarti");
            myInvo.Article = "Pistols";
            myInvo.Quontity = 10;
            myInvo.PricePerUnit = 299.99;

            Console.WriteLine("With NDS: {0}, Without NDS: {1}", myInvo.GetFullPrice(true), myInvo.GetFullPrice(false));

            Console.ReadLine();
        }
    }

    class Invoice
    {
        public Invoice(string account)
        {
            Account = account;
        }

        public string Account { get; private set; }

        public int Quontity { get; set; }
        public double PricePerUnit { get; set; }
        public string Article { get; set; }

        public double GetFullPrice(bool withNDS)
        {
            if (withNDS)
            {
                return (double)Quontity * PricePerUnit * 1.20;
            }
            else
            {
                return (double)Quontity * PricePerUnit;
            }
        }
    }
}
