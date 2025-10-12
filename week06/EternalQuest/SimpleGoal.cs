public class SimpleGoal : Goal
{
    //ATTRIBUTES
    bool _isComplete;

    //CONSTRUCTORS
    //This should also set the the variables _isComplete to be false.
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    //GETTERS AND SETTERS
    public void SetIsCompleteTrue()
    {
        _isComplete = true;
    }

    //METHODS
    public override int RecordEvent()
    {
        _isComplete = true;
        return int.Parse(GetPoints());
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{base.GetStringRepresentation()},{_isComplete}";
    }
}