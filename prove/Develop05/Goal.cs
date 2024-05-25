using System;
using System.Runtime.CompilerServices;

public abstract class Goal
{
    // Protected variablesto store the goal's name, description, and pointsGoal
    protected string _shortName;
    protected string _description;
    protected int _points;

    // Constructor to initialize the goal object
    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // This method will return the points earned for the event
    public abstract int RecordEvent();

    // This method will return true if the goal is complete, otherwise false
    public abstract bool IsComplete();

    // Method to get the name of the goal
    public string GetName()
    {
        return _shortName;
    }

    // Method to get a detailed string representation of the goal
    // Derived classes can override this method to provide additional details
    public virtual string GetDetailsString()
    {
        return $"{(IsComplete() ? "[x]" : "[ ]")} {_shortName} ({_description})";

    }

    // This is used for saving the goal's state
    public abstract string GetStringRepresentation();
}