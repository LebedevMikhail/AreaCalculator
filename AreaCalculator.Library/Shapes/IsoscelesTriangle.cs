namespace AreaCalculator.Library.Shapes;
/// <summary>
/// Represents an isosceles triangle shape.
/// </summary>
public class IsoscelesTriangle : Triangle
{
    /// <summary>
    /// Initializes a new instance of the IsoscelesTriangle class with the specified equal side and base side lengths.
    /// </summary>
    /// <param name="equalSide">The length of the equal sides of the triangle.</param>
    /// <param name="baseSide">The length of the base side of the triangle.</param>
    /// <exception cref="ArgumentException">Thrown when the sides do not form a valid isosceles triangle.</exception>

    public IsoscelesTriangle(double equalSide, double baseSide)
        : base(equalSide, equalSide, baseSide)
    {
    }
    
    /// <summary>
    /// Calculates the area of the isosceles triangle.
    /// </summary>
    /// <returns>The area of the isosceles triangle.</returns>

    public override double CalculateArea()
    {
        var height = Math.Sqrt(Math.Pow(_sideC, 2) - Math.Pow(_sideA, 2) / 4);
        return _sideA * height / 2;
    }
}