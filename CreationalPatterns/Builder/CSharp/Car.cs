namespace Builder
{
    public class Car
    {
        public int Seats { get; set; }
        public string Engine { get; set; }
        public bool TripComputer { get; set; }
        public bool GPS { get; set; }

        public override string ToString()
        {
            return $"Seats: {Seats}, Engine: {Engine}, TripComputer: {TripComputer}, GPS: {GPS}";
        }
    }
}

