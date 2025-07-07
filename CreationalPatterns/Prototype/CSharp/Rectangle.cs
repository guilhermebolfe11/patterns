namespace Prototype
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle() { }
        public Rectangle(Rectangle source) : base(source)
        {
            Width = source.Width;
            Height = source.Height;
        }

        public override Rectangle Clone()
        {
            return new Rectangle(this);
        }

        public override string ToString()
        {
            return $"Rectangle: X={X}, Y={Y}, Color={Color}, Width={Width}, Height={Height}";
        }
    }
}

