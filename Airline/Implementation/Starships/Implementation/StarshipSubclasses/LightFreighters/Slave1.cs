namespace Airline.Implementation.Starships.Implementation.StarshipSubclasses.LightFreighters
{
    class Slave1 : LightFreighter
    {
        private readonly int BombCount = 4;
        internal Slave1()
        {
            ModelName = "Slave-1";
            MaximumFlightRange = 22000;
            FuelConsumption = 6.8m;
            PassengerCount = 2;
            Weight = 1400 + BombCount * 5;
            Category = Enums.Category.Military;
            NumberOfCargoHolds = 1;
        }
    }
}
