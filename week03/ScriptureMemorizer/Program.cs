using System;
using System.Collections.Generic;
using System.Xml.Serialization;

//Exceeding requirements
//1. added a class, ScriptureBase, to hold more than one scripture, and a method within to randomly choose one of the scriptures and return that information as a string.  The string is parsed and assigned in the Program class.
//2. stretch challenge of only randomly selecting from non hidden words completed.  This was done by creating a new list in Scripture that holds only Word instances who's words are not hidden, then randomly choosing from this list. 

class Program
{
    static void Main(string[] args)
    {
        //retrieving scriptures at random from a class that stores them
        ScriptureBase scriptureBase = new ScriptureBase();
        List<string> randomScripture = scriptureBase.ChooseRandomScripture();
        string scriptureText = randomScripture[0];
        string scriptureBook = randomScripture[1];
        int scriptureChapter = int.Parse(randomScripture[2]);
        int scriptureStartVerse = int.Parse(randomScripture[3]);
        int scriptureEndVerse = int.Parse(randomScripture[4]);

        //stores scripture references in the reference instance
        Reference reference = new Reference(scriptureBook, scriptureChapter, scriptureStartVerse, scriptureEndVerse);
        Scripture scripture = new Scripture(reference, scriptureText);

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'quit' to finish:");
        string choice = Console.ReadLine();

        while (choice != "quit")
        {
            scripture.HideRandomWords();
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            choice = Console.ReadLine();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
    }
}