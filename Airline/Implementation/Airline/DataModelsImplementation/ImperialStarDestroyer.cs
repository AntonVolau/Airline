using Airline.Implementation.Enum;
using System;

namespace Airline.Implementation.Airline.DataModelsImplementation
{
    class ImperialStarDestroyer : ISpaceVehicle
    {
        public string ModelName => "Imperial Star Destroyer";

        public decimal MaximumFlightRange => 20000;

        public decimal FuelConsumption => 12;

        public int PassengerCount => 27850;

        public double LiftingCapacity => 37900;

        public int Weight => 15000000;

        public VehicleType TypeofVehicle => VehicleType.SpaceCruiser;

        public Guid SerialNumber => Guid.NewGuid();
    }
}
