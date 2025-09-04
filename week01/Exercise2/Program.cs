using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("What is your grade percentage? ");
        int gradePercent = int.Parse(Console.ReadLine());
        string letter = "";
        string sign = "";
        if (gradePercent > 89)
        {
            letter = "A";
        }
        else if (gradePercent > 79)
        {
            letter = "B";
        }
        else if (gradePercent > 69)
        {
            letter = "C";
        }
        else if (gradePercent > 59)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (gradePercent < 97 && gradePercent > 59)
        {
            if (gradePercent % 10 >= 7)
            {
                sign = "+";
            }
            else if (gradePercent % 10 < 3)
            {
                sign = "-";
            }
        }

        Console.WriteLine($"Your grad is: {letter}{sign}");


        if (gradePercent > 69)
        {
            Console.WriteLine("Congratulations, you have passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass this time.  With some help, I know you will do better next time.");
        }    }
}