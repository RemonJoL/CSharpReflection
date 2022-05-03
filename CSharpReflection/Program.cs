using System;
using System.Collections.Generic;

namespace CSharpReflection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var cars = new List<Car> { };

            cars.Add(new Car("Corvega", "Atomic V-8", "h1513-vh41", 2072, 50000));
            cars.Add(new Car("Corvega", "Blitz", "i8535-fj87", 2075, 55000));
            cars.Add(new Car("Chryslus Motors", "Cherry Bomb", "p8616-ph98", 2077, 80000));

            foreach(Car car in cars)
            {
                Console.WriteLine(car.ToString());
            }

            Console.ReadLine();
        }
    }
}

