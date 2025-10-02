// using System.ComponentModel;

public class Activity
{
    //ATTRIBUTES
    private string _name;
    private string _description;
    private int _duration;

    //CONSTRUCTORS
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    //GETTERS AND SETTERS
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    //METHODS
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}\n");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        {
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
        }
        for (int i = 0; i < seconds; i++)
        {
            foreach (string s in animationStrings)
            {
                Console.Write($"  {s}");
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
        Console.WriteLine("");
    }

    public void ShowCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
    }
}