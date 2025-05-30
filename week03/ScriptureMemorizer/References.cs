public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._startVerse = verse;
        this._endVerse = verse;
    }

    // Constructor for a verse range
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._startVerse = startVerse;
        this._endVerse = endVerse;
    }

    // Return the formatted reference as a string
    public string GetDisplayText()
    {
        if (this._startVerse == this._endVerse)
        {
            return $"{this._book} {this._chapter}:{this._startVerse}";
        }
        else
        {
            return $"{this._book} {this._chapter}:{this._startVerse}-{this._endVerse}";
        }
    }
}
