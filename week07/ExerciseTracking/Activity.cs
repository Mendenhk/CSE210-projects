public abstract class Activity
{
    //ATTRIBUTES
    int _distance;
    int _speed;
    int _pace;

    //CONSTRUCTORS

    //GETTERS AND SETTERS

    //METHODS
    public abstract void GetDistance();

    public abstract void GetSpeed();

    public abstract void GetPace();

    //GetSummary method is defined in the base class and calls virtual methods for getting the distance, speed, and pace.
    //points docked for the following: GetSummary method is defined in the base class but it is overridden in each of the derived classes, rather than using a single method in the base class that does not need to be overridden.
    public virtual string GetSummary(){
        return "hello";
    }
}