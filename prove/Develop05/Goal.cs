using System;
using System.Runtime.CompilerServices;

public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();

    public abstract bool IsComplete();

    public string GetName()
    {
        return _shortName;
    }

    public virtual string GetDetailsString()
    {
       return $"{(IsComplete() ? "[x]" : "[ ]")} {_shortName} ({_description})";

    }

    public abstract string GetStringRepresentation();
}