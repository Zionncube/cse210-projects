# cse210-ww-student-template
This is the starter code for students in the worldwide content version of CSE 210.

This repository contains the starter code for many different projects. They are arranged folders by week. There is also an an empty sandbox project that can be used to play around with any concept you would like.


on the resumae code this is the code below is a mordern simpler way.
//job.cs

public class Job
{
    pulic string jobTitle {get;set;}
    pulic string companyName {get;set;}
    pulic string location {get;set;}
    pulic string jobDescription {get;set;}
    pulic string salary {get;set;}

    // constructor

    public Job(string jobTitle, string companyName, string location, string jobDescription, string salary)
    {
        _jobTitle = jobTitle;
        _companyName = companyName;
        _location = location;
        _jobDescription = jobDescription;
        _salary = salary;
    }
}

_jobTitle = _jobTitle; this on the constructor is reporting a fix which is asigning to the same variable 
this  can be fixed by adding (this.) or giving it a different name
eg. 
this._jobTitle = _jobTitle;
the giving of the different name shoud start from the public Job( string title,etc)
