public class SimpleGoal : Goal
{
    //ATTRIBUTES
    bool _isComplete;

    //CONSTRUCTORS
    //This should also set the the variables for if it is complete to be false.
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        
    }

    //GETTERS AND SETTERS

    //METHODS
    public override void RecordEvent()
    {
        Console.WriteLine("hello");  
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
        return "hello";
    }
}