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

    //METHODS
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}\n");
    }

    public void DisplayEndingMessage()
    {
        //do something
    }

    public void ShowSpinner(int seconds)  //spinner is not using duration.  Duration is used for the time of all of the activities.  The spinner is controlled by me.  
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
        Console.WriteLine();

    }

    public void ShowCountDown(int second)
    {
        for (int i = 4; i > 0; i--) {
            
        }
    }
}