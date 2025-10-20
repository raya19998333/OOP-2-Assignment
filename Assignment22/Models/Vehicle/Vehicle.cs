using Assignment22.Models.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22.Models.Vehicle
{
     class Vehicle
    {
        protected string make;
        protected string model;
        protected int year;
        public Vehicle(string make, string model, int year)
        {
            this.make = make;
            this.model = model;
            this.year = year;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Make: {make}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Year: {year}");
        }
    }
}
class Car : Vehicle
{
    private int NumberOfDoors;
    public Car(string make, string model, int year, int numberOfDoors)
        : base(make, model, year)
    {
        this.NumberOfDoors = numberOfDoors;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Number of Doors: {NumberOfDoors}");
    }


};

//class Truck : Vehicle
class Truck : Vehicle
{
    private double LoadCapacity;
    public Truck(string make, string model, int year, double loadCapacity)
        : base(make, model, year)
    {
        this.LoadCapacity = loadCapacity;
    }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Load Capacity: {LoadCapacity} tons");
    }
}