public class Running : Activity
{
    //ATTRIBUTES
    //distance in miles
    private double _distance;

    //CONSTRUCTORS
    public Running (string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    //GETTERS AND SETTERS

    //METHODS
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _length * 60;
    }

    public override double GetPace()
    {
        return _length / _distance;
    }
    
}