using System;

public abstract class Goal
{
    // Common attributes shared by all types of goals
    protected string _shortName;
    protected string _description;
    protected int _points;

    // constructor to initialize common attributes
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // accessor methods
    public string GetName() => _shortName;
    public string GetDescription() => _description;
    public int GetPoints() => _points;

    // virtual method that can be overridden
    public virtual string GetDetailsString()
    {
        return $"{_shortName} ({_description})";
    }

    // abstract method that must be implemented in derived classes
    public abstract int RecordEvent();
}
