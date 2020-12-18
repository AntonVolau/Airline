using Airline.Implementation.Enums;
using System;

namespace Airline.Implementation.Starships.Implementation
{
    class StarCruiser : ISpaceVehicle
    {
        internal virtual int NumberOfStarfighters { get; set; }
        public string ModelName { get; internal set; } = "Venator";

        public decimal MaximumFlightRange { get; internal set; } = 20000;

        public decimal FuelConsumption { get; internal set; } = 12;

        public int PassengerCount { get; internal set; } = 27850;

        public double LiftingCapacity { get; internal set; } = 37900;

        public int Weight { get; internal set; } = 15000000;

        public VehicleType TypeofVehicle => VehicleType.SpaceCruiser;

        public Guid SerialNumber => Guid.NewGuid();
    }
}
