using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    // Constructor that builds the scripture from reference and text
    public Scripture(Reference reference, string text)
    {
        this._reference = reference;
        this._words = new List<Word>();
        this._random = new Random();

        // Split text into words and create Word objects
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            this._words.Add(new Word(word));
        }
    }

    // Hide a specified number of random words that are not already hidden
    public void HideRandomWords(int numberToHide)
    {
        int attempts = 0;

        while (numberToHide > 0 && attempts < 100)
        {
            int index = this._random.Next(this._words.Count);

            if (!this._words[index].IsHidden())
            {
                this._words[index].Hide();
                numberToHide--;
            }

            attempts++;
        }
    }

    // Return the scripture text with current visibility state
    public string GetDisplayText()
    {
        string display = this._reference.GetDisplayText() + " ";

        foreach (Word word in this._words)
        {
            display += word.GetDisplayText() + " ";
        }

        return display.Trim(); // Remove trailing space
    }

    // Check if all words have been hidden
    public bool AllWordsHidden()
    {
        foreach (Word word in this._words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}
