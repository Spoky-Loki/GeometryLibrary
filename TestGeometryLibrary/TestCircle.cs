using GeometryLibrary;

namespace TestGeometryShape
{
    [TestClass]
    public class TestCircle
    {
        [TestMethod]
        public void TestAreaWithZeroRadius()
        {
            Circle circle = new Circle(0);
            Assert.AreEqual(0, circle.Area());
        }

        [TestMethod]
        public void TestAreaWithPositiveRadius()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(78.54, circle.Area(), 0.01);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
            "Radius cannot be negative")]
        public void TestCircleWithNegativeRadius()
        {
            Circle circle = new Circle(-2);
        }
    }
}