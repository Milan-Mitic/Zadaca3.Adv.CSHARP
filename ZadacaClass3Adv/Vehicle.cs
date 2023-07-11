using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Vehicle
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public int YearOfProducton { get; set; }

        public int BatchNumber { get; set; }

        public virtual void PrintVehicle()
        {
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Type: {Type}");
        }

        public static class DB
        {
            public static List<Vehicle> vehicleList { get; set; } = new List<Vehicle>();

            public static void AddVehicle(Car car, Bike bike, Vehicle vehicle)
            {
                vehicleList.Add(car);
                vehicleList.Add(bike);
                vehicleList.Add(vehicle);
            }
        }
    }
    public static class Validator
    {
        public static bool Validate(Vehicle vehicle)
        {
            if (vehicle.Id <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*** The Id is not validate ***");
                Console.ResetColor();
                return false;
            }
            if (string.IsNullOrEmpty(vehicle.Type))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*** The type of vehicle is not valid ***");
                Console.ResetColor();
                return false;
            }
            if (vehicle.YearOfProducton <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*** The Year Of Production is not valid ***");
                Console.ResetColor();
                return false;
            }
            return true;
        }
    }
}
