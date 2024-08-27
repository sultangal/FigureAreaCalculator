namespace AreaCalculatorLibrary;

public class ShapeFactory
{
    public Shape CreateCircle(double radius)
    {
        return new Circle(radius);
    }

    public Shape CreateTriangle(double sideA, double sideB, double sideC)
    {
        return new Triangle(sideA, sideB, sideC);
    }
}