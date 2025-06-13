using System;

public class EternalGoal : Goal
{
    // Constructor with no additional attributes
    public EternalGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
    }

    // Always awards points because this goal never completes
    public override int RecordEvent()
    {
        return _points;
    }

    // Uses the base details string
}
