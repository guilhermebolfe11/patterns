namespace Builder
{
    public class CarManualBuilder : IBuilder
    {
        private Manual _manual = new Manual();

        public void Reset()
        {
            _manual = new Manual();
        }

        public void SetSeats(int number)
        {
            _manual.Seats = number;
        }

        public void SetEngine(string engine)
        {
            _manual.Engine = engine;
        }

        public void SetTripComputer(bool hasTripComputer)
        {
            _manual.TripComputer = hasTripComputer;
        }

        public void SetGPS(bool hasGPS)
        {
            _manual.GPS = hasGPS;
        }

        public Manual GetResult()
        {
            return _manual;
        }
    }
}

