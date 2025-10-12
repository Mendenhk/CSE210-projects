using System;
using System.IO;

//Exceeding Requirements:  I added a Confetti method to all classes to celebrate when goals are reached and points are earned.
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string choice = "0";
        while (choice != "6")
        {
            goalManager.DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            //finished 2.
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                goalManager.CreateGoal();
            }
            if (choice == "2")
            {
                goalManager.ListGoalDetails();
            }
            if (choice == "3")
            {
                goalManager.SaveGoals();
            }
            if (choice == "4")
            {
                goalManager.LoadGoals();
            }
            if (choice == "5")
            {
                goalManager.RecordEvent();
            }
        }
    }
}