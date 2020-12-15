using Airline.Implementation.Airline.DataModelsImplementation.ShipsImplementation.StarCruisers;
using Airline.Implementation.DataModelsImplementation.AirlineImplementation;
using Airline.Implementation.DataModelsImplementation.ShipsImplementation;
using Airline.Implementation.DataModelsImplementation.ShipsImplementation.BattleStations;
using Airline.Implementation.DataModelsImplementation.ShipsImplementation.LightFreighters;
using Airline.Implementation.DataModelsImplementation.ShipsImplementation.StarFighters;
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

            airline.BuyShip(new XWing(), 3); // Buying new starfighters for our corporation
            airline.BuyShip(new TieFighter(), 4); // Buying more starfighters for our corporation
            airline.BuyShip(new Starfighter(), 2); // Buying even more starfighters for our corporation
            airline.BuyShip(new DeathStar()); // Buying Death Star to blow up planets if needed
            airline.BuyShip(new StarCruiser()); // Buying Standart Star Destroyer
            airline.BuyShip(new ImperialStarCruiser(), 2); // Buying few Imperial Star Destroyers
            airline.BuyShip(new MonCalamariStarCruiser(), 2); // Buying couple of Mon Calamary Cruisers
            airline.BuyShip(new Slave1()); // Buying Slave 1
            airline.BuyShip(new LightFreighter(), 2); // Buying few standart light freighters
            airline.BuyShip(new MilleniumFalcon()); // Buying legendary Millenium Falcon

            Console.WriteLine($"_________________General information about {airline.Name}_________________");
            Console.WriteLine($" Total vehicle count -> {airline.VehicleCount}"); // Displaying our current vehicle count
            Console.WriteLine($" Total passenger capacity -> {airline.GetSeatingCapacity()}"); // Displaying maximum passenger places
            Console.WriteLine($" Total lifting capacity -> {airline.GetLiftingCapacity()}"); // Displaying maximum lifting capacity of all our ships combined

            Console.WriteLine($"_________________Ships hierarchy by flight range_________________");
            airline.AscendingSortByFlightRange(); // Sorting our vehicles by flight range from lowest to highest
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
                    Console.WriteLine($"Ship name -> {ship.ModelName}. Fuel consumtion per 100 parsecs -> {ship.FuelConsumption} gallons"); // Displaying list of ships via user input
                }
            }
            catch
            {
                Console.WriteLine("invalid input. Try again"); // Displaying this message in case of invalid user input
            }
            
            Console.ReadKey();
        }
    }
}
