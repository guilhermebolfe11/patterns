namespace Builder
{
    public class CarBuilder : IBuilder
    {
        private Car _car = new Car();

        public void Reset()
        {
            _car = new Car();
        }

        public void SetSeats(int number)
        {
            _car.Seats = number;
        }

        public void SetEngine(string engine)
        {
            _car.Engine = engine;
        }

        public void SetTripComputer(bool hasTripComputer)
        {
            _car.TripComputer = hasTripComputer;
        }

        public void SetGPS(bool hasGPS)
        {
            _car.GPS = hasGPS;
        }

        public Car GetResult()
        {
            return _car;
        }
    }
}

