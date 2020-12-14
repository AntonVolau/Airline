using System;
using System.Collections;
using System.Collections.Generic;

namespace Airline.Implementation.Airline.DataModelsImplementation
{
    class Airline<SpaceVehicle> : IAirline<ISpaceVehicle>, IEnumerable<ISpaceVehicle>
    {
        /// <summary>
        /// Total list of available vehicles
        /// </summary>
        private readonly List<ISpaceVehicle> SpaceVehicles = new List<ISpaceVehicle>();

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
            for (int i = 0; i < SpaceVehicles.Count - 2; i++)
            {
                if (SpaceVehicles[i].MaximumFlightRange > SpaceVehicles[i + 1].MaximumFlightRange)
                {
                    ISpaceVehicle temp = SpaceVehicles[i];
                    SpaceVehicles[i] = SpaceVehicles[i + 1];
                    SpaceVehicles[i + 1] = temp;
                }
            }
        }

        public IEnumerator<ISpaceVehicle> GetEnumerator()
        {
            return SpaceVehicles.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public List<ISpaceVehicle> SearchByFuelConsumption(decimal minimumFuelConsumption, decimal MaximumFuelConsumption)
        {
            List<ISpaceVehicle> searchedShips = new List<ISpaceVehicle>();
            foreach (ISpaceVehicle ship in SpaceVehicles)
            {
                if (ship.FuelConsumption >= minimumFuelConsumption && ship.FuelConsumption <= MaximumFuelConsumption)
                {
                    searchedShips.Add(ship);
                }
            }
            return searchedShips;
        }
    }
}
