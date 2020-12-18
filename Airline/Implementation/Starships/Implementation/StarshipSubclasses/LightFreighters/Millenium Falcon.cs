namespace Airline.Implementation.Starships.Implementation.StarshipSubclasses.LightFreighters
{
    class MilleniumFalcon : LightFreighter
    {
        public override int NumberOfCargoHolds => 4;
        public bool HasUpgradedShields() => true;
        internal MilleniumFalcon()
        {
            ModelName = "Millenium Falcon";
            MaximumFlightRange = 26000;
            PassengerCount = 21;
            Weight = 3700;
            LiftingCapacity = NumberOfCargoHolds * 300;
            Category = Enums.Category.Civil;
            if (HasUpgradedShields())
            {
                FuelConsumption = 6.8m;
            }
            else
            {
                FuelConsumption = 6.2m;
            }
        }
    }
}
