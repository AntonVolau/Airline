using Airline.Implementation.Starships.Implementation.StarshipSubclasses.StarFighters;

namespace Airline.Implementation.Starships.Implementation.StarshipSubclasses.StarCruisers
{
    class ImperialStarCruiser : StarCruiser
    {
        internal override int NumberOfStarfighters { get; set; } = 12;
        internal virtual int NumberOfShieldGenerators { get; set; } = 2;
        private readonly decimal energyConsumptionByShield = 0.5m;

        internal ImperialStarCruiser()
        {
            ModelName = "Imperial-II";
            MaximumFlightRange = 22000;
            PassengerCount = 18000 + NumberOfStarfighters * new TieFighter().NumberOfSeats;
            FuelConsumption = 14 + energyConsumptionByShield * NumberOfShieldGenerators;
            LiftingCapacity = 41000;
            Weight = 15600000;
        }
    }
}
