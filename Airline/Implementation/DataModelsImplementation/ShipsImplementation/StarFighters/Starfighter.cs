using Airline.Implementation.DataModelsImplementation.ShipsImplementation;
using Airline.Implementation.Enum;
using System;

namespace Airline.Implementation.DataModelsImplementation.ShipsImplementation.StarFighters
{
    class Starfighter : ISpaceVehicle
    {
        public virtual string ModelName { get; set; } = "Delta-7 light interceptor";

        public virtual decimal MaximumFlightRange { get; set; } = 10000;

        public virtual decimal FuelConsumption { get; set; } = 4.2m;

        public virtual int Weight { get; set; } = 350;

        public VehicleType TypeofVehicle => VehicleType.StarFighter;

        public Guid SerialNumber => Guid.NewGuid();

        public virtual int PassengerCount => 1;

        public virtual double LiftingCapacity => 200;
    }
}
