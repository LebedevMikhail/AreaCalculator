using AreaCalculator.Library.Shapes;

namespace AreaCalculator.UnitTests.Shapes;

public class RectangleTests
{
    [Test]
    public void Rectangle_ValidParameters_CorrectRectangle()
    {
        // Arrange
        var length = 2;
        var width = 4;

        // Act
        var rectangle = new Rectangle(2, 4);
        // Assert
        Assert.IsNotNull(rectangle);
    }
    [Test]
    public void Rectangle_InvalidLength_ThrowsArgumentException()
    {
        // Arrange
        var length = -2;
        var width = 4;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Rectangle(length, width));
    }
    
    [Test]
    public void Rectangle_InvalidWidth_ThrowsArgumentException()
    {
        // Arrange
        var length = 2;
        var width = -4;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => new Rectangle(length, width));
    }
    
    [Test]
    public void Rectangle_CalculateArea_ReturnsCorrectArea()
    {
        // Arrange
        var length = 4;
        var width = 6;
        var rectangle = new Rectangle(length, width);
        var expectedArea = length * width;

        // Act
        var actualArea = rectangle.CalculateArea();

        // Assert
        Assert.That(actualArea, Is.EqualTo(expectedArea));
    }
}