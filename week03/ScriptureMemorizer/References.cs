using System;


//defone the Refrence class
piblic classReference
{
    //member variable
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    //constructor for single verse
    pubic Reference(string book, int chapter, int verse)
    {
        //initializing the book chapter and the verse
        _book = book;
        _chapter = chapter;
        _verse =  verse;
    }

    //constructor for the verse renge
    public Refrence(string book, int chapter, int startVerse, int _endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse - _endVerse;
    }

    //methord to get the display text 
    public string GetDisplayText()
    {
        //returning the refrence text
        if(_endVerse.HasValue)
        {
        return $"{_book} {_chapter} : {_verse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter} : {_verse}";
        }
    }

}