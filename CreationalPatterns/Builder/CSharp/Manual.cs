namespace Builder
{
    public class Manual
    {
        public int Seats { get; set; }
        public string Engine { get; set; }
        public bool TripComputer { get; set; }
        public bool GPS { get; set; }

        public override string ToString()
        {
            return $"Manual: Seats: {Seats}, Engine: {Engine}, TripComputer: {TripComputer}, GPS: {GPS}";
        }
    }
}

