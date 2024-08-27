using AreaCalculatorLibrary;
using AreaCalculatorClient;
namespace AreaCalculatorTests;

public class ShapeTests
{
    [Test]
    public void TestCircleArea()
    {
        var circle = new Circle(5);
        Assert.AreEqual(Math.PI * 25, circle.CalculateArea(), 1e-5);
    }
    
    [Test]
    public void TestTriangleArea()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.AreEqual(6, triangle.CalculateArea(), 1e-5);
    }
    
    [Test]
    public void TestRightTriangle()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.IsTrue(triangle.IsRightTriangle());
    }
    
    [Test]
    public void TestRectangleArea()
    {
        var rectangle = new Rectangle(5, 5);
        Assert.AreEqual(25, rectangle.CalculateArea(), 1e-5);
    }
}