using Airline.Implementation.Enums;
using System;

namespace Airline.Implementation.Starships.Implementation
{
    public abstract class SpaceVehicle : ISpaceVehicle
    {
        public abstract string ModelName { get; set; }

        public abstract decimal MaximumFlightRange { get; }

        public abstract decimal FuelConsumption { get; }

        public abstract int Weight { get; }

        public abstract int PassengerCount { get; }

        public abstract double LiftingCapacity { get; }
        public abstract VehicleType TypeofVehicle { get; }

        public Guid SerialNumber => Guid.NewGuid();
    }
}
