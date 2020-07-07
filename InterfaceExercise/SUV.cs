using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public int DoorCount { get; set; }
        public int WheelCount { get; set; }
        public bool IsAutomatic { get; set; }
        public double Year { get; set; }
        public string Logo { get; set; }
        public string Model { get; set; }
        public bool HasThirdRow { get; set; }
        public bool HasCargo { get; set; }

        public SUV(int doorCount, int wheelCount, bool isAutomatic, double year, string logo, string model, bool hasThirdRow, bool hasCargo)
        {
            DoorCount = doorCount;
            WheelCount = wheelCount;
            IsAutomatic = isAutomatic;
            Year = year;
            Logo = logo;
            Model = model;
            HasThirdRow = hasThirdRow;
            HasCargo = hasCargo;
        }

        public void Drive()
        {
            Console.WriteLine($"The {Model} SUV is now driving.");

        }

        public void Break()
        {
            Console.WriteLine($"The {Model} SUV is now breaking.");

        }

        public void ChangeGear()
        {
            Console.WriteLine($"The {Model} SUV is now changing gears.");

        }

        public void SUVInfo()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Logo: {Logo}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Automatic: {IsAutomatic}");
            Console.WriteLine($"WheelCount: {WheelCount}");
            Console.WriteLine($"DoorCount: {DoorCount}");
            Console.WriteLine($"Third Seat row: {HasThirdRow}");
            Console.WriteLine($"Extra Cargo Space: {HasCargo}");
            Console.WriteLine("-----------------------------------------");

        }

    }
}
