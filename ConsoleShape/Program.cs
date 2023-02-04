using Shapes.Interfaces;
using Shapes.Shapes;

IShape shape = new Triangle(3, 4, 5);

Console.WriteLine(shape.CalculateArea());
Console.WriteLine(((Triangle)shape).IsRight());