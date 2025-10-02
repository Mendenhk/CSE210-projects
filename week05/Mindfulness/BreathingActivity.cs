


public class BreathingActivity : Activity
{
    //CONSTRUCTORS
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly.  Clear your mind and focus on your breathing.", 0)
    {
        //Curly braces because I get an error stating that "BreathingActivity must contain a body" if I don't.
    }

    //METHODS
    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like your session to last? ");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in...");
            ShowCountDown(4);
            Console.Write("Now breathe out...");
            ShowCountDown(6);
            Console.WriteLine("");
        }
        DisplayEndingMessage();
        Console.Clear();
    }
}