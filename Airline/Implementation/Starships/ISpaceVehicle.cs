using Airline.Implementation.Enums;
using System;

namespace Airline.Implementation.Starships
{
    public interface ISpaceVehicle
    {
        /// <summary>
        /// Name of model
        /// </summary>
        string ModelName { get; }

        /// <summary>
        /// Maximum flight range in parsecs
        /// </summary>
        decimal MaximumFlightRange { get; }

        /// <summary>
        /// Fuel consumption in gallons per 100 parceks
        /// </summary>
        decimal FuelConsumption { get; }

        /// <summary>
        /// Total number of passengers
        /// </summary>
        int PassengerCount { get; }

        /// <summary>
        /// Maximum lifting capacity in kg
        /// </summary>
        double LiftingCapacity { get; }

        /// <summary>
        /// Vehicle weight in kg
        /// </summary>
        int Weight { get; }

        /// <summary>
        /// Type of spaceship
        /// </summary>
        VehicleType TypeofVehicle { get; }

        /// <summary>
        /// Unique serial number of vehicle
        /// </summary>
        Guid SerialNumber { get; }
    }
}
