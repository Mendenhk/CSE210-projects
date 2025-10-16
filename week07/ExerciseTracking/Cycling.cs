public class Cycling : Activity
{
    //ATTRIBUTES
    //remove unneeded
    private int _speed;

    //CONSTRUCTORS
    //ALL of the following is copied and pasted from the running class.  Change as needed
    public Cycling (string date, double length, int speed) : base(date, length)
    {
        _speed = speed;
    }

    //GETTERS AND SETTERS

    //METHODS
    public override double GetDistance()
    {
        //distance = (length (min) * speed (mph)) / 60 (min/hr)
        return _length * _speed / 60;
    }

    public override double GetSpeed()
    {
        return (double)_speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

}