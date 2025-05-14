using System;

public class Job
{
    private string _jobTitle;
    private string _companyName;
    private int _startYear;
    private int _endYear;

    public void display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName})} {_startYear}-{_endYear}")
    }
}