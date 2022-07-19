using System;
using System.Collections.Generic;
using InterfaceExercise;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car car = new Car();
            car.IsFuelEfficent = true;
            car.GroundClearance = "low";
            car.CompanyLocation = "Japan";
            car.Price = 30045;
            car.MakesElectricCar = false;
            car.NumberOfSeats = 5;
            car.NumberOfWheels = 4;
            car.NumberOfDoors = 4;
            car.Name = "Toyota Camry";

            Truck truck = new Truck();
            truck.IsManuel = true;
            truck.UsesDiesel = true;
            truck.CompanyLocation = "USA";
            truck.Price = 180000;
            truck.MakesElectricCar = false;
            truck.NumberOfSeats = 2;
            truck.NumberOfWheels = 6;
            truck.NumberOfDoors = 2;
            truck.Name = "Semi-Truck";

            SUV suv = new SUV();
            suv.HasSunroof = true;
            suv.CanGoOffRoad = true;
            suv.CompanyLocation = "USA";
            suv.Price = 39000;
            suv.MakesElectricCar = false;
            suv.NumberOfSeats = 5;
            suv.NumberOfWheels = 4;
            suv.NumberOfDoors = 4;
            suv.Name = "Jeep Cherokee";

            var vehicles = new List<IVehicle>() { car, truck, suv };
            foreach(var vehicle in vehicles)
            {
                vehicle.PrintVehicleInfo();
                vehicle.PrintCompanyInfo();
                vehicle.PrintInfo();
                Console.WriteLine("--------------------------------");
            }

        }
    }
}
