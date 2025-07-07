namespace Prototype
{
    public class Circle : Shape
    {
        public int Radius { get; set; }

        public Circle() { }
        public Circle(Circle source) : base(source)
        {
            Radius = source.Radius;
        }

        public override Circle Clone()
        {
            return new Circle(this);
        }

        public override string ToString()
        {
            return $"Circle: X={X}, Y={Y}, Color={Color}, Radius={Radius}";
        }
    }
}

