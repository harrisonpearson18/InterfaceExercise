using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var Sedan = new Car(2, 4, true, 2000, "Das Auto", "Volkswagen", true, false);
            var Sedan2 = new Car(2, 4, true, 2000, "Das Auto", "Volkswagen", true, false);
            var Sedan3 = new Car(2, 4, true, 2000, "Das Auto", "Volkswagen", true, false);
            var Sedan4 = new Car(2, 4, true, 2000, "Das Auto", "Volkswagen", true, false);
            var Ford = new Truck(4, 4, true, 2000, "Built Ford Tough", "Ford", true, true);
            var Ford2 = new Truck(4, 4, true, 2000, "Built Ford Tough", "Ford", true, true);
            var Ford3 = new Truck(4, 4, true, 2000, "Built Ford Tough", "Ford", true, true);
            var Ford4 = new Truck(4, 4, true, 2000, "Built Ford Tough", "Ford", true, true);
            var GMC = new SUV(4, 4, true, 2000, "Like a Pro", "GMC", false, true);
            var GMC2 = new SUV(4, 4, true, 2000, "Like a Pro", "GMC", false, true);
            var GMC3 = new SUV(4, 4, true, 2000, "Like a Pro", "GMC", false, true);
            var GMC4 = new SUV(4, 4, true, 2000, "Like a Pro", "GMC", false, true);

            var carList = new List<IVehicle>();
            carList.Add(Sedan);
            carList.Add(Sedan2);
            carList.Add(Sedan3);
            carList.Add(Sedan4);

            carList.Add(Ford);
            carList.Add(Ford2);
            carList.Add(Ford3);
            carList.Add(Ford4);

            carList.Add(GMC);
            carList.Add(GMC2);
            carList.Add(GMC3);
            carList.Add(GMC4);


            /////
            Sedan.Drive();
            Sedan.ChangeGear();
            Sedan.Break();
            /////
            Ford.Drive();
            Ford.ChangeGear();
            Ford.Break();
            /////
            GMC.Drive();
            GMC.ChangeGear();
            GMC.Break();
            /////
            Sedan.CarInfo();
            Ford.TruckInfo();
            GMC.SUVInfo();
            ///

            foreach(IVehicle item in carList)
            {
                Console.WriteLine($"-------------------");
                Console.WriteLine($"Model: {item.Model}");
                Console.WriteLine($"Year: {item.Year}");
                Console.WriteLine($"Logo: {item.Logo}");
                Console.WriteLine($"Automatic: {item.IsAutomatic}");
                Console.WriteLine($"WheelCount: {item.WheelCount}");
                Console.WriteLine($"DoorCount: {item.DoorCount}");
                Console.WriteLine($"-------------------");
            }
        }
    }
}
