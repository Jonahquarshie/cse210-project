using System;
using System.ComponentModel.Design;

public class Job

{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

}

    
class Program
{
    static void Main(string[] args)
    {
        // Create some Job objects
        Job job1 = new Job
        {
            _jobTitle = "Software Developer",
            _company = "Tech Corp",
            _startYear = 2020,
            _endYear = 2023
        };

        Job job2 = new Job
        {
            _jobTitle = "Technical Officer",
            _company = "Ghana Meteorological Agency",
            _startYear = 2011,
            _endYear = 2012
        };

        // Create a Resume object and add jobs to it
        Resume myResume = new Resume
        {
            _name = "Jonah Quarshie"
        };
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume
        myResume.Display();
    }
}