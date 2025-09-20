//Next step is to assemble the initial message from the word instance list and display it to the user. 
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string scriptureText = "Trust in the Lord with all thine heart; and lean not uto thine own understanding.  In all thy ways acknowledge him, and he shall direct thy paths.";
        string scriptureBook = "Proverbs";
        int scriptureChapter = 3;
        int scriptureStartVerse = 5;
        int scriptureEndVerse = 6;

        //stores scripture references in the reference instance
        Reference reference = new Reference(scriptureBook, scriptureChapter, scriptureStartVerse, scriptureEndVerse);

        Scripture scripture = new Scripture(reference, scriptureText);

        string choice = "";
        while (choice != "quit")
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            choice = Console.ReadLine();
        }

        // Console.WriteLine("");
            // Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        }
}