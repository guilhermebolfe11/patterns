using System;

namespace Bridge {
    public class RasterRenderer : IRenderer {
        public void RenderCircle(double radius) {
            Console.WriteLine($"Drawing a circle of radius {radius} with raster renderer.");
        }
        public void RenderSquare(double size) {
            Console.WriteLine($"Drawing a square of size {size} with raster renderer.");
        }
    }
}

