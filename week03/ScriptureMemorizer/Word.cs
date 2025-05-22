using System;

//define the Word class
piblic class Word
{
   //member variables
    private string _text;
    private bool<Word> _isHidden;

    //constructor
    public Word(string text) 
    {
        //initializing the text and visibiliy
        
        _text = text;
        _isHidden = false;
    }
    
     //method to hide the word 
    public voide Hide()
    {
        //set the visibility ot hidden
        _isHidden = true;
    }

    //method to show the word
    public void Show()
    {
        //set the visibility to visible
        _isHidden = false;
    }

    //methord to check of the word is hidden
    pubic bool IsHidden()
    {
        // returning the visibility
        return isHidden;
    }

    //methord to get the disply text
    pubic sting GetDisplayText()
    {
        // returning the next if visible, otherwise return underscores
        return _isHidden ? new string('_',_text.Length) : _text;
    }

}
       