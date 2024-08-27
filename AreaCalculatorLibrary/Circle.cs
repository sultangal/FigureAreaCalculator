namespace AreaCalculatorLibrary;

public class Circle : Shape
{
    private double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}