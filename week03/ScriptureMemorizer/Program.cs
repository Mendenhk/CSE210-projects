using System;
using System.Collections.Generic;
using System.Xml.Serialization;

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