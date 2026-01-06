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
        protected double a, b, c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }

    class RectTriangle : Triangle
    {
        public RectTriangle(double a, double b)
            : base(a, b, Math.Sqrt(a * a + b * b))
        {
        }

        public new double GetArea()
        {
            return a * b / 2;
        }

        public bool IsPythagorean
        {
            get
            {
                return a == b && b == c ? true : false;
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
