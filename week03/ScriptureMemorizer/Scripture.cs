using System;


//defining the scripture class
piblic class Scripture
{
    //member variables
    private Reference _reference;
    private List<Word> _word;

    //constructor
    public Scripture(Reference reference, string text) {
        //initializing the reference and and word
        _reference = reference;
        _word = new List<word>();

        //spliting the text into words and create Word object
        string[] words = text.Split ('');
        foreach(string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    //methord to hide random words
    public void  HideRandomWords(int numberToHide)
    {
        //getting a list of visible words
        List<word> visibeWords = _words.Where(=> ! w.IsHidden())ToList();

        //hiding random words
        Random random = new Random();
        for(int i = 0; i <numberToHide; i++)
        {
            if (visibleWords.Count >0){
            Word wordtoHide =visibleWords[random.Next(visibleWords.Count)];
            wordtoHide.Hide();visibeWords.Remove(wordtoHide)
            }
        }
    }

    //mrthord to get the display text 
    public string GetDisplayText()
    {
        //get the display text for each word and join them together 
        return sting.join(",_words.Select"(w => w.GetDisplayText()));
    }
    //methord to checkif the cripture is completely hidden
    public bool IsCompletelyHidden()
    {
        //checkign if all words are hidden
        return _words.all(w => w.IsHidden());
    }
}
        

    