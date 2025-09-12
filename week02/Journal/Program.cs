using System;
using System.IO;

//Exceeding Requirements:  I added a new class called MotivationGenerator.  This class saves motivational statements in an array, and the method in this class randomly chooses one of these motivational statements and returns it as a string.
//The method is called at the beginning of every program start to give the user reasons to continue journaling.  

class Program
{
    static void Main(string[] args)
    {
        MotivationGenerator motivationGenerator = new MotivationGenerator();
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();

        Console.WriteLine("");
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine(motivationGenerator.GetMotivation());

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("");
            Console.WriteLine("Please select one fo the following choices:");
            Console.WriteLine("1. Write an entry");
            Console.WriteLine("2. Display current entries");
            Console.WriteLine("3. Load saved entries");
            Console.WriteLine("4. Save current entries");
            Console.WriteLine("5. Quit");
            Console.Write("> ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                //creating a new instance of Entry with each choice of 1.  I learned that the new instances can all have the same variable name for our purposes.
                Entry entry = new Entry();
                entry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine("");
                Console.WriteLine(entry._promptText);
                Console.Write(">");
                entry._entryText = Console.ReadLine();
                //creates an object with the current time.
                DateTime theCurrentTime = DateTime.Now;
                //converts the object into a string with the date (not the time)
                entry._date = theCurrentTime.ToShortDateString();
                journal.AddEntry(entry);
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                string fileName = "";
                Console.WriteLine("What is the filename?");
                fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }
            else if (choice == "4")
            {
                string fileName = "";
                Console.WriteLine("What is the filename?");
                fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
            }
        }
    }
}