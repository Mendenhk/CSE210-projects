public class ReflectingActivity : Activity
{
    //ATTRIBUTES
    private List<string> _prompts;
    private List<string> _questions;

    //CONSTRUCTORS
    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.  This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
    {
        _prompts = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
        _questions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
    }

    //METHODS
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like your session to last? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("\nNow ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write($"> {GetRandomQuestion()}");
            ShowSpinner(15);
        }
        Console.WriteLine("");
        DisplayEndingMessage();
        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        Random randomInt = new Random();
        int number = randomInt.Next(0, _prompts.Count);
        return _prompts[number];
    }

    public string GetRandomQuestion()
    {
        Random randomInt = new Random();
        int number = randomInt.Next(0, _questions.Count);
        return _questions[number];
    }

    public void DisplayPrompt()
    {
        //do something
    }

    public void DisplayQuestions()
    {
        //do something
    }
}