using System;
using System.Runtime.InteropServices;

public class SimpleGoal : Goal
{

    // Variable to store whether the goal is complete
    private bool _isComplete;

    // Constructor to initialize a simple goal with name, description, and points
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        // By default the goal is not complete
        _isComplete = false;
    }

    // Constructor to initialize the simple goal with the parameters for completion status  
    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    // Returns the points associated with the goal if it is not already complete
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        return 0;
    }
    // Returns true if the goal is complete, otherwise false
    public override bool IsComplete()
    {
        return _isComplete;
    }

    // Method to get a string representation for saving the goal
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}