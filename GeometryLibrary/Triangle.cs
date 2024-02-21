namespace GeometryLibrary
{
    public class Triangle : Shape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Invalid side lengths for a triangle");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Area()
        {
            double p = (a + b + c) / 2.0;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool IsRectangular()
        {
            if ((a * a + b * b == c * c) || (a * a + c * c == b * b) || (c * c + b * b == a * a))
                return true;
            return false;
        }
    }
}
