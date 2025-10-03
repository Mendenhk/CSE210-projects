public class ListingActivity : Activity
{
    //ATTRIBUTES
    private int _count;
    private List<string> _prompts;

    //CONSTRUCTORS
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        _count = 1;
        _prompts = ["Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"];
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

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!\n");
        DisplayEndingMessage();
        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        Random randomInt = new Random();
        int number = randomInt.Next(0, _prompts.Count);
        return _prompts[number];
    }

    public List<string> GetListFromUser()
    {
        return ["string1", "string2"];  //not actual
    }
}