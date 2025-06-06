using System;

// Inherits from Activity and implements the specific breathing behavior
public class BreathingActivity : Activity
{
    // No additional attributes needed

    // Constructor sets default values using base constructor
    public BreathingActivity() : base("Breathing", 
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 
        0) // Default, will be set by user input
    {
    }

    // Implements Run() method - polymorphism
    public override void Run()
    {
        DisplayStartingMessage();

        int cycles = _duration / 10;
        for (int i = 0; i < cycles; i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(6);
        }

        DisplayEndingMessage();
    }
}
