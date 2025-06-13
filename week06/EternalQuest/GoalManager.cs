using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals; // List to store all goals
    private int _score;        // Running total score

    // Constructor initializes list and score
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // Creates a new goal and adds it to the list
    public void CreateGoal()
    {
        Console.WriteLine("Choose goal type:\n1. Simple\n2. Eternal\n3. Checklist");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter description: ");
        string desc = Console.ReadLine();
        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        // Use switch to instantiate the correct goal type
        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, desc, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, desc, points));
                break;
            case "3":
                Console.Write("Enter target completions: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid selection.");
                break;
        }
    }

    // Displays all goals and their details
    public void DisplayGoals()
    {
        Console.WriteLine($"\nTotal Score: {_score}");
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    // Prompts the user to choose a goal to record progress
    public void RecordEvent()
    {
        Console.WriteLine("Choose a goal to record:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");
        }

        int index = int.Parse(Console.ReadLine()) - 1;

        if (index >= 0 && index < _goals.Count)
        {
            int points = _goals[index].RecordEvent();
            _score += points;
            Console.WriteLine($"You earned {points} points!");
        }
        else
        {
            Console.WriteLine("Invalid selection.");
        }
    }

    // Getter for current score
    public int GetScore()
    {
        return _score;
    }
}
