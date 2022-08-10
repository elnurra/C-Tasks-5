using System;
using System.Collections.Generic;
using System.Text;

namespace TaskForInheritanceMethod.Models
{
    class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;

        
        public Car(string Color,int Year,string Brand,string Model,double FuelCapacity,double FuelFor1Km):base(Color,Year)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.FuelCapacity = FuelCapacity;
            this.FuelFor1Km = FuelFor1Km;
        }
        public Car(string Color, int Year, string Brand, string Model, int FuelCapacity, double FuelFor1Km, double CurrentFuel):this(Color,Year,Brand, Model,FuelCapacity, FuelFor1Km)
        {
           
            this.CurrentFuel = CurrentFuel;
        }
        public double Drive(double Distance) 
        {
            double ReqGasoline = Distance * FuelFor1Km;
             
            if (FuelCapacity >= CurrentFuel && CurrentFuel >= ReqGasoline) 
            {
                
                return CurrentFuel - ReqGasoline;
            }
            else if (FuelCapacity<CurrentFuel) 
            {
                Console.Write("Current fuel cannot be more than capacity");

                return FuelCapacity; 
            }
            else 
            {

                Console.Write("It will be stopped cause it can't be continue driving: " );
                return CurrentFuel;
            }

            
        } 
        public void ShowInfo() 
        {
            Console.WriteLine(Brand+  " " + Model + " " + FuelCapacity + " " + FuelFor1Km );

        }
    }
}
