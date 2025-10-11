public class Goal
{
    //ATTRIBUTES
    private string _shortName;
    private string _description;
    private string _points;

    //CONSTRUCTORS
    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    //GETTERS AND SETTERS

    //METHODS
    public virtual void RecordEvent()
    {
        Console.WriteLine("stuff");
    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return "hello";
    }
    
    public virtual string GetStringRepresentation()
    {
        return "hello";
    }
}