public class Running : Activity
{
    //ATTRIBUTES
    //remove unneeded
    private float _distance;

    //CONSTRUCTORS
    public Running (string date, float length, float distance) : base(date, length)
    {
        _distance = distance;
    }

    //GETTERS AND SETTERS

    //METHODS
    public override float GetDistance()
    {
        return 5/9;
    }

    public override float GetSpeed()
    {
        return 5/9;
    }

    public override float GetPace()
    {
        return 5/9;
    }
    
}