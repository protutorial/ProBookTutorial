using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int speed = 50;

            string name = "Tesla 2020";

            NewCar car = new NewCar(name, speed)
            {
                speed = 200
            };

            Console.WriteLine($"Name: {car.carName} Speed: {car.speed} ");

            Console.WriteLine(30_00_000);
        }
    }
}