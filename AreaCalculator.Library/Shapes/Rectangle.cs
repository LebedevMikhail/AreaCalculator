namespace AreaCalculator.Library.Shapes;
/// <summary>
/// Represents a rectangle shape.
/// </summary>
public class Rectangle : IShape
{
    protected readonly double Length;
    private readonly double _width;
    
    /// <summary>
    /// Initializes a new instance of the Rectangle class with the specified length and width.
    /// </summary>
    /// <param name="length">The length of the rectangle.</param>
    /// <param name="width">The width of the rectangle.</param>
    /// <exception cref="ArgumentException">Thrown when the length or width is zero or negative.</exception>

    public Rectangle(double length, double width)
    { 
        if (length <= 0 || width <= 0)
            throw new ArgumentException("Length and width must be positive values.");

        Length = length;
        _width = width;
    }

    /// <summary>
    /// Calculates the area of the rectangle.
    /// </summary>
    /// <returns>The area of the rectangle.</returns>
    public virtual double CalculateArea()
    {
        return Length * _width;
    }
}