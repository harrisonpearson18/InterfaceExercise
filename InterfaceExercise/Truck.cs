using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public int DoorCount { get; set; }
        public int WheelCount { get; set; }
        public bool IsAutomatic { get; set; }
        public double Year { get; set; }
        public string Logo { get; set; }
        public string Model { get; set; }
        public bool HasTruckBed { get; set; }
        public bool IsFourWheel { get; set; }

        public Truck(int doorCount, int wheelCount, bool isAutomatic, double year, string logo, string model, bool hasTruckBed, bool isFourWheel)
        {
            DoorCount = doorCount;
            WheelCount = wheelCount;
            IsAutomatic = isAutomatic;
            Year = year;
            Logo = logo;
            Model = model;
            HasTruckBed = hasTruckBed;
            IsFourWheel = isFourWheel;
        }



        public void Drive()
        {
            Console.WriteLine($"The {Model} truck is now driving.");
        }

        public void Break()
        {
            Console.WriteLine($"The {Model} truck is now breaking.");

        }

        public void ChangeGear()
        {
            Console.WriteLine($"The {Model} truck is now changing gears.");

        }

        public void TruckInfo()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Logo: {Logo}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Automatic: {IsAutomatic}");
            Console.WriteLine($"WheelCount: {WheelCount}");
            Console.WriteLine($"DoorCount: {DoorCount}");
            Console.WriteLine($"Truckbed: {HasTruckBed}");
            Console.WriteLine($"Four Wheel Drive: {IsFourWheel}");
            Console.WriteLine("-----------------------------------------");

        }
    }
}
