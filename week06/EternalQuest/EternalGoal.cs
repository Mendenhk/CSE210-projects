public class EternalGoal : Goal
{
    //ATTRIBUTES

    //CONSTRUCTORS
    public EternalGoal(string name, string description, string points) : base(name, description, points)
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