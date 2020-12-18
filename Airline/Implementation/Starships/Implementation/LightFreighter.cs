using Airline.Implementation.Enums;
using System;

namespace Airline.Implementation.Starships.Implementation
{
    class LightFreighter : ISpaceVehicle
    {
        public virtual int NumberOfCargoHolds { get; set; }

        public virtual string ModelName { get; set; } = "XS Stock freighter";

        public virtual decimal MaximumFlightRange { get; set; } = 25000;

        public virtual decimal FuelConsumption { get; set; } = 6.5m;

        public virtual int PassengerCount { get; set; } = 21;

        public virtual double LiftingCapacity { get; set; } = 1580;

        public virtual int Weight { get; set; } = 3700;

        public VehicleType TypeofVehicle => VehicleType.Starship;

        public virtual Category Category { get; set; } = Category.Civil;

        public Guid SerialNumber => Guid.NewGuid();
    }
}
