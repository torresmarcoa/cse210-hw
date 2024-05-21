using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(2, "blue");
        Rectangle rectangle = new Rectangle(1,2,"red");
        Circle circle = new Circle(2, "Green");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();

            Console.WriteLine($" The {color} shape has an area of {area}");
        }
    }
}