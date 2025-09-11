using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string input;
        PromptGenerator promptGenerator = new PromptGenerator();
        Entry entry = new Entry();
        Journal journal = new Journal();

        entry._promptText = promptGenerator.GetRandomPrompt();
        Console.WriteLine(entry._promptText);
        Console.Write(">");
        entry._entryText = Console.ReadLine();
        //creates an object with the current time.
        DateTime theCurrentTime = DateTime.Now;
        //converts the object into a string with the date (not the time)
        entry._date = theCurrentTime.ToShortDateString();
        entry.Display();
    }
}