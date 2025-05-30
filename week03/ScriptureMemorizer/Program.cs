using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference using book, chapter, and verse range
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Create a scripture with the reference and text
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding.");

        // Keep running the loop until the scripture is fully hidden
        while (!scripture.AllWordsHidden())
        {
            Console.Clear(); // Clear the console screen
            Console.WriteLine(scripture.GetDisplayText()); // Display the current state of the scripture
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine(); // Get user input

            if (input.ToLower() == "quit") // Exit if user types quit
            {
                break;
            }

            scripture.HideRandomWords(3); // Hide 3 more words each time Enter is pressed
        }

        // Display final hidden scripture
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are now hidden. Press any key to exit.");
        Console.ReadKey(); // Pause at end
    }
}
