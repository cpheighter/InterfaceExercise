using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public bool HasSunroof { get; set; }
        public bool CanGoOffRoad { get; set; }

        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
        public int Price { get; set; }
        public string CompanyLocation { get; set; }
        public bool MakesElectricCar { get; set; }
        public string Name { get; set; }

        public void PrintInfo()
        {
            if (HasSunroof == true)
            {
                Console.WriteLine($"This SUV has a sunroof");
            }
            else
            {
                Console.WriteLine($"This SUV DOES NOT have a sunroof");
            }
            if (CanGoOffRoad == true)
            {
                Console.WriteLine($"This SUV can go off-road");
            }
            else
            {
                Console.WriteLine($"This SUV CANNOT go off-road");
            }
        }
    }
}
