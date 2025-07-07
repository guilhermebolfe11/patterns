namespace Builder
{
    public class Director
    {
        public void ConstructSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(2);
            builder.SetEngine("V8");
            builder.SetTripComputer(true);
            builder.SetGPS(true);
        }

        public void ConstructSUV(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(7);
            builder.SetEngine("V6");
            builder.SetTripComputer(false);
            builder.SetGPS(true);
        }
    }
}

