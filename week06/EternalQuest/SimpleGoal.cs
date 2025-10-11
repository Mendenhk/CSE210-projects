public class SimpleGoal : Goal
{
    //ATTRIBUTES
    bool _isComplete;

    //CONSTRUCTORS

    //GETTERS AND SETTERS
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        
    }

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