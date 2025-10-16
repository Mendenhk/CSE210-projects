public class Cycling : Activity
{
    //ATTRIBUTES
    //remove unneeded
    private int _speed;

    //CONSTRUCTORS
 //remove this if not needed
    private double _distance;


    //CONSTRUCTORS
    //ALL of the following is copied and pasted from the running class.  Change as needed
    public Cycling (string date, double length, double distance) : base(date, length)
    {
        _distance = distance;
    }

    //GETTERS AND SETTERS

    //METHODS
    public override double GetDistance()
    {
        return 5/9;
    }

    public override double GetSpeed()
    {
        return 5/9;
    }

    public override double GetPace()
    {
        return 5/9;
    }

}