


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
        // Console.Write("How long, in seconds, would you like your session to last? ");
        // int duration = int.Parse(Console.ReadLine());
        // SetDuration(duration);
        Console.WriteLine("Get ready...");
        ShowSpinner(4);
    }
}