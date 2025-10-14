public class Activity
{
    //ATTRIBUTES
    //maybe protected rather than private
    private string _date;
    //maybe protected rather than private
    private string _length;

    //CONSTRUCTORS

    //GETTERS AND SETTERS

    //METHODS
    //these may need to be defined with abstract rather than virtual, class would have to be changed to abstract. See rubric #4
    public virtual void GetDistance()
    {
        
    }

    public virtual void GetSpeed()
    {
        
    }

    public virtual void GetPace()
    {

    }

    //GetSummary method is defined in the base class and calls virtual methods for getting the distance, speed, and pace.
    //points docked for the following: GetSummary method is defined in the base class but it is overridden in each of the derived classes, rather than using a single method in the base class that does not need to be overridden.
    //Me: not virtual because will not be overridden
    public string GetSummary(){
        return "hello";
    }
}