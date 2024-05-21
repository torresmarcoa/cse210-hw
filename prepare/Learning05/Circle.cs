using System;

public class Circle : Shape
{
    private double _radious; 

    public Circle(double radious, string color) : base (color)
    {
        _radious = radious;
    }

    public override double GetArea()
    {
        return _radious * _radious * Math.PI;
    }
}