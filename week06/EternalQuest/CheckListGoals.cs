using System;

public class ChecklistGoal : Goal
{
    // Tracks progress and bonus
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // Constructor initializes base and checklist-specific attributes
    public ChecklistGoal(string shortName, string description, int points, int target, int bonus)
        : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    // Awards points and bonus if completed
    public override int RecordEvent()
    {
        _amountCompleted++;

        // Check if this completion reaches the target
        if (_amountCompleted == _target)
        {
            return _points + _bonus; // Award points plus bonus
        }
        else if (_amountCompleted < _target)
        {
            return _points; // Just regular points
        }

        return 0; // No points after goal has fully completed
    }

    // Displays how many times the goal has been completed
    public override string GetDetailsString()
    {
        string status = _amountCompleted >= _target ? "[X]" : "[ ]";
        return $"{status} {base.GetDetailsString()} -- Completed: {_amountCompleted}/{_target}";
    }
}
