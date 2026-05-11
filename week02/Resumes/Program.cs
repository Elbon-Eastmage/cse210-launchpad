using System;

class Program
{
    static void Main(string[] args)
    {   
        Job job1 = new Job();
        job1._companyName = "Maginova";
        job1._title = "Game Designer";
        job1._startYear = 2026;
        job1._endYear = 2036;

        Job job2 = new Job();
        job2._companyName = "Shelem";
        job2._title = "Editor";
        job2._startYear = 2026;
        job2._endYear = 2034;

        Resume resume = new Resume();
        resume._name = "Elbon Eastmage";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayJobs();
    }
}