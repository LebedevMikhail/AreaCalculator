using AreaCalculator.Library.Shapes;

namespace AreaCalculator.UnitTests.Shapes;

public class SquareTests
{
    [Test]
    public void Square_CalculateArea_ReturnsCorrectArea()
    {
        // Arrange
        var side = 5;
        var square = new Square(side);
        var expectedArea = side * side;

        // Act
        var actualArea = square.CalculateArea();

        // Assert
        Assert.That(actualArea, Is.EqualTo(expectedArea));
    }
    
    [Test]
    public void Square_PositiveLength_CreateInstance()
    {
        // Arrange
        double side = 4;

        // Act
        var square = new Square(side);
        // Assert
        Assert.IsNotNull(square);

    }
    
    [Test]
    public void Square_ZeroLength_ThrowsArgumentException()
    {
        // Arrange
        double side = 0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Square(side));
    }

    [Test]
    public void Square_NegativeLength_ThrowsArgumentException()
    {
        // Arrange
        double side = -5;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Square(side));
    }
}