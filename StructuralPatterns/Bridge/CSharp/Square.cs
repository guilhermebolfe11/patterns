namespace Bridge {
    public class Square : Shape {
        private double size;
        public Square(IRenderer renderer, double size) : base(renderer) {
            this.size = size;
        }
        public override void Draw() {
            renderer.RenderSquare(size);
        }
    }
}

