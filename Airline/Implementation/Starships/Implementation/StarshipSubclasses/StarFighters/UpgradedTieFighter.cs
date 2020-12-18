namespace Airline.Implementation.Starships.Implementation.StarshipSubclasses.StarFighters
{
    class UpgradedTieFighter : TieFighter
    {
        public override string ModelName => "Upgraded Tie-fighter";
        public override int NumberOfSeats => 2;
        public override bool CanTransportCargo()
        {
            return true;
        }
    }
}
