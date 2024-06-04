using System;

public class Swimming : Activity
{
    private double _laps;
    
    public Swimming(string date, double minutes, string type, double laps) : base (date, minutes, type)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        double distance = GetDistance();
        double hours = _minutes / 60;
        return distance / hours;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}