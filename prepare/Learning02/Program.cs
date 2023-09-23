using System;

class Program
{
    public static Job job1;

    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Micrsoft";
        job1._startYear = 2022;
        job1._endYear = 2023;
        job1.PrintJobTitle();
        
    

        Job job2 = new Job();
        job2._jobTitle = "Electrical Engineer";
        job2._company = "Boeing";
        job2._startYear = 1999;
        job2._endYear = 2065;
        job2.PrintJobTitle();

        Resume resume1 = new Resume();
        resume1._personName = "Noah Lee";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.Display();


    }
}
