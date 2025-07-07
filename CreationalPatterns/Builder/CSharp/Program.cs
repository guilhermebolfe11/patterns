using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            var builder = new CarBuilder();
            director.ConstructSportsCar(builder);
            Car car = builder.GetResult();
            Console.WriteLine($"Car built: {car}");

            var manualBuilder = new CarManualBuilder();
            director.ConstructSportsCar(manualBuilder);
            Manual manual = manualBuilder.GetResult();
            Console.WriteLine($"Manual built: {manual}");
        }
    }
}

