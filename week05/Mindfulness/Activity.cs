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
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("\b  |");
            Thread.Sleep(200);
            Console.Write("\b  /");
            Thread.Sleep(200);
            Console.Write("\b  -");
            Thread.Sleep(200);
            Console.Write("\b  \\");
            Thread.Sleep(200);
            Console.Write("\b  |");
            Thread.Sleep(200);

        }
        Console.WriteLine();

    }

    public void ShowCountDown(int second)
    {
        //do something
    }
}