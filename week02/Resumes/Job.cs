using System;
using System.ComponentModel.Design;

public class Job

{
    public string _jobTitle = "software developer";
    public string _company = "tech corp";
    public int _startYear = 2020;
    public int _endYear = 2023;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}

    

