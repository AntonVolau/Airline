using Airline.Implementation.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airline.Implementation.Airline.DataModelsImplementation
{
    class SpaceStation : ISpaceVehicle
    {
        public string ModelName => "Death Star";

        public decimal MaximumFlightRange => 1500;

        public decimal FuelConsumption => 15000;

        public int Weight => 15000000;

        public VehicleType TypeofVehicle => VehicleType.BattleStation;

        public Guid SerialNumber => Guid.NewGuid();

        public int PassengerCount => 2500000;

        public double LiftingCapacity => 30000000000;
    }
}
