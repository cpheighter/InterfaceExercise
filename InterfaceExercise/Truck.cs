using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public bool UsesDiesel { get; set; }
        public bool IsManuel { get; set; }

        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
        public int Price { get; set; }
        public string CompanyLocation { get; set; }
        public bool MakesElectricCar { get; set; }
        public string Name { get; set; }

        public void PrintInfo()
        {
            if (UsesDiesel == true)
            {
                Console.WriteLine($"This truck uses diesel");
            }
            else
            {
                Console.WriteLine($"This truck DOES NOT use diesel");
            }
            if (IsManuel == true)
            {
                Console.WriteLine($"This truck uses manuel transmission");
            }
            else
            {
                Console.WriteLine($"This truck uses automatic transmission");
            }
        }
    }
}
