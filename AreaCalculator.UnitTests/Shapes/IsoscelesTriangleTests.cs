using AreaCalculator.Library.Shapes;

namespace AreaCalculator.UnitTests.Shapes
{
    [TestFixture]
    public class IsoscelesTriangleTests
    {
        [Test]
        public void IsoscelesTriangle_ValidSides_CreatesInstance()
        {
            // Arrange
            var equalSide = 4;
            var baseSide = 6;

            // Act
            var triangle = new IsoscelesTriangle(equalSide, baseSide);

            // Assert
            Assert.IsNotNull(triangle);
        }

        [Test]
        public void IsoscelesTriangle_InvalidSides_ThrowsArgumentException()
        {
            // Arrange
            var equalSide = 4;
            var baseSide = 10;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new IsoscelesTriangle(equalSide, baseSide));
        }

        [Test]
        public void CalculateArea_ValidSides_ReturnsCorrectArea()
        {
            // Arrange
            var equalSide = 4;
            var baseSide = 6;
            var triangle = new IsoscelesTriangle(equalSide, baseSide);
            var expectedArea = (equalSide * Math.Sqrt(Math.Pow(baseSide, 2) - Math.Pow(equalSide, 2) / 4)) / 2;

            // Act
            var actualArea = triangle.CalculateArea();

            // Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea));
        }
    }
}