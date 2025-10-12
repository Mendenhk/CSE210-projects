public class EternalGoal : Goal
{
    //ATTRIBUTES

    //CONSTRUCTORS
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    //GETTERS AND SETTERS

    //METHODS
    public override int RecordEvent()
    {
        return base.RecordEvent();
    }

    //why is this method needed if the Goal method returns the same value?
    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{base.GetStringRepresentation()}";
    }
}