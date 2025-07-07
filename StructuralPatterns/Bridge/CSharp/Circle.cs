namespace Bridge {
    public class Circle : Shape {
        private double radius;
        public Circle(IRenderer renderer, double radius) : base(renderer) {
            this.radius = radius;
        }
        public override void Draw() {
            renderer.RenderCircle(radius);
        }
    }
}

