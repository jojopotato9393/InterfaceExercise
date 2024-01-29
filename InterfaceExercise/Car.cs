using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany 
    {
        public string ExhaustType { get; set; } = "dule";
        public int NumberOfDoors { get; set; } = 2;
        public int EmployeeAmount { get; set; } = 300;
        public string CompanyName { get; set; } = "TOYOTA";
        public string Make { get; set; } = "toyota";
        public string Model { get; set; } = "supra";
        public double TopSpeed { get; set; } = 100;
        public int HP { get; set; } = 300;

       
    }
}
