using AreaCalculator.Library.Shapes;

namespace AreaCalculator.UnitTests.Shapes;

public class TriangleTests
{
    [Test]
    public void Triangle_ValidSides_CreatesInstance()
    {
        // Arrange
        var sideA = 3;
        var sideB = 4;
        var sideC = 5;

        // Act
        var triangle = new Triangle(sideA, sideB, sideC);

        // Assert
        Assert.IsNotNull(triangle);
    }

    [Test]
    public void Triangle_InvalidSides_ThrowsArgumentException()
    {
        // Arrange
        var sideA = 3;
        var sideB = 7;
        var sideC = 15;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [Test]
    public void CalculateArea_ValidSides_ReturnsCorrectArea()
    {
        // Arrange
        var sideA = 3;
        var sideB = 4;
        var sideC = 5;
        var triangle = new Triangle(sideA, sideB, sideC);
        var expectedArea = 6;

        // Act
        var actualArea = triangle.CalculateArea();

        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }
    
    [Test]
    public void CalculateArea_NegativeSide_ThrowsArgumentException()
    {
        // Arrange
        var sideA = 3;
        var sideB = -4;
        var sideC = 5;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => { new Triangle(sideA, sideB, sideC); });
    }

    [Test]
    public void CalculateArea_InvalidTriangleSides_ThrowsArgumentException()
    {
        // Arrange
        var sideA = 3;
        var sideB = 4;
        var sideC = 8;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => { new Triangle(sideA, sideB, sideC); });
    }
}