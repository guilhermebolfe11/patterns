using System;
using System.Collections.Generic;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>();

            var circle = new Circle { X = 10, Y = 20, Color = "Red", Radius = 15 };
            shapes.Add(circle);

            var anotherCircle = circle.Clone();
            anotherCircle.Color = "Blue";
            shapes.Add(anotherCircle);

            var rectangle = new Rectangle { X = 5, Y = 7, Color = "Green", Width = 30, Height = 40 };
            shapes.Add(rectangle);

            var anotherRectangle = rectangle.Clone();
            anotherRectangle.Width = 50;
            shapes.Add(anotherRectangle);

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}

