namespace Builder
{
    public interface IBuilder
    {
        void Reset();
        void SetSeats(int number);
        void SetEngine(string engine);
        void SetTripComputer(bool hasTripComputer);
        void SetGPS(bool hasGPS);
    }
}

