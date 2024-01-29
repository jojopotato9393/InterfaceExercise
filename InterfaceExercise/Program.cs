using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            List<IVehicle> list = new List<IVehicle>();

            Truck truck = new Truck()
            {
                Make = "Ford",
                Model = "F150",
                TopSpeed = 110,
                HP = 300,
                EngineType = "Diesel",
                BedSize = 6,      
                EmployeeAmount = 6,
                CompanyName = "FORD"
            };
            Console.WriteLine();
            SUV suv = new SUV()
            {
                Make = "Chevy",
                Model = "Blazer",
                TopSpeed = 95,
                HP = 210,
                NumberOfSeats = 5,
                AllWheelDrive = true,
                EmployeeAmount = 5,
                CompanyName =  " GM"
            };
            Console.WriteLine();
            Car car = new Car()
            { 
             Make = "Toyota",
             Model = "Supra",
             TopSpeed = 160,
             HP = 350,
             ExhaustType = "dule",
             NumberOfDoors = 2, 
             EmployeeAmount = 3,
             CompanyName = "TOYOTA"
            };

             list.Add(truck);
             list.Add(suv);
             list.Add(car);

            //WriteOut(car);
            //Console.WriteLine();
            //WriteOut(truck);
            //Console.WriteLine();
            //WriteOut(suv);
            foreach (var item in list)
            {
                WriteOut(item);
            }


        }

        //when this was public it didnt work 
        static void WriteOut(IVehicle vehicle)
        {
            var company = (ICompany)vehicle;


            Console.WriteLine($"MAKE: {vehicle.Make}");
            Console.WriteLine($"MODEL: {vehicle.Model}");
            Console.WriteLine($"TOPSPEED: {vehicle.TopSpeed}");
            Console.WriteLine($"HP: {vehicle.HP}");
            Console.WriteLine($"EmployeesAmount: {company.EmployeeAmount}");
            Console.WriteLine($"CompanyName: {company.CompanyName}");

            switch(vehicle)
            {
                case Truck truck:
                    Console.WriteLine($"Bedsize {truck.BedSize}");
                    Console.WriteLine($"Engine Type {truck.EngineType}");
                    Console.WriteLine();

                           break;
                case Car car:
                    Console.WriteLine($"ExhaustType: {car.ExhaustType}");
                    Console.WriteLine($"NumberOfDoors: {car.NumberOfDoors}");
                    Console.WriteLine();
                    break;
                case SUV suv:
                    Console.WriteLine($"Number of seats {suv.NumberOfSeats}");
                    Console.WriteLine($"AWD: {suv.AllWheelDrive}");
                    Console.WriteLine(); 
                    break;
                default:
                    Console.WriteLine("not Valid");
                    break;


            }
        }

    }
}
