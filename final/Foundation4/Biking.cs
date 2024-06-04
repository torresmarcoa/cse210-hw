using System;

public class Biking : Activity
{
    private double _speed;

    public Biking(string date, double minutes, string type, double speed) : base(date, minutes, type)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_minutes / 60);
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }
}