/*
BYU-Pathway CS210 - Programming with Classes | 25T5 | Waldyr Junior
Author: Akinsola David Akindileni
W02 Learning Activity: Abstraction
    
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // create job1
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2015;
        job1._endYear = 2021;

        // create job2
        Job job2 = new Job();
        job2._jobTitle = "FrontEnd Web Developer";
        job2._company = "Meta";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // create resume
        Resume resume1 = new Resume();
        resume1._name = "James Baldwin";

        // add the jobs
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        // display the resume with job details
        resume1.DisplayResumeDetails();
        
    }
}