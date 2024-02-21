namespace GeometryLibrary
{
    public class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Radius cannot be negative");
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
