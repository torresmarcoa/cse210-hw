using System; 

public abstract class Activity
{
    // Member variables to store the date, minutes, and type
    protected string _date; 
    protected double _minutes; 
    protected string _type;

    // Constructor to initialize the activity object
    public Activity(string date, double minutes, string type)
    {
        _date = date;
        _minutes = minutes; 
        _type = type;
    }

    // Method to get a summary of each activity
    public string GetSummary()
    {
        return $"{_date} {_type} ({_minutes} minutes) - Distance: {GetDistance()} km, Speed {GetSpeed()} km/h, Pace {GetPace()} min per km";
    }


    // Abstract methods to get details of each activity
    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();
}