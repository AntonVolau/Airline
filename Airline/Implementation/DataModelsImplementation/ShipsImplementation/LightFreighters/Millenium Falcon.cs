namespace Airline.Implementation.DataModelsImplementation.ShipsImplementation.LightFreighters
{
    class MilleniumFalcon : LightFreighter
    {
        internal MilleniumFalcon()
        {
            ModelName = "Millenium Falcon";
            MaximumFlightRange = 26000;
            FuelConsumption = 6.2m;
            PassengerCount = 21;
            Weight = 3700;
            Category = Enum.Category.Civil;
        }
    }
}
