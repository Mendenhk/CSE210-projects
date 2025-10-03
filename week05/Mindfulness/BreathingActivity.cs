


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
        Console.Clear();
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
            ShowBreatheIn(4);
            ShowBreatheOut(6);
            // Console.Write("Breathe in...");
            // ShowCountDown(4);
            // Console.Write("Now breathe out...");
            // ShowCountDown(6);
            // Console.WriteLine("");
        }
        DisplayEndingMessage();
        Console.Clear();
    }
    public void ShowBreatheIn(int second)
    {
        string space = "";
        // string backSpace = "\b \b";
        for (int i = second; i > 0; i--)
        {
            Console.Write($"{i}: B{space}r{space}e{space}a{space}t{space}h{space}e{space} I{space}n");
            Thread.Sleep(1000);
            string repeatedString = new string(' ',100);
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(repeatedString);
            Console.SetCursorPosition(0, Console.CursorTop);
            // Console.Write($"\b \b\b \b\b \b\b \b\b \b\b \b\b \b\b \b\b \b\b \b\b \b{backSpace}");
            space += " ";
            // backSpace += "\b \b\b \b\b \b\b \b\b \b\b \b\b \b\b \b";
        }
        Console.WriteLine("0: Breath In");
    }

    public void ShowBreatheOut(int second)
    {
        string space = new string(' ', second); //sets spaces to number of times for loop is iterated.  Needed because will remove this number of spaces by end of loop.
        // string backSpace = "\b \b";
        for (int i = second; i > 0; i--)
        {
            Console.Write($"{i}: B{space}r{space}e{space}a{space}t{space}h{space}e{space} O{space}u{space}t");
            Thread.Sleep(1000);
            string repeatedString = new string(' ', 100);
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(repeatedString);
            Console.SetCursorPosition(0, Console.CursorTop);
            // Console.Write($"\b \b\b \b\b \b\b \b\b \b\b \b\b \b\b \b\b \b\b \b\b \b{backSpace}");
            space = space.Remove(0, 1);
            // backSpace += "\b \b\b \b\b \b\b \b\b \b\b \b\b \b\b \b";
        }
        Console.WriteLine($"{second}: Breathe Out");
        Console.WriteLine("");
    }
}