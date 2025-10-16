public class Cycling : Activity
{
    //ATTRIBUTES
    //remove unneeded
    private int _speed;

    //CONSTRUCTORS
 //remove this if not needed
    private float _distance;


    //CONSTRUCTORS
    //ALL of the following is copied and pasted from the running class.  Change as needed
    public Cycling (string date, float length, float distance) : base(date, length)
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