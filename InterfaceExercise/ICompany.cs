using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface ICompany
    {
        public string CompanyLocation { get; set; }
        public bool MakesElectricCar { get; set; }

        public virtual void PrintCompanyInfo()
        {
            Console.WriteLine($"This vehicle was made in {CompanyLocation}");
            if (MakesElectricCar == true)
            {
                Console.WriteLine("This vehicle is electric");
            }
            else
            {
                Console.WriteLine("This vehicle is NOT eletric");
            }
        }
    }
}
