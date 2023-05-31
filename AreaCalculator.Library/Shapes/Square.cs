namespace AreaCalculator.Library.Shapes;
/// <summary>
/// Represents a square shape.
/// </summary>
public class Square: Rectangle
{
    /// /// <summary>
    /// Initializes a new instance of the Square class with the specified side length.
    /// </summary>
    /// <param name="side">The length of the square's sides.</param>
    /// <exception cref="ArgumentException">Thrown when the side length is zero or negative.</exception>

    public Square(double side) : base(side, side)
    {
        if (side <= 0)
            throw new ArgumentException("Side length must be a positive value.");
    }
    
    /// <summary>
    /// Calculates the area of the square.
    /// </summary>
    /// <returns>The area of the square.</returns>
    public override double CalculateArea()
    {
        return Math.Pow(Length, 2);
    }
}