using System;

namespace Bridge {
    public class VectorRenderer : IRenderer {
        public void RenderCircle(double radius) {
            Console.WriteLine($"Drawing a circle of radius {radius} with vector renderer.");
        }
        public void RenderSquare(double size) {
            Console.WriteLine($"Drawing a square of size {size} with vector renderer.");
        }
    }
}

