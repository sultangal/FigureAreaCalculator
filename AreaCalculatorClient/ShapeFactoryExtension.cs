using AreaCalculatorLibrary;
namespace AreaCalculatorClient;

public static class ShapeFactoryExtension
{
    public static Shape CreateRectangle(this ShapeFactory shapeFactory, double width, double height)
    {
        return new Rectangle(width, height);
    }
}