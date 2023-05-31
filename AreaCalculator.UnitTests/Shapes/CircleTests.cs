using AreaCalculator.Library.Shapes;

namespace AreaCalculator.UnitTests.Shapes;

public class CircleTests
{
    [Test]
    public void Circle_ValidRadius_CreatesInstance()
    {
        // Arrange
        var radius = 5;

        // Act
        var circle = new Circle(radius);

        // Assert
        Assert.IsNotNull(circle);
    }

    [Test]
    public void Circle_ZeroRadius_ThrowsArgumentException()
    {
        // Arrange
        var radius = 0;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
    
    [Test]
    public void Circle_NegativeRadius_ThrowsArgumentException()
    {
        // Arrange
        var radius = -5;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Circle(radius));
    }
    [Test]
    public void CalculateArea_ValidRadius_ReturnsCorrectArea()
    {
        // Arrange
        var radius = 5;
        var circle = new Circle(radius);
        var expectedArea = Math.PI * radius * radius;

        // Act
        var actualArea = circle.CalculateArea();

        // Assert
        Assert.AreEqual(expectedArea, actualArea);
    }
}