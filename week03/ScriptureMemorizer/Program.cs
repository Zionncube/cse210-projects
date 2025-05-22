using System;

//define the program class
class Program
{
    static void Main(string[] args)
    {
        //creating a refrence and a scripture
        Refrence reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference "For God so loved the wordl  that He gave his one and only Son")
        

        //Hiding random words and display the scripture
        while (! scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(Reference.GetDisplayText);
            Console.WriteLine(Scripture.GetDisplayText);
            Console.WriteLine("Press enter to hide more words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (imput.ToLower() == "quit")
            {
                break;
            }
scripture.HideRandomWords(1);
        }
        
    }
}