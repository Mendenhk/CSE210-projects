using System;

class Program
{
    static void Main(string[] args)
    {

        int guess = 0;
        string playAgain = "";
        int guesses = 0;

        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100); 
            Console.WriteLine(number);       
            guesses = 0;
            do
            {
                Console.Write("What is your guess(1 to 100)? ");
                guess = int.Parse(Console.ReadLine());
                guesses++;
                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
            } while (guess != number);
            Console.WriteLine("You guessed it!");
            Console.WriteLine($"It took you {guesses} tries to guess the number.");
            Console.Write("Would you like to play again? ");
            Console.Write("(Enter yes to play again.): ");
            playAgain = (Console.ReadLine());
        } while (playAgain == "yes");
        Console.WriteLine("Thank you for playing.");
    }
}