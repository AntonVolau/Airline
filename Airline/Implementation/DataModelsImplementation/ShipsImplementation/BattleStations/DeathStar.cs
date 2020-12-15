using Airline.Implementation.Enum;
using System;

namespace Airline.Implementation.DataModelsImplementation.ShipsImplementation.BattleStations
{
    class DeathStar : ISpaceVehicle
    {
        public string ModelName { get; internal set; } = "Death Star";

        public decimal MaximumFlightRange => 1500;

        public decimal FuelConsumption => 15000;

        public int Weight => 15000000;

        public VehicleType TypeofVehicle => VehicleType.BattleStation;

        public Guid SerialNumber => Guid.NewGuid();

        public int PassengerCount => 2500000;

        public double LiftingCapacity => 30000000000;
    }
}
