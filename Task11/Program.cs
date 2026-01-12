namespace Task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape[] shapes = new IShape[]
            {
                new Triangle(3,4,5),
                new Triangle(5,5,6),
                new Rectangle(5,6),
                new Rectangle(3,3)
            };

            foreach (IShape shape in shapes)
            {
                Console.WriteLine($"{shape.Name}"); ;
            }
        }
    }

    public interface IShape
    {
        string Name { get; }
        public double CalculateArea();
        public double CalculatePerimeter();
    }


    class Triangle : IShape
    {
        public string Name => "Треугольник";
        public double SideA { get; }
        public double SideB { get; }
        public double SideC { get; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        public double CalculateArea()
        {
            double p = CalculatePerimeter() / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public double CalculatePerimeter()
        {
            return SideA + SideB + SideC;
        }
    }

    public class Rectangle : IShape
    {
        public string Name => "Прямоугольник";
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }

        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
