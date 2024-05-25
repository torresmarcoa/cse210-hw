using System;

public class EternalGoal : Goal
{

    // Constructor to initialize an eternal goal with name, description, and points
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {

    }

    // Returns the points associated with the eternal goal
    public override int RecordEvent()
    {
        return _points;
    }

    // Returns the points associated with the eternal goal
    public override bool IsComplete()
    {
        return false;
    }

// Method to get a string representation for saving the eternal goal
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
}