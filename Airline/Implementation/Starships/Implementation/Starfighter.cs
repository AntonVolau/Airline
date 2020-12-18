using Airline.Implementation.Enums;
using System;

namespace Airline.Implementation.Starships.Implementation
{
    class Starfighter : ISpaceVehicle
    {
        public virtual string ModelName { get; set; } = "Delta-7 light interceptor";

        public virtual decimal MaximumFlightRange { get; set; } = 10000;

        public virtual decimal FuelConsumption { get; set; } = 4.2m;

        public virtual int Weight { get; set; } = 350;

        public virtual int PassengerCount { get; set; } = 1;

        public virtual double LiftingCapacity { get; set; } = 200; 
        
        public VehicleType TypeofVehicle => VehicleType.StarFighter;

        public Guid SerialNumber => Guid.NewGuid();
    }
}
