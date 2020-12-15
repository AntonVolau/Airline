namespace Airline.Implementation.DataModelsImplementation.ShipsImplementation.StarFighters
{
    class TieFighter : Starfighter
    {
        internal TieFighter()
        {
            ModelName = "TIE/LN starfighter";
            FuelConsumption = 3.0m;
            MaximumFlightRange = 8000;
            Weight = 275;
        }
    }
}
