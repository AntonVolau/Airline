namespace Airline.Implementation.Starships.Implementation.StarshipSubclasses.StarFighters
{
    class TieFighter : Starfighter
    {
        public virtual int NumberOfSeats { get; set; } = 1;
        public virtual bool CanTransportCargo() => false;
        public override string ModelName => "TIE/LN starfighter";
        public override int PassengerCount => NumberOfSeats;
        public override decimal FuelConsumption => 3;
        public override decimal MaximumFlightRange => 8000;

        internal TieFighter()
        {
            Weight = 275;
            if (CanTransportCargo())
            {
                LiftingCapacity = 300;
            }
            else
            {
                LiftingCapacity = 0;
            }
        }
    }
}
