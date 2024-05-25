using System;

public class ChecklistGoal : Goal
{
    // Variables to store the amount, taget and bonus
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    // Constructor to initialize a checklist goal with name, description, points, target, and bonus
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int amountCompleted, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    // Returns the points associated with completing a task and the bonus
    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted += 1;
            if (_amountCompleted == _target)
            {
                return _points + _bonus;
            }
            return _points;
        }
        return 0;
    }

    // Returns true if all tasks are completed, otherwise false
    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }
    // Method to get a detailed string representation of the checklist goal
    public override string GetDetailsString()
    {
        return $"{(IsComplete() ? "[x]" : "[ ]")} {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    // Method to get a string representation for saving the goal
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal|{_shortName}|{_description}|{_points}|{_amountCompleted}|{_target}|{_bonus}";
    }
}