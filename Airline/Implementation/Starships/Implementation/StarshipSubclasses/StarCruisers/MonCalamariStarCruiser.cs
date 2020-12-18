using Airline.Implementation.Starships.Implementation.StarshipSubclasses.StarFighters;

namespace Airline.Implementation.Starships.Implementation.StarshipSubclasses.StarCruisers
{
    internal class MonCalamariStarCruiser : StarCruiser
    {
        internal override int NumberOfStarfighters { get; set; } = 10;
        internal MonCalamariStarCruiser()
        {
            ModelName = "Mon Calamari Star Cruiser";
            MaximumFlightRange = 18000;
            PassengerCount = 15000 + NumberOfStarfighters * new XWing().PassengerCount;
            FuelConsumption = 12;
            LiftingCapacity = 34000;
            Weight = 14200000 + NumberOfStarfighters * new XWing().Weight;
        }
    }
}
