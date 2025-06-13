using System;

public class SimpleGoal : Goal
{
    // Tracks whether the goal has been completed
    private bool _isComplete;

    // Constructor initializing inherited attributes and setting _isComplete to false
    public SimpleGoal(string shortName, string description, int points)
        : base(shortName, description, points)
    {
        _isComplete = false;
    }

    // Records the event and returns points if not already completed
    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return _points; // Award full points
        }
        return 0; // No points if already complete
    }

    // Custom string showing whether the goal is completed
    public override string GetDetailsString()
    {
        string status = _isComplete ? "[X]" : "[ ]";
        return $"{status} {base.GetDetailsString()}";
    }
}
