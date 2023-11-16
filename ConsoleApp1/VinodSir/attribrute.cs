using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.VinodSir
{
    internal class attribrute
    {


        // Custom attribute to define fuel type
        [AttributeUsage(AttributeTargets.Class)]
        public class FuelTypeAttribute : Attribute
        {
            public string Fuel { get; }

            public FuelTypeAttribute(string fuel)
            {
                Fuel = fuel;
            }
        }

        // Applying the custom attribute to vehicle classes
        [FuelType("Gasoline")]
        class Car
        {
            
            public string Model { get; set; }
            public int Year { get; set; }
            // Other properties and methods...
        }

        [FuelType("Electric")]
        class ElectricCar
        {
            public string Model { get; set; }
            public int Year { get; set; }
            // Other properties and methods...
        }

        class Program
        {
            static void Main()
            {
                // Retrieving and using the custom attribute
                var carFuelType = GetFuelType<Car>();
                var electricCarFuelType = GetFuelType<ElectricCar>();

                Console.WriteLine("Car Fuel Type: " + carFuelType);
                Console.WriteLine("Electric Car Fuel Type: " + electricCarFuelType);

                // Other operations...
            }

            // Method to get the fuel type from the custom attribute
            static string GetFuelType<T>() where T : class
            {
                var attribute = typeof(T).GetCustomAttributes(typeof(FuelTypeAttribute), false);
                if (attribute.Length > 0 && attribute[0] is FuelTypeAttribute fuelType)
                {
                    return fuelType.Fuel;
                }
                return "Unknown";
            }
        }



    }
}