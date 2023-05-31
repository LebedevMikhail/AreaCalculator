namespace AreaCalculator.Library.Shapes;
/// <summary>
/// Represents a generic triangle shape.
/// </summary>
public class Triangle: IShape
{
    protected readonly double _sideA;
    private readonly double _sideB;
    protected readonly double _sideC;
    
    /// <summary>
    /// Initializes a new instance of the Triangle class with the specified side lengths.
    /// </summary>
    /// <param name="sideA">The length of side A.</param>
    /// <param name="sideB">The length of side B.</param>
    /// <param name="sideC">The length of side C.</param>
    /// <exception cref="ArgumentException">Thrown when the sides do not form a valid triangle or when any side length is zero or negative.</exception>

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Triangle sides must be positive values.");

        if (!IsValidTriangle(sideA, sideB, sideC))
            throw new ArgumentException("Invalid triangle sides.");

        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
    }
    
    /// <summary>
    /// Calculates the area of the triangle.
    /// </summary>
    /// <returns>The area of the triangle.</returns>
    public virtual double CalculateArea()
    {
        var semiPerimeter = (_sideA + _sideB + _sideC) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
    }

    private bool IsValidTriangle(double sideA, double sideB, double sideC)
    {
        return sideA + sideB > sideC && sideB + sideC > sideA && sideC + sideA > sideB;
    }
}