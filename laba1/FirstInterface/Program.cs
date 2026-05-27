using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

using System.Collections;
using System.Numerics;
public class FirstInterface
{
    public static void Main(string[] args)
    {
        Car car = new Car(0);

        int fuel = int.Parse(Console.ReadLine());
        if (car.Refuel(fuel))
        {
            car.Drive();
        }
    }
    public interface IVeicle
    {
        void Drive();
        bool Refuel(int amount);
    }
    public class Car : IVeicle
    {
        public int Fuel { get; set; }

        public Car(int fuel)
        {
            Fuel = fuel;
        }
        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Driving");
            }
            else
            {
                Console.WriteLine("Not fuel");
            }
        }

        public bool Refuel(int refuel)
        {
            Fuel = refuel;
            return true;
        }

    }
}