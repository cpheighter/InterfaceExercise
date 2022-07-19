using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle : ICompany
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }   

        public void PrintInfo();
        public virtual void PrintVehicleInfo()
        {
            Console.WriteLine($"This {Name} has {NumberOfWheels} wheels, {NumberOfDoors} doors, {NumberOfSeats} seats, and cost {Price}");
        }
    }
}
