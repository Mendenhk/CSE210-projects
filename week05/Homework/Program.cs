using System;

class Program
{
    static void Main(string[] args)
    {
        // Assignment assignment = new Assignment("Albert Aloa", "French");
        // Console.WriteLine(assignment.GetSummary());
        MathAssignment mathAssignment = new MathAssignment("Albert Aloa", "French", "Section 7.3", "Problems 8-19");
        Console.WriteLine(mathAssignment.GetHomeworkList());
        WritingAssignment writingAssignment = new WritingAssignment("Albert Aloa", "French", "Paris in the 1800s");
        Console.WriteLine(writingAssignment.GetWritingInformation());

        // Console.WriteLine("Hello World! This is the Homework Project.");
    }
}