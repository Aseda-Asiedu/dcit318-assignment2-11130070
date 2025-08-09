using System;

namespace AbstractClass
{
    public abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return Length * Width;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(4.5);
            Rectangle rectangle = new Rectangle(5, 8);

            Console.WriteLine($"Area of Circle: {circle.GetArea()}");
            Console.WriteLine($"Area of Rectangle: {rectangle.GetArea()}");

            Console.ReadLine();
        }
    }
}
