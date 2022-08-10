using System;
using TaskForInheritanceMethod.Models;

namespace TaskForInheritanceMethod
{
    class Program
    {
        static void Main(string[] args)
        {                   //string Color, int Year, string Brand, string Model, int FuelCapacity, double FuelFor1Km, double CurrentFuel
            Car car = new Car("Yellow",2014,"Chevrolet","Camaro",72,1.3,50);
            car.ShowInfo();
            
            Console.WriteLine(car.Drive(10));
        }
    }
}
