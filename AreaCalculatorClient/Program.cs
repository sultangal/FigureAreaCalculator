using AreaCalculatorClient;
using AreaCalculatorLibrary;

var shapeFactory = new ShapeFactory();

var circle = shapeFactory.CreateCircle(5);
Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");

var triangle = shapeFactory.CreateTriangle(3, 4, 5);
Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");

if (triangle is Triangle specificTriangle)
{
    Console.WriteLine($"Треугольник прямоугольный: {specificTriangle.IsRightTriangle()}");
}

//Чтобы добавить свою фигуру, просто создаем класс унаследовав его от Shape, реализуем метод CalculateArea
//затем создаем метод расширения для ShapeFactory для создания его экземпляра.

var rectangle = shapeFactory.CreateRectangle(5,5);
Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea()}");