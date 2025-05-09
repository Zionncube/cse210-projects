using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Whar is your name?");
        string first = Console.ReadLine();

        Console.Write("Whar is your surname?");
        string last = Console.ReadLine();
        
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    
    }
}

