using System.Net;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GeometricShape[] shapes = new GeometricShape[]
            {
                new Triangle(3,4,5),
                new Triangle(5,5,6),
                new Rectangle(5,6),
                new Rectangle(3,3)
            };

            foreach (GeometricShape shape in shapes)
            {
                shape.PrintInfo();
            }

        }
    }

    public abstract class GeometricShape
    {
        public abstract string Name { get; }
        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public void PrintInfo()
        {
            Console.WriteLine($"Тип {Name}");
            Console.WriteLine($"S = {CalculateArea()}");
            Console.WriteLine($"P = {CalculatePerimeter()}");
            Console.WriteLine();
        }
    }

    class Triangle : GeometricShape
    {
        public override string Name => "Треугольник";
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public override double CalculateArea()
        {
            double p = CalculatePerimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public override double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }

    class RectTriangle : Triangle
    {
        public RectTriangle(double a, double b)
            : base(a, b, Math.Sqrt(a * a + b * b))
        {
        }

        public new double CalculateArea()
        {
            return SideA * SideB / 2;
        }

        public bool IsPythagorean
        {
            get
            {
                return SideA % 1 == 0 && SideB % 1 == 0 && SideC % 1 == 0;
            }
        }
    }

    class RegularTriangle : Triangle
    {
        public RegularTriangle(double a)
            : base(a, a, a)
        {

        }
    }

    public class Rectangle : GeometricShape
    {
        public override string Name => "Прямоугольник";
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
