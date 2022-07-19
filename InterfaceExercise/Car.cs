using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
       public bool IsFuelEfficent { get; set; }
        public string GroundClearance { get; set; }

        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
        public int Price { get; set; }
        public string CompanyLocation { get; set; }
        public bool MakesElectricCar { get; set; }
        public string Name { get; set; }

        public void PrintInfo()
        {
            if (IsFuelEfficent == true)
            {
                Console.WriteLine($"This car is fuel efficent");
            }
            else
            {
                Console.WriteLine($"This car is NOT fuel efficent");
            }
            Console.WriteLine($"The ground clearance of this car is {GroundClearance}");
        }
    }
}
