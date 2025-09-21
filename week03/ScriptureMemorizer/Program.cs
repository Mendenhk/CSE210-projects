using System;
using System.Collections.Generic;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.  In all thy ways acknowledge him, and he shall direct thy paths.";
        string scriptureBook = "Proverbs";
        int scriptureChapter = 3;
        int scriptureStartVerse = 5;
        int scriptureEndVerse = 6;

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