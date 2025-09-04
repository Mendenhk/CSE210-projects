using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string nameInner = Console.ReadLine();
            return nameInner;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            int numberInner = int.Parse(Console.ReadLine());
            return numberInner;
        }

        static int SquareNumber(int numberInner)
        {
            int numSquaredInner = numberInner * numberInner;
            return numSquaredInner;
        }

        static void DisplayResult(string name, int numSquared)
        {
            Console.WriteLine($"{name}, the square of your number is {numSquared}");
        }

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int numSquared = SquareNumber(number);
        DisplayResult(name, numSquared);
    }
}