using Airline.Implementation.Airline;
using Airline.Implementation.Airline.DataModelsImplementation;
using System;
using System.Collections.Generic;

namespace Airline
{
    class Program
    {
        static void Main()
        {
            Airline<ISpaceVehicle> airline = new Airline<ISpaceVehicle>() // initializing our space corporation
            {
                Name = "Incom"
            };

            airline.BuyShip(new XWing(), 5); // Buying new starfighters for our corporation
            airline.BuyShip(new SpaceStation()); // Buying Death Star to blow up planets if needed
            airline.BuyShip(new ImperialStarDestroyer(), 3); // Buying few Star Destroyers
            airline.BuyShip(new LightFreighter()); // Buying legendary Millenium Falcon

            Console.WriteLine($"_________________general information about {airline.Name}_________________");
            Console.WriteLine($" Total vehicle count -> {airline.VehicleCount}"); // Displaying our current vehicle count
            Console.WriteLine($" Total passenger capacity -> {airline.GetSeatingCapacity()}"); // Displaying maximum passenger places
            Console.WriteLine($" Total lifting capacity -> {airline.GetLiftingCapacity()}"); // Displaying maximum lifting capacity of all our ships combined

            Console.WriteLine($"_________________Ships hierarchy by flight range_________________");
            airline.AscendingSortByFlightRange(); // Sorting our vehicles by flight range from slowest to fastest
            foreach (ISpaceVehicle ship in airline)
            {
                Console.WriteLine($" Ship Name: '{ship.ModelName}'. Maximum flight range: {ship.MaximumFlightRange} km. Ship ID -> {ship.SerialNumber}"); // Displaying sorted list
            }
            Console.WriteLine("Enter minimum and maximum fuel consumption values to search for ships"); // Ask for user input to return list of ships with range of fuel consumption
            try
            {
                int minimumFuelConsumption = Int32.Parse(Console.ReadLine()); // minimal fuel consumption
                int maximumFuelConsumption = Int32.Parse(Console.ReadLine()); // maximum fuel consumption
                if (minimumFuelConsumption < 0 || maximumFuelConsumption < 0 || minimumFuelConsumption > maximumFuelConsumption)
                {
                    throw new ArgumentException();
                }
                Console.WriteLine($"_________________Ships list with fuel consumption from {minimumFuelConsumption} to {maximumFuelConsumption}_________________");
                List<ISpaceVehicle> shipsByFuelConsumption = airline.SearchByFuelConsumption(minimumFuelConsumption, maximumFuelConsumption);
                foreach (ISpaceVehicle ship in shipsByFuelConsumption)
                {
                    Console.WriteLine($"Ship name -> {ship.ModelName}. Fuel consumtion per 100 km -> {ship.FuelConsumption} gallons"); // Displaying list of ships via user input
                }
            }
            catch
            {
                Console.WriteLine("invalid input. Try again");
            }
            
            Console.ReadKey();
        }
    }
}
