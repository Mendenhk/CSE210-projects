public class Swimming : Activity
{
    //ATTRIBUTES
    //remove unneeded
    private int _numberOfLaps;

    //CONSTRUCTORS
    //ALL of the following is copied and pasted from the running class.  Change as needed
    public Swimming (string date, double length, int laps) : base(date, length)
    {
        _numberOfLaps = laps;
    }

    //GETTERS AND SETTERS

    //METHODS
    public override double GetDistance()
    {
        return _numberOfLaps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }

    public override double GetPace()
    {
        return _length / GetDistance();
    }

}