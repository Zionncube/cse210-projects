using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference for Proverbs 3:5-6
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        // Create a scripture with the reference and the scripture text
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not unto thine own understanding.");

        // Loop until all words are hidden
        while (!scripture.AllWordsHidden())
        {
            Console.Clear(); // Clear the screen
            Console.WriteLine(scripture.GetDisplayText()); // Show the scripture
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to end.");
            string input = Console.ReadLine(); // Read user input

            if (input.ToLower() == "quit") // End the program if user types 'quit'
            {
                break;
            }

            scripture.HideRandomWords(3); // Hide 3 words at a time
        }

        // Show final fully hidden scripture
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nAll words are hidden. Press any key to exit.");
        Console.ReadKey(); // Wait for key press
    }
}
