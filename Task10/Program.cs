using System.Net;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegularTriangle triangle = new RegularTriangle(10);
            Triangle triangle1 = triangle;
            RectTriangle triangle2 = triangle1 as RectTriangle;

        }
    }

    class Triangle
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double GetArea()
        {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }

    class RectTriangle : Triangle
    {
        public RectTriangle(double a, double b)
            : base(a, b, Math.Sqrt(a * a + b * b))
        {

        }

        public bool IsPythagorean
        {
            get
            {
                return A == B && B == C ? true : false;
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
}
