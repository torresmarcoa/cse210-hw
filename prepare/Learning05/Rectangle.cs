using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double length, double with, string color) : base (color)
    {
        _length = length;
        _width = with;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}