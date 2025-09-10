using System;

class Program
{
    static void Main(string[] args)
    {
        //creates instance and storage space of the Job Class
        Job job1 = new Job();
        job1._company = "Apple";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2024;
        job1._endYear = 2025;

        Job job2 = new Job();
        job2._company = "Microsoft";
        job2._jobTitle = "AI developer";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume myResume = new Resume();
        myResume._name = "Kriston Mendenhall";
        myResume._jobs = [job1, job2];

        Console.Clear();
        myResume.Display();
        Console.WriteLine();
    }
}