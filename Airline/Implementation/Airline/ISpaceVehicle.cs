using Airline.Implementation.Enum;
using System;

namespace Airline.Implementation.Airline
{
    internal interface ISpaceVehicle
    {
        /// <summary>
        /// Name of model
        /// </summary>
        public string ModelName { get; }

        /// <summary>
        /// Maximum flight range in parsecs
        /// </summary>
        public decimal MaximumFlightRange { get; }

        /// <summary>
        /// Fuel consumption in gallons per 100 parceks
        /// </summary>
        public decimal FuelConsumption { get; }

        /// <summary>
        /// Total number of passengers
        /// </summary>
        public int PassengerCount { get; }

        /// <summary>
        /// Maximum lifting capacity in kg
        /// </summary>
        public double LiftingCapacity { get; }

        /// <summary>
        /// Vehicle weight in kg
        /// </summary>
        public int Weight { get; }

        /// <summary>
        /// Type of spaceship
        /// </summary>
        public abstract VehicleType TypeofVehicle { get; }

        /// <summary>
        /// Unique serial number of vehicle
        /// </summary>
        Guid SerialNumber { get; }
    }
}
