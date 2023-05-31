namespace AreaCalculator.Library.Shapes;
/// <summary>
/// Represents a circle shape.
/// </summary>
public class Circle : IShape
{
    private readonly double _radius;
    /// <summary>
    /// Initializes a new instance of the Circle class with the specified radius.
    /// </summary>
    /// <param name="radius">The radius of the circle.</param>
    /// <exception cref="ArgumentException">Thrown when the radius is zero or negative.</exception>

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Circle radius must be a positive value.");

        _radius = radius;
    }
    
    /// <summary>
    /// Calculates the area of the circle.
    /// </summary>
    /// <returns>The area of the circle.</returns>
    public double CalculateArea()
    {
        return Math.PI * _radius * _radius;
    }
}