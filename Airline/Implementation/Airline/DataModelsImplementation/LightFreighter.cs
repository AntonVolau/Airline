using Airline.Implementation.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airline.Implementation.Airline.DataModelsImplementation
{
    class LightFreighter : ISpaceVehicle
    {
        public string ModelName => "Millenium Falcon";

        public decimal MaximumFlightRange => 25000;

        public decimal FuelConsumption => 6.5m;

        public int PassengerCount => 21;

        public double LiftingCapacity => 1580;

        public int Weight => 3700;

        public VehicleType TypeofVehicle => VehicleType.Starship;

        public Guid SerialNumber => Guid.NewGuid();
    }
}
