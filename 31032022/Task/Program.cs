using Interfaces;
using Models;
using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Drive(20);
            car.Drive(10);

            Console.WriteLine(car.Millage);

            VehicleStore vehicleStore = new VehicleStore();

            vehicleStore.Products = new Product[] { car, new Bicycle(), new Car() };
        }
    }
}
