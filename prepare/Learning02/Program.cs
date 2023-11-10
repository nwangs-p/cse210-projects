using System;
using System.Collections.Generic;

// Job class
public class Job
{
    // Member variables
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

   
    public Job(string company, string jobTitle, int startYear, int endYear)
    {
        _company = company;
        _jobTitle = jobTitle;
        _startYear = startYear;
        _endYear = endYear;
    }

    // Display method to show job details
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

// Resume class
public class Resume
{
   
    public string _personName;
    public List<Job> _jobs;

    public Resume(string personName)
    {
        _personName = personName;
        _jobs = new List<Job>(); 
    }

    // Method to add a job to the list
    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    // Display method to show resume details
    public void Display()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");


        foreach (var job in _jobs)
        {
            job.Display();
        }
    }
}

// Main program
class Program
{
    static void Main()
    {
  
        Job job1 = new Job("Microsoft", "Software Engineer", 2019, 2022);
        Job job2 = new Job("Apple", "Manager", 2022, 2023);

        // Create Resume instance
        Resume myResume = new Resume("Nanwanga Ifeanyi");

        // Add jobs to the resume
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        // Test Resume Display method
        myResume.Display();
    }
}