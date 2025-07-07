namespace Prototype
{
    public abstract class Shape : IPrototype<Shape>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }

        public Shape() { }
        public Shape(Shape source)
        {
            X = source.X;
            Y = source.Y;
            Color = source.Color;
        }

        public abstract Shape Clone();
    }
}

