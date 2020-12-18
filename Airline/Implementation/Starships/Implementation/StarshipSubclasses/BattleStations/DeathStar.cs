using Airline.Implementation.Enums;
using Airline.Implementation.Starships.Implementation.StarshipSubclasses.StarCruisers;
using Airline.Implementation.Starships.Implementation.StarshipSubclasses.StarFighters;
using System;

namespace Airline.Implementation.Starships.Implementation.StarshipSubclasses.BattleStations
{
    class DeathStar : ISpaceVehicle
    {
        private readonly int EngineCount = 8;

        internal int NumberOfCruisers { get; set; } = 6;

        internal int NumberOfStarFighters { get; set; } = 12;

        public string ModelName { get; internal set; } = "Death Star";

        public decimal MaximumFlightRange => EngineCount * 500;

        public decimal FuelConsumption => 15000;

        public int Weight => 15000000 + NumberOfCruisers * new ImperialStarCruiser().Weight + NumberOfStarFighters * new TieFighter().Weight;

        public VehicleType TypeofVehicle => VehicleType.BattleStation;

        public Category Category => Category.Military;

        public Guid SerialNumber => Guid.NewGuid();

        public int PassengerCount => 2500000 + NumberOfCruisers * new ImperialStarCruiser().PassengerCount + new TieFighter().PassengerCount;

        public double LiftingCapacity => 30000000000 - NumberOfCruisers * new ImperialStarCruiser().Weight - new TieFighter().Weight;
    }
}
