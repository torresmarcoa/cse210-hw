using System; 

public class Running : Activity
{
    private double _distance; 

    public Running(string date, double minutes, string type, double distance) : base (date, minutes, type)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _minutes * 60;
    }

    public override double GetPace()
    {
        return _minutes / _distance;
    }
}