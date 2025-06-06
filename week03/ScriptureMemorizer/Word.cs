public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor to initialize word text
    public Word(string text)
    {
        this._text = text;
        this._isHidden = false;
    }

    // Method to hide the word
    public void Hide()
    {
        this._isHidden = true;
    }

    // Check if word is hidden
    public bool IsHidden()
    {
        return this._isHidden;
    }

    // Return underscores or actual word
    public string GetDisplayText()
    {
        if (this._isHidden)
        {
            return new string('_', this._text.Length);
        }
        else
        {
            return this._text;
        }
    }
}
