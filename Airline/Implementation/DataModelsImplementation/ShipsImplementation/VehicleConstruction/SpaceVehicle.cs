using Airline.Implementation.Enum;
using System;

namespace Airline.Implementation.DataModelsImplementation.ShipsImplementation.VehicleConstruction
{
    abstract class SpaceVehicle : ISpaceVehicle
    {
        public abstract string ModelName { get; set; }

        public abstract decimal MaximumFlightRange { get; }

        public abstract decimal FuelConsumption { get; }

        public abstract int Weight { get; }

        public abstract VehicleType TypeofVehicle { get; }

        public Guid SerialNumber => Guid.NewGuid();

        public abstract int PassengerCount { get; }

        public abstract double LiftingCapacity { get; }
    }
}
