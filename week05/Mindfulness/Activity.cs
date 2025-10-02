public class Activity
{
    //ATTRIBUTES
    private string _name;
    private string _description;
    private int _duration;

    //CONSTRUCTORS
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    //METHODS
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n\n{_description}");
    }

    public void DisplayEndingMessage()
    {
        //do something
    }

    public void ShowSpinner(int seconds)
    {
        //do something
    }

    public void ShowCountDown(int second)
    {
        //do something
    }
}