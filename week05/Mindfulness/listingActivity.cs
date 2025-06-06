using System;
using System.Collections.Generic;

// Handles the listing activity and user interaction
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    // Constructor
    public ListingActivity() : base("Listing", 
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 
        0)
    {
        this._prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    // Gets a random prompt from the list
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompts.Count);
        return _prompts[index];
    }

    // Gets list of items from user
    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                items.Add(input);
            }
        }

        this._count = items.Count;
        return items;
    }

    // Implements Run()
    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        List<string> items = GetListFromUser();

        Console.WriteLine($"You listed {items.Count} items.");
        DisplayEndingMessage();
    }
}
