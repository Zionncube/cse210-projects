public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string prompt, string entry)
    {
        _date = DateTime.Now.ToShortDateString();
        _promptText = prompt;
        _entryText = entry;
    }

    public string GetDisplayText()
    {
        return $"Date: {_date}\nPrompt: {_promptText}\nResponse: {_entryText}\n";
    }

    public string ToFileFormat()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    public static Entry FromFileFormat(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 3)
        {
            Entry entry = new Entry(parts[1], parts[2]);
            entry._date = parts[0];
            return entry;
        }
        return null;
    }
}
