using System;
using System.Collections.Generic;

// Provides random prompts and reflection questions
public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    // Constructor
    public ReflectingActivity() : base("Reflecting", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience.", 
        0)
    {
        this._prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        this._questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // Gets a random prompt
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }

    // Gets a random question
    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];
    }

    // Displays the selected prompt
    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
    }

    // Displays a series of questions
    public void DisplayQuestions()
    {
        for (int i = 0; i < _duration / 10; i++)
        {
            Console.WriteLine($"> {GetRandomQuestion()}");
            ShowSpinner(10); // Spinner gives time for user to reflect
        }
    }

    // Implements Run()
    public override void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }
}
