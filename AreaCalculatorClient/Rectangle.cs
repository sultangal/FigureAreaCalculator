using AreaCalculatorLibrary;
namespace AreaCalculatorClient;

public class Rectangle : Shape
{
    private double Width { get; set; }
    private double Height { get; set; }
    
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public override double CalculateArea()
    {
        return Width * Height;
    }
}