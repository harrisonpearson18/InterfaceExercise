using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle : ICompany
    {
        public int DoorCount { get; set; }
        public int WheelCount { get; set; }
        public bool IsAutomatic { get; set; }
        public double Year { get; set; }
        public string Model { get; set; }

        public void Drive();

        public void Break();
        public void ChangeGear();

        public void VehicleInfo()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Automatic: {IsAutomatic}");
            Console.WriteLine($"WheelCount: {WheelCount}");
            Console.WriteLine($"DoorCount: {DoorCount}");
        }
    }
}
