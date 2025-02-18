using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the Shapes Project.");
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", 2);
        shapes.Add(square);
        Rectangle rectangle = new Rectangle("yellow", 4, 3);
        shapes.Add(rectangle);
        Circle circle = new Circle("green", 6);
        shapes.Add(circle);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}