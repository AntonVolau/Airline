using Airline.Implementation.DataModelsImplementation;
using Airline.Implementation.Starships;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Airline.Implementation.Airline.Implementation
{
    class Airline : IAirline, IEnumerable<ISpaceVehicle>
    {
        /// <summary>
        /// Total list of available vehicles
        /// </summary>
        private List<ISpaceVehicle> SpaceVehicles = new List<ISpaceVehicle>();

        public string Name { get; set; }
        public Guid Id => Guid.NewGuid();

        public int VehicleCount => SpaceVehicles.Count;

        public int GetSeatingCapacity()
        {
            int seatingCapacity = 0;
            foreach (ISpaceVehicle ship in SpaceVehicles)
            {
                seatingCapacity += ship.PassengerCount;
            }
            return seatingCapacity;
        }

        public double GetLiftingCapacity()
        {
            double liftingCapacity = 0;
            foreach (ISpaceVehicle ship in SpaceVehicles)
            {
                liftingCapacity += ship.LiftingCapacity;
            }
            return liftingCapacity;
        }

        public ISpaceVehicle GetVehicle(int vehiclePosition) => SpaceVehicles[vehiclePosition];

        public void BuyShip(ISpaceVehicle spaceVehicle) => SpaceVehicles.Add(spaceVehicle);

        public void BuyShip(ISpaceVehicle spaceVehicle, int count)
        {
            while (count > 0)
            {
                SpaceVehicles.Add(spaceVehicle);
                count--;
            }
        }

        public List<ISpaceVehicle> SearchByName(string nameToSearch)
        {
            List<ISpaceVehicle> searchedVehicles = new List<ISpaceVehicle>();
            foreach (ISpaceVehicle searchedShip in SpaceVehicles)
            {
                if (searchedShip.ModelName == nameToSearch)
                {
                    searchedVehicles.Add(searchedShip);
                }
            }
            return searchedVehicles;
        }

        public void AscendingSortByFlightRange()
        {
            SpaceVehicles = SpaceVehicles.OrderBy(x => x.MaximumFlightRange).ToList();
        }

        public IEnumerator<ISpaceVehicle> GetEnumerator()
        {
            return SpaceVehicles.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public List<ISpaceVehicle> SearchByFuelConsumption(decimal minimumFuelConsumption, decimal maximumFuelConsumption)
        {
            List<ISpaceVehicle> searchedShips = new List<ISpaceVehicle>();
            foreach (ISpaceVehicle ship in SpaceVehicles)
            {
                if (ship.FuelConsumption >= minimumFuelConsumption && ship.FuelConsumption <= maximumFuelConsumption)
                {
                    searchedShips.Add(ship);
                }
            }
            return searchedShips;
        }
    }
}
