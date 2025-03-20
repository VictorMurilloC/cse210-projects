using System;

class Program
{
    static void Main(string[] args)
    {
        Resume resume = new Resume();
        Job job1 = new Job();
        Job job2 = new Job();
        job1._role= "Software Engineer Jr";
        job1._company = "Google";
        job1._startYear = 2020;
        job1._endYear = 2022;
        job2._role = "Software Engineer Senior";
        job2._company = "Tesla";
        job2._startYear = 2022;
        job2._endYear = 2025;
        resume._name = "Victor Murillo";
        resume._jobs = new List<Job>();
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume.Display();
    }
}