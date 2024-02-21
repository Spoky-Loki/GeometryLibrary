using GeometryLibrary;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Circle(2), new Triangle(3, 4, 5) };

            foreach (Shape shape in shapes)
                Console.WriteLine($"Площадь фигуры: {shape.Area()}");
        }
    }
}
