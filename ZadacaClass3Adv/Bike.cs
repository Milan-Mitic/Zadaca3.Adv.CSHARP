using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Bike : Vehicle 
    {
        public string Color { get; set; }

        public override void PrintVehicle()
        {
            Console.WriteLine($"Year Of Production: {YearOfProducton}");
            Console.WriteLine($"Color: {Color}");
        }
    }
}
