using System;
using System.Threading;

// Abstract base class - common functionality for all activities
public abstract class Activity
{
    protected string _name;         // Name of the activity
    protected string _description;  // Description of the activity
    protected int _duration;        // Duration in seconds

    // Constructor with parameters
    public Activity(string name, string description, int duration)
    {
        this._name = name;
        this._description = description;
        this._duration = duration;
    }

    // Displays the starting message
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine(_description);
        Console.Write("How many seconds would you like this session to last? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    // Displays the ending message
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);
    }

    // Shows a spinner animation for a given number of seconds
    public void ShowSpinner(int seconds)
    {
        string spinner = @"|/-\";
        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        while (DateTime.Now < endTime)
        {
            foreach (char ch in spinner)
            {
                Console.Write(ch);
                Thread.Sleep(250);
                Console.Write("\b");
            }
        }
    }

    // Shows a countdown
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // Abstract method to be overridden by each subclass
    public abstract void Run();
}
