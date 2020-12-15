namespace Airline.Implementation.DataModelsImplementation.ShipsImplementation.LightFreighters
{
    class Slave1 : LightFreighter
    {
        internal Slave1()
        {
            ModelName = "Slave-1";
            MaximumFlightRange = 22000;
            FuelConsumption = 6.8m;
            PassengerCount = 2;
            Weight = 1400;
            Category = Enum.Category.Military;
        }
    }
}
