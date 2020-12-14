using Airline.Implementation.Enum;
using System;

namespace Airline.Implementation.Airline.DataModelsImplementation
{
    abstract class SpaceVehicle : ISpaceVehicle
    {
        public string ModelName { get; }

        public decimal MaximumFlightRange { get; }

        public decimal FuelConsumption { get; }

        public int Weight { get; }

        public VehicleType TypeofVehicle { get; }

        public Guid SerialNumber => Guid.NewGuid();

        public int PassengerCount { get; }

        public double LiftingCapacity { get; }
    }
}
