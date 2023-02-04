using Shapes.Interfaces;
using Shapes.Shapes;

namespace Shapes.Tests
{
    public class Tests
    {
        private Circle _circle;
        private Triangle _triangle;

        [SetUp]
        public void Setup()
        {
            _circle = new Circle(5);
            _triangle = new Triangle(3, 4, 5);
        }

        [Test]
        public void IsShape()
        {
            Assert.That(_circle is IShape, Is.True);
            Assert.That(_triangle is IShape, Is.True);
        }

        [Test]
        public void TriangleIsRight()
        {
            Assert.That(_triangle.IsRight(), Is.True);
        }

        [Test]
        public void CannotBeNegative()
        {
            Assert.Throws<ArgumentException>(() => _circle.Radius = -10);
            Assert.Throws<ArgumentException>(() => _triangle.FirstSide = -10);
        }
    }
}