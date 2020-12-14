using Airline.Implementation.Enum;
using System;

namespace Airline.Implementation.Airline.DataModelsImplementation
{
    class XWing : ISpaceVehicle
    {
        public string ModelName => "T-65 X-wing Starfighter";

        public decimal MaximumFlightRange => 10000;

        public decimal FuelConsumption => 5.5m;

        public int Weight => 350;

        public VehicleType TypeofVehicle => VehicleType.StarFighter;

        public Guid SerialNumber => Guid.NewGuid();

        public int PassengerCount => 1;

        public double LiftingCapacity => 200;
    }
}
