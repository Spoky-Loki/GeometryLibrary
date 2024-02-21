using GeometryLibrary;

namespace TestGeometryShape
{

    [TestClass]
    public class TestTriangle
    {
        [TestMethod]
        public void TestAreaWithValidSides()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.Area());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Invalid side lengths for a triangle")]
        public void TestTriangleWithInvalidSides()
        {
            Triangle triangle = new Triangle(2, 3, 10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Invalid side lengths for a triangle")]
        public void TestTriangleWithNegativeSides()
        {
            Triangle triangle = new Triangle(2, -3, 4);
        }

        [TestMethod]
        public void TestIsRectangularWithValidSides()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.IsTrue(triangle.IsRectangular());
        }

        [TestMethod]
        public void TestIsRectangularWithInvalidSides()
        {
            Triangle triangle = new Triangle(5, 6, 7);
            Assert.IsFalse(triangle.IsRectangular());
        }
    }
}
