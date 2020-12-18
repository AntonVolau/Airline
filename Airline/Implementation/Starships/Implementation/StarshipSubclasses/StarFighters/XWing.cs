namespace Airline.Implementation.Starships.Implementation.StarshipSubclasses.StarFighters
{
    class XWing : Starfighter
    {
        private bool CanTravelInHyperspace() => true;
        public override int Weight => 280;
        internal XWing()
        {
            ModelName = "T-65 X-wing";
            if (CanTravelInHyperspace())
            {
                MaximumFlightRange = 23000;
                FuelConsumption = 3.2m;
            }
            else
            {
                MaximumFlightRange = 14000;
                FuelConsumption = 2.5m;
            }
        }
    }
}
