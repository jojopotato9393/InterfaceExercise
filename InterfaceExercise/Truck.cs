using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public double BedSize { get; set; }
        //EngineType (Gas or Diesel)
        public string EngineType { get; set; }
        public double TopSpeed { get; set; }
        public int HP { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int EmployeeAmount { get; set; }
        public string CompanyName { get; set; }

    
    }
}
