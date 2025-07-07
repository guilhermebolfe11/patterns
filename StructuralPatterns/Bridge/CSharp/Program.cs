using System;

namespace Bridge {
    class Program {
        static void Main(string[] args) {
            IRenderer vector = new VectorRenderer();
            IRenderer raster = new RasterRenderer();

            Shape circle = new Circle(vector, 5);
            circle.Draw();

            Shape square = new Square(raster, 10);
            square.Draw();
        }
    }
}

