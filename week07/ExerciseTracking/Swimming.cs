public class Swimming : Activity
{
    //ATTRIBUTES
    //remove unneeded
    private int _distance;
    private int _speed;
    private int _pace;
    private int _numberOfLaps;

    //CONSTRUCTORS

    //GETTERS AND SETTERS

    //METHODS
    //may need to remove GetSummary from here (do not overide base class!!!)
    public virtual string GetSummary()
    {
        return "hello";
    }
    
    public override void GetDistance()
    {
        
    }

    public override void GetSpeed()
    {
        
    }

    public override void GetPace()
    {
        
    }
}