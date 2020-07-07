using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public int DoorCount { get; set; }
        public int WheelCount { get; set; }
        public bool IsAutomatic { get; set; }
        public double Year { get; set; }
        public string Logo { get; set; }
        public string Model { get; set; }
        public bool HasTrunkSpace { get; set; }
        public bool HasTwoSeats { get; set; }

        public Car(int doorCount, int wheelCount, bool isAutomatic, double year, string logo, string model, bool hasTrunkSpace, bool hasTwoSeats)
        {
            DoorCount = doorCount;
            WheelCount = wheelCount;
            IsAutomatic = isAutomatic;
            Year = year;
            Logo = logo;
            Model = model;
            HasTrunkSpace = hasTrunkSpace;
            HasTwoSeats = hasTwoSeats;
        }

        public void Drive()
        {
            Console.WriteLine($"The {Model} is now driving.");
        }

        public void Break()
        {
            Console.WriteLine($"The {Model} is now breaking.");

        }

        public void ChangeGear()
        {
            Console.WriteLine($"The {Model} is changing gears.");

        }

        public void CarInfo()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Logo: {Logo}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Automatic: {IsAutomatic}");
            Console.WriteLine($"WheelCount: {WheelCount}");
            Console.WriteLine($"DoorCount: {DoorCount}");
            Console.WriteLine($"Trunkspace: {HasTrunkSpace}");
            Console.WriteLine($"Two-Seater: {HasTwoSeats}");
            Console.WriteLine("-----------------------------------------");

        }

    }
}
