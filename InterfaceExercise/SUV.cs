using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany 
    {
        public int NumberOfSeats { get; set; }
        public bool AllWheelDrive { get; set; } 
        public string Make { get; set; } 
        public string Model { get; set; } 
        public double TopSpeed { get; set; } 
        public int HP { get; set; } 
        public int EmployeeAmount { get; set; } 
        public string CompanyName { get; set; }

      
       


    }
}
