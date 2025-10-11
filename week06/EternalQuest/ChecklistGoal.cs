public class ChecklistGoal : Goal
{
    //ATTRIBUTES
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //CONSTRUCTORS
    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
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

    public override string GetDetailsString()
    {
        return "hello";
    }
}