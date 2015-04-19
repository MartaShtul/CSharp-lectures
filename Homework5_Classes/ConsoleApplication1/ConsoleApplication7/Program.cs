using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            var lada = new Car
            {
                Cost = 200,
                Created = new DateTime(1990, 2, 3),
                Speed = 68
            };

            var boeng = new Plane
            {
                Cost = 10000000,
                Created = new DateTime(2000, 1, 2),
                Height = 5000,
                Passangers = 200,
                Speed = 300
            };

            var parohod = new Ship
            {
                Cost = 10000,
                Created = new DateTime(1818, 2, 3),
                Passangers = 500,
                Port = "Havai",
                Speed = 140
            };

            lada.GetInfo();
            boeng.GetInfo();
            parohod.GetInfo();

            Console.ReadLine();
        }
    }

    class Vehicle
    {
        public double Cost { get; set; }
        public int Speed { get; set; }
        public DateTime Created { get; set; }

        public virtual void GetInfo()
        {
        }
    }

    class Car : Vehicle
    {
        public override void GetInfo()
        {
            Console.WriteLine("This is CAR, Speed is : {0}, Created in {1}, Costs {2}", Speed, Created, Cost);
        }
    }

    class Plane : Vehicle
    {
        public int Passangers { get; set; }
        public int Height { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine("This is PLANE, Speed is : {0}, Created in {1}, Costs {2}. Passangers: {3}, Max Height: {4}",
                Speed, Created, Cost, Passangers, Height);
        }
    }

    class Ship : Vehicle
    {
        public int Passangers { get; set; }
        public string Port { get; set; }


        public override void GetInfo()
        {
            Console.WriteLine("This is SHIP, Speed is : {0}, Created in {1}, Costs {2}. Passangers: {3}, Port Address: {4}",
                Speed, Created, Cost, Passangers, Port);
        }
    }
}
