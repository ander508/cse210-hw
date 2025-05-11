using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Console.WriteLine("");
        
        
        
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2019;
        job1._endYear = 2022;
        // Console.WriteLine(job1._company);
        job1.DisplayJob();
        
        
        
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;
        // Console.WriteLine(job2._company);
        job2.DisplayJob();
        
        
        Console.WriteLine("");
        
        
        
        
        // Resume section
        Resume resume1 = new Resume();
        
        resume1._job.Add(job1);
        resume1._job.Add(job2);
        Console.WriteLine(resume1._job[0]._jobTitle);
        Console.WriteLine(resume1._job[1]._jobTitle);
        Console.WriteLine("");
        
        
        resume1._name = "Oluchukwu Offor";
        resume1.Display();
        Console.WriteLine("");
        
    }
}