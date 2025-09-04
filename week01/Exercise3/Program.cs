using System;

class Program
{
    static void Main(string[] args)
    {

        int guess = 0;
        int playAgain = -1;
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
            Console.Write("(Enter 1 for yes or 0 for no): ");
            playAgain = int.Parse(Console.ReadLine());
        } while (playAgain != 0);
        Console.WriteLine("Thank you for playing.");
    }
}