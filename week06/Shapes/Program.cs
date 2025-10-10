using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square square = new Square("red", 10);
        shapes.Add(square);
        // Console.WriteLine(square.GetColor());
        Circle circle = new Circle("purple", 10);
        shapes.Add(circle);
        // Console.WriteLine(square.GetColor());
        Rectangle rectangle = new Rectangle("brown", 10, 5);
        // Console.WriteLine(square.GetColor());
        // Console.WriteLine($"Square Area (10): {square.GetArea()}, Circle Area (10r) = {circle.GetArea()}, Rectangle area (10,5) = {rectangle.GetArea()}");
        shapes.Add(rectangle);

        foreach(Shape shapeClass in shapes)
        {
            Console.WriteLine($"The color is {shapeClass.GetColor()}, the area is {shapeClass.GetArea()}");
        }
    }
}